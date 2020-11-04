using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDU_Management.Model;
using GDU_Management.Service;

namespace GDU_Management.GDU_Views
{
    public partial class frmPhongHoc : Form
    {
        public frmPhongHoc()
        {
            InitializeComponent();
        }

        //khai báo các hàm service
        PhongHocService phongHocService = new PhongHocService();

        //---------------------------DANH SÁCH HÀM PUBLIC------------------------------//
        //---------------------------------------------------------------------------------------//

        //đưa data lên datagridview 
        public void LoadDanhSachPhongHocToDgv()
        {
            dgvDanhSachPhongHoc.DataSource = phongHocService.GetAllPhongHoc();
            CountRowsPhogHoc();
        }

        //điếm số thứ tự
        public void CountRowsPhogHoc()
        {
            for(int i = 0; i < dgvDanhSachPhongHoc.Rows.Count; i++)
            {
                dgvDanhSachPhongHoc.Rows[i].Cells[0].Value = (i + 1);
            }
        }

        //đóng các button mặc định
        public void EnableFalseButton()
        {
            btnSaveRoom.Enabled = false;
            btnUpdateRoom.Enabled = false;
            btnDeleteRoom.Enabled = false;
        }

        //---------------------------kẾT THÚC HÀM PUBLIC--------------------------------//
        //--------------------------------------------------------------------------------------//


        private void frmPhongHoc_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhongHocToDgv();
            EnableFalseButton();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDanhSachPhongHoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUpdateRoom.Enabled = true;
            btnDeleteRoom.Enabled = true;
            txtPhongHoc.DataBindings.Clear();
            txtPhongHoc.DataBindings.Add("text", dgvDanhSachPhongHoc.DataSource, "MaPhongHoc");
            txtNote.DataBindings.Clear();
            txtNote.DataBindings.Add("text", dgvDanhSachPhongHoc.DataSource, "GhiChu");
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            txtPhongHoc.Clear();
            txtPhongHoc.Focus();
            txtNote.Clear();

            btnSaveRoom.Enabled = true;
            btnUpdateRoom.Enabled = false ;
            btnDeleteRoom.Enabled = false ;
        }

        private void btnSaveRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhongHoc.Text))
            {
                MessageBox.Show("Chưa nhập phòng học...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhongHoc.Focus();
            }
            else
            {
                PhongHoc ph = new PhongHoc();
                ph.MaPhongHoc = txtPhongHoc.Text.Trim();
                ph.GhiChu = txtNote.Text.Trim();
                phongHocService.AddClassRoom(ph);
                LoadDanhSachPhongHocToDgv();
                btnSaveRoom.Enabled = false;
                btnUpdateRoom.Enabled = true;
                btnDeleteRoom.Enabled = true;
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
                PhongHoc ph = new PhongHoc();
                ph.MaPhongHoc = txtPhongHoc.Text.Trim();
                ph.GhiChu = txtNote.Text.Trim();
                phongHocService.UpdateClassRoom(ph);
                LoadDanhSachPhongHocToDgv();
                btnSaveRoom.Enabled = false;
                btnUpdateRoom.Enabled = true;
                btnDeleteRoom.Enabled = true;
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhongHoc.Text))
            {
                MessageBox.Show("Chọn pHòng để xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                phongHocService.DeleteClassRoom(txtPhongHoc.Text.Trim());
                LoadDanhSachPhongHocToDgv();
                EnableFalseButton();
            }
        }

        private void txtTimKiemPhongHoc_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemPhongHoc.Text.Trim()))
            {
                LoadDanhSachPhongHocToDgv();
            }
            else
            {
                dgvDanhSachPhongHoc.DataSource = phongHocService.SearchPhongHoc(txtTimKiemPhongHoc.Text.Trim()).ToList();
            }
        }
    }
}
