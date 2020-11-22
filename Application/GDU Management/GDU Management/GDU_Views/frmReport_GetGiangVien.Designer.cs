namespace GDU_Management.GDU_Views
{
    partial class frmReport_GetGiangVien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboChonKhoa = new System.Windows.Forms.ComboBox();
            this.cboChonNganh = new System.Windows.Forms.ComboBox();
            this.reporting = new GDU_Management.Reporting();
            this.getGiangVienByNganhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_GiangVienByNganhTableAdapter = new GDU_Management.ReportingTableAdapters.Get_GiangVienByNganhTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reporting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGiangVienByNganhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.getGiangVienByNganhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GDU_Management.GDU_Views.Report_GetDanhSachGiangVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1312, 673);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboChonNganh);
            this.panel1.Controls.Add(this.cboChonKhoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 736);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn ngành:";
            // 
            // cboChonKhoa
            // 
            this.cboChonKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonKhoa.FormattingEnabled = true;
            this.cboChonKhoa.Location = new System.Drawing.Point(145, 17);
            this.cboChonKhoa.Name = "cboChonKhoa";
            this.cboChonKhoa.Size = new System.Drawing.Size(261, 30);
            this.cboChonKhoa.TabIndex = 2;
            this.cboChonKhoa.SelectedIndexChanged += new System.EventHandler(this.cboChonKhoa_SelectedIndexChanged);
            // 
            // cboChonNganh
            // 
            this.cboChonNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonNganh.FormattingEnabled = true;
            this.cboChonNganh.Location = new System.Drawing.Point(556, 17);
            this.cboChonNganh.Name = "cboChonNganh";
            this.cboChonNganh.Size = new System.Drawing.Size(275, 30);
            this.cboChonNganh.TabIndex = 3;
            this.cboChonNganh.SelectedIndexChanged += new System.EventHandler(this.cboChonNganh_SelectedIndexChanged);
            // 
            // reporting
            // 
            this.reporting.DataSetName = "Reporting";
            this.reporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getGiangVienByNganhBindingSource
            // 
            this.getGiangVienByNganhBindingSource.DataMember = "Get_GiangVienByNganh";
            this.getGiangVienByNganhBindingSource.DataSource = this.reporting;
            // 
            // get_GiangVienByNganhTableAdapter
            // 
            this.get_GiangVienByNganhTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport_GetGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 736);
            this.Controls.Add(this.panel1);
            this.Name = "frmReport_GetGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách giảng viên";
            this.Load += new System.EventHandler(this.frmReport_GetGiangVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reporting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGiangVienByNganhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource getGiangVienByNganhBindingSource;
        private Reporting reporting;
        private System.Windows.Forms.ComboBox cboChonNganh;
        private System.Windows.Forms.ComboBox cboChonKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ReportingTableAdapters.Get_GiangVienByNganhTableAdapter get_GiangVienByNganhTableAdapter;
    }
}