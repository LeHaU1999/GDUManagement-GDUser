namespace GDU_Management.GDU_Views
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGiaiMaDES = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tnGiaiMa = new System.Windows.Forms.Button();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.txtMaHoaDES = new System.Windows.Forms.TextBox();
            this.txtMaHoaMD5 = new System.Windows.Forms.TextBox();
            this.txtChuoiNhapVao = new System.Windows.Forms.TextBox();
            this.lblBanTinDuocGiaiMa = new System.Windows.Forms.Label();
            this.lblBanTinDuocMaHoa = new System.Windows.Forms.Label();
            this.lblBantinro = new System.Windows.Forms.Label();
            this.txtMD5DES = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(323, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(299, 335);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(4, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "chọn ảnh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(323, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "convert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(4, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(313, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 396);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtMD5DES);
            this.panel2.Controls.Add(this.txtGiaiMaDES);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tnGiaiMa);
            this.panel2.Controls.Add(this.btnMaHoa);
            this.panel2.Controls.Add(this.txtMaHoaDES);
            this.panel2.Controls.Add(this.txtMaHoaMD5);
            this.panel2.Controls.Add(this.txtChuoiNhapVao);
            this.panel2.Controls.Add(this.lblBanTinDuocGiaiMa);
            this.panel2.Controls.Add(this.lblBanTinDuocMaHoa);
            this.panel2.Controls.Add(this.lblBantinro);
            this.panel2.Location = new System.Drawing.Point(647, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 393);
            this.panel2.TabIndex = 6;
            // 
            // txtGiaiMaDES
            // 
            this.txtGiaiMaDES.Location = new System.Drawing.Point(206, 92);
            this.txtGiaiMaDES.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaiMaDES.Name = "txtGiaiMaDES";
            this.txtGiaiMaDES.Size = new System.Drawing.Size(273, 22);
            this.txtGiaiMaDES.TabIndex = 19;
            this.txtGiaiMaDES.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Giai ma DES";
            // 
            // tnGiaiMa
            // 
            this.tnGiaiMa.Location = new System.Drawing.Point(382, 150);
            this.tnGiaiMa.Name = "tnGiaiMa";
            this.tnGiaiMa.Size = new System.Drawing.Size(97, 32);
            this.tnGiaiMa.TabIndex = 17;
            this.tnGiaiMa.Text = "giai ma";
            this.tnGiaiMa.UseVisualStyleBackColor = true;
            this.tnGiaiMa.Click += new System.EventHandler(this.tnGiaiMa_Click);
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Location = new System.Drawing.Point(206, 150);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(95, 32);
            this.btnMaHoa.TabIndex = 16;
            this.btnMaHoa.Text = "ma hoa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // txtMaHoaDES
            // 
            this.txtMaHoaDES.Location = new System.Drawing.Point(206, 62);
            this.txtMaHoaDES.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHoaDES.Name = "txtMaHoaDES";
            this.txtMaHoaDES.Size = new System.Drawing.Size(273, 22);
            this.txtMaHoaDES.TabIndex = 15;
            this.txtMaHoaDES.Text = " ";
            // 
            // txtMaHoaMD5
            // 
            this.txtMaHoaMD5.Location = new System.Drawing.Point(206, 32);
            this.txtMaHoaMD5.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHoaMD5.Name = "txtMaHoaMD5";
            this.txtMaHoaMD5.Size = new System.Drawing.Size(273, 22);
            this.txtMaHoaMD5.TabIndex = 14;
            // 
            // txtChuoiNhapVao
            // 
            this.txtChuoiNhapVao.Location = new System.Drawing.Point(206, 2);
            this.txtChuoiNhapVao.Margin = new System.Windows.Forms.Padding(4);
            this.txtChuoiNhapVao.Name = "txtChuoiNhapVao";
            this.txtChuoiNhapVao.Size = new System.Drawing.Size(273, 22);
            this.txtChuoiNhapVao.TabIndex = 13;
            // 
            // lblBanTinDuocGiaiMa
            // 
            this.lblBanTinDuocGiaiMa.AutoSize = true;
            this.lblBanTinDuocGiaiMa.Location = new System.Drawing.Point(13, 37);
            this.lblBanTinDuocGiaiMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBanTinDuocGiaiMa.Name = "lblBanTinDuocGiaiMa";
            this.lblBanTinDuocGiaiMa.Size = new System.Drawing.Size(37, 17);
            this.lblBanTinDuocGiaiMa.TabIndex = 12;
            this.lblBanTinDuocGiaiMa.Text = "MD5";
            // 
            // lblBanTinDuocMaHoa
            // 
            this.lblBanTinDuocMaHoa.AutoSize = true;
            this.lblBanTinDuocMaHoa.Location = new System.Drawing.Point(14, 67);
            this.lblBanTinDuocMaHoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBanTinDuocMaHoa.Name = "lblBanTinDuocMaHoa";
            this.lblBanTinDuocMaHoa.Size = new System.Drawing.Size(36, 17);
            this.lblBanTinDuocMaHoa.TabIndex = 11;
            this.lblBanTinDuocMaHoa.Text = "DES";
            // 
            // lblBantinro
            // 
            this.lblBantinro.AutoSize = true;
            this.lblBantinro.Location = new System.Drawing.Point(13, 2);
            this.lblBantinro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBantinro.Name = "lblBantinro";
            this.lblBantinro.Size = new System.Drawing.Size(35, 17);
            this.lblBantinro.TabIndex = 10;
            this.lblBantinro.Text = "Text";
            // 
            // txtMD5DES
            // 
            this.txtMD5DES.Location = new System.Drawing.Point(206, 241);
            this.txtMD5DES.Name = "txtMD5DES";
            this.txtMD5DES.Size = new System.Drawing.Size(273, 22);
            this.txtMD5DES.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 430);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaHoaDES;
        private System.Windows.Forms.TextBox txtMaHoaMD5;
        private System.Windows.Forms.TextBox txtChuoiNhapVao;
        private System.Windows.Forms.Label lblBanTinDuocGiaiMa;
        private System.Windows.Forms.Label lblBanTinDuocMaHoa;
        private System.Windows.Forms.Label lblBantinro;
        private System.Windows.Forms.Button tnGiaiMa;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.TextBox txtGiaiMaDES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMD5DES;
    }
}