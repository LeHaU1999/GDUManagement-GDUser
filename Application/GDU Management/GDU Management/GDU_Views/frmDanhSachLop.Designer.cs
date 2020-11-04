namespace GDU_Management
{
    partial class frmDanhSachLop
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
            this.pnDanhSachLop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTimKiemLop = new System.Windows.Forms.TextBox();
            this.pnControl = new System.Windows.Forms.Panel();
            this.btnDeleteAllLop = new System.Windows.Forms.Button();
            this.btnExitDSLop = new System.Windows.Forms.Button();
            this.btnDeleteLop = new System.Windows.Forms.Button();
            this.btnNewLop = new System.Windows.Forms.Button();
            this.btnUpdateLop = new System.Windows.Forms.Button();
            this.btnSaveLop = new System.Windows.Forms.Button();
            this.dgvDanhSachLop = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNganhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoaHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nganhHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbDanhSachLop = new System.Windows.Forms.GroupBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblTenNganh = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMaKhoasHoc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportDSLop = new System.Windows.Forms.Button();
            this.pnDanhSachLop.SuspendLayout();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            this.grbDanhSachLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDanhSachLop
            // 
            this.pnDanhSachLop.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnDanhSachLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDanhSachLop.Controls.Add(this.label4);
            this.pnDanhSachLop.Controls.Add(this.label11);
            this.pnDanhSachLop.Controls.Add(this.txtTimKiemLop);
            this.pnDanhSachLop.Controls.Add(this.pnControl);
            this.pnDanhSachLop.Controls.Add(this.dgvDanhSachLop);
            this.pnDanhSachLop.Controls.Add(this.grbDanhSachLop);
            this.pnDanhSachLop.Controls.Add(this.btnExportDSLop);
            this.pnDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDanhSachLop.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pnDanhSachLop.Location = new System.Drawing.Point(4, 12);
            this.pnDanhSachLop.Name = "pnDanhSachLop";
            this.pnDanhSachLop.Size = new System.Drawing.Size(825, 448);
            this.pnDanhSachLop.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Image = global::GDU_Management.Properties.Resources.logo_03_03;
            this.label4.Location = new System.Drawing.Point(479, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 115);
            this.label4.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.Image = global::GDU_Management.Properties.Resources.icon_gdumanagement_ps_13;
            this.label11.Location = new System.Drawing.Point(644, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 114);
            this.label11.TabIndex = 22;
            // 
            // txtTimKiemLop
            // 
            this.txtTimKiemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemLop.Location = new System.Drawing.Point(14, 176);
            this.txtTimKiemLop.Name = "txtTimKiemLop";
            this.txtTimKiemLop.Size = new System.Drawing.Size(312, 27);
            this.txtTimKiemLop.TabIndex = 9;
            this.txtTimKiemLop.Text = "Nhập Thông Tin Để Tìm Kiếm";
            this.txtTimKiemLop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiemLop_MouseClick);
            this.txtTimKiemLop.TextChanged += new System.EventHandler(this.txtTimKiemLop_TextChanged);
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.btnDeleteAllLop);
            this.pnControl.Controls.Add(this.btnExitDSLop);
            this.pnControl.Controls.Add(this.btnDeleteLop);
            this.pnControl.Controls.Add(this.btnNewLop);
            this.pnControl.Controls.Add(this.btnUpdateLop);
            this.pnControl.Controls.Add(this.btnSaveLop);
            this.pnControl.Location = new System.Drawing.Point(14, 385);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(802, 55);
            this.pnControl.TabIndex = 7;
            // 
            // btnDeleteAllLop
            // 
            this.btnDeleteAllLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteAllLop.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllLop.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeleteAllLop.Location = new System.Drawing.Point(541, 3);
            this.btnDeleteAllLop.Name = "btnDeleteAllLop";
            this.btnDeleteAllLop.Size = new System.Drawing.Size(150, 45);
            this.btnDeleteAllLop.TabIndex = 24;
            this.btnDeleteAllLop.Text = "Delete All";
            this.btnDeleteAllLop.UseVisualStyleBackColor = false;
            this.btnDeleteAllLop.Click += new System.EventHandler(this.btnDeleteAllLop_Click);
            // 
            // btnExitDSLop
            // 
            this.btnExitDSLop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExitDSLop.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExitDSLop.Image = global::GDU_Management.Properties.Resources.icons_exit_38;
            this.btnExitDSLop.Location = new System.Drawing.Point(695, 3);
            this.btnExitDSLop.Name = "btnExitDSLop";
            this.btnExitDSLop.Size = new System.Drawing.Size(104, 45);
            this.btnExitDSLop.TabIndex = 7;
            this.btnExitDSLop.UseVisualStyleBackColor = false;
            this.btnExitDSLop.Click += new System.EventHandler(this.btnExitDSLop_Click);
            // 
            // btnDeleteLop
            // 
            this.btnDeleteLop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteLop.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeleteLop.Image = global::GDU_Management.Properties.Resources.icons_delete_3;
            this.btnDeleteLop.Location = new System.Drawing.Point(371, 3);
            this.btnDeleteLop.Name = "btnDeleteLop";
            this.btnDeleteLop.Size = new System.Drawing.Size(120, 45);
            this.btnDeleteLop.TabIndex = 6;
            this.btnDeleteLop.UseVisualStyleBackColor = false;
            this.btnDeleteLop.Click += new System.EventHandler(this.btnDeleteLop_Click);
            // 
            // btnNewLop
            // 
            this.btnNewLop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNewLop.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNewLop.Image = global::GDU_Management.Properties.Resources.icon_lop_2;
            this.btnNewLop.Location = new System.Drawing.Point(3, 3);
            this.btnNewLop.Name = "btnNewLop";
            this.btnNewLop.Size = new System.Drawing.Size(110, 45);
            this.btnNewLop.TabIndex = 3;
            this.btnNewLop.UseVisualStyleBackColor = false;
            this.btnNewLop.Click += new System.EventHandler(this.btnNewLop_Click);
            // 
            // btnUpdateLop
            // 
            this.btnUpdateLop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdateLop.Image = global::GDU_Management.Properties.Resources.icons_update_30;
            this.btnUpdateLop.Location = new System.Drawing.Point(245, 3);
            this.btnUpdateLop.Name = "btnUpdateLop";
            this.btnUpdateLop.Size = new System.Drawing.Size(120, 45);
            this.btnUpdateLop.TabIndex = 5;
            this.btnUpdateLop.UseVisualStyleBackColor = false;
            this.btnUpdateLop.Click += new System.EventHandler(this.btnUpdateLop_Click);
            // 
            // btnSaveLop
            // 
            this.btnSaveLop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSaveLop.Image = global::GDU_Management.Properties.Resources.icons_save_2;
            this.btnSaveLop.Location = new System.Drawing.Point(119, 3);
            this.btnSaveLop.Name = "btnSaveLop";
            this.btnSaveLop.Size = new System.Drawing.Size(120, 45);
            this.btnSaveLop.TabIndex = 4;
            this.btnSaveLop.UseVisualStyleBackColor = false;
            this.btnSaveLop.Click += new System.EventHandler(this.btnSaveLop_Click);
            // 
            // dgvDanhSachLop
            // 
            this.dgvDanhSachLop.AllowUserToAddRows = false;
            this.dgvDanhSachLop.AllowUserToDeleteRows = false;
            this.dgvDanhSachLop.AutoGenerateColumns = false;
            this.dgvDanhSachLop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maLopDataGridViewTextBoxColumn,
            this.tenLopDataGridViewTextBoxColumn,
            this.maNganhDataGridViewTextBoxColumn,
            this.maKhoaHocDataGridViewTextBoxColumn,
            this.nganhHocDataGridViewTextBoxColumn});
            this.dgvDanhSachLop.DataSource = this.lopBindingSource;
            this.dgvDanhSachLop.GridColor = System.Drawing.Color.Magenta;
            this.dgvDanhSachLop.Location = new System.Drawing.Point(14, 209);
            this.dgvDanhSachLop.Name = "dgvDanhSachLop";
            this.dgvDanhSachLop.ReadOnly = true;
            this.dgvDanhSachLop.RowHeadersWidth = 5;
            this.dgvDanhSachLop.RowTemplate.Height = 24;
            this.dgvDanhSachLop.Size = new System.Drawing.Size(802, 170);
            this.dgvDanhSachLop.TabIndex = 1;
            this.dgvDanhSachLop.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhSachLop_CellMouseClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 90;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "Mã Lớp";
            this.maLopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            this.maLopDataGridViewTextBoxColumn.ReadOnly = true;
            this.maLopDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenLopDataGridViewTextBoxColumn
            // 
            this.tenLopDataGridViewTextBoxColumn.DataPropertyName = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.HeaderText = "Tên Lớp";
            this.tenLopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLopDataGridViewTextBoxColumn.Name = "tenLopDataGridViewTextBoxColumn";
            this.tenLopDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenLopDataGridViewTextBoxColumn.Width = 200;
            // 
            // maNganhDataGridViewTextBoxColumn
            // 
            this.maNganhDataGridViewTextBoxColumn.DataPropertyName = "MaNganh";
            this.maNganhDataGridViewTextBoxColumn.HeaderText = "MaNganh";
            this.maNganhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNganhDataGridViewTextBoxColumn.Name = "maNganhDataGridViewTextBoxColumn";
            this.maNganhDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNganhDataGridViewTextBoxColumn.Visible = false;
            this.maNganhDataGridViewTextBoxColumn.Width = 125;
            // 
            // maKhoaHocDataGridViewTextBoxColumn
            // 
            this.maKhoaHocDataGridViewTextBoxColumn.DataPropertyName = "MaKhoaHoc";
            this.maKhoaHocDataGridViewTextBoxColumn.HeaderText = "MaKhoaHoc";
            this.maKhoaHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKhoaHocDataGridViewTextBoxColumn.Name = "maKhoaHocDataGridViewTextBoxColumn";
            this.maKhoaHocDataGridViewTextBoxColumn.ReadOnly = true;
            this.maKhoaHocDataGridViewTextBoxColumn.Visible = false;
            this.maKhoaHocDataGridViewTextBoxColumn.Width = 125;
            // 
            // nganhHocDataGridViewTextBoxColumn
            // 
            this.nganhHocDataGridViewTextBoxColumn.DataPropertyName = "NganhHoc";
            this.nganhHocDataGridViewTextBoxColumn.HeaderText = "NganhHoc";
            this.nganhHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nganhHocDataGridViewTextBoxColumn.Name = "nganhHocDataGridViewTextBoxColumn";
            this.nganhHocDataGridViewTextBoxColumn.ReadOnly = true;
            this.nganhHocDataGridViewTextBoxColumn.Visible = false;
            this.nganhHocDataGridViewTextBoxColumn.Width = 125;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataSource = typeof(GDU_Management.Model.Lop);
            // 
            // grbDanhSachLop
            // 
            this.grbDanhSachLop.Controls.Add(this.lblMaLop);
            this.grbDanhSachLop.Controls.Add(this.lblTenNganh);
            this.grbDanhSachLop.Controls.Add(this.label8);
            this.grbDanhSachLop.Controls.Add(this.lblMaKhoasHoc);
            this.grbDanhSachLop.Controls.Add(this.label5);
            this.grbDanhSachLop.Controls.Add(this.txtTenLop);
            this.grbDanhSachLop.Controls.Add(this.label2);
            this.grbDanhSachLop.Controls.Add(this.label1);
            this.grbDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachLop.Location = new System.Drawing.Point(14, 4);
            this.grbDanhSachLop.Name = "grbDanhSachLop";
            this.grbDanhSachLop.Size = new System.Drawing.Size(449, 166);
            this.grbDanhSachLop.TabIndex = 0;
            this.grbDanhSachLop.TabStop = false;
            this.grbDanhSachLop.Text = "LỚP";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.Location = new System.Drawing.Point(131, 92);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(32, 17);
            this.lblMaLop.TabIndex = 8;
            this.lblMaLop.Text = "???";
            // 
            // lblTenNganh
            // 
            this.lblTenNganh.AutoSize = true;
            this.lblTenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNganh.Location = new System.Drawing.Point(131, 60);
            this.lblTenNganh.Name = "lblTenNganh";
            this.lblTenNganh.Size = new System.Drawing.Size(32, 17);
            this.lblTenNganh.TabIndex = 7;
            this.lblTenNganh.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngành:";
            // 
            // lblMaKhoasHoc
            // 
            this.lblMaKhoasHoc.AutoSize = true;
            this.lblMaKhoasHoc.Location = new System.Drawing.Point(131, 27);
            this.lblMaKhoasHoc.Name = "lblMaKhoasHoc";
            this.lblMaKhoasHoc.Size = new System.Drawing.Size(32, 17);
            this.lblMaKhoasHoc.TabIndex = 5;
            this.lblMaKhoasHoc.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Khóa:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Enabled = false;
            this.txtTenLop.Location = new System.Drawing.Point(134, 125);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(308, 22);
            this.txtTenLop.TabIndex = 3;
            this.txtTenLop.TextChanged += new System.EventHandler(this.txtTenLop_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lớp:";
            // 
            // btnExportDSLop
            // 
            this.btnExportDSLop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExportDSLop.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportDSLop.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExportDSLop.Image = global::GDU_Management.Properties.Resources.icons_print_45;
            this.btnExportDSLop.Location = new System.Drawing.Point(555, 138);
            this.btnExportDSLop.Name = "btnExportDSLop";
            this.btnExportDSLop.Size = new System.Drawing.Size(261, 65);
            this.btnExportDSLop.TabIndex = 15;
            this.btnExportDSLop.UseVisualStyleBackColor = false;
            // 
            // frmDanhSachLop
            // 
            this.AcceptButton = this.btnSaveLop;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(833, 472);
            this.Controls.Add(this.pnDanhSachLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDanhSachLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Lớp";
            this.Load += new System.EventHandler(this.frmDanhSachLop_Load);
            this.pnDanhSachLop.ResumeLayout(false);
            this.pnDanhSachLop.PerformLayout();
            this.pnControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            this.grbDanhSachLop.ResumeLayout(false);
            this.grbDanhSachLop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDanhSachLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExportDSLop;
        private System.Windows.Forms.TextBox txtTimKiemLop;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Button btnDeleteLop;
        private System.Windows.Forms.Button btnNewLop;
        private System.Windows.Forms.Button btnUpdateLop;
        private System.Windows.Forms.Button btnSaveLop;
        private System.Windows.Forms.DataGridView dgvDanhSachLop;
        private System.Windows.Forms.GroupBox grbDanhSachLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenNganh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMaKhoasHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private System.Windows.Forms.Button btnExitDSLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoaHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Button btnDeleteAllLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNganhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nganhHocDataGridViewTextBoxColumn;
    }
}