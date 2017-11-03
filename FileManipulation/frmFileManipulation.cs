using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// Added
using System.IO;
using System.Diagnostics;
using System.Net.Mail;

/*
 * TO DO:
 * Check why I can't access the checkbox's checked value in code. 
 */

namespace FileManipulation
{
    public partial class frmFileManipulation : Form
    {
        #region Variables
        string fileName = string.Empty;
        string filePath = string.Empty;
        bool HasUnsavedChanges = false;
        frmSendEmail frmSendEmail;
        #endregion

        #region Functions
        private void OpenFile(string fileName)
                {
                    rtxtRutina.LoadFile(fileName);
                    SetFileNameAndPath(fileName);
                    HasUnsavedChanges = false;
                    UpdateWindowTitle();
                }

        private bool Save()
        {
            try
            {
                if (!File.Exists(filePath + fileName + ".jes"))
                    return SaveAs();

                if (fileName != string.Empty && HasUnsavedChanges)
                {
                    rtxtRutina.SaveFile(filePath + fileName + ".jes");
                    HasUnsavedChanges = false;
                    UpdateWindowTitle();
                }

                else if (fileName == string.Empty)
                    return SaveAs();

                lblStatus.Text = "Project saved.";
                return true;
            }

            catch(Exception ex)
            {
                lblStatus.Text = "Error Saving!";
                MessageBox.Show(ex.Message, "Error Saving!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool SaveAs(string newFileName = "")
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.ValidateNames = true;
                saveFileDialog.OverwritePrompt = true;
                if (newFileName != string.Empty)
                    saveFileDialog.FileName = newFileName;

                // Create master projects directory if it doesn't exist
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Jessica_Text"))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Jessica_Text");

                }

                // Set additional, initial dialog values
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Jessica_Text";
                saveFileDialog.Filter = "Jessica Vazquez Files (*.jes)|*.jes";
                DialogResult result = saveFileDialog.ShowDialog();

                if (result != DialogResult.Cancel)
                {
                    if (!saveFileDialog.FileName.Contains(Environment.CurrentDirectory))
                    {
                        SetFileNameAndPath(saveFileDialog.FileName);

                        // Create project directory if it doesn't exist
                        if (!Directory.Exists(filePath + fileName))
                            Directory.CreateDirectory(filePath + fileName);
                        else
                        {
                            // Confirm overwrite
                            DialogResult overwriteConfirm = MessageBox.Show("Project folder with the name '" + fileName + "' exists already. Do you want to overwrite it?", "Overwrite?", MessageBoxButtons.OKCancel);
                            if (overwriteConfirm == DialogResult.Cancel)
                            {
                                lblStatus.Text = "Save cancelled.";
                                return false;
                            }
                        }

                        // Project folder has the same name as fileName
                        filePath = filePath + fileName + "\\";
                        // Save file as fileName/fileName.jes
                        rtxtRutina.SaveFile(filePath + fileName + ".jes");

                        HasUnsavedChanges = false;
                        UpdateWindowTitle();

                        lblStatus.Text = "Project saved.";
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Can't save your project inside Jessica_Text directory. Please choose another location.");
                    }

                    return false;
                }
                else
                    return false;
              }

            catch(Exception ex)
            {
                lblStatus.Text = "Error Saving!";
                MessageBox.Show(ex.Message, "Error Saving!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
               
            }

        }

        private bool Backup()
        {
            try
            {
                // Create Backups folder if it doesn't exist
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Jessica_Text\\_Backups"))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Jessica_Text\\_Backups");

                }

                if (!File.Exists(filePath + fileName + ".jes"))
                    return false;

