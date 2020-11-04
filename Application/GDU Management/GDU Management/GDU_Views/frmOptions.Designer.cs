namespace GDU_Management.GDU_Views
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.pnOptions = new System.Windows.Forms.Panel();
            this.lblCloseOption = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblManagerAccount = new System.Windows.Forms.Label();
            this.pnOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnOptions
            // 
            this.pnOptions.BackColor = System.Drawing.Color.White;
            this.pnOptions.Controls.Add(this.lblCloseOption);
            this.pnOptions.Controls.Add(this.lblContact);
            this.pnOptions.Controls.Add(this.lblManagerAccount);
            this.pnOptions.Location = new System.Drawing.Point(13, 13);
            this.pnOptions.Name = "pnOptions";
            this.pnOptions.Size = new System.Drawing.Size(577, 249);
            this.pnOptions.TabIndex = 0;
            // 
            // lblCloseOption
            // 
            this.lblCloseOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCloseOption.Image = ((System.Drawing.Image)(resources.GetObject("lblCloseOption.Image")));
            this.lblCloseOption.Location = new System.Drawing.Point(537, -4);
            this.lblCloseOption.Name = "lblCloseOption";
            this.lblCloseOption.Size = new System.Drawing.Size(40, 40);
            this.lblCloseOption.TabIndex = 1;
            this.lblCloseOption.Click += new System.EventHandler(this.lblCloseOption_Click);
            // 
            // lblContact
            // 
            this.lblContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContact.Image = global::GDU_Management.Properties.Resources.Training_Education_Instruction_150px;
            this.lblContact.Location = new System.Drawing.Point(295, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(282, 249);
            this.lblContact.TabIndex = 1;
            this.lblContact.Click += new System.EventHandler(this.lblContact_Click);
            // 
            // lblManagerAccount
            // 
            this.lblManagerAccount.Image = global::GDU_Management.Properties.Resources.Contact_Education_140;
            this.lblManagerAccount.Location = new System.Drawing.Point(3, 0);
            this.lblManagerAccount.Name = "lblManagerAccount";
            this.lblManagerAccount.Size = new System.Drawing.Size(286, 249);
            this.lblManagerAccount.TabIndex = 0;
            this.lblManagerAccount.Click += new System.EventHandler(this.lblManagerAccount_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(602, 274);
            this.Controls.Add(this.pnOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOptions";
            this.pnOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnOptions;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblManagerAccount;
        private System.Windows.Forms.Label lblCloseOption;
    }
}