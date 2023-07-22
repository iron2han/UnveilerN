using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnveilerN.Utils
{
    public enum UnveilerLogLevel
    {
        Debug,
        Info,
        Warn,
        Error,
    }
    
    /// <summary>
    /// Unveiler 反编译命令生成器
    /// </summary>
    internal class UnveilerDecompileCommandStringBuilder
    {
        /// <summary>
        /// 可执行文件位置
        /// </summary>
        public string ExecutePath { get; }

        public UnveilerDecompileCommandStringBuilder(string executePath)
        {
            ExecutePath = executePath ?? throw new ArgumentNullException(nameof(executePath));
        }

        /// <summary>
        /// 付费版本 Token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 日志等级
        /// </summary>
        public UnveilerLogLevel? LogLevel { get; set; }

        /// <summary>
        /// 扫描敏感信息
        /// </summary>
        public bool ScanSensitive { get; set; }

        /// <summary>
        /// 解密 PCWechat 时需要填写的 AppId
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 格式化反编译后的代码
        /// </summary>
        public bool FormatCode { get; set; }

        /// <summary>
        /// True, 解析后的残留文件将不会被清除
        /// </summary>
        public bool NoClearDecompile { get; set; }

        /// <summary>
        /// 要保存的路径将不会被清除
        /// </summary>
        public bool NoClearSave { get; set; }

        /// <summary>
        /// 只提取文件，但不会解析
        /// </summary>
        public bool NoParse { get; set; }

        /// <summary>
        /// 目录查找深度, 默认:1, 0为不限制深度
        /// </summary>
        public int? DirectoryDepth { get; set; }
        
        /// <summary>
        /// 允许清空目录并输出
        /// </summary>
        public bool OverwriteDirectory { get; set; }

        /// <summary>
        /// 输出目录
        /// </summary>
        public string OutputDirectory { get; set; }

        /// <summary>
        /// 反编译目录
        /// </summary>
        private string _directory;

        /// <summary>
        /// 设置反编译目录
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public UnveilerDecompileCommandStringBuilder SetDirectory(string directory)
        {
            if (_paths?.Any() ?? false)
            {
                throw new InvalidOperationException("您已经设置了包文件, 不能在添加目录!");
            }

            _directory = directory;
            return this;
        }

        /// <summary>
        /// 反编译包文件
        /// </summary>
        private List<string> _paths;

        public UnveilerDecompileCommandStringBuilder AddFiles(params string[] paths)
        {
            if (_directory != null)
            {
                throw new InvalidOperationException("您已经设置了目录, 不能在添加文件!");
            }

            (_paths ?? (_paths = new List<string>())).AddRange(paths);
            return this;
        }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(_directory) && _paths is null)
            {
                throw new InvalidOperationException("包路径没有设置!");
            }

            var commands = BuildCommands().ToArray();

            if (!commands.Any())
            {
                throw new InvalidOperationException("没有构建可执行的命令!");
            }

            return string.Join(" ", commands);
        }

        private IEnumerable<string> BuildCommands()
        {
            if (!string.IsNullOrWhiteSpace(Token))
            {
                yield return $"--stk={Token}";
            }

            if (LogLevel != null)
            {
                yield return $"--log-level {LogLevel.ToString().ToLower()}";
            }

            if (!string.IsNullOrWhiteSpace(AppId))
            {
                yield return $"--appid {AppId}";
            }

            if (FormatCode)
            {
                yield return "--format";
            }

            if (ScanSensitive)
            {
                yield return "--scan-sensitive";
            }

            if (NoClearDecompile)
            {
                yield return "--no-clear-decompile";
            }

            if (NoClearSave)
            {
                yield return "--no-clear-save";
            }

            if (NoParse)
            {
                yield return "--no-parse";
            }

            if (OverwriteDirectory)
            {
                yield return "--clear-output";
            }

            if (DirectoryDepth != null)
            {
                yield return $"--depth {DirectoryDepth}";
            }

            if (!string.IsNullOrWhiteSpace(OutputDirectory))
            {
                yield return $"--output {GetPath(OutputDirectory)}";
            }

            if (!string.IsNullOrWhiteSpace(_directory))
            {
                yield return GetPath(_directory);
            }

            if (_paths != null)
            {
                foreach (var path in _paths)
                {
                    yield return GetPath(path);
                }
            }
        }

        private static string GetPath(string path)
        {
            return string.Concat('"', path, '"');
        }
    }
}
