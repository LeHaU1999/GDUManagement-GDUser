namespace GDU_Management.GDU_Views
{
    partial class frmReport_GetAllDiemBySinhVien
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
            this.getAllDiemBySinhVien01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporting = new GDU_Management.Reporting();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboChonKhoaHoc = new System.Windows.Forms.ComboBox();
            this.cboChonNganh = new System.Windows.Forms.ComboBox();
            this.cboChonSinhVien = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboChonLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.get_AllDiemBySinhVien01TableAdapter = new GDU_Management.ReportingTableAdapters.Get_AllDiemBySinhVien01TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getAllDiemBySinhVien01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporting)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getAllDiemBySinhVien01BindingSource
            // 
            this.getAllDiemBySinhVien01BindingSource.DataMember = "Get_AllDiemBySinhVien01";
            this.getAllDiemBySinhVien01BindingSource.DataSource = this.reporting;
            // 
            // reporting
            // 
            this.reporting.DataSetName = "Reporting";
            this.reporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboChonKhoaHoc);
            this.panel1.Controls.Add(this.cboChonNganh);
            this.panel1.Controls.Add(this.cboChonSinhVien);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.cboChonLop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 758);
            this.panel1.TabIndex = 1;
            // 
            // cboChonKhoaHoc
            // 
            this.cboChonKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonKhoaHoc.FormattingEnabled = true;
            this.cboChonKhoaHoc.Location = new System.Drawing.Point(17, 134);
            this.cboChonKhoaHoc.Name = "cboChonKhoaHoc";
            this.cboChonKhoaHoc.Size = new System.Drawing.Size(251, 30);
            this.cboChonKhoaHoc.TabIndex = 8;
            this.cboChonKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cboChonKhoaHoc_SelectedIndexChanged);
            // 
            // cboChonNganh
            // 
            this.cboChonNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonNganh.FormattingEnabled = true;
            this.cboChonNganh.Location = new System.Drawing.Point(15, 54);
            this.cboChonNganh.Name = "cboChonNganh";
            this.cboChonNganh.Size = new System.Drawing.Size(253, 30);
            this.cboChonNganh.TabIndex = 7;
            this.cboChonNganh.SelectedIndexChanged += new System.EventHandler(this.cboChonNganh_SelectedIndexChanged);
            // 
            // cboChonSinhVien
            // 
            this.cboChonSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonSinhVien.FormattingEnabled = true;
            this.cboChonSinhVien.Location = new System.Drawing.Point(15, 297);
            this.cboChonSinhVien.Name = "cboChonSinhVien";
            this.cboChonSinhVien.Size = new System.Drawing.Size(253, 30);
            this.cboChonSinhVien.TabIndex = 6;
            this.cboChonSinhVien.SelectedIndexChanged += new System.EventHandler(this.cboChonSinhVien_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getAllDiemBySinhVien01BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GDU_Management.GDU_Views.Report_GetAllDiemBySinhVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(274, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1138, 758);
            this.reportViewer1.TabIndex = 5;
            // 
            // cboChonLop
            // 
            this.cboChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonLop.FormattingEnabled = true;
            this.cboChonLop.Location = new System.Drawing.Point(15, 216);
            this.cboChonLop.Name = "cboChonLop";
            this.cboChonLop.Size = new System.Drawing.Size(253, 30);
            this.cboChonLop.TabIndex = 2;
            this.cboChonLop.SelectedIndexChanged += new System.EventHandler(this.cboChonLop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn Sinh Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chọn Ngành:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chọn Khóa Học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Lớp:";
            // 
            // get_AllDiemBySinhVien01TableAdapter
            // 
            this.get_AllDiemBySinhVien01TableAdapter.ClearBeforeFill = true;
            // 
            // frmReport_GetAllDiemBySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1412, 758);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmReport_GetAllDiemBySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm sinh viên";
            this.Load += new System.EventHandler(this.frmReport_GetAllDiemBySinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getAllDiemBySinhVien01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporting)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboChonLop;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getAllDiemBySinhVien01BindingSource;
        private Reporting reporting;
        private ReportingTableAdapters.Get_AllDiemBySinhVien01TableAdapter get_AllDiemBySinhVien01TableAdapter;
        private System.Windows.Forms.ComboBox cboChonSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboChonNganh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboChonKhoaHoc;
        private System.Windows.Forms.Label label4;
    }
}