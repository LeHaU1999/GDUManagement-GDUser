namespace GDU_Management
{
    partial class frmCheckAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckAdmin));
            this.pnVerificationCode = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbCode = new System.Windows.Forms.GroupBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnGoOnForm = new System.Windows.Forms.Button();
            this.txtVerificationCode = new System.Windows.Forms.TextBox();
            this.lblGuiLaiMaXacNhan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImg = new System.Windows.Forms.Label();
            this.lblCloseCheckAcc = new System.Windows.Forms.Label();
            this.lblThongTinAdmin = new System.Windows.Forms.Label();
            this.pnVerificationCode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnVerificationCode
            // 
            this.pnVerificationCode.BackColor = System.Drawing.Color.White;
            this.pnVerificationCode.Controls.Add(this.panel1);
            this.pnVerificationCode.Controls.Add(this.lblImg);
            this.pnVerificationCode.Controls.Add(this.lblCloseCheckAcc);
            this.pnVerificationCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnVerificationCode.Location = new System.Drawing.Point(13, 13);
            this.pnVerificationCode.Name = "pnVerificationCode";
            this.pnVerificationCode.Size = new System.Drawing.Size(577, 249);
            this.pnVerificationCode.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblThongTinAdmin);
            this.panel1.Controls.Add(this.grbCode);
            this.panel1.Controls.Add(this.lblGuiLaiMaXacNhan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(158, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 245);
            this.panel1.TabIndex = 4;
            // 
            // grbCode
            // 
            this.grbCode.Controls.Add(this.lblNote);
            this.grbCode.Controls.Add(this.btnGoOnForm);
            this.grbCode.Controls.Add(this.txtVerificationCode);
            this.grbCode.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCode.Location = new System.Drawing.Point(20, 132);
            this.grbCode.Name = "grbCode";
            this.grbCode.Size = new System.Drawing.Size(349, 109);
            this.grbCode.TabIndex = 6;
            this.grbCode.TabStop = false;
            this.grbCode.Text = "Mã Xác Nhận";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(6, 34);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(165, 13);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "Nhập mã xác thực vào ô bên dưới";
            // 
            // btnGoOnForm
            // 
            this.btnGoOnForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoOnForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoOnForm.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGoOnForm.Location = new System.Drawing.Point(213, 54);
            this.btnGoOnForm.Name = "btnGoOnForm";
            this.btnGoOnForm.Size = new System.Drawing.Size(130, 38);
            this.btnGoOnForm.TabIndex = 1;
            this.btnGoOnForm.Text = "GO";
            this.btnGoOnForm.UseVisualStyleBackColor = true;
            this.btnGoOnForm.Click += new System.EventHandler(this.btnGoOnForm_Click);
            this.btnGoOnForm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGoOnForm_MouseClick);
            this.btnGoOnForm.MouseLeave += new System.EventHandler(this.btnGoOnForm_MouseLeave);
            this.btnGoOnForm.MouseHover += new System.EventHandler(this.btnGoOnForm_MouseHover);
            // 
            // txtVerificationCode
            // 
            this.txtVerificationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerificationCode.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtVerificationCode.Location = new System.Drawing.Point(6, 54);
            this.txtVerificationCode.Name = "txtVerificationCode";
            this.txtVerificationCode.Size = new System.Drawing.Size(201, 38);
            this.txtVerificationCode.TabIndex = 0;
            this.txtVerificationCode.TextChanged += new System.EventHandler(this.txtVerificationCode_TextChanged);
            // 
            // lblGuiLaiMaXacNhan
            // 
            this.lblGuiLaiMaXacNhan.AutoSize = true;
            this.lblGuiLaiMaXacNhan.Location = new System.Drawing.Point(28, 112);
            this.lblGuiLaiMaXacNhan.Name = "lblGuiLaiMaXacNhan";
            this.lblGuiLaiMaXacNhan.Size = new System.Drawing.Size(162, 17);
            this.lblGuiLaiMaXacNhan.TabIndex = 5;
            this.lblGuiLaiMaXacNhan.Text = "=> Gửi Lại Mã Xác Nhận";
            this.lblGuiLaiMaXacNhan.Click += new System.EventHandler(this.lblGuiLaiMaXacNhan_Click);
            this.lblGuiLaiMaXacNhan.MouseLeave += new System.EventHandler(this.lblGuiLaiMatKhau_MouseLeave);
            this.lblGuiLaiMaXacNhan.MouseHover += new System.EventHandler(this.lblGuiLaiMatKhau_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "*   Một mã xác nhận vữa được gữi đến mail của bạn. \r\n**  Nhập mã xác nhận để tiếp" +
    " tục\r\n ";
            // 
            // lblImg
            // 
            this.lblImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblImg.Image = global::GDU_Management.Properties.Resources.logo_03_03;
            this.lblImg.Location = new System.Drawing.Point(-2, 50);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(154, 140);
            this.lblImg.TabIndex = 3;
            // 
            // lblCloseCheckAcc
            // 
            this.lblCloseCheckAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCloseCheckAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCloseCheckAcc.Image = ((System.Drawing.Image)(resources.GetObject("lblCloseCheckAcc.Image")));
            this.lblCloseCheckAcc.Location = new System.Drawing.Point(537, -4);
            this.lblCloseCheckAcc.Name = "lblCloseCheckAcc";
            this.lblCloseCheckAcc.Size = new System.Drawing.Size(40, 40);
            this.lblCloseCheckAcc.TabIndex = 2;
            this.lblCloseCheckAcc.Click += new System.EventHandler(this.lblCloseCheckAcc_Click);
            // 
            // lblThongTinAdmin
            // 
            this.lblThongTinAdmin.Location = new System.Drawing.Point(4, 0);
            this.lblThongTinAdmin.Name = "lblThongTinAdmin";
            this.lblThongTinAdmin.Size = new System.Drawing.Size(361, 46);
            this.lblThongTinAdmin.TabIndex = 7;
            this.lblThongTinAdmin.Text = "??? - ???";
            this.lblThongTinAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCheckAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(602, 274);
            this.Controls.Add(this.pnVerificationCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCheckAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCheckAdmin_Load);
            this.pnVerificationCode.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbCode.ResumeLayout(false);
            this.grbCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnVerificationCode;
        private System.Windows.Forms.Label lblCloseCheckAcc;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGuiLaiMaXacNhan;
        private System.Windows.Forms.GroupBox grbCode;
        private System.Windows.Forms.TextBox txtVerificationCode;
        private System.Windows.Forms.Button btnGoOnForm;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblThongTinAdmin;
    }
}