                // Make sure the file exists and that it is NOT another backup file
                if (fileName != string.Empty && !fileName.EndsWith("_bak") && HasUnsavedChanges)
                {
                    // Create project backup folder if it doesn't exist
                    if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Jessica_Text\\_Backups\\" + fileName))
                    {
                        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Jessica_Text\\_Backups\\" + fileName);

                    }

                    // Save backup file
                    DateTime now = DateTime.Now;
                    rtxtRutina.SaveFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Jessica_Text\\_Backups\\" + fileName + "\\" + fileName + "-" + now.ToString("MMddyyyyhhmm") + "_bak.jes");
                    lblStatus.Text = "Project backup saved on " + now.ToString("MM/dd/yyyy - hh:mm") + ".";
                    return true;
                }

                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); // displays an error
                return false;
            }
        }
        #endregion

        private void UpdateWindowTitle()
        {
            string fname = fileName == string.Empty ? "UNTITLED" : fileName;
            string title = HasUnsavedChanges ? fname + "*" : fname;
            this.Text = title + " - " + "Jessica_Text";
        }

        private void SetFileNameAndPath(string str)
        {
            string[] spltString = str.Split('\\');
            fileName = (((spltString[spltString.Length - 1]).Split('.'))[0]).Trim().Replace(" ", "_");

            filePath = string.Empty;
            for(int i = 0; i < spltString.Length - 1; i++)
            {
                filePath += spltString[i];
                filePath += "\\";
            }
        }

        public frmFileManipulation()
        {
            InitializeComponent();
        }

        private void frmFileManipulation_Load(object sender, System.EventArgs e)
        {
            lblStatus.Text = "New project opened, unsaved.";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                string[] rawName = Process.GetCurrentProcess().ProcessName.Split('.');
                string processName = rawName[0] + ".exe";

                Process process = new Process();
                process.StartInfo.FileName = processName;
                process.Start();
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); // displays an error
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Jessica_Text"))
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Jessica_Text");
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Jessica_Text";
            openFileDialog.Filter = "Jessica Vazquez Files (*.jes)|*.jes";
            DialogResult result = openFileDialog.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                OpenFile(openFileDialog.FileName);
                lblStatus.Text = "Project opened.";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();

        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            if (fileName != string.Empty)
                SaveAs(this.fileName + "_copy");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEvaluación_Click(object sender, EventArgs e)
        {

        }

        private void rtxtRutina_TextChanged(object sender, EventArgs e)
        {
            HasUnsavedChanges = true;
            UpdateWindowTitle();
        }

        private void frmFileManipulation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(HasUnsavedChanges)
            {
                DialogResult result = MessageBox.Show("Do you want to save the changes?", "Unsaved Changes!", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.Yes)
                {
                    Save();
                    if(HasUnsavedChanges)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void tmrBackupTimer_Tick(object sender, System.EventArgs e)
        {
            Backup();
        }

        private void EmailFormClosed(object sender, EventArgs e)
        {
            this.Enabled = true;
            this.Focus();
        }

        private void SendEmail(object sender, EventArgs e)
        {
            try { 
                MailMessage mail = new MailMessage();

                // SMTP Settings group
                String server = frmSendEmail.Controls["grpSmtpSettings"].Controls["txtSmtpServer"].Text;

                int port;
                Int32.TryParse(frmSendEmail.Controls["grpSmtpSettings"].Controls["txtSmtpPort"].Text, out port);

                String username = frmSendEmail.Controls["grpSmtpSettings"].Controls["txtUsername"].Text;
                String password = frmSendEmail.Controls["grpSmtpSettings"].Controls["txtPassword"].Text;
                bool enableSsl = ((CheckBox)frmSendEmail.Controls["grpSmtpSettings"].Controls["chkEnableSsl"]).Checked;

                // Email Options group
                String mailFrom = frmSendEmail.Controls["grpEmailOptions"].Controls["txtEmailFrom"].Text;
                String mailTo = frmSendEmail.Controls["grpEmailOptions"].Controls["txtEmailTo"].Text;
                String mailSubject = frmSendEmail.Controls["grpEmailOptions"].Controls["txtEmailSubject"].Text;
                String mailBody = frmSendEmail.Controls["grpEmailOptions"].Controls["txtEmailBody"].Text;
                String mailAttachmentName = filePath + fileName + ".jes";

                // Prepare email
                SmtpClient SmtpServer = new SmtpClient(server);
                mail.From = new MailAddress(mailFrom);
                mail.To.Add(mailTo);
                mail.Subject = mailSubject;
                mail.Body = mailBody;

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(mailAttachmentName);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = port;
                SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);
                SmtpServer.EnableSsl = enableSsl;

                lblStatus.Text = "Sending email...";
                SmtpServer.Send(mail);

                frmSendEmail.Controls["strStatusBar"].Text = "Email sent to '" + mailTo + "'.";

                MessageBox.Show("Email sent!");
                lblStatus.Text = "Email sent.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error sending email!";
                frmSendEmail.Controls["strStatusBar"].Text = "Error sending email!";
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnStartEmail_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath + fileName + ".jes"))
            {
                MessageBox.Show("File does not exist. To attach your project to an email, please save it first.", "Missing Attachment!");
                return;
            }

            frmSendEmail = new frmSendEmail();
            frmSendEmail.Show();
            this.Enabled = false;
            frmSendEmail.Focus();
                
            // Add event handlers
            frmSendEmail.FormClosed += new FormClosedEventHandler(EmailFormClosed);
            frmSendEmail.Controls["btnSendEmail"].Click += new EventHandler(SendEmail);

            // Display attachment info
            frmSendEmail.Controls["grpEmailOptions"].Controls["txtEmailAttachment"].Text = filePath + fileName + ".jes";

            // Change window title
            frmSendEmail.Text = fileName + ".jes - " + frmSendEmail.Text + " - Jessica_Text";
        }
    }
}
