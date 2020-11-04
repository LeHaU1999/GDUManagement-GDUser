namespace GDU_Management.GDU_Views
{
    partial class frmPhongHoc
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
            this.pnPhongHoc = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvDanhSachPhongHoc = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiemPhongHoc = new System.Windows.Forms.TextBox();
            this.grbInfoRoom = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnSaveRoom = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhongHoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maPhongHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnPhongHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhongHoc)).BeginInit();
            this.grbInfoRoom.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPhongHoc
            // 
            this.pnPhongHoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnPhongHoc.Controls.Add(this.btnClose);
            this.pnPhongHoc.Controls.Add(this.dgvDanhSachPhongHoc);
            this.pnPhongHoc.Controls.Add(this.txtTimKiemPhongHoc);
            this.pnPhongHoc.Controls.Add(this.grbInfoRoom);
            this.pnPhongHoc.Location = new System.Drawing.Point(0, 12);
            this.pnPhongHoc.Name = "pnPhongHoc";
            this.pnPhongHoc.Size = new System.Drawing.Size(477, 630);
            this.pnPhongHoc.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(365, 186);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDanhSachPhongHoc
            // 
            this.dgvDanhSachPhongHoc.AllowUserToAddRows = false;
            this.dgvDanhSachPhongHoc.AllowUserToDeleteRows = false;
            this.dgvDanhSachPhongHoc.AutoGenerateColumns = false;
            this.dgvDanhSachPhongHoc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDanhSachPhongHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhongHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maPhongHocDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dgvDanhSachPhongHoc.DataSource = this.phongHocBindingSource;
            this.dgvDanhSachPhongHoc.Location = new System.Drawing.Point(14, 226);
            this.dgvDanhSachPhongHoc.Name = "dgvDanhSachPhongHoc";
            this.dgvDanhSachPhongHoc.ReadOnly = true;
            this.dgvDanhSachPhongHoc.RowHeadersWidth = 5;
            this.dgvDanhSachPhongHoc.RowTemplate.Height = 24;
            this.dgvDanhSachPhongHoc.Size = new System.Drawing.Size(451, 389);
            this.dgvDanhSachPhongHoc.TabIndex = 78;
            this.dgvDanhSachPhongHoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhSachPhongHoc_CellMouseClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 80;
            // 
            // txtTimKiemPhongHoc
            // 
            this.txtTimKiemPhongHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemPhongHoc.Location = new System.Drawing.Point(17, 190);
            this.txtTimKiemPhongHoc.Name = "txtTimKiemPhongHoc";
            this.txtTimKiemPhongHoc.Size = new System.Drawing.Size(312, 27);
            this.txtTimKiemPhongHoc.TabIndex = 77;
            this.txtTimKiemPhongHoc.TextChanged += new System.EventHandler(this.txtTimKiemPhongHoc_TextChanged);
            // 
            // grbInfoRoom
            // 
            this.grbInfoRoom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbInfoRoom.Controls.Add(this.panel2);
            this.grbInfoRoom.Controls.Add(this.txtNote);
            this.grbInfoRoom.Controls.Add(this.label2);
            this.grbInfoRoom.Controls.Add(this.txtPhongHoc);
            this.grbInfoRoom.Controls.Add(this.label1);
            this.grbInfoRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoRoom.Location = new System.Drawing.Point(4, 4);
            this.grbInfoRoom.Name = "grbInfoRoom";
            this.grbInfoRoom.Size = new System.Drawing.Size(461, 165);
            this.grbInfoRoom.TabIndex = 0;
            this.grbInfoRoom.TabStop = false;
            this.grbInfoRoom.Text = "Phòng Học";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteRoom);
            this.panel2.Controls.Add(this.btnAddRoom);
            this.panel2.Controls.Add(this.btnSaveRoom);
            this.panel2.Controls.Add(this.btnUpdateRoom);
            this.panel2.Location = new System.Drawing.Point(10, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 40);
            this.panel2.TabIndex = 75;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.Location = new System.Drawing.Point(321, 2);
            this.btnDeleteRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteRoom.TabIndex = 53;
            this.btnDeleteRoom.Text = "DElete";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Location = new System.Drawing.Point(3, 2);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(100, 35);
            this.btnAddRoom.TabIndex = 50;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnSaveRoom
            // 
            this.btnSaveRoom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSaveRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRoom.Location = new System.Drawing.Point(109, 2);
            this.btnSaveRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveRoom.Name = "btnSaveRoom";
            this.btnSaveRoom.Size = new System.Drawing.Size(100, 35);
            this.btnSaveRoom.TabIndex = 50;
            this.btnSaveRoom.Text = "Save";
            this.btnSaveRoom.UseVisualStyleBackColor = false;
            this.btnSaveRoom.Click += new System.EventHandler(this.btnSaveRoom_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.Location = new System.Drawing.Point(215, 2);
            this.btnUpdateRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(100, 35);
            this.btnUpdateRoom.TabIndex = 52;
            this.btnUpdateRoom.Text = "UPdate";
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(101, 61);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(240, 27);
            this.txtNote.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Note";
            // 
            // txtPhongHoc
            // 
            this.txtPhongHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhongHoc.Location = new System.Drawing.Point(101, 26);
            this.txtPhongHoc.Name = "txtPhongHoc";
            this.txtPhongHoc.Size = new System.Drawing.Size(120, 27);
            this.txtPhongHoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng";
            // 
            // maPhongHocDataGridViewTextBoxColumn
            // 
            this.maPhongHocDataGridViewTextBoxColumn.DataPropertyName = "MaPhongHoc";
            this.maPhongHocDataGridViewTextBoxColumn.HeaderText = "Phòng";
            this.maPhongHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhongHocDataGridViewTextBoxColumn.Name = "maPhongHocDataGridViewTextBoxColumn";
            this.maPhongHocDataGridViewTextBoxColumn.ReadOnly = true;
            this.maPhongHocDataGridViewTextBoxColumn.Width = 135;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.ghiChuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiChuDataGridViewTextBoxColumn.Width = 200;
            // 
            // phongHocBindingSource
            // 
            this.phongHocBindingSource.DataSource = typeof(GDU_Management.Model.PhongHoc);
            // 
            // frmPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(477, 642);
            this.Controls.Add(this.pnPhongHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhongHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhongHoc";
            this.Load += new System.EventHandler(this.frmPhongHoc_Load);
            this.pnPhongHoc.ResumeLayout(false);
            this.pnPhongHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhongHoc)).EndInit();
            this.grbInfoRoom.ResumeLayout(false);
            this.grbInfoRoom.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phongHocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPhongHoc;
        private System.Windows.Forms.GroupBox grbInfoRoom;
        private System.Windows.Forms.TextBox txtPhongHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnSaveRoom;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.TextBox txtTimKiemPhongHoc;
        private System.Windows.Forms.DataGridView dgvDanhSachPhongHoc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource phongHocBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
    }
}