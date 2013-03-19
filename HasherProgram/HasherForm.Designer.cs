namespace WindowsFormsApplication1
{
    partial class HasherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblFileNameProcessing = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fileHashing = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCheckChecksum = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.chkLowerCase = new System.Windows.Forms.CheckBox();
            this.txtSHA256 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCRC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSHA1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkSaveDefaultFile = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChecksumFilename = new System.Windows.Forms.TextBox();
            this.chkSaveToFile = new System.Windows.Forms.CheckBox();
            this.btnBatchHash = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.chkLowerCaseDir = new System.Windows.Forms.CheckBox();
            this.cbHashing = new System.Windows.Forms.ComboBox();
            this.chkFullPath = new System.Windows.Forms.CheckBox();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.chkRecursively = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.fileHashing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(4, 313);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(617, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // lblFileNameProcessing
            // 
            this.lblFileNameProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileNameProcessing.AutoSize = true;
            this.lblFileNameProcessing.BackColor = System.Drawing.Color.Transparent;
            this.lblFileNameProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFileNameProcessing.Location = new System.Drawing.Point(10, 292);
            this.lblFileNameProcessing.Name = "lblFileNameProcessing";
            this.lblFileNameProcessing.Size = new System.Drawing.Size(56, 13);
            this.lblFileNameProcessing.TabIndex = 13;
            this.lblFileNameProcessing.Text = "Progress";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 279);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fileHashing);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fileHashing
            // 
            this.fileHashing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileHashing.Controls.Add(this.pictureBox2);
            this.fileHashing.Controls.Add(this.label7);
            this.fileHashing.Controls.Add(this.txtCheckChecksum);
            this.fileHashing.Controls.Add(this.pictureBox1);
            this.fileHashing.Controls.Add(this.txtFilePath);
            this.fileHashing.Controls.Add(this.label6);
            this.fileHashing.Controls.Add(this.btnSelectFile);
            this.fileHashing.Controls.Add(this.chkLowerCase);
            this.fileHashing.Controls.Add(this.txtSHA256);
            this.fileHashing.Controls.Add(this.label4);
            this.fileHashing.Controls.Add(this.txtCRC);
            this.fileHashing.Controls.Add(this.label3);
            this.fileHashing.Controls.Add(this.txtSHA1);
            this.fileHashing.Controls.Add(this.label2);
            this.fileHashing.Controls.Add(this.label1);
            this.fileHashing.Controls.Add(this.txtMD5);
            this.fileHashing.Location = new System.Drawing.Point(0, 6);
            this.fileHashing.Name = "fileHashing";
            this.fileHashing.Size = new System.Drawing.Size(606, 160);
            this.fileHashing.TabIndex = 11;
            this.fileHashing.TabStop = false;
            this.fileHashing.Text = "File hashing";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hasher.Properties.Resources._true;
            this.pictureBox2.Location = new System.Drawing.Point(356, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Checksum";
            // 
            // txtCheckChecksum
            // 
            this.txtCheckChecksum.BackColor = System.Drawing.Color.White;
            this.txtCheckChecksum.Location = new System.Drawing.Point(79, 127);
            this.txtCheckChecksum.Name = "txtCheckChecksum";
            this.txtCheckChecksum.Size = new System.Drawing.Size(271, 20);
            this.txtCheckChecksum.TabIndex = 23;
            this.txtCheckChecksum.TextChanged += new System.EventHandler(this.txtCheckChecksum_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hasher.Properties.Resources._false;
            this.pictureBox1.Location = new System.Drawing.Point(356, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(80, 23);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(425, 20);
            this.txtFilePath.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "File path";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(511, 21);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 19;
            this.btnSelectFile.Text = "Select file";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // chkLowerCase
            // 
            this.chkLowerCase.AutoSize = true;
            this.chkLowerCase.Checked = true;
            this.chkLowerCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLowerCase.Location = new System.Drawing.Point(475, 52);
            this.chkLowerCase.Name = "chkLowerCase";
            this.chkLowerCase.Size = new System.Drawing.Size(111, 17);
            this.chkLowerCase.TabIndex = 18;
            this.chkLowerCase.Text = "lowercase hashes";
            this.chkLowerCase.UseVisualStyleBackColor = true;
            this.chkLowerCase.CheckStateChanged += new System.EventHandler(this.chkLowerCase_CheckedChanged);
            // 
            // txtSHA256
            // 
            this.txtSHA256.Location = new System.Drawing.Point(79, 153);
            this.txtSHA256.Name = "txtSHA256";
            this.txtSHA256.ReadOnly = true;
            this.txtSHA256.Size = new System.Drawing.Size(425, 20);
            this.txtSHA256.TabIndex = 17;
            this.txtSHA256.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "SHA256";
            this.label4.Visible = false;
            // 
            // txtCRC
            // 
            this.txtCRC.Location = new System.Drawing.Point(80, 49);
            this.txtCRC.Name = "txtCRC";
            this.txtCRC.ReadOnly = true;
            this.txtCRC.Size = new System.Drawing.Size(82, 20);
            this.txtCRC.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "CRC32";
            // 
            // txtSHA1
            // 
            this.txtSHA1.Location = new System.Drawing.Point(80, 101);
            this.txtSHA1.Name = "txtSHA1";
            this.txtSHA1.ReadOnly = true;
            this.txtSHA1.Size = new System.Drawing.Size(270, 20);
            this.txtSHA1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "SHA1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "MD5";
            // 
            // txtMD5
            // 
            this.txtMD5.Location = new System.Drawing.Point(80, 75);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.ReadOnly = true;
            this.txtMD5.Size = new System.Drawing.Size(270, 20);
            this.txtMD5.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Directory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.chkSaveDefaultFile);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtChecksumFilename);
            this.groupBox1.Controls.Add(this.chkSaveToFile);
            this.groupBox1.Controls.Add(this.btnBatchHash);
            this.groupBox1.Controls.Add(this.btnSaveToFile);
            this.groupBox1.Controls.Add(this.chkLowerCaseDir);
            this.groupBox1.Controls.Add(this.cbHashing);
            this.groupBox1.Controls.Add(this.chkFullPath);
            this.groupBox1.Controls.Add(this.btnSelectDirectory);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.chkRecursively);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 239);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directory hashing";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(223, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkSaveDefaultFile
            // 
            this.chkSaveDefaultFile.AutoSize = true;
            this.chkSaveDefaultFile.Checked = true;
            this.chkSaveDefaultFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveDefaultFile.Location = new System.Drawing.Point(8, 136);
            this.chkSaveDefaultFile.Name = "chkSaveDefaultFile";
            this.chkSaveDefaultFile.Size = new System.Drawing.Size(223, 17);
            this.chkSaveDefaultFile.TabIndex = 25;
            this.chkSaveDefaultFile.Text = "save hash results to default checksum file";
            this.chkSaveDefaultFile.UseVisualStyleBackColor = true;
            this.chkSaveDefaultFile.CheckStateChanged += new System.EventHandler(this.chkSaveDefaultFile_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Default checksum filename";
            // 
            // txtChecksumFilename
            // 
            this.txtChecksumFilename.Location = new System.Drawing.Point(7, 179);
            this.txtChecksumFilename.Name = "txtChecksumFilename";
            this.txtChecksumFilename.Size = new System.Drawing.Size(209, 20);
            this.txtChecksumFilename.TabIndex = 23;
            this.txtChecksumFilename.Text = "checksum";
            this.toolTip1.SetToolTip(this.txtChecksumFilename, "Name of checksum file which is place in selected directory. Extension \r\nis set de" +
        "pending on which hashing you select (.svf for CRC, .md5 for MD5\r\nand .sha fro SH" +
        "A1)");
            // 
            // chkSaveToFile
            // 
            this.chkSaveToFile.AutoSize = true;
            this.chkSaveToFile.Location = new System.Drawing.Point(8, 113);
            this.chkSaveToFile.Name = "chkSaveToFile";
            this.chkSaveToFile.Size = new System.Drawing.Size(137, 17);
            this.chkSaveToFile.TabIndex = 22;
            this.chkSaveToFile.Text = "ask to save result to file";
            this.toolTip1.SetToolTip(this.chkSaveToFile, "Ask to save checksum file to selected filename.\r\nDisables \"save hash results to d" +
        "efault checksum file\"\r\nDoes not work for batch hashing.");
            this.chkSaveToFile.UseVisualStyleBackColor = true;
            this.chkSaveToFile.CheckStateChanged += new System.EventHandler(this.chkSaveToFile_CheckedChanged);
            // 
            // btnBatchHash
            // 
            this.btnBatchHash.Location = new System.Drawing.Point(118, 205);
            this.btnBatchHash.Name = "btnBatchHash";
            this.btnBatchHash.Size = new System.Drawing.Size(98, 23);
            this.btnBatchHash.TabIndex = 21;
            this.btnBatchHash.Text = "Batch hashing";
            this.toolTip1.SetToolTip(this.btnBatchHash, "Selected file should contain list of directories\r\nseparated with new line.\r\n\r\nExa" +
        "mple of batch file:\r\nc:\\Directory1\\\r\nc:\\Directory2\\");
            this.btnBatchHash.UseVisualStyleBackColor = true;
            this.btnBatchHash.Click += new System.EventHandler(this.btnBatchHash_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(223, 18);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveToFile.TabIndex = 20;
            this.btnSaveToFile.Text = "Save to file";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // chkLowerCaseDir
            // 
            this.chkLowerCaseDir.AutoSize = true;
            this.chkLowerCaseDir.Checked = true;
            this.chkLowerCaseDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLowerCaseDir.Location = new System.Drawing.Point(8, 67);
            this.chkLowerCaseDir.Name = "chkLowerCaseDir";
            this.chkLowerCaseDir.Size = new System.Drawing.Size(111, 17);
            this.chkLowerCaseDir.TabIndex = 19;
            this.chkLowerCaseDir.Text = "lowercase hashes";
            this.chkLowerCaseDir.UseVisualStyleBackColor = true;
            // 
            // cbHashing
            // 
            this.cbHashing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHashing.Items.AddRange(new object[] {
            "CRC",
            "MD5",
            "SHA1"});
            this.cbHashing.Location = new System.Drawing.Point(8, 17);
            this.cbHashing.Name = "cbHashing";
            this.cbHashing.Size = new System.Drawing.Size(69, 21);
            this.cbHashing.TabIndex = 9;
            // 
            // chkFullPath
            // 
            this.chkFullPath.AutoSize = true;
            this.chkFullPath.Location = new System.Drawing.Point(8, 90);
            this.chkFullPath.Name = "chkFullPath";
            this.chkFullPath.Size = new System.Drawing.Size(181, 17);
            this.chkFullPath.TabIndex = 8;
            this.chkFullPath.Text = "keep full path of file in checksum";
            this.chkFullPath.UseVisualStyleBackColor = true;
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Location = new System.Drawing.Point(7, 205);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(105, 23);
            this.btnSelectDirectory.TabIndex = 7;
            this.btnSelectDirectory.Text = "Select directory";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(304, 18);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(294, 212);
            this.txtResult.TabIndex = 6;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // chkRecursively
            // 
            this.chkRecursively.AutoSize = true;
            this.chkRecursively.Checked = true;
            this.chkRecursively.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecursively.Location = new System.Drawing.Point(8, 44);
            this.chkRecursively.Name = "chkRecursively";
            this.chkRecursively.Size = new System.Drawing.Size(112, 17);
            this.chkRecursively.TabIndex = 1;
            this.chkRecursively.Text = "recurse directories";
            this.chkRecursively.UseVisualStyleBackColor = true;
            // 
            // HasherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(626, 339);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblFileNameProcessing);
            this.Controls.Add(this.progressBar1);
            this.MinimumSize = new System.Drawing.Size(642, 377);
            this.Name = "HasherForm";
            this.Text = "Hasher";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.fileHashing.ResumeLayout(false);
            this.fileHashing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblFileNameProcessing;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox fileHashing;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.CheckBox chkLowerCase;
        private System.Windows.Forms.TextBox txtSHA256;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCRC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSHA1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkSaveDefaultFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChecksumFilename;
        private System.Windows.Forms.CheckBox chkSaveToFile;
        private System.Windows.Forms.Button btnBatchHash;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.CheckBox chkLowerCaseDir;
        private System.Windows.Forms.ComboBox cbHashing;
        private System.Windows.Forms.CheckBox chkFullPath;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.CheckBox chkRecursively;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCheckChecksum;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

