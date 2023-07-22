using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnveilerN.Utils;

namespace UnveilerN.Services
{
    internal class UnveilerService
    {
        private readonly UnveilerDecompileCommandStringBuilder _commandStringBuilder;

        public UnveilerService(UnveilerDecompileCommandStringBuilder commandStringBuilder)
        {
            _commandStringBuilder = commandStringBuilder ?? throw new ArgumentNullException(nameof(commandStringBuilder));
        }

        public Task ExecuteAsync(Action<string> processOutput)
        {
            var tcs = new TaskCompletionSource<int>();

            string args = _commandStringBuilder.ToString();

            processOutput.Invoke($"[INFO] {_commandStringBuilder.ExecutePath} {args}");

            // 看 Process 代码, Dispose 不是很重要, 调用了只会有通知事件和从 Site 中移除.
            var process = new Process
            {
                StartInfo = new ProcessStartInfo(_commandStringBuilder.ExecutePath)
                {
                    WorkingDirectory = Directory.GetParent(_commandStringBuilder.ExecutePath)?.FullName ?? string.Empty,
                    Arguments = args,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    StandardOutputEncoding = Encoding.UTF8,
                    StandardErrorEncoding = Encoding.UTF8,
                },
                EnableRaisingEvents = true,
            };

            process.Exited += (_, e) =>
            {
                tcs.SetResult(0);
            };

            process.OutputDataReceived += (_, e) =>
            {
                if (!string.IsNullOrWhiteSpace(e.Data))
                {
                    processOutput.Invoke(e.Data);
                }
            };

            process.ErrorDataReceived += (_, e) =>
            {
                if (!string.IsNullOrWhiteSpace(e.Data))
                {
                    processOutput.Invoke(e.Data);
                }
            };

            try
            {
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }

            return tcs.Task;
        }

        public string GetOutputDirectory()
        {
            if (!string.IsNullOrWhiteSpace(_commandStringBuilder.OutputDirectory))
            {
                return _commandStringBuilder.OutputDirectory;
            }

            return Directory.GetParent(_commandStringBuilder.ExecutePath)?.FullName ?? string.Empty;
        }
    }
}
