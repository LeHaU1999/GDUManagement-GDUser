namespace GDU_Management.GDU_Views
{
    partial class frmReport_GetDanhSachTKB
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
            this.cboChonHK = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboChonLop = new System.Windows.Forms.ComboBox();
            this.getThoiKhoaBieuByLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporting = new GDU_Management.Reporting();
            this.get_ThoiKhoaBieuByLopTableAdapter = new GDU_Management.ReportingTableAdapters.Get_ThoiKhoaBieuByLopTableAdapter();
            this.getThoiKhoaBieuByHocKiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_ThoiKhoaBieuByHocKiTableAdapter = new GDU_Management.ReportingTableAdapters.Get_ThoiKhoaBieuByHocKiTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getThoiKhoaBieuByLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getThoiKhoaBieuByHocKiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getThoiKhoaBieuByHocKiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GDU_Management.GDU_Views.Report_GetThoiKhoaBieu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 73);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1123, 577);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboChonHK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboChonLop);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 650);
            this.panel1.TabIndex = 1;
            // 
            // cboChonHK
            // 
            this.cboChonHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonHK.FormattingEnabled = true;
            this.cboChonHK.Location = new System.Drawing.Point(576, 17);
            this.cboChonHK.Name = "cboChonHK";
            this.cboChonHK.Size = new System.Drawing.Size(242, 30);
            this.cboChonHK.TabIndex = 3;
            this.cboChonHK.SelectedIndexChanged += new System.EventHandler(this.cboChonHK_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn học kì:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn lớp:";
            // 
            // cboChonLop
            // 
            this.cboChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonLop.FormattingEnabled = true;
            this.cboChonLop.Location = new System.Drawing.Point(137, 20);
            this.cboChonLop.Name = "cboChonLop";
            this.cboChonLop.Size = new System.Drawing.Size(234, 30);
            this.cboChonLop.TabIndex = 1;
            this.cboChonLop.SelectedIndexChanged += new System.EventHandler(this.cboChonLop_SelectedIndexChanged);
            // 
            // getThoiKhoaBieuByLopBindingSource
            // 
            this.getThoiKhoaBieuByLopBindingSource.DataMember = "Get_ThoiKhoaBieuByLop";
            this.getThoiKhoaBieuByLopBindingSource.DataSource = this.reporting;
            // 
            // reporting
            // 
            this.reporting.DataSetName = "Reporting";
            this.reporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_ThoiKhoaBieuByLopTableAdapter
            // 
            this.get_ThoiKhoaBieuByLopTableAdapter.ClearBeforeFill = true;
            // 
            // getThoiKhoaBieuByHocKiBindingSource
            // 
            this.getThoiKhoaBieuByHocKiBindingSource.DataMember = "Get_ThoiKhoaBieuByHocKi";
            this.getThoiKhoaBieuByHocKiBindingSource.DataSource = this.reporting;
            // 
            // get_ThoiKhoaBieuByHocKiTableAdapter
            // 
            this.get_ThoiKhoaBieuByHocKiTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport_GetDanhSachTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 650);
            this.Controls.Add(this.panel1);
            this.Name = "frmReport_GetDanhSachTKB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách thời khóa biểu";
            this.Load += new System.EventHandler(this.frmReport_GetDanhSachTKB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getThoiKhoaBieuByLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getThoiKhoaBieuByHocKiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getThoiKhoaBieuByLopBindingSource;
        private Reporting reporting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboChonLop;
        private ReportingTableAdapters.Get_ThoiKhoaBieuByLopTableAdapter get_ThoiKhoaBieuByLopTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboChonHK;
        private System.Windows.Forms.BindingSource getThoiKhoaBieuByHocKiBindingSource;
        private ReportingTableAdapters.Get_ThoiKhoaBieuByHocKiTableAdapter get_ThoiKhoaBieuByHocKiTableAdapter;
    }
}