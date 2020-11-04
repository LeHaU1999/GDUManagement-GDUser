namespace GDU_Management.GDU_Views
{
    partial class frmContacts
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
            this.grbEmail = new System.Windows.Forms.GroupBox();
            this.txtEmailContacts = new System.Windows.Forms.TextBox();
            this.grbPass = new System.Windows.Forms.GroupBox();
            this.txtPassContacts = new System.Windows.Forms.TextBox();
            this.rtxtTitle = new System.Windows.Forms.RichTextBox();
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.rtxtInforOther = new System.Windows.Forms.RichTextBox();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnContact = new System.Windows.Forms.Panel();
            this.cboChonContacts = new System.Windows.Forms.ComboBox();
            this.grbEmail.SuspendLayout();
            this.grbPass.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.pnContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEmail
            // 
            this.grbEmail.Controls.Add(this.txtEmailContacts);
            this.grbEmail.Location = new System.Drawing.Point(16, 154);
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.Size = new System.Drawing.Size(308, 64);
            this.grbEmail.TabIndex = 1;
            this.grbEmail.TabStop = false;
            this.grbEmail.Text = "Email";
            // 
            // txtEmailContacts
            // 
            this.txtEmailContacts.Enabled = false;
            this.txtEmailContacts.Location = new System.Drawing.Point(6, 26);
            this.txtEmailContacts.Name = "txtEmailContacts";
            this.txtEmailContacts.Size = new System.Drawing.Size(288, 27);
            this.txtEmailContacts.TabIndex = 0;
            // 
            // grbPass
            // 
            this.grbPass.Controls.Add(this.txtPassContacts);
            this.grbPass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbPass.Location = new System.Drawing.Point(16, 224);
            this.grbPass.Name = "grbPass";
            this.grbPass.Size = new System.Drawing.Size(308, 59);
            this.grbPass.TabIndex = 2;
            this.grbPass.TabStop = false;
            this.grbPass.Text = "Pass";
            // 
            // txtPassContacts
            // 
            this.txtPassContacts.Enabled = false;
            this.txtPassContacts.Location = new System.Drawing.Point(10, 22);
            this.txtPassContacts.Name = "txtPassContacts";
            this.txtPassContacts.Size = new System.Drawing.Size(284, 27);
            this.txtPassContacts.TabIndex = 0;
            // 
            // rtxtTitle
            // 
            this.rtxtTitle.Location = new System.Drawing.Point(16, 299);
            this.rtxtTitle.Name = "rtxtTitle";
            this.rtxtTitle.Size = new System.Drawing.Size(308, 71);
            this.rtxtTitle.TabIndex = 4;
            this.rtxtTitle.Text = "Title";
            this.rtxtTitle.TextChanged += new System.EventHandler(this.rtxtTitle_TextChanged);
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.Location = new System.Drawing.Point(16, 376);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(524, 154);
            this.rtxtMessage.TabIndex = 6;
            this.rtxtMessage.Text = "Message";
            this.rtxtMessage.TextChanged += new System.EventHandler(this.rtxtMessage_TextChanged);
            // 
            // rtxtInforOther
            // 
            this.rtxtInforOther.Location = new System.Drawing.Point(15, 536);
            this.rtxtInforOther.Name = "rtxtInforOther";
            this.rtxtInforOther.Size = new System.Drawing.Size(525, 117);
            this.rtxtInforOther.TabIndex = 8;
            this.rtxtInforOther.Text = "Information";
            this.rtxtInforOther.TextChanged += new System.EventHandler(this.rtxtDiaChi_TextChanged);
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnTitle.Controls.Add(this.label4);
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(552, 78);
            this.pnTitle.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(531, 75);
            this.label4.TabIndex = 0;
            this.label4.Text = "CONTACTS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::GDU_Management.Properties.Resources.icons8_update_tag_64px;
            this.btnUpdate.Location = new System.Drawing.Point(16, 659);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(251, 79);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::GDU_Management.Properties.Resources.icons8_exit_sign_64;
            this.btnClose.Location = new System.Drawing.Point(273, 659);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(267, 79);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Image = global::GDU_Management.Properties.Resources.logo_03_03;
            this.label1.Location = new System.Drawing.Point(330, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 136);
            this.label1.TabIndex = 22;
            // 
            // pnContact
            // 
            this.pnContact.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnContact.Controls.Add(this.cboChonContacts);
            this.pnContact.Controls.Add(this.label1);
            this.pnContact.Controls.Add(this.btnClose);
            this.pnContact.Controls.Add(this.btnUpdate);
            this.pnContact.Controls.Add(this.pnTitle);
            this.pnContact.Controls.Add(this.rtxtInforOther);
            this.pnContact.Controls.Add(this.rtxtMessage);
            this.pnContact.Controls.Add(this.rtxtTitle);
            this.pnContact.Controls.Add(this.grbPass);
            this.pnContact.Controls.Add(this.grbEmail);
            this.pnContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnContact.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pnContact.Location = new System.Drawing.Point(0, 0);
            this.pnContact.Name = "pnContact";
            this.pnContact.Size = new System.Drawing.Size(552, 741);
            this.pnContact.TabIndex = 0;
            // 
            // cboChonContacts
            // 
            this.cboChonContacts.FormattingEnabled = true;
            this.cboChonContacts.Location = new System.Drawing.Point(22, 85);
            this.cboChonContacts.Name = "cboChonContacts";
            this.cboChonContacts.Size = new System.Drawing.Size(302, 28);
            this.cboChonContacts.TabIndex = 23;
            this.cboChonContacts.SelectedIndexChanged += new System.EventHandler(this.cboChonContacts_SelectedIndexChanged);
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(552, 753);
            this.Controls.Add(this.pnContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmContacts_Load);
            this.grbEmail.ResumeLayout(false);
            this.grbEmail.PerformLayout();
            this.grbPass.ResumeLayout(false);
            this.grbPass.PerformLayout();
            this.pnTitle.ResumeLayout(false);
            this.pnContact.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEmail;
        private System.Windows.Forms.TextBox txtEmailContacts;
        private System.Windows.Forms.GroupBox grbPass;
        private System.Windows.Forms.TextBox txtPassContacts;
        private System.Windows.Forms.RichTextBox rtxtTitle;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private System.Windows.Forms.RichTextBox rtxtInforOther;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnContact;
        private System.Windows.Forms.ComboBox cboChonContacts;
    }
}