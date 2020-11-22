namespace GDU_Management.GDU_Views
{
    partial class frmReport_GetDanhSachSinhVien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboChonLop = new System.Windows.Forms.ComboBox();
            this.cboChonKhoaHoc = new System.Windows.Forms.ComboBox();
            this.cboChonNganh = new System.Windows.Forms.ComboBox();
            this.cboChonKhoa = new System.Windows.Forms.ComboBox();
            this.lblChonLop = new System.Windows.Forms.Label();
            this.lblChonKhoaHoc = new System.Windows.Forms.Label();
            this.lblChonNganh = new System.Windows.Forms.Label();
            this.lblChonKhoa = new System.Windows.Forms.Label();
            this.Get_SinhVienLopKhoaHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporting = new GDU_Management.Reporting();
            this.getSinhVienLopKhoaHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_SinhVienLopKhoaHocTableAdapter = new GDU_Management.ReportingTableAdapters.Get_SinhVienLopKhoaHocTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Get_SinhVienLopKhoaHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSinhVienLopKhoaHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getSinhVienLopKhoaHocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GDU_Management.GDU_Views.Report_GetDanhSachSinhVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(311, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1105, 718);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboChonLop);
            this.panel1.Controls.Add(this.cboChonKhoaHoc);
            this.panel1.Controls.Add(this.cboChonNganh);
            this.panel1.Controls.Add(this.cboChonKhoa);
            this.panel1.Controls.Add(this.lblChonLop);
            this.panel1.Controls.Add(this.lblChonKhoaHoc);
            this.panel1.Controls.Add(this.lblChonNganh);
            this.panel1.Controls.Add(this.lblChonKhoa);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1416, 724);
            this.panel1.TabIndex = 1;
            // 
            // cboChonLop
            // 
            this.cboChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonLop.FormattingEnabled = true;
            this.cboChonLop.Location = new System.Drawing.Point(18, 271);
            this.cboChonLop.Margin = new System.Windows.Forms.Padding(4);
            this.cboChonLop.Name = "cboChonLop";
            this.cboChonLop.Size = new System.Drawing.Size(286, 32);
            this.cboChonLop.TabIndex = 7;
            this.cboChonLop.SelectedIndexChanged += new System.EventHandler(this.cboChonLop_SelectedIndexChanged);
            // 
            // cboChonKhoaHoc
            // 
            this.cboChonKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonKhoaHoc.FormattingEnabled = true;
            this.cboChonKhoaHoc.Location = new System.Drawing.Point(18, 195);
            this.cboChonKhoaHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cboChonKhoaHoc.Name = "cboChonKhoaHoc";
            this.cboChonKhoaHoc.Size = new System.Drawing.Size(286, 32);
            this.cboChonKhoaHoc.TabIndex = 8;
            this.cboChonKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cboChonKhoaHoc_SelectedIndexChanged);
            // 
            // cboChonNganh
            // 
            this.cboChonNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonNganh.FormattingEnabled = true;
            this.cboChonNganh.Location = new System.Drawing.Point(18, 120);
            this.cboChonNganh.Margin = new System.Windows.Forms.Padding(4);
            this.cboChonNganh.Name = "cboChonNganh";
            this.cboChonNganh.Size = new System.Drawing.Size(286, 32);
            this.cboChonNganh.TabIndex = 9;
            this.cboChonNganh.SelectedIndexChanged += new System.EventHandler(this.cboChonNganh_SelectedIndexChanged);
            // 
            // cboChonKhoa
            // 
            this.cboChonKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonKhoa.FormattingEnabled = true;
            this.cboChonKhoa.Location = new System.Drawing.Point(18, 51);
            this.cboChonKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cboChonKhoa.Name = "cboChonKhoa";
            this.cboChonKhoa.Size = new System.Drawing.Size(286, 32);
            this.cboChonKhoa.TabIndex = 10;
            this.cboChonKhoa.SelectedIndexChanged += new System.EventHandler(this.cboChonKhoa_SelectedIndexChanged);
            // 
            // lblChonLop
            // 
            this.lblChonLop.AutoSize = true;
            this.lblChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonLop.Location = new System.Drawing.Point(13, 243);
            this.lblChonLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(104, 25);
            this.lblChonLop.TabIndex = 3;
            this.lblChonLop.Text = "Chọn Lớp:";
            // 
            // lblChonKhoaHoc
            // 
            this.lblChonKhoaHoc.AutoSize = true;
            this.lblChonKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonKhoaHoc.Location = new System.Drawing.Point(13, 166);
            this.lblChonKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChonKhoaHoc.Name = "lblChonKhoaHoc";
            this.lblChonKhoaHoc.Size = new System.Drawing.Size(118, 25);
            this.lblChonKhoaHoc.TabIndex = 4;
            this.lblChonKhoaHoc.Text = "Chọn Khóa:";
            // 
            // lblChonNganh
            // 
            this.lblChonNganh.AutoSize = true;
            this.lblChonNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonNganh.Location = new System.Drawing.Point(13, 94);
            this.lblChonNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChonNganh.Name = "lblChonNganh";
            this.lblChonNganh.Size = new System.Drawing.Size(129, 25);
            this.lblChonNganh.TabIndex = 5;
            this.lblChonNganh.Text = "Chọn Ngành:";
            // 
            // lblChonKhoa
            // 
            this.lblChonKhoa.AutoSize = true;
            this.lblChonKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonKhoa.Location = new System.Drawing.Point(13, 21);
            this.lblChonKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChonKhoa.Name = "lblChonKhoa";
            this.lblChonKhoa.Size = new System.Drawing.Size(118, 25);
            this.lblChonKhoa.TabIndex = 6;
            this.lblChonKhoa.Text = "Chọn Khoa:";
            // 
            // reporting
            // 
            this.reporting.DataSetName = "Reporting";
            this.reporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getSinhVienLopKhoaHocBindingSource
            // 
            this.getSinhVienLopKhoaHocBindingSource.DataMember = "Get_SinhVienLopKhoaHoc";
            this.getSinhVienLopKhoaHocBindingSource.DataSource = this.reporting;
            // 
            // get_SinhVienLopKhoaHocTableAdapter
            // 
            this.get_SinhVienLopKhoaHocTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport_GetDanhSachSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 724);
            this.Controls.Add(this.panel1);
            this.Name = "frmReport_GetDanhSachSinhVien";
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.frmReport_GetDanhSachSinhVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Get_SinhVienLopKhoaHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSinhVienLopKhoaHocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboChonLop;
        private System.Windows.Forms.ComboBox cboChonKhoaHoc;
        private System.Windows.Forms.ComboBox cboChonNganh;
        private System.Windows.Forms.ComboBox cboChonKhoa;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.Label lblChonKhoaHoc;
        private System.Windows.Forms.Label lblChonNganh;
        private System.Windows.Forms.Label lblChonKhoa;
        private System.Windows.Forms.BindingSource Get_SinhVienLopKhoaHocBindingSource;
        private System.Windows.Forms.BindingSource getSinhVienLopKhoaHocBindingSource;
        private Reporting reporting;
        private ReportingTableAdapters.Get_SinhVienLopKhoaHocTableAdapter get_SinhVienLopKhoaHocTableAdapter;
    }
}