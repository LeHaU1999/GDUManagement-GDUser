namespace GDU_Management
{
    partial class frmPhanCongCongViec
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
            this.pnPhanCongCongViec = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReturnGDU = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPhanCongCongViec.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPhanCongCongViec
            // 
            this.pnPhanCongCongViec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPhanCongCongViec.Controls.Add(this.label3);
            this.pnPhanCongCongViec.Controls.Add(this.lblReturnGDU);
            this.pnPhanCongCongViec.Controls.Add(this.label1);
            this.pnPhanCongCongViec.Location = new System.Drawing.Point(13, 13);
            this.pnPhanCongCongViec.Name = "pnPhanCongCongViec";
            this.pnPhanCongCongViec.Size = new System.Drawing.Size(741, 445);
            this.pnPhanCongCongViec.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Image = global::GDU_Management.Properties.Resources.images;
            this.label3.Location = new System.Drawing.Point(199, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 181);
            this.label3.TabIndex = 2;
            // 
            // lblReturnGDU
            // 
            this.lblReturnGDU.AutoSize = true;
            this.lblReturnGDU.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnGDU.Location = new System.Drawing.Point(213, 382);
            this.lblReturnGDU.Name = "lblReturnGDU";
            this.lblReturnGDU.Size = new System.Drawing.Size(253, 32);
            this.lblReturnGDU.TabIndex = 1;
            this.lblReturnGDU.Text = "Click here to return";
            this.lblReturnGDU.Click += new System.EventHandler(this.lblReturnGDU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Be Continued";
            // 
            // frmPhanCongCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 469);
            this.Controls.Add(this.pnPhanCongCongViec);
            this.Name = "frmPhanCongCongViec";
            this.pnPhanCongCongViec.ResumeLayout(false);
            this.pnPhanCongCongViec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPhanCongCongViec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReturnGDU;
        private System.Windows.Forms.Label label3;
    }
}