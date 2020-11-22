namespace GDU_Management.GDU_Views
{
    partial class frmReport_GetDanhSachDiemSinhVien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reporting = new GDU_Management.Reporting();
            this.getDiemSinhVienByMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_DiemSinhVienByMonHocTableAdapter = new GDU_Management.ReportingTableAdapters.Get_DiemSinhVienByMonHocTableAdapter();
            this.pnThongTinLop = new System.Windows.Forms.Panel();
            this.cboChonMonHoc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboChonLop = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboChonKhoaHoc = new System.Windows.Forms.ComboBox();
            this.cboChonNganh = new System.Windows.Forms.ComboBox();
            this.cboChonKhoa = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reporting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDiemSinhVienByMonHocBindingSource)).BeginInit();
            this.pnThongTinLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.getDiemSinhVienByMonHocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GDU_Management.GDU_Views.Report_GetDanhSachDiemSinhVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 217);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1274, 527);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnThongTinLop);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 744);
            this.panel1.TabIndex = 1;
            // 
            // reporting
            // 
            this.reporting.DataSetName = "Reporting";
            this.reporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getDiemSinhVienByMonHocBindingSource
            // 
            this.getDiemSinhVienByMonHocBindingSource.DataMember = "Get_DiemSinhVienByMonHoc";
            this.getDiemSinhVienByMonHocBindingSource.DataSource = this.reporting;
            // 
            // get_DiemSinhVienByMonHocTableAdapter
            // 
            this.get_DiemSinhVienByMonHocTableAdapter.ClearBeforeFill = true;
            // 
            // pnThongTinLop
            // 
            this.pnThongTinLop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnThongTinLop.Controls.Add(this.cboChonMonHoc);
            this.pnThongTinLop.Controls.Add(this.label11);
            this.pnThongTinLop.Controls.Add(this.cboChonLop);
            this.pnThongTinLop.Controls.Add(this.label8);
            this.pnThongTinLop.Controls.Add(this.cboChonKhoaHoc);
            this.pnThongTinLop.Controls.Add(this.cboChonNganh);
            this.pnThongTinLop.Controls.Add(this.cboChonKhoa);
            this.pnThongTinLop.Controls.Add(this.label20);
            this.pnThongTinLop.Controls.Add(this.label5);
            this.pnThongTinLop.Controls.Add(this.label6);
            this.pnThongTinLop.Location = new System.Drawing.Point(12, 11);
            this.pnThongTinLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnThongTinLop.Name = "pnThongTinLop";
            this.pnThongTinLop.Size = new System.Drawing.Size(663, 201);
            this.pnThongTinLop.TabIndex = 2;
            // 
            // cboChonMonHoc
            // 
            this.cboChonMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonMonHoc.FormattingEnabled = true;
            this.cboChonMonHoc.Location = new System.Drawing.Point(85, 146);
            this.cboChonMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboChonMonHoc.Name = "cboChonMonHoc";
            this.cboChonMonHoc.Size = new System.Drawing.Size(563, 33);
            this.cboChonMonHoc.TabIndex = 17;
            this.cboChonMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboChonMonHoc_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Môn:";
            // 
            // cboChonLop
            // 
            this.cboChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonLop.FormattingEnabled = true;
            this.cboChonLop.Location = new System.Drawing.Point(457, 103);
            this.cboChonLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboChonLop.Name = "cboChonLop";
            this.cboChonLop.Size = new System.Drawing.Size(192, 33);
            this.cboChonLop.TabIndex = 13;
            this.cboChonLop.Text = "Chọn Lớp";
            this.cboChonLop.SelectedIndexChanged += new System.EventHandler(this.cboChonLop_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(393, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Lớp:";
            // 
            // cboChonKhoaHoc
            // 
            this.cboChonKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonKhoaHoc.FormattingEnabled = true;
            this.cboChonKhoaHoc.Location = new System.Drawing.Point(85, 103);
            this.cboChonKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboChonKhoaHoc.Name = "cboChonKhoaHoc";
            this.cboChonKhoaHoc.Size = new System.Drawing.Size(201, 33);
            this.cboChonKhoaHoc.TabIndex = 11;
            this.cboChonKhoaHoc.Text = "Chọn Khóa";
            this.cboChonKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cboChonKhoaHoc_SelectedIndexChanged);
            // 
            // cboChonNganh
            // 
            this.cboChonNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonNganh.FormattingEnabled = true;
            this.cboChonNganh.Location = new System.Drawing.Point(85, 57);
            this.cboChonNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboChonNganh.Name = "cboChonNganh";
            this.cboChonNganh.Size = new System.Drawing.Size(563, 33);
            this.cboChonNganh.TabIndex = 10;
            this.cboChonNganh.SelectedIndexChanged += new System.EventHandler(this.cboChonNganh_SelectedIndexChanged);
            // 
            // cboChonKhoa
            // 
            this.cboChonKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonKhoa.FormattingEnabled = true;
            this.cboChonKhoa.Location = new System.Drawing.Point(85, 9);
            this.cboChonKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboChonKhoa.Name = "cboChonKhoa";
            this.cboChonKhoa.Size = new System.Drawing.Size(563, 33);
            this.cboChonKhoa.TabIndex = 9;
            this.cboChonKhoa.SelectedIndexChanged += new System.EventHandler(this.cboChonKhoa_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(9, 107);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 25);
            this.label20.TabIndex = 8;
            this.label20.Text = "Khóa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngành:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Khoa:";
            // 
            // frmReport_GetDanhSachDiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 744);
            this.Controls.Add(this.panel1);
            this.Name = "frmReport_GetDanhSachDiemSinhVien";
            this.Text = "Danh Sách điểm";
            this.Load += new System.EventHandler(this.frmReport_GetDanhSachDiemSinhVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reporting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDiemSinhVienByMonHocBindingSource)).EndInit();
            this.pnThongTinLop.ResumeLayout(false);
            this.pnThongTinLop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getDiemSinhVienByMonHocBindingSource;
        private Reporting reporting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnThongTinLop;
        private System.Windows.Forms.ComboBox cboChonMonHoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboChonLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboChonKhoaHoc;
        private System.Windows.Forms.ComboBox cboChonNganh;
        private System.Windows.Forms.ComboBox cboChonKhoa;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ReportingTableAdapters.Get_DiemSinhVienByMonHocTableAdapter get_DiemSinhVienByMonHocTableAdapter;
    }
}