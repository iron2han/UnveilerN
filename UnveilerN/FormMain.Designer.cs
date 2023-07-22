namespace UnveilerN
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Button btnSelectFile;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Button btnSelectOutputDirectory;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbUnveilerPath = new System.Windows.Forms.TextBox();
            this.tbToken = new System.Windows.Forms.TextBox();
            this.tpDecompile = new System.Windows.Forms.TabPage();
            this.tbOutputDirectory = new System.Windows.Forms.TextBox();
            this.rbFiles = new System.Windows.Forms.RadioButton();
            this.rbDirectory = new System.Windows.Forms.RadioButton();
            this.btnDecompile = new System.Windows.Forms.Button();
            this.cbLogLevel = new System.Windows.Forms.ComboBox();
            this.unveilerLogLevelBindingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbScanSensitive = new System.Windows.Forms.CheckBox();
            this.tbDepth = new System.Windows.Forms.TextBox();
            this.cbOverwriteDirectory = new System.Windows.Forms.CheckBox();
            this.cbNoClearDecompile = new System.Windows.Forms.CheckBox();
            this.cbFormatCode = new System.Windows.Forms.CheckBox();
            this.tbAppId = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogSelectFiles = new System.Windows.Forms.OpenFileDialog();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnSelectFile = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            btnSelectOutputDirectory = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpDecompile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unveilerLogLevelBindingBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(19, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 17);
            label1.TabIndex = 0;
            label1.Text = "Token:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(31, 24);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 17);
            label2.TabIndex = 2;
            label2.Text = "路径:";
            // 
            // btnSelectFile
            // 
            btnSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnSelectFile.Location = new System.Drawing.Point(471, 18);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new System.Drawing.Size(75, 23);
            btnSelectFile.TabIndex = 4;
            btnSelectFile.Text = "浏览";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(277, 23);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 17);
            label5.TabIndex = 8;
            label5.Text = "日志等级:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(31, 199);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(130, 17);
            label4.TabIndex = 5;
            label4.Text = "目录搜索深度 (默认 0):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(31, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 17);
            label3.TabIndex = 0;
            label3.Text = "AppId:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(19, 53);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(59, 17);
            label6.TabIndex = 14;
            label6.Text = "输出目录:";
            // 
            // btnSelectOutputDirectory
            // 
            btnSelectOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnSelectOutputDirectory.Location = new System.Drawing.Point(405, 47);
            btnSelectOutputDirectory.Name = "btnSelectOutputDirectory";
            btnSelectOutputDirectory.Size = new System.Drawing.Size(75, 23);
            btnSelectOutputDirectory.TabIndex = 16;
            btnSelectOutputDirectory.Text = "浏览";
            btnSelectOutputDirectory.UseVisualStyleBackColor = true;
            btnSelectOutputDirectory.Click += new System.EventHandler(this.BtnSelectOutputDirectory_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpDecompile);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 265);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(btnSelectFile);
            this.tabPage1.Controls.Add(this.tbUnveilerPath);
            this.tabPage1.Controls.Add(label2);
            this.tabPage1.Controls.Add(this.tbToken);
            this.tabPage1.Controls.Add(label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(566, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "#";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbUnveilerPath
            // 
            this.tbUnveilerPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUnveilerPath.Location = new System.Drawing.Point(72, 18);
            this.tbUnveilerPath.Name = "tbUnveilerPath";
            this.tbUnveilerPath.Size = new System.Drawing.Size(393, 23);
            this.tbUnveilerPath.TabIndex = 3;
            // 
            // tbToken
            // 
            this.tbToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbToken.Location = new System.Drawing.Point(72, 47);
            this.tbToken.Name = "tbToken";
            this.tbToken.Size = new System.Drawing.Size(474, 23);
            this.tbToken.TabIndex = 1;
            // 
            // tpDecompile
            // 
            this.tpDecompile.AllowDrop = true;
            this.tpDecompile.Controls.Add(btnSelectOutputDirectory);
            this.tpDecompile.Controls.Add(this.tbOutputDirectory);
            this.tpDecompile.Controls.Add(label6);
            this.tpDecompile.Controls.Add(this.rbFiles);
            this.tpDecompile.Controls.Add(this.rbDirectory);
            this.tpDecompile.Controls.Add(this.btnDecompile);
            this.tpDecompile.Controls.Add(this.cbLogLevel);
            this.tpDecompile.Controls.Add(label5);
            this.tpDecompile.Controls.Add(this.cbScanSensitive);
            this.tpDecompile.Controls.Add(this.tbDepth);
            this.tpDecompile.Controls.Add(label4);
            this.tpDecompile.Controls.Add(this.cbOverwriteDirectory);
            this.tpDecompile.Controls.Add(this.cbNoClearDecompile);
            this.tpDecompile.Controls.Add(this.cbFormatCode);
            this.tpDecompile.Controls.Add(this.tbAppId);
            this.tpDecompile.Controls.Add(label3);
            this.tpDecompile.Location = new System.Drawing.Point(4, 26);
            this.tpDecompile.Name = "tpDecompile";
            this.tpDecompile.Padding = new System.Windows.Forms.Padding(3);
            this.tpDecompile.Size = new System.Drawing.Size(566, 235);
            this.tpDecompile.TabIndex = 1;
            this.tpDecompile.Text = "解包";
            this.tpDecompile.UseVisualStyleBackColor = true;
            this.tpDecompile.DragDrop += new System.Windows.Forms.DragEventHandler(this.TpDecompile_DragDrop);
            this.tpDecompile.DragEnter += new System.Windows.Forms.DragEventHandler(this.TpDecompile_DragEnter);
            // 
            // tbOutputDirectory
            // 
            this.tbOutputDirectory.Location = new System.Drawing.Point(84, 47);
            this.tbOutputDirectory.Name = "tbOutputDirectory";
            this.tbOutputDirectory.Size = new System.Drawing.Size(315, 23);
            this.tbOutputDirectory.TabIndex = 15;
            // 
            // rbFiles
            // 
            this.rbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFiles.AutoSize = true;
            this.rbFiles.Location = new System.Drawing.Point(467, 179);
            this.rbFiles.Name = "rbFiles";
            this.rbFiles.Size = new System.Drawing.Size(62, 21);
            this.rbFiles.TabIndex = 13;
            this.rbFiles.Text = "包文件";
            this.rbFiles.UseVisualStyleBackColor = true;
            // 
            // rbDirectory
            // 
            this.rbDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDirectory.AutoSize = true;
            this.rbDirectory.Checked = true;
            this.rbDirectory.Location = new System.Drawing.Point(411, 179);
            this.rbDirectory.Name = "rbDirectory";
            this.rbDirectory.Size = new System.Drawing.Size(50, 21);
            this.rbDirectory.TabIndex = 12;
            this.rbDirectory.TabStop = true;
            this.rbDirectory.Text = "目录";
            this.rbDirectory.UseVisualStyleBackColor = true;
            // 
            // btnDecompile
            // 
            this.btnDecompile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecompile.Location = new System.Drawing.Point(411, 206);
            this.btnDecompile.Name = "btnDecompile";
            this.btnDecompile.Size = new System.Drawing.Size(149, 23);
            this.btnDecompile.TabIndex = 11;
            this.btnDecompile.Text = "解包";
            this.btnDecompile.UseVisualStyleBackColor = true;
            this.btnDecompile.Click += new System.EventHandler(this.BtnDecompile_Click);
            // 
            // cbLogLevel
            // 
            this.cbLogLevel.DataSource = this.unveilerLogLevelBindingBindingSource;
            this.cbLogLevel.DisplayMember = "Key";
            this.cbLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogLevel.FormattingEnabled = true;
            this.cbLogLevel.Location = new System.Drawing.Point(343, 16);
            this.cbLogLevel.Name = "cbLogLevel";
            this.cbLogLevel.Size = new System.Drawing.Size(137, 25);
            this.cbLogLevel.TabIndex = 9;
            this.cbLogLevel.ValueMember = "Value";
            // 
            // unveilerLogLevelBindingBindingSource
            // 
            this.unveilerLogLevelBindingBindingSource.DataSource = typeof(UnveilerN.Bindings.UnveilerLogLevelBinding);
            // 
            // cbScanSensitive
            // 
            this.cbScanSensitive.AutoSize = true;
            this.cbScanSensitive.Location = new System.Drawing.Point(34, 166);
            this.cbScanSensitive.Name = "cbScanSensitive";
            this.cbScanSensitive.Size = new System.Drawing.Size(201, 21);
            this.cbScanSensitive.TabIndex = 7;
            this.cbScanSensitive.Text = "扫描敏感信息 (--scan-sensitive)";
            this.cbScanSensitive.UseVisualStyleBackColor = true;
            // 
            // tbDepth
            // 
            this.tbDepth.Location = new System.Drawing.Point(167, 193);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Size = new System.Drawing.Size(90, 23);
            this.tbDepth.TabIndex = 6;
            // 
            // cbOverwriteDirectory
            // 
            this.cbOverwriteDirectory.AutoSize = true;
            this.cbOverwriteDirectory.Location = new System.Drawing.Point(34, 139);
            this.cbOverwriteDirectory.Name = "cbOverwriteDirectory";
            this.cbOverwriteDirectory.Size = new System.Drawing.Size(331, 21);
            this.cbOverwriteDirectory.TabIndex = 4;
            this.cbOverwriteDirectory.Text = "如果输出目录不为空, 允许程序覆盖目录 (--clear-output)";
            this.cbOverwriteDirectory.UseVisualStyleBackColor = true;
            // 
            // cbNoClearDecompile
            // 
            this.cbNoClearDecompile.AutoSize = true;
            this.cbNoClearDecompile.Location = new System.Drawing.Point(34, 112);
            this.cbNoClearDecompile.Name = "cbNoClearDecompile";
            this.cbNoClearDecompile.Size = new System.Drawing.Size(331, 21);
            this.cbNoClearDecompile.TabIndex = 3;
            this.cbNoClearDecompile.Text = "解析后的残留文件将不会被清除 (--no-clear-decompile)";
            this.cbNoClearDecompile.UseVisualStyleBackColor = true;
            // 
            // cbFormatCode
            // 
            this.cbFormatCode.AutoSize = true;
            this.cbFormatCode.Location = new System.Drawing.Point(34, 85);
            this.cbFormatCode.Name = "cbFormatCode";
            this.cbFormatCode.Size = new System.Drawing.Size(184, 21);
            this.cbFormatCode.TabIndex = 2;
            this.cbFormatCode.Text = "格式化反编译代码 (--format)";
            this.cbFormatCode.UseVisualStyleBackColor = true;
            // 
            // tbAppId
            // 
            this.tbAppId.Location = new System.Drawing.Point(84, 18);
            this.tbAppId.Name = "tbAppId";
            this.tbAppId.Size = new System.Drawing.Size(173, 23);
            this.tbAppId.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbOutput);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(566, 235);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "终端";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbOutput
            // 
            this.tbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOutput.Location = new System.Drawing.Point(3, 3);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(560, 229);
            this.tbOutput.TabIndex = 0;
            this.tbOutput.Text = "等待执行...\r\n";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(590, 281);
            this.panel1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "exe";
            this.openFileDialog1.Filter = "EXE 文件 (*.exe)|*.exe";
            this.openFileDialog1.Title = "打开文件";
            // 
            // openFileDialogSelectFiles
            // 
            this.openFileDialogSelectFiles.Multiselect = true;
            this.openFileDialogSelectFiles.Title = "选择包文件";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 281);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Unveiler For Windows";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpDecompile.ResumeLayout(false);
            this.tpDecompile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unveilerLogLevelBindingBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpDecompile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbToken;
        private System.Windows.Forms.TextBox tbUnveilerPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox cbNoClearDecompile;
        private System.Windows.Forms.CheckBox cbFormatCode;
        private System.Windows.Forms.TextBox tbAppId;
        private System.Windows.Forms.CheckBox cbOverwriteDirectory;
        private System.Windows.Forms.CheckBox cbScanSensitive;
        private System.Windows.Forms.TextBox tbDepth;
        private System.Windows.Forms.ComboBox cbLogLevel;
        private System.Windows.Forms.BindingSource unveilerLogLevelBindingBindingSource;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rbFiles;
        private System.Windows.Forms.RadioButton rbDirectory;
        private System.Windows.Forms.Button btnDecompile;
        private System.Windows.Forms.TextBox tbOutputDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialogSelectFiles;
    }
}

