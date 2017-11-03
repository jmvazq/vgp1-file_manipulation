namespace FileManipulation
{
    partial class frmFileManipulation
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEvaluación = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rtxtRutina = new System.Windows.Forms.RichTextBox();
            this.tmrBackupTimer = new System.Windows.Forms.Timer(this.components);
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.btnStartEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(41, 23);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 34);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(147, 25);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(93, 33);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(264, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(357, 24);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(81, 34);
            this.btnSaveAs.TabIndex = 3;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(576, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEvaluación
            // 
            this.btnEvaluación.Location = new System.Drawing.Point(665, 81);
            this.btnEvaluación.Name = "btnEvaluación";
            this.btnEvaluación.Size = new System.Drawing.Size(120, 48);
            this.btnEvaluación.TabIndex = 6;
            this.btnEvaluación.Text = "EVALUACIÓN";
            this.btnEvaluación.UseVisualStyleBackColor = true;
            this.btnEvaluación.Click += new System.EventHandler(this.btnEvaluación_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(52, 427);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // rtxtRutina
            // 
            this.rtxtRutina.Location = new System.Drawing.Point(41, 72);
            this.rtxtRutina.Name = "rtxtRutina";
            this.rtxtRutina.Size = new System.Drawing.Size(607, 325);
            this.rtxtRutina.TabIndex = 8;
            this.rtxtRutina.Text = "Enter your text here.";
            this.rtxtRutina.TextChanged += new System.EventHandler(this.rtxtRutina_TextChanged);
            // 
            // tmrBackupTimer
            // 
            this.tmrBackupTimer.Enabled = true;
            this.tmrBackupTimer.Interval = 30000;
            this.tmrBackupTimer.Tick += new System.EventHandler(this.tmrBackupTimer_Tick);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Location = new System.Drawing.Point(444, 25);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(94, 33);
            this.btnDuplicate.TabIndex = 9;
            this.btnDuplicate.Text = "Copy";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
            // 
            // btnStartEmail
            // 
            this.btnStartEmail.Location = new System.Drawing.Point(665, 363);
            this.btnStartEmail.Name = "btnStartEmail";
            this.btnStartEmail.Size = new System.Drawing.Size(120, 34);
            this.btnStartEmail.TabIndex = 10;
            this.btnStartEmail.Text = "Email";
            this.btnStartEmail.UseVisualStyleBackColor = true;
            this.btnStartEmail.Click += new System.EventHandler(this.btnStartEmail_Click);
            // 
            // frmFileManipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 484);
            this.Controls.Add(this.btnStartEmail);
            this.Controls.Add(this.btnDuplicate);
            this.Controls.Add(this.rtxtRutina);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnEvaluación);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnNew);
            this.Name = "frmFileManipulation";
            this.Text = "File Manipulation - Jessica_Text";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFileManipulation_FormClosing);
            this.Load += new System.EventHandler(this.frmFileManipulation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEvaluación;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox rtxtRutina;
        private System.Windows.Forms.Timer tmrBackupTimer;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.Button btnStartEmail;
    }
}

