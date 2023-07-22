using Jot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnveilerN.Bindings;
using UnveilerN.Services;
using UnveilerN.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnveilerN
{
    public partial class FormMain : Form
    {
        private static readonly Tracker Tracker = new Tracker();

        static FormMain()
        {
            Tracker.Configure<FormMain>()
                .Id(a => a.GetType().Name)
                .Properties(a => new
                {
                    Height = a.Height,
                    Width = a.Width,
                    Left = a.Left,
                    Top = a.Top,

                    UnveilerToken = a.tbToken.Text,
                    UnveilerPath = a.tbUnveilerPath.Text,
                    UnveilerAppId = a.tbAppId.Text,
                    UnveilerLogLevel = a.cbLogLevel.SelectedValue,
                    UnveilerFormatCode = a.cbFormatCode.Checked,
                    UnveilerNoClearDecompile = a.cbNoClearDecompile.Checked,
                    UnveilerOverwriteDirectory = a.cbOverwriteDirectory.Checked,
                    UnveilerScanSensitive = a.cbScanSensitive.Checked,
                    UnveilerDepth = a.tbDepth.Text,
                    UnveilerOutputDirectory = a.tbOutputDirectory.Text,
                })
                .StopTrackingOn(nameof(Closed))
                .PersistOn(nameof(Closing))
                .PersistOn(nameof(Move))
                .PersistOn(nameof(Resize));
        }

        public FormMain()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            unveilerLogLevelBindingBindingSource.DataSource = UnveilerLogLevelBinding.Instance;

            Tracker.Track(this);
            base.OnLoad(e);
        }

        protected override void OnShown(EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUnveilerPath.Text) || !File.Exists(tbUnveilerPath.Text))
            {
                tbUnveilerPath.Text = Unveiler.FindExecutePath();

                if (string.IsNullOrWhiteSpace(tbUnveilerPath.Text))
                {
                    MsgError("没有发现 unveiler, 请手动选择文件!");
                    return;
                }

            }

            base.OnShown(e);
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            tbUnveilerPath.Text = openFileDialog1.FileName;
        }

        private void MsgError(string content)
        {
            MessageBox.Show(this, content, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckExecuteCondition(out string errMsg)
        {
            if (!File.Exists(tbUnveilerPath.Text))
            {
                errMsg = "Unveiler 文件不存在!";
                return false;
            }

            if (Path.GetExtension(tbUnveilerPath.Text) != ".exe")
            {
                errMsg = "选择的路径不是一个可执行文件!";
                return false;
            }

            errMsg = null;
            return true;
        }

        private void BtnSelectOutputDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            tbOutputDirectory.Text = folderBrowserDialog1.SelectedPath;
        }

        private async void BtnDecompile_Click(object sender, EventArgs e)
        {
            if (!CheckExecuteCondition(out var errMsg))
            {
                MsgError(errMsg);
                return;
            }

            using (new ControlDisable(btnDecompile))
            {
                var builder = CreateCommandStringBuilder();

                if (rbDirectory.Checked)
                {
                    if (folderBrowserDialog1.ShowDialog(this) != DialogResult.OK)
                    {
                        return;
                    }

                    builder.SetDirectory(folderBrowserDialog1.SelectedPath);
                }

                if (rbFiles.Checked)
                {
                    if (openFileDialogSelectFiles.ShowDialog(this) != DialogResult.OK)
                    {
                        return;
                    }

                    builder.AddFiles(openFileDialogSelectFiles.FileNames);
                }

                await UnveilerRunner(builder);
            }
        }

        private void TpDecompile_DragEnter(object sender, DragEventArgs e)
        {
            if (!btnDecompile.Enabled)
            {
                return;
            }

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private async void TpDecompile_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                return;
            }

            if (!CheckExecuteCondition(out var errMsg))
            {
                MsgError(errMsg);
                return;
            }

            var paths = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (paths.Length == 0)
            {
                return;
            }

            bool isDir = File.GetAttributes(paths[0]).HasFlag(FileAttributes.Directory);

            var builder = CreateCommandStringBuilder();

            if (isDir)
            {
                builder.SetDirectory(paths[0]);
            }
            else
            {
                string[] files = paths.Where(a => !File.GetAttributes(a).HasFlag(FileAttributes.Directory)).ToArray();
                builder.AddFiles(files);
            }

            await UnveilerRunner(builder);
        }

        private UnveilerDecompileCommandStringBuilder CreateCommandStringBuilder()
        {
            return new UnveilerDecompileCommandStringBuilder(tbUnveilerPath.Text)
            {
                AppId = tbAppId.Text,
                LogLevel = (UnveilerLogLevel?)cbLogLevel.SelectedValue,
                DirectoryDepth = DirectoryDepth,
                FormatCode = cbFormatCode.Checked,
                NoClearDecompile = cbNoClearDecompile.Checked,
                OverwriteDirectory = cbOverwriteDirectory.Checked,
                ScanSensitive = cbScanSensitive.Checked,
                OutputDirectory = tbOutputDirectory.Text,
            };
        }

        private async Task UnveilerRunner(UnveilerDecompileCommandStringBuilder builder)
        {
            using (new ControlDisable(btnDecompile))
            {
                Tracker.PersistAll();
                tbOutput.ResetText();

                tabControl1.SelectedTab = tabPage3;

                var service = new UnveilerService(builder);

                await service.ExecuteAsync(output =>
                {
                    Invoke(new Action(() =>
                    {
                        tbOutput.AppendText(output);
                        tbOutput.AppendText("\r\n");
                        tbOutput.SelectionStart = tbOutput.TextLength;
                        tbOutput.ScrollToCaret();
                    }));
                });

                tabControl1.SelectedTab = tpDecompile;

                if (!CheckOutput(out string errorMsg))
                {
                    MsgError(errorMsg);
                    return;
                }

                var dialog = MessageBox.Show(this, "解包完成, 是否打开目录?", "询问:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog != DialogResult.Yes)
                {
                    return;
                }

                string outputDirectory = service.GetOutputDirectory();
                Process.Start("explorer.exe", string.Concat('"', outputDirectory, '"'));
            }
        }

        private int? DirectoryDepth
            => int.TryParse(tbDepth.Text, out int depth) ? (int?)depth : null;

        /// <summary>
        /// 输出内是否存在错误, 尝试用 MessageBox 弹出错误信息
        /// </summary>
        private bool CheckOutput(out string errMsg)
        {
            string output = tbOutput.Text;
            
            if (string.IsNullOrWhiteSpace(output))
            {
                errMsg = null;
                return true;
            }

            if (output.Contains("403 Please check your credentials"))
            {
                errMsg = "Token 失效或错误, 请检查后在执行";
                return false;
            }

            if (output.Contains("wxAppId must be required"))
            {
                errMsg = "PC微信必须填写 AppId!";
                return false;
            }

            if (output.Contains("[ERROR]"))
            {
                errMsg = "出现错误, 详情查看终端输出内容!";
                return false;
            }

            errMsg = null;
            return true;
        }

    }
}