namespace GDU_Management
{
    partial class frmLogin
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
            this.pnContents = new System.Windows.Forms.Panel();
            this.pnSystem = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblReset = new System.Windows.Forms.Label();
            this.lblLoginToSYS = new System.Windows.Forms.Label();
            this.grbUsername = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.grbPassword = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnLogoGDU = new System.Windows.Forms.Panel();
            this.pnContents.SuspendLayout();
            this.pnSystem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbUsername.SuspendLayout();
            this.grbPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContents
            // 
            this.pnContents.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnContents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContents.Controls.Add(this.pnSystem);
            this.pnContents.Controls.Add(this.pnLogoGDU);
            this.pnContents.Location = new System.Drawing.Point(13, 12);
            this.pnContents.Name = "pnContents";
            this.pnContents.Size = new System.Drawing.Size(883, 418);
            this.pnContents.TabIndex = 0;
            // 
            // pnSystem
            // 
            this.pnSystem.BackColor = System.Drawing.Color.White;
            this.pnSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSystem.Controls.Add(this.panel1);
            this.pnSystem.Controls.Add(this.lblReset);
            this.pnSystem.Controls.Add(this.lblLoginToSYS);
            this.pnSystem.Controls.Add(this.grbUsername);
            this.pnSystem.Controls.Add(this.grbPassword);
            this.pnSystem.Location = new System.Drawing.Point(443, 31);
            this.pnSystem.Name = "pnSystem";
            this.pnSystem.Size = new System.Drawing.Size(412, 362);
            this.pnSystem.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(32, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 69);
            this.panel1.TabIndex = 8;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Blue;
            this.btnLogin.Location = new System.Drawing.Point(7, 7);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 52);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            this.btnLogin.MouseHover += new System.EventHandler(this.btnLogin_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExit.Location = new System.Drawing.Point(173, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 52);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // lblReset
            // 
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset.Image = global::GDU_Management.Properties.Resources.icons8_available_updates_30;
            this.lblReset.Location = new System.Drawing.Point(364, 204);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(43, 32);
            this.lblReset.TabIndex = 7;
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            this.lblReset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblReset_MouseClick);
            // 
            // lblLoginToSYS
            // 
            this.lblLoginToSYS.AutoSize = true;
            this.lblLoginToSYS.Font = new System.Drawing.Font(".VnCentury Schoolbook", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginToSYS.Location = new System.Drawing.Point(25, 24);
            this.lblLoginToSYS.Name = "lblLoginToSYS";
            this.lblLoginToSYS.Size = new System.Drawing.Size(339, 47);
            this.lblLoginToSYS.TabIndex = 0;
            this.lblLoginToSYS.Text = "Login To System";
            // 
            // grbUsername
            // 
            this.grbUsername.Controls.Add(this.txtUsername);
            this.grbUsername.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUsername.Location = new System.Drawing.Point(33, 91);
            this.grbUsername.Name = "grbUsername";
            this.grbUsername.Size = new System.Drawing.Size(331, 76);
            this.grbUsername.TabIndex = 1;
            this.grbUsername.TabStop = false;
            this.grbUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(6, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(319, 31);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // grbPassword
            // 
            this.grbPassword.Controls.Add(this.txtPassword);
            this.grbPassword.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPassword.Location = new System.Drawing.Point(32, 173);
            this.grbPassword.Name = "grbPassword";
            this.grbPassword.Size = new System.Drawing.Size(332, 76);
            this.grbPassword.TabIndex = 2;
            this.grbPassword.TabStop = false;
            this.grbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(7, 31);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(319, 31);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // pnLogoGDU
            // 
            this.pnLogoGDU.BackgroundImage = global::GDU_Management.Properties.Resources.logo;
            this.pnLogoGDU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnLogoGDU.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnLogoGDU.Location = new System.Drawing.Point(32, 31);
            this.pnLogoGDU.Name = "pnLogoGDU";
            this.pnLogoGDU.Size = new System.Drawing.Size(405, 362);
            this.pnLogoGDU.TabIndex = 5;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(908, 442);
            this.Controls.Add(this.pnContents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to System";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnContents.ResumeLayout(false);
            this.pnSystem.ResumeLayout(false);
            this.pnSystem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grbUsername.ResumeLayout(false);
            this.grbUsername.PerformLayout();
            this.grbPassword.ResumeLayout(false);
            this.grbPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContents;
        private System.Windows.Forms.GroupBox grbUsername;
        private System.Windows.Forms.Label lblLoginToSYS;
        private System.Windows.Forms.GroupBox grbPassword;
        private System.Windows.Forms.Panel pnLogoGDU;
        private System.Windows.Forms.Panel pnSystem;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}

