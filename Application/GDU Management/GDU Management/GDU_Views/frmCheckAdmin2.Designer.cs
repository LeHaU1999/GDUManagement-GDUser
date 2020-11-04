namespace GDU_Management
{
    partial class frmCheckAdmin2
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
            this.pnCheckAdmin2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTiepTuc2 = new System.Windows.Forms.Button();
            this.txtKetQua2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnCheckAdmin2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCheckAdmin2
            // 
            this.pnCheckAdmin2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnCheckAdmin2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCheckAdmin2.Controls.Add(this.btnExit);
            this.pnCheckAdmin2.Controls.Add(this.btnTiepTuc2);
            this.pnCheckAdmin2.Controls.Add(this.txtKetQua2);
            this.pnCheckAdmin2.Controls.Add(this.label3);
            this.pnCheckAdmin2.Controls.Add(this.label2);
            this.pnCheckAdmin2.Controls.Add(this.label1);
            this.pnCheckAdmin2.Location = new System.Drawing.Point(13, 13);
            this.pnCheckAdmin2.Name = "pnCheckAdmin2";
            this.pnCheckAdmin2.Size = new System.Drawing.Size(1025, 494);
            this.pnCheckAdmin2.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(851, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 33);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTiepTuc2
            // 
            this.btnTiepTuc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTiepTuc2.Location = new System.Drawing.Point(682, 440);
            this.btnTiepTuc2.Name = "btnTiepTuc2";
            this.btnTiepTuc2.Size = new System.Drawing.Size(126, 34);
            this.btnTiepTuc2.TabIndex = 9;
            this.btnTiepTuc2.Text = "Tiếp Tục";
            this.btnTiepTuc2.UseVisualStyleBackColor = true;
            this.btnTiepTuc2.Click += new System.EventHandler(this.btnTiepTuc2_Click);
            // 
            // txtKetQua2
            // 
            this.txtKetQua2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua2.Location = new System.Drawing.Point(522, 444);
            this.txtKetQua2.Name = "txtKetQua2";
            this.txtKetQua2.Size = new System.Drawing.Size(154, 30);
            this.txtKetQua2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập Đáp án để tiếp tục:";
            // 
            // label2
            // 
            this.label2.Image = global::GDU_Management.Properties.Resources.img_check_admin_2;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(937, 374);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bạn Có Phải Admin Không...???";
            // 
            // frmCheckAdmin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1050, 521);
            this.Controls.Add(this.pnCheckAdmin2);
            this.Name = "frmCheckAdmin2";
            this.pnCheckAdmin2.ResumeLayout(false);
            this.pnCheckAdmin2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCheckAdmin2;
        private System.Windows.Forms.Button btnTiepTuc2;
        private System.Windows.Forms.TextBox txtKetQua2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}