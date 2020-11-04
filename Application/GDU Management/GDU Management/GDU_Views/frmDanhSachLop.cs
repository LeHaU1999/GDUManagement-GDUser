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
    public partial class frmDanhSachLop : Form
    {
        public frmDanhSachLop()
        {
            InitializeComponent();
            EnableFalseButton();
        }

        //khai báo các service 
        LopService lopService = new LopService();
        SinhVienService sinhVienService = new SinhVienService();
        DiemMonHocService diemMonHocService = new DiemMonHocService();
        NganhHocService nganhHocService = new NganhHocService();

        //public value
        string _maNganh;

        //------------------------------------HÀM PUBLIC------------------------------------------//
        //---------------------------------------------------------------------------------------------//

        // hàm nhận mã ngành và khóa học từ frmQLSV
        public void FunDatafrmDanhSachLopToFrmQLSV(string maNganh , string maKhoasHoc)
        {
            _maNganh = maNganh;
            lblMaKhoasHoc.Text = maKhoasHoc;
            NganhHoc nganhHoc = new NganhHoc();
            nganhHoc = nganhHocService.GetNganhHocByMaNganh(_maNganh);
            lblTenNganh.Text = nganhHoc.TenNganh;
        }

        //hàm check data
        public bool checkDataLOP()
        {
            if (string.IsNullOrEmpty(lblMaLop.Text))
            {
                MessageBox.Show("Mã Lớp Không được bỏ trống, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtTenLop.Text))
            {
                txtTenLop.Focus();
                MessageBox.Show("Tên Lớp Không được bỏ trống, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        //hàm load data từ datagridview lên textbox
        public void ShowdataTuDatagridviewToTextbox()
        {
            lblMaLop.DataBindings.Clear();
            lblMaLop.DataBindings.Add("text", dgvDanhSachLop.DataSource, "MaLop");
            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("text", dgvDanhSachLop.DataSource, "TenLop");
        }

        //show danh sách lớp theo ngành và khóa học
        public void LoadDanhSachLopToDatagridview()
        {
            string maKhoaHoc = lblMaKhoasHoc.Text;
            dgvDanhSachLop.DataSource = lopService.GetDanhSachLopByMaNganhVaMaKhoaHoc(_maNganh, maKhoaHoc).ToList();
            CountRowsLop();
            CheckDeleteAlClass();
        }

        //hàm auto id lớp
        public void AutoIDLop()
        {
            int count;
            count = dgvDanhSachLop.Rows.Count;

            string IdKhoas = lblMaKhoasHoc.Text;
            string LastIdKhoas = IdKhoas.Substring(1);

            string IdNganh = _maNganh;
            string LastIDNganh = IdNganh.Substring(6);

            if (count == 0)
            {
                lblMaLop.Text = LastIdKhoas + "GD" + LastIDNganh + "01";
            }
            else
            {
                string chuoi_id = "";
                int chuoi_id_key = 0;

                chuoi_id = Convert.ToString(dgvDanhSachLop.Rows[count - 1].Cells[1].Value);
                chuoi_id_key = Convert.ToInt32(chuoi_id.Remove(0, 8));
                if (chuoi_id_key + 1 < 10)
                {
                    //[mã khóa]+GD+[2 số cuối mã khoa]+[2 số cuối mã ngành]-[01]GD[00000][0]
                    lblMaLop.Text = LastIdKhoas + "GD" + LastIDNganh + "0" + (chuoi_id_key + 1);
                }
                else if (chuoi_id_key + 1 >= 10)
                {
                    //[mã khóa]+GD+[2 số cuối mã khoa]+[2 số cuối mã ngành]-[01]GD[00000][0]
                    lblMaLop.Text = LastIdKhoas + "GD" + LastIDNganh + (chuoi_id_key + 1);
                }
            }
        }

        //đếm số thứ tự Lớp
        public void CountRowsLop()
        {
            for(int i = 0; i < dgvDanhSachLop.Rows.Count; i++)
            {
                dgvDanhSachLop.Rows[i].Cells[0].Value = (i + 1);
            }
        }

        //enableFalse button
        public void EnableFalseButton()
        {
            btnSaveLop.Enabled = false;
            btnDeleteLop.Enabled = false;
            btnUpdateLop.Enabled = false;
        }

        // check delete all lop
        public void CheckDeleteAlClass()
        {
            if (dgvDanhSachLop.Rows.Count > 0)
            {
                btnDeleteAllLop.Enabled = true;
            }
            else
            {
                btnDeleteAllLop.Enabled = false;
            }
        }
        //-----------------------------------------KẾT THÚC HÀM PUPLIC--------------------------------//
        //----------------------------------------------------------------------------------------------------//
        
        private void frmDanhSachLop_Load(object sender, EventArgs e)
        {
            LoadDanhSachLopToDatagridview();
            ShowdataTuDatagridviewToTextbox();
            EnableFalseButton();
        }

        private void btnSaveLop_Click(object sender, EventArgs e)
        {
            if (checkDataLOP())
            {
                Lop lop = new Lop();
                lop.MaLop = lblMaLop.Text.Trim();
                lop.TenLop = txtTenLop.Text.Trim();
                lop.MaNganh = _maNganh;
                lop.MaKhoaHoc = lblMaKhoasHoc.Text.Trim();
                lopService.CreateLop(lop);
                LoadDanhSachLopToDatagridview();
                btnSaveLop.Enabled = false;
                MessageBox.Show("Thêm Mới Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm Mới Thất Bại, vui lòng kiểm tra lại...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewLop_Click(object sender, EventArgs e)
        {
            AutoIDLop();
            txtTenLop.Clear();
            txtTenLop.Focus();
            txtTenLop.Enabled = true;
            btnSaveLop.Enabled = true;
            btnUpdateLop.Enabled = false;
            btnDeleteLop.Enabled = false;
        }

        private void btnUpdateLop_Click(object sender, EventArgs e)
        {
            if (checkDataLOP())
            {
                Lop lp = new Lop();
                lp.MaLop = lblMaLop.Text.Trim();
                lp.TenLop = txtTenLop.Text.Trim();
                lp.MaNganh = lblTenNganh.Text.Trim();
                lp.MaKhoaHoc = lblMaKhoasHoc.Text.Trim();
                lopService.UpdateLop(lp);
                LoadDanhSachLopToDatagridview();
                btnUpdateLop.Enabled = false;
                btnSaveLop.Enabled = false;
                btnDeleteLop.Enabled = false;
                MessageBox.Show("Cập nhật thông tin  ["+lblMaLop.Text+"]' thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập Nhật thông tin Thất Bại, vui lòng kiểm tra lại...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExitDSLop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDanhSachLop_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUpdateLop.Enabled = true;
            btnSaveLop.Enabled = false;
            btnDeleteLop.Enabled = true;
            txtTenLop.Enabled = true;
            ShowdataTuDatagridviewToTextbox();
        }

        private void btnDeleteLop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa [" + lblMaLop.Text + "], Việc này sẽ xóa tất cả thông tin liên quan đến lớp bao gồm danh sách sinh viên trong lớp)", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string maLop = lblMaLop.Text.Trim();
                if (maLop.Equals("null"))
                {
                    MessageBox.Show("Xóa thất bại, Không tồn tại mã lớp [--"+maLop+"--]", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // xóa tất cả điểm 
                    var listSV = sinhVienService.GetSinhVienByMaLop(maLop).ToList();
                    foreach(var  sv in listSV)
                    {
                        string maSV = sv.MaSV;
                        diemMonHocService.DeleteAllDiemMonHocByMaSinhVien(maSV);
                    }
                    //xóa tất cả sinh sinh viên trong lớp
                    sinhVienService.DeleteAllSinhVienByMaLop(maLop);

                    //xóa lớp
                    lopService.DeleteLop(maLop);
                    LoadDanhSachLopToDatagridview();
                    MessageBox.Show("Đã Xóa [" + lblMaLop.Text + "]", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblMaLop.Text="null";
                    txtTenLop.Clear();
                    btnDeleteLop.Enabled = false;
                    btnSaveLop.Enabled = false;
                    btnUpdateLop.Enabled = false;
                }
            }
        }

        private void txtTenLop_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTimKiemLop_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiemLop.Clear();
        }

        private void txtTimKiemLop_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemLop.Text))
            {
                LoadDanhSachLopToDatagridview();
            }
            else
            {
                dgvDanhSachLop.DataSource = lopService.SearchLopHocByTenLop(_maNganh, txtTimKiemLop.Text.Trim());
            }
        }

        private void btnDeleteAllLop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("***XÓA TẤT CẢ LỚP ?" + "\n ***Việc này sẽ xóa tất cả thông tin:" + "\n -Danh sách lớp trong ngành "+lblTenNganh.Text+"." + "\n -Danh sách sinh viên." + "\n -Danh sách Điểm.", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (lblMaKhoasHoc.Text !="???" & lblTenNganh.Text !="???")
                {
                    var listLop = lopService.GetDanhSachLopByMaNganhVaMaKhoaHoc(_maNganh, lblMaKhoasHoc.Text);
                    
                    foreach (var lp in listLop)
                    {
                        var listSV = sinhVienService.GetSinhVienByMaLop(lp.MaLop).ToList();
                        foreach (var sv in listSV)
                        {
                            //xóa danh sách điểm
                            diemMonHocService.DeleteAllDiemMonHocByMaSinhVien(sv.MaSV);
                        }
                        //xóa danh sách sinh viên trong lớp
                        sinhVienService.DeleteAllSinhVienByMaLop(lp.MaLop);
                    }
                    //xóa danh sách lớp
                    lopService.DeleteAllLopInNganh(lblMaKhoasHoc.Text, _maNganh);
                    LoadDanhSachLopToDatagridview();
                    MessageBox.Show("Deleted All Classes Successfully  </> !!!...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deleted All Classes Failled  (-__-) !!!...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
