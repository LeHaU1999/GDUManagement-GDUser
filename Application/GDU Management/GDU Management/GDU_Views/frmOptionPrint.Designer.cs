namespace GDU_Management.GDU_Views
{
    partial class frmOptionPrint
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
            this.btnInTheoSV = new System.Windows.Forms.Button();
            this.btnInTheoMH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInTheoSV
            // 
            this.btnInTheoSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInTheoSV.Location = new System.Drawing.Point(93, 26);
            this.btnInTheoSV.Name = "btnInTheoSV";
            this.btnInTheoSV.Size = new System.Drawing.Size(189, 50);
            this.btnInTheoSV.TabIndex = 0;
            this.btnInTheoSV.Text = "In theo sinh viên";
            this.btnInTheoSV.UseVisualStyleBackColor = true;
            this.btnInTheoSV.Click += new System.EventHandler(this.btnInTheoSV_Click);
            // 
            // btnInTheoMH
            // 
            this.btnInTheoMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInTheoMH.Location = new System.Drawing.Point(93, 82);
            this.btnInTheoMH.Name = "btnInTheoMH";
            this.btnInTheoMH.Size = new System.Drawing.Size(189, 50);
            this.btnInTheoMH.TabIndex = 0;
            this.btnInTheoMH.Text = "In theo môn học";
            this.btnInTheoMH.UseVisualStyleBackColor = true;
            this.btnInTheoMH.Click += new System.EventHandler(this.btnInTheoMH_Click);
            // 
            // frmOptionPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 153);
            this.Controls.Add(this.btnInTheoMH);
            this.Controls.Add(this.btnInTheoSV);
            this.Name = "frmOptionPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOptionPrint";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInTheoSV;
        private System.Windows.Forms.Button btnInTheoMH;
    }
}