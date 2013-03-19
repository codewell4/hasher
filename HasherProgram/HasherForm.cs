using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

/**
 * TODO:
 * Exception handling
 * Checksum for every file in directory
 * Save checksum to file in file mode
 * 
*/


namespace WindowsFormsApplication1
{
    public partial class HasherForm : Form
    {
        private const int BUFFER_SIZE = 1200000;
        private const String VERSION = "1.0";

        StringBuilder sbResult      = new StringBuilder();
        private BackgroundWorker bw = new BackgroundWorker();
        
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                this.lblFileNameProcessing.Text = "Canceled!";
            }
            else if (!(e.Error == null))
            {
                this.lblFileNameProcessing.Text = ("Error: " + e.Error.Message);
            }
            else
            {
                this.lblFileNameProcessing.Text = "Done!";
            }

            if (chkSaveToFile.Checked)
            {
                DialogResult saveFileResult = saveFileDialog1.ShowDialog();
                if (saveFileResult == DialogResult.OK)
                {
                    if (saveFileDialog1.FileName.Length > 0)
                    {
                        if (cbHashing.SelectedIndex == 0)
                            System.IO.File.WriteAllText(saveFileDialog1.FileName + ".sfv", sbResult.ToString());
                        else if (cbHashing.SelectedIndex == 1)
                            System.IO.File.WriteAllText(saveFileDialog1.FileName + ".md5", sbResult.ToString());
                        else if (cbHashing.SelectedIndex == 2)
                            System.IO.File.WriteAllText(saveFileDialog1.FileName + ".sha", sbResult.ToString());
                        else if (cbHashing.SelectedIndex == 3)
                            System.IO.File.WriteAllText(saveFileDialog1.FileName + ".sha256", sbResult.ToString());
                    }
                }
                else
                {
                    txtResult.Text = sbResult.ToString();
                }
            }
            else if (chkSaveDefaultFile.Checked)
            {}
            else
            {
                txtResult.Text = sbResult.ToString();
            }
            btnCancel.Enabled           = false;
            btnBatchHash.Enabled        = true;
            btnSelectDirectory.Enabled  = true;
            btnSelectFile.Enabled       = true;

            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = progressBar1.Minimum;
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            String reportString = e.UserState as String;
            lblFileNameProcessing.Text = "Processing: " + reportString;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 100;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if ((worker.CancellationPending == true))
            {
                e.Cancel = true;
            }
            else
            {
                System.Threading.Thread.Sleep(500);
                object[] parameters = e.Argument as object[];

                int hashMode = (int)parameters[0];
                String inputString = (String)parameters[1];
                int hashType = (int)parameters[2];
                Boolean isFullPath = (Boolean)parameters[3];
                Boolean isLowerCase = (Boolean)parameters[4];
                Boolean isRecursively = (Boolean)parameters[5];
                Boolean isSaveDefaultFile = (Boolean)parameters[6];
                Boolean isSaveToFile = (Boolean)parameters[7];
                String checksumFileName = (String)parameters[8];

                if (hashMode == 1)
                {
                    if (!inputString.EndsWith("\\"))
                        inputString = inputString + "\\";

                    if (isRecursively)
                    {
                        if (isFullPath)
                            DirSearch(inputString, hashType, isLowerCase, worker, e);
                        else
                            DirSearch(inputString, hashType, isLowerCase, worker, e, inputString);
                    }
                    else
                    { 
                        if (isFullPath)
                            DirNoSearch(inputString, hashType, isLowerCase, worker, e);
                        else
                            DirNoSearch(inputString, hashType, isLowerCase, worker, e, inputString);
                    }

                    if (isSaveDefaultFile)
                    {
                        if (checksumFileName.Length == 0)
                            checksumFileName = "checksum";

                        if (hashType == 0)
                            System.IO.File.WriteAllText(inputString + checksumFileName + ".sfv", sbResult.ToString());
                        else if (hashType == 1)
                            System.IO.File.WriteAllText(inputString + checksumFileName + ".md5", sbResult.ToString());
                        else if (hashType == 2)
                            System.IO.File.WriteAllText(inputString + checksumFileName + ".sha", sbResult.ToString());
                        else if (hashType == 3)
                            System.IO.File.WriteAllText(inputString + checksumFileName + ".sha256", sbResult.ToString());
                        sbResult.Clear();                   
                    }
                }
                else if (hashMode == 2)
                { 
                    String selectedDirectory = "";
                    String[] fileContent = File.ReadAllLines(inputString);
                    foreach(String line in fileContent)
                    {
                        if ((worker.CancellationPending == true))
                        {
                            e.Cancel = true;
                            break;
                        }
                        selectedDirectory = line;
                        if (!selectedDirectory.EndsWith("\\"))
                            selectedDirectory = selectedDirectory + "\\";

                        if (Directory.Exists(selectedDirectory))
                        { 
                            if (isRecursively)
                            {
                                if (isFullPath)
                                    DirSearch(selectedDirectory, hashType, isLowerCase, worker, e);
                                else
                                    DirSearch(selectedDirectory, hashType, isLowerCase, worker, e, selectedDirectory);
                            }
                            else
                            {
                                if (isFullPath)
                                    DirNoSearch(selectedDirectory, hashType, isLowerCase, worker, e);
                                else
                                    DirNoSearch(selectedDirectory, hashType, isLowerCase, worker, e, selectedDirectory);
                            }

                            if (checksumFileName.Length == 0)
                                checksumFileName = "checksum";

                            if (hashType == 0)
                                System.IO.File.WriteAllText(selectedDirectory + checksumFileName + ".sfv", sbResult.ToString());
                            else if (hashType == 1)
                                System.IO.File.WriteAllText(selectedDirectory + checksumFileName + ".md5", sbResult.ToString());
                            else if (hashType == 2)
                                System.IO.File.WriteAllText(selectedDirectory + checksumFileName + ".sha", sbResult.ToString());
                            else if (hashType == 3)
                                System.IO.File.WriteAllText(selectedDirectory + checksumFileName + ".sha256", sbResult.ToString());
                            sbResult.Clear();
                        }
                    }
                }
            }
        }


        public HasherForm()
        {
            InitializeComponent();
            cbHashing.SelectedIndex = 2;
            btnSaveToFile.Enabled = false;
            lblFileNameProcessing.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            bw.WorkerReportsProgress        = true;
            bw.WorkerSupportsCancellation   = true;
            bw.DoWork                       += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged              += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted           += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);

            this.Text += " " + VERSION;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            DialogResult openFileResult = openFileDialog1.ShowDialog();

            if (openFileResult == DialogResult.OK)
            { 
                if (openFileDialog1.FileName.Length > 0)
                {
                    txtFilePath.Text            = openFileDialog1.FileName;
                    txtCRC.Text                 = "";
                    txtMD5.Text                 = "";
                    txtSHA1.Text                = "";
                    txtSHA256.Text              = "";

                    btnCancel.Enabled           = false;
                    btnBatchHash.Enabled        = false;
                    btnSelectDirectory.Enabled  = false;
                    btnSelectFile.Enabled       = false;

                    using (var stream = new BufferedStream((File.OpenRead(openFileDialog1.FileName)), BUFFER_SIZE))
                    {
                        Application.DoEvents();

                        Crc32 crc32 = new Crc32();
                        byte[] checksumCRC = crc32.ComputeHash(stream);

                        if (chkLowerCase.Checked)
                            txtCRC.Text = BitConverter.ToString(checksumCRC).Replace("-", String.Empty).ToLower();
                        else
                            txtCRC.Text = BitConverter.ToString(checksumCRC).Replace("-", String.Empty);

                        MD5 md5 = MD5.Create();
                        byte[] checksumMD5 = md5.ComputeHash(stream);

                        if (chkLowerCase.Checked)
                            txtMD5.Text = BitConverter.ToString(checksumMD5).Replace("-", String.Empty).ToLower();
                        else
                            txtMD5.Text = BitConverter.ToString(checksumMD5).Replace("-", String.Empty);

                        SHA1Managed sha = new SHA1Managed();
                        byte[] checksumSHA = sha.ComputeHash(stream);

                        if (chkLowerCase.Checked)
                            txtSHA1.Text = BitConverter.ToString(checksumSHA).Replace("-", String.Empty).ToLower();
                        else
                            txtSHA1.Text = BitConverter.ToString(checksumSHA).Replace("-", String.Empty);
                    }

                    if (txtCheckChecksum.Text.Length > 0 && (txtCRC.Text.Length > 0 || txtMD5.Text.Length > 0 || txtSHA1.Text.Length > 0))
                    {
                        if (!(txtCRC.Text.ToLower().Equals(txtCheckChecksum.Text.ToLower()) || txtMD5.Text.ToLower().Equals(txtCheckChecksum.Text.ToLower()) || txtSHA1.Text.ToLower().Equals(txtCheckChecksum.Text.ToLower())))
                        {
                            pictureBox1.Visible = true;
                            pictureBox2.Visible = false;
                            txtCheckChecksum.BackColor = Color.FromArgb(255, 224, 224);
                        }
                        else
                        {
                            pictureBox1.Visible = false;
                            pictureBox2.Visible = true;
                            txtCheckChecksum.BackColor = Color.FromArgb(181, 255, 178);
                        }
                    }
                    else
                    { 
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        txtCheckChecksum.BackColor = Color.White;
                    }
                }
            }
            btnCancel.Enabled           = false;
            btnBatchHash.Enabled        = true;
            btnSelectDirectory.Enabled  = true;
            btnSelectFile.Enabled       = true;
        }

        private void chkLowerCase_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLowerCase.Checked)
            {
                txtCRC.Text    = txtCRC.Text.ToLower();
                txtMD5.Text    = txtMD5.Text.ToLower();
                txtSHA1.Text   = txtSHA1.Text.ToLower();
                txtSHA256.Text = txtSHA256.Text.ToLower();
            }
            else
            {
                txtCRC.Text    = txtCRC.Text.ToUpper();
                txtMD5.Text    = txtMD5.Text.ToUpper();
                txtSHA1.Text   = txtSHA1.Text.ToUpper();
                txtSHA256.Text = txtSHA256.Text.ToUpper();
            }
        }

        private String calculateCRC(String pFilePath, Boolean inLowerCase = true)
        {
            String result = "";
            try
            {
                using (var stream = new BufferedStream((File.OpenRead(pFilePath)), BUFFER_SIZE))
                {
                    Application.DoEvents();
                    Crc32 crc32     = new Crc32();
                    byte[] checksum = crc32.ComputeHash(stream);
                    result          = BitConverter.ToString(checksum).Replace("-", String.Empty);

                    if (inLowerCase)
                        result = result.ToLower();
                }
            }
            catch(Exception ex)
            {
                //Not handled
            }
            return result;
        }

        private String calculateMD5(String pFilePath, Boolean inLowerCase = true)
        {
            String result = "";
            try
            {
                using (var stream = new BufferedStream((File.OpenRead(pFilePath)), BUFFER_SIZE))
                {
                    Application.DoEvents();
                    MD5 md5             = MD5.Create();
                    byte [] checksum    = md5.ComputeHash(stream);
                    result              = BitConverter.ToString(checksum).Replace("-", String.Empty);

                    if (inLowerCase)
                        result = result.ToLower();
                }
            }
            catch(Exception ex)
            {
                //Not handled
            }
            return result;
        }

        private String calculateSHA1(String pFilePath, Boolean inLowerCase = true)
        {
            String result = "";
            try
            {
                using (var stream = new BufferedStream((File.OpenRead(pFilePath)), BUFFER_SIZE))
                {
                    Application.DoEvents();
                    SHA1Managed sha     = new SHA1Managed();
                    byte [] checksum    = sha.ComputeHash(stream);
                    result              = BitConverter.ToString(checksum).Replace("-", String.Empty);

                    if (inLowerCase)
                        result = result.ToLower();
                }
            }
            catch(Exception ex)
            {
                //Not handled
            }
            return result;
        }

        private String calculateSHA256(String pFilePath, Boolean inLowerCase = true)
        {
            String result = "";
            try
            {
                using (var stream = new BufferedStream((File.OpenRead(pFilePath)), BUFFER_SIZE))
                {
                    Application.DoEvents();
                    SHA256Managed sha   = new SHA256Managed();
                    byte[] checksum     = sha.ComputeHash(stream);
                    result              = BitConverter.ToString(checksum).Replace("-", String.Empty);

                    if (inLowerCase)
                        result = result.ToLower();
                }
            }
            catch(Exception ex)
            {
                //Not handled
            }
            return result;
        }


        private void DirSearch(String pDir, int hashingType, Boolean isLowerCase, BackgroundWorker worker, DoWorkEventArgs e, String pFullPath = "")
        {
            String tempStr = "";
            try
            {
                foreach (String files in Directory.GetFiles(pDir))
                {
                    worker.ReportProgress(1,files);
                    if ((worker.CancellationPending == true))
                    {
                        e.Cancel = true;
                        break;
                    }
                    if (hashingType == 0)
                        tempStr = calculateCRC(files, isLowerCase);
                    else if (hashingType == 1)
                        tempStr = calculateMD5(files, isLowerCase);
                    else if (hashingType == 2)
                    {
                        tempStr = calculateSHA1(files, isLowerCase);
                    }
                    else if (hashingType == 3)
                        tempStr = calculateSHA256(files, isLowerCase);

                    if (pFullPath.Length > 0)
                    {
                        if (hashingType == 0)
                            sbResult.AppendLine(files.Replace(pFullPath, "") + " " + tempStr);
                        else
                            sbResult.AppendLine(tempStr + " *" + files.Replace(pFullPath, ""));
                    }
                    else
                    { 
                        if (hashingType == 0)
                            sbResult.AppendLine(files + " " + tempStr);
                        else
                            sbResult.AppendLine(tempStr + " *" + files);
                    }
                }
                foreach (String dirs in Directory.GetDirectories(pDir))
                {
                    DirSearch(dirs, hashingType, isLowerCase, worker, e, pFullPath);
                }
            }
            catch (Exception ex)
            {
                //Not handled   
            }
        }

        private void DirNoSearch(String pDir, int hashingType, Boolean isLowerCase, BackgroundWorker worker, DoWorkEventArgs e, String pFullPath = "")
        {
            String tempStr = "";
            try
            {
                foreach (String files in Directory.GetFiles(pDir))
                {
                    worker.ReportProgress(1,files);
                    if (hashingType == 0)
                        tempStr = calculateCRC(files, chkLowerCaseDir.Checked);
                    else if (hashingType == 1)
                        tempStr = calculateMD5(files, chkLowerCaseDir.Checked);
                    else if (hashingType == 2)
                        tempStr = calculateSHA1(files, chkLowerCaseDir.Checked);
                    else if (hashingType == 3)
                        tempStr = calculateSHA256(files, chkLowerCaseDir.Checked);

                    if (pFullPath.Length > 0)
                    {
                        if (hashingType == 0)
                            sbResult.AppendLine(files.Replace(pFullPath, "") + " " + tempStr);
                        else
                            sbResult.AppendLine(tempStr + " *" + files.Replace(pFullPath, ""));
                    }
                    else
                    { 
                        if (hashingType == 0)
                            sbResult.AppendLine(files + " " + tempStr);
                        else
                            sbResult.AppendLine(tempStr + " *" + files);
                    }
                }
            }
            catch (Exception ex)
            {
                //Not handled
            }
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            lblFileNameProcessing.Text = "";
            DialogResult openDirectoryResult = folderBrowserDialog1.ShowDialog();
            sbResult.Clear();

            if (openDirectoryResult == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath.Length > 0)
                {
                    if (bw.IsBusy != true)
                    {
                        btnCancel.Enabled           = true;
                        btnBatchHash.Enabled        = false;
                        btnSelectDirectory.Enabled  = false;
                        btnSelectFile.Enabled       = false;

                        object[] parameters = new object [] {1, folderBrowserDialog1.SelectedPath, cbHashing.SelectedIndex, chkFullPath.Checked, chkLowerCase.Checked, chkRecursively.Checked, chkSaveDefaultFile.Checked, chkSaveToFile.Checked, txtChecksumFilename.Text};
                        bw.RunWorkerAsync(parameters);
                    }
                }
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            DialogResult saveFileResult = saveFileDialog1.ShowDialog();
            if (saveFileResult == DialogResult.OK)
            {
                if (saveFileDialog1.FileName.Length > 0)
                {
                    if (cbHashing.SelectedIndex == 0)
                        System.IO.File.WriteAllText(saveFileDialog1.FileName + ".sfv", txtResult.Text.ToString());
                    else if (cbHashing.SelectedIndex == 1)
                        System.IO.File.WriteAllText(saveFileDialog1.FileName + ".md5", txtResult.Text.ToString());
                    else if (cbHashing.SelectedIndex == 2)
                        System.IO.File.WriteAllText(saveFileDialog1.FileName + ".sha", txtResult.Text.ToString());
                    else if (cbHashing.SelectedIndex == 3)
                        System.IO.File.WriteAllText(saveFileDialog1.FileName + ".sha256", txtResult.Text.ToString());
                }
            }
        }

        private void btnBatchHash_Click(object sender, EventArgs e)
        {
            lblFileNameProcessing.Text = "";
            DialogResult openFileResult = openFileDialog1.ShowDialog();

            if (openFileResult == DialogResult.OK)
            { 
                if (openFileDialog1.FileName.Length > 0)
                {
                    if (bw.IsBusy != true)
                    {
                        btnCancel.Enabled           = true;
                        btnBatchHash.Enabled        = false;
                        btnSelectDirectory.Enabled  = false;
                        btnSelectFile.Enabled       = false;

                        object[] parameters = new object [] {2, openFileDialog1.FileName, cbHashing.SelectedIndex, chkFullPath.Checked, chkLowerCase.Checked, chkRecursively.Checked, chkSaveDefaultFile.Checked, chkSaveToFile.Checked, txtChecksumFilename.Text};
                        bw.RunWorkerAsync(parameters);
                    }
                }
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            if (txtResult.TextLength > 0)
                btnSaveToFile.Enabled = true;
            else
                btnSaveToFile.Enabled = false;
        }

        private void chkSaveDefaultFile_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSaveDefaultFile.Checked)
            {
                txtChecksumFilename.Enabled = true;
                chkSaveToFile.Checked = false;
            }
            else
                txtChecksumFilename.Enabled = false;
        }

        private void chkSaveToFile_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSaveToFile.Checked)
                chkSaveDefaultFile.Checked = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (bw.WorkerSupportsCancellation == true)
            {
                bw.CancelAsync();
                lblFileNameProcessing.Text = "";
            }
        }

        private void txtCheckChecksum_TextChanged(object sender, EventArgs e)
        {
            if (txtCheckChecksum.Text.Length > 0 && (txtCRC.Text.Length > 0 || txtMD5.Text.Length > 0 || txtSHA1.Text.Length > 0))
            {
                if (!(txtCRC.Text.ToLower().Equals(txtCheckChecksum.Text.ToLower()) || txtMD5.Text.ToLower().Equals(txtCheckChecksum.Text.ToLower()) || txtSHA1.Text.ToLower().Equals(txtCheckChecksum.Text.ToLower())))
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    txtCheckChecksum.BackColor = Color.FromArgb(255, 224, 224);
                }
                else
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    txtCheckChecksum.BackColor = Color.FromArgb(225, 255, 224);
                }
            }
            else
            { 
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                txtCheckChecksum.BackColor = Color.White;
            }
        }
    }
}
