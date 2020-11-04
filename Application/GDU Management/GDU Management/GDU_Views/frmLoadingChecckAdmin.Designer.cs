namespace GDU_Management.GDU_Views
{
    partial class frmLoadingChecckAdmin
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
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.pnLoading = new System.Windows.Forms.Panel();
            this.lblGitLoading = new System.Windows.Forms.Label();
            this.pnLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 1000;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // pnLoading
            // 
            this.pnLoading.BackColor = System.Drawing.Color.White;
            this.pnLoading.Controls.Add(this.lblGitLoading);
            this.pnLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnLoading.Location = new System.Drawing.Point(13, 13);
            this.pnLoading.Name = "pnLoading";
            this.pnLoading.Size = new System.Drawing.Size(577, 249);
            this.pnLoading.TabIndex = 1;
            // 
            // lblGitLoading
            // 
            this.lblGitLoading.Image = global::GDU_Management.Properties.Resources.gif_home_loading_100x100;
            this.lblGitLoading.Location = new System.Drawing.Point(4, 0);
            this.lblGitLoading.Name = "lblGitLoading";
            this.lblGitLoading.Size = new System.Drawing.Size(570, 249);
            this.lblGitLoading.TabIndex = 3;
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(602, 274);
            this.Controls.Add(this.pnLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoading";
            this.Load += new System.EventHandler(this.frmLoading_Load);
            this.pnLoading.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Panel pnLoading;
        private System.Windows.Forms.Label lblGitLoading;
    }
}