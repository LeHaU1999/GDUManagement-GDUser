using GDU_Management.IDao;
using GDU_Management.Model;
using GDU_Management.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDU_Management
{
    public partial class frmDanhSachNganh : Form
    {
        public frmDanhSachNganh()
        {
            InitializeComponent();
            EnableFalseButton();
        }
        //
        
        //khai báo các service 
        NganhHocService nganhHocService = new NganhHocService();
        LopService lopService = new LopService();
        KhoaService khoaService = new KhoaService();
        MonHocService monHocService = new MonHocService();

        //public Value
        string _maKhoa;

        //---------------------------DANH SÁCH HÀM PUBLIC------------------------------//
        //---------------------------------------------------------------------------------------//

        //hàm enable false button 
        public void EnableFalseButton()
        {
            btnSaveNganh.Enabled = false;
            btnUpdateNganh.Enabled = false;
            btnDeleteNganh.Enabled = false;
        }

        //load danh sách ngành vào dgv
        public void LoadDanhSachNganh()
        {
            dgvDSNganh.DataSource = nganhHocService.GetNganhHocByKHOA(_maKhoa);
            CountRowsNganh();
        }

        //load data lên textbox
        public void ShowDataTuDataGridViewToTextBox()
        {
            lblMaNganh.DataBindings.Clear();
            lblMaNganh.DataBindings.Add("text", dgvDSNganh.DataSource, "MaNganh");
            txtTenNganh.DataBindings.Clear();
            txtTenNganh.DataBindings.Add("text", dgvDSNganh.DataSource, "TenNganh");
            CheckDataDeleteNganh();
        }

        //check data
        public bool checkDataNGANH()
        {
            if (string.IsNullOrEmpty(txtTenNganh.Text))
            {
                MessageBox.Show("Tên Ngành Không được bỏ trống, vui lòng kiểm tra lại..." , "Cảnh Báo" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNganh.Focus();
                return false;
            }
            return true;
        }

        //hàm nhận text maKhoa từ frmQLSV
        public void FunData(Label maKhoa)
        {
            _maKhoa = maKhoa.Text;
            //lblMaKhoa.Text = txtFrmDanhSachKhoa.Text;
            Khoa kh = new Khoa();
            kh = khoaService.GetKhoaByMaKhoa(_maKhoa);
            lblTenKhoa.Text = kh.TenKhoa;

        }

        //hàm tạo id tự động
        public void AutoIDNganh()
        {
            int count;

            string maKhoa = _maKhoa;
            string lastID = maKhoa.Substring(8); //lay 2 so cuoi cua ma khoa

            count = dgvDSNganh.Rows.Count;

            if(count == 0)
            {
                lblMaNganh.Text = "M4716" + lastID + "001";
            }
            else
            {
                string chuoi_id = "";
                int chuoi_id_key = 0;

                chuoi_id = Convert.ToString(dgvDSNganh.Rows[count - 1].Cells[1].Value);
                chuoi_id_key = Convert.ToInt32(chuoi_id.Remove(0, 9));

                if (chuoi_id_key + 1 < 10)
                {
                    lblMaNganh.Text = "M4716" + lastID + "00" + (chuoi_id_key + 1).ToString();
                }
                else if (chuoi_id_key + 1 >= 10)
                {
                    lblMaNganh.Text = "M4716" + lastID + "0" + (chuoi_id_key + 1).ToString();
                }
                else if (chuoi_id_key + 1 >= 100)
                {
                    lblMaNganh.Text = "M4716" + lastID + (chuoi_id_key + 1).ToString();
                }
            }
        }

        //đếm số thứ tự ngành
        public void CountRowsNganh()
        {
            for(int i = 0; i < dgvDSNganh.Rows.Count; i++)
            {
                dgvDSNganh.Rows[i].Cells[0].Value = (i + 1);
            }
        }

        //check dữ liệu trước khi xóa ngành
        public void CheckDataDeleteNganh()
        {
            var listLop = lopService.GetAllLop();
            foreach(var lp in listLop)
            {
                if(lp.MaNganh == lblMaNganh.Text)
                {
                    btnDeleteNganh.Enabled = false;
                    break;
                }
                else
                {
                    btnDeleteNganh.Enabled = true;
                }
            }
        }

        //-------------------------KẾT THÚC DS HÀM PUBLIC------------------------------//
        //--------------------------------------------------------------------------------------//



        private void pnDanhSachNganh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDanhSachNganh_Load(object sender, EventArgs e)
        {
            LoadDanhSachNganh();
            ShowDataTuDataGridViewToTextBox();
        }

        private void dgvDSNganh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnSaveNganh.Enabled = false;
            txtTenNganh.Enabled = true;
            btnUpdateNganh.Enabled = true;
            btnDeleteNganh.Enabled = true;
            ShowDataTuDataGridViewToTextBox();
        }

        private void btnSaveNganh_Click(object sender, EventArgs e)
        {
            if (checkDataNGANH())
            {
                NganhHoc nganhHoc = new NganhHoc();
                nganhHoc.MaNganh = lblMaNganh.Text;
                nganhHoc.TenNganh = txtTenNganh.Text;
                nganhHoc.MaKhoa = _maKhoa;
                nganhHocService.CreateNganhHoc(nganhHoc);
                MessageBox.Show("Tạo Mới Thành Công...(^...^) ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSaveNganh.Enabled = false;
                LoadDanhSachNganh();
            }
            else
            {
                MessageBox.Show("Lỗi, Thêm Thất Bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteNganh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa '" + lblMaNganh.Text + "' ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string maNganh = lblMaNganh.Text.Trim();
                if (string.IsNullOrEmpty(lblMaNganh.Text))
                {
                    MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    monHocService.DeleteMonHocByNganh(lblMaNganh.Text);
                    nganhHocService.DeleteNganhHoc(maNganh);
                    lblMaNganh.Text = "???";
                    txtTenNganh.Text = ""; 
                    btnSaveNganh.Enabled = false;
                    btnUpdateNganh.Enabled = false;
                    btnDeleteNganh.Enabled = false;
                    LoadDanhSachNganh();
                    MessageBox.Show("Đã Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateNganh_Click(object sender, EventArgs e)
        {
            NganhHoc nganhHoc = new NganhHoc();
            nganhHoc.MaNganh = lblMaNganh.Text;
            nganhHoc.TenNganh = txtTenNganh.Text;
            nganhHocService.UpdateNganhHoc(nganhHoc);
            MessageBox.Show("Cập nhật thông tin '" + lblMaNganh.Text + "' Thành Công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDanhSachNganh();
        }

        private void btnNewNganh_Click(object sender, EventArgs e)
        {
            AutoIDNganh();
            txtTenNganh.Focus();
            txtTenNganh.Text = "";
            txtTenNganh.Enabled = true;
            btnSaveNganh.Enabled = true;
            btnUpdateNganh.Enabled = false;
            btnDeleteNganh.Enabled = false;
            LoadDanhSachNganh();
        }

        private void txtTimKiemNganh_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiemNganh.Clear();
        }

        private void txtTimKiemNganh_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemNganh.Text))
            {
                LoadDanhSachNganh();
            }
            else
            {
                dgvDSNganh.DataSource = nganhHocService.SearchNganhHocByTenNganh(_maKhoa,txtTimKiemNganh.Text.Trim()).ToList();
            }
        }
    }
}
