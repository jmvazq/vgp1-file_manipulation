namespace FileManipulation
{
    partial class frmSendEmail
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
            this.grpSmtpSettings = new System.Windows.Forms.GroupBox();
            this.lblSMTPPort = new System.Windows.Forms.Label();
            this.txtSmtpPort = new System.Windows.Forms.TextBox();
            this.lblSMTPServer = new System.Windows.Forms.Label();
            this.txtSmtpServer = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.grpEmailOptions = new System.Windows.Forms.GroupBox();
            this.txtEmailFrom = new System.Windows.Forms.TextBox();
            this.lblEmailFrom = new System.Windows.Forms.Label();
            this.lblEmailTo = new System.Windows.Forms.Label();
            this.txtEmailTo = new System.Windows.Forms.TextBox();
            this.lblEmailSubject = new System.Windows.Forms.Label();
            this.txtEmailSubject = new System.Windows.Forms.TextBox();
            this.lblEmailBody = new System.Windows.Forms.Label();
            this.txtEmailBody = new System.Windows.Forms.TextBox();
            this.lblAttachmentFileName = new System.Windows.Forms.Label();
            this.txtEmailAttachment = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.strStatusBar = new System.Windows.Forms.StatusStrip();
            this.chkEnableSsl = new System.Windows.Forms.CheckBox();
            this.grpSmtpSettings.SuspendLayout();
            this.grpEmailOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSmtpSettings
            // 
            this.grpSmtpSettings.Controls.Add(this.chkEnableSsl);
            this.grpSmtpSettings.Controls.Add(this.lblPassword);
            this.grpSmtpSettings.Controls.Add(this.txtPassword);
            this.grpSmtpSettings.Controls.Add(this.lblUsername);
            this.grpSmtpSettings.Controls.Add(this.txtUsername);
            this.grpSmtpSettings.Controls.Add(this.lblSMTPPort);
            this.grpSmtpSettings.Controls.Add(this.txtSmtpPort);
            this.grpSmtpSettings.Controls.Add(this.lblSMTPServer);
            this.grpSmtpSettings.Controls.Add(this.txtSmtpServer);
            this.grpSmtpSettings.Location = new System.Drawing.Point(12, 12);
            this.grpSmtpSettings.Name = "grpSmtpSettings";
            this.grpSmtpSettings.Size = new System.Drawing.Size(635, 110);
            this.grpSmtpSettings.TabIndex = 6;
            this.grpSmtpSettings.TabStop = false;
            this.grpSmtpSettings.Text = "SMTP Settings";
            // 
            // lblSMTPPort
            // 
            this.lblSMTPPort.AutoSize = true;
            this.lblSMTPPort.Location = new System.Drawing.Point(9, 57);
            this.lblSMTPPort.Name = "lblSMTPPort";
            this.lblSMTPPort.Size = new System.Drawing.Size(34, 17);
            this.lblSMTPPort.TabIndex = 9;
            this.lblSMTPPort.Text = "Port";
            // 
            // txtSmtpPort
            // 
            this.txtSmtpPort.Location = new System.Drawing.Point(88, 52);
            this.txtSmtpPort.Name = "txtSmtpPort";
            this.txtSmtpPort.Size = new System.Drawing.Size(199, 22);
            this.txtSmtpPort.TabIndex = 8;
            this.txtSmtpPort.Text = "587";
            // 
            // lblSMTPServer
            // 
            this.lblSMTPServer.AutoSize = true;
            this.lblSMTPServer.Location = new System.Drawing.Point(10, 29);
            this.lblSMTPServer.Name = "lblSMTPServer";
            this.lblSMTPServer.Size = new System.Drawing.Size(50, 17);
            this.lblSMTPServer.TabIndex = 7;
            this.lblSMTPServer.Text = "Server";
            // 
            // txtSmtpServer
            // 
            this.txtSmtpServer.Location = new System.Drawing.Point(89, 24);
            this.txtSmtpServer.Name = "txtSmtpServer";
            this.txtSmtpServer.Size = new System.Drawing.Size(199, 22);
            this.txtSmtpServer.TabIndex = 6;
            this.txtSmtpServer.Text = "smtp.gmail.com";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(326, 29);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(425, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(199, 22);
            this.txtUsername.TabIndex = 12;
            this.txtUsername.Text = "user@domain.com";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(326, 57);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(425, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(199, 22);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // grpEmailOptions
            // 
            this.grpEmailOptions.Controls.Add(this.txtEmailAttachment);
            this.grpEmailOptions.Controls.Add(this.lblAttachmentFileName);
            this.grpEmailOptions.Controls.Add(this.lblEmailBody);
            this.grpEmailOptions.Controls.Add(this.txtEmailBody);
            this.grpEmailOptions.Controls.Add(this.lblEmailSubject);
            this.grpEmailOptions.Controls.Add(this.txtEmailSubject);
            this.grpEmailOptions.Controls.Add(this.lblEmailTo);
            this.grpEmailOptions.Controls.Add(this.txtEmailTo);
            this.grpEmailOptions.Controls.Add(this.lblEmailFrom);
            this.grpEmailOptions.Controls.Add(this.txtEmailFrom);
            this.grpEmailOptions.Location = new System.Drawing.Point(12, 128);
            this.grpEmailOptions.Name = "grpEmailOptions";
            this.grpEmailOptions.Size = new System.Drawing.Size(635, 277);
            this.grpEmailOptions.TabIndex = 7;
            this.grpEmailOptions.TabStop = false;
            this.grpEmailOptions.Text = "Email Options";
            // 
            // txtEmailFrom
            // 
            this.txtEmailFrom.Location = new System.Drawing.Point(88, 27);
            this.txtEmailFrom.Name = "txtEmailFrom";
            this.txtEmailFrom.Size = new System.Drawing.Size(200, 22);
            this.txtEmailFrom.TabIndex = 0;
            this.txtEmailFrom.Text = "user@domain.com";
            // 
            // lblEmailFrom
            // 
            this.lblEmailFrom.AutoSize = true;
            this.lblEmailFrom.Location = new System.Drawing.Point(9, 30);
            this.lblEmailFrom.Name = "lblEmailFrom";
            this.lblEmailFrom.Size = new System.Drawing.Size(40, 17);
            this.lblEmailFrom.TabIndex = 10;
            this.lblEmailFrom.Text = "From";
            // 
            // lblEmailTo
            // 
            this.lblEmailTo.AutoSize = true;
            this.lblEmailTo.Location = new System.Drawing.Point(9, 58);
            this.lblEmailTo.Name = "lblEmailTo";
            this.lblEmailTo.Size = new System.Drawing.Size(25, 17);
            this.lblEmailTo.TabIndex = 12;
            this.lblEmailTo.Text = "To";
            // 
            // txtEmailTo
            // 
            this.txtEmailTo.Location = new System.Drawing.Point(88, 55);
            this.txtEmailTo.Name = "txtEmailTo";
            this.txtEmailTo.Size = new System.Drawing.Size(200, 22);
            this.txtEmailTo.TabIndex = 11;
            this.txtEmailTo.Text = "user@domain.com";
            // 
            // lblEmailSubject
            // 
            this.lblEmailSubject.AutoSize = true;
            this.lblEmailSubject.Location = new System.Drawing.Point(10, 87);
            this.lblEmailSubject.Name = "lblEmailSubject";
            this.lblEmailSubject.Size = new System.Drawing.Size(55, 17);
            this.lblEmailSubject.TabIndex = 14;
            this.lblEmailSubject.Text = "Subject";
            // 
            // txtEmailSubject
            // 
            this.txtEmailSubject.Location = new System.Drawing.Point(89, 84);
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.Size = new System.Drawing.Size(535, 22);
            this.txtEmailSubject.TabIndex = 13;
            // 
            // lblEmailBody
            // 
            this.lblEmailBody.AutoSize = true;
            this.lblEmailBody.Location = new System.Drawing.Point(10, 116);
            this.lblEmailBody.Name = "lblEmailBody";
            this.lblEmailBody.Size = new System.Drawing.Size(40, 17);
            this.lblEmailBody.TabIndex = 16;
            this.lblEmailBody.Text = "Body";
            // 
            // txtEmailBody
            // 
            this.txtEmailBody.Location = new System.Drawing.Point(89, 113);
            this.txtEmailBody.Multiline = true;
            this.txtEmailBody.Name = "txtEmailBody";
            this.txtEmailBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmailBody.Size = new System.Drawing.Size(535, 113);
            this.txtEmailBody.TabIndex = 15;
            // 
            // lblAttachmentFileName
            // 
            this.lblAttachmentFileName.AutoSize = true;
            this.lblAttachmentFileName.Location = new System.Drawing.Point(9, 242);
            this.lblAttachmentFileName.Name = "lblAttachmentFileName";
            this.lblAttachmentFileName.Size = new System.Drawing.Size(79, 17);
            this.lblAttachmentFileName.TabIndex = 17;
            this.lblAttachmentFileName.Text = "Attachment";
            // 
            // txtEmailAttachment
            // 
            this.txtEmailAttachment.Location = new System.Drawing.Point(88, 237);
            this.txtEmailAttachment.Name = "txtEmailAttachment";
            this.txtEmailAttachment.ReadOnly = true;
            this.txtEmailAttachment.Size = new System.Drawing.Size(535, 22);
            this.txtEmailAttachment.TabIndex = 18;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(495, 411);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(152, 33);
            this.btnSendEmail.TabIndex = 8;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // strStatusBar
            // 
            this.strStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.strStatusBar.Location = new System.Drawing.Point(0, 457);
            this.strStatusBar.Name = "strStatusBar";
            this.strStatusBar.Size = new System.Drawing.Size(663, 22);
            this.strStatusBar.TabIndex = 10;
            this.strStatusBar.Text = "Status";
            // 
            // chkEnableSsl
            // 
            this.chkEnableSsl.AutoSize = true;
            this.chkEnableSsl.Checked = true;
            this.chkEnableSsl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableSsl.Location = new System.Drawing.Point(13, 82);
            this.chkEnableSsl.Name = "chkEnableSsl";
            this.chkEnableSsl.Size = new System.Drawing.Size(104, 21);
            this.chkEnableSsl.TabIndex = 16;
            this.chkEnableSsl.Text = "Enable SSL";
            this.chkEnableSsl.UseVisualStyleBackColor = true;
            // 
            // frmSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 479);
            this.Controls.Add(this.strStatusBar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.grpEmailOptions);
            this.Controls.Add(this.grpSmtpSettings);
            this.Name = "frmSendEmail";
            this.Text = "Send Email";
            this.Load += new System.EventHandler(this.frmSendEmail_Load);
            this.grpSmtpSettings.ResumeLayout(false);
            this.grpSmtpSettings.PerformLayout();
            this.grpEmailOptions.ResumeLayout(false);
            this.grpEmailOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSmtpSettings;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblSMTPPort;
        private System.Windows.Forms.TextBox txtSmtpPort;
        private System.Windows.Forms.Label lblSMTPServer;
        private System.Windows.Forms.TextBox txtSmtpServer;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox grpEmailOptions;
        private System.Windows.Forms.Label lblEmailTo;
        private System.Windows.Forms.TextBox txtEmailTo;
        private System.Windows.Forms.Label lblEmailFrom;
        private System.Windows.Forms.TextBox txtEmailFrom;
        private System.Windows.Forms.Label lblEmailBody;
        private System.Windows.Forms.TextBox txtEmailBody;
        private System.Windows.Forms.Label lblEmailSubject;
        private System.Windows.Forms.TextBox txtEmailSubject;
        private System.Windows.Forms.TextBox txtEmailAttachment;
        private System.Windows.Forms.Label lblAttachmentFileName;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip strStatusBar;
        private System.Windows.Forms.CheckBox chkEnableSsl;
    }
}