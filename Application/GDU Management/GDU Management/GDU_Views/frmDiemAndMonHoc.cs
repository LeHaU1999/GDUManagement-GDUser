using GDU_Management.Model;
using GDU_Management.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace GDU_Management
{
    public partial class frmDiemAndMonHoc : Form
    {
        public frmDiemAndMonHoc()
        {
            InitializeComponent();
            NgayGio();
        }
        //Khai Báo Các Service
        MonHocService monHocService = new MonHocService();
        DiemMonHocService diemMonHocService = new DiemMonHocService();
        KhoaService khoaService = new KhoaService();
        NganhHocService nganhHocService = new NganhHocService();
        KhoasHocService khoaHocService = new KhoasHocService();
        LopService lopService = new LopService();
        SinhVienService sinhVienService = new SinhVienService();

        //public value
        double DTB;
        string DiemChu;
        string DiemSo;
        string Diem4;
        string maMonHoc;

        //---------------------------DANH SÁCH HÀM PUBLIC------------------------------//
        //---------------------------------------------------------------------------------------//


        //1-Hàm lấy thời gian
        public void NgayGio()
        {
            //get ngày
            DateTime ngay = DateTime.Now;
            lblDay.Text = ngay.ToString("dddd, dd/MMyyyy");

            //get thời gian
            timerMonHoc.Start();
        }

        //2-Hàm Quay Trở Lại Menu GDUmanagement
        public void GoToGDUmanagement()
        {
            this.Hide();
            GDUManagement gdu = new GDUManagement();
            gdu.ShowDialog();
        }

        //load dữ liệu vào các combobox mặc định
        public void LoadDataToCombox()
        {
            //tab mon hoc
            cboChonKhoa_MH.DataSource = khoaService.GetAllKhoa();
            cboChonKhoa_MH.DisplayMember = "TenKhoa";
            cboChonKhoa_MH.ValueMember = "MaKhoa";

            //tab điểm
            cboChonKhoa_QLD.DataSource = khoaService.GetAllKhoa();
            cboChonKhoa_QLD.DisplayMember = "TenKhoa";
            cboChonKhoa_QLD.ValueMember = "MaKhoa";
        }

        //laod danh sách môn học vào datagridview
        public void LoadDanhSachMonHocToDatagridview()
        {
            string mmh = cboChonNganh_MH.SelectedValue.ToString();
            dgvDanhSachMonHoc.DataSource = monHocService.GetMonHocByNganh(mmh);
            CountRowsMonHoc();
        }

        //load danh sách điểm vào dgv theo mã lopwx và mã môn học
        public void LoadDanhSachDiemSinhVienToDatagridview()
        {
            string maLop = cboChonLop_QLD.SelectedValue.ToString();
            string maMonHoc = cboChonMon_QLD.SelectedValue.ToString();
            dgvDanhSachDiemSinhVien.DataSource = diemMonHocService.GetDanhSachMonByMaLopAndMaMonHoc(maLop, maMonHoc);
            SinhVien sv = new SinhVien();
            for (int i = 0; i < dgvDanhSachDiemSinhVien.Rows.Count; i++)
            {
                string maSV = dgvDanhSachDiemSinhVien.Rows[i].Cells[2].Value.ToString();
                sv = sinhVienService.GetSinhVienByMaSinhVien(maSV);
                dgvDanhSachDiemSinhVien.Rows[i].Cells[3].Value = sv.TenSV;
            }
        }

        //show data môn học to textbox
        public void ShowDataMonHocTuGDgvToTextBox()
        {
            int countRows = dgvDanhSachMonHoc.Rows.Count;
            if (countRows == 0)
            {
                dgvDanhSachMonHoc.Enabled = false;
            }
            else
            {
                dgvDanhSachMonHoc.Enabled = true;
                lblMaMonHocMH.DataBindings.Clear();
                lblMaMonHocMH.DataBindings.Add("text", dgvDanhSachMonHoc.DataSource, "MaMonHoc");
                txtTenMon_MH.DataBindings.Clear();
                txtTenMon_MH.DataBindings.Add("text", dgvDanhSachMonHoc.DataSource, "TenMonHoc");
                numericSoTinChi_MH.DataBindings.Clear();
                string STC = dgvDanhSachMonHoc.CurrentRow.Cells[3].Value.ToString();
                numericSoTinChi_MH.Value = Convert.ToInt32(STC);
            }
        }

        //check data Môn Học
        public bool checkDataMonHoc()
        {
            if (string.IsNullOrEmpty(txtTenMon_MH.Text))
            {
                MessageBox.Show("Tên Môn Không được bỏ trống, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMon_MH.Focus();
                return false;
            }

            int soTC = Convert.ToInt32(numericSoTinChi_MH.Value.ToString());
            if (soTC <= 0 )
            {
                MessageBox.Show("STC không được nhỏ hơn hoặc bằng 0, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (soTC <= 0 || soTC > 10)
            {
                MessageBox.Show("STC không được lớn hơn 10, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        //check data điểm
        public bool CheckDataDiem()
        {
            if (string.IsNullOrEmpty(txtDiem30.Text.Trim()) && Convert.ToDouble(txtDiem30.Text) > 0 && Convert.ToDouble(txtDiem30.Text) <=10 )
            {
                MessageBox.Show("Điểm 30% không đuợc trống họa nhỏ hơn 0, vui lòng kiểm tra lại...", "CảnhBáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem30.Focus();
                return false;
            }
            
            if (string.IsNullOrEmpty(txtDiem70L1.Text.Trim()) && Convert.ToDouble(txtDiem70L1.Text) > 0 && Convert.ToDouble(txtDiem70L1.Text) <= 10)
            {
                MessageBox.Show("Điểm 70% Trống, vui lòng kiểm tra lại...", "CảnhBáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem70L1.Focus();
                return false;
            }
            return true;
        }

        //auto id mon hoc
        public void AutoIDMonHoc()
        {
            int count;
            count = dgvDanhSachMonHoc.Rows.Count;

            string idKhoa = cboChonKhoa_MH.SelectedValue.ToString();
            string LastIdKhoa = idKhoa.Substring(8);

            string idNganh = cboChonNganh_MH.SelectedValue.ToString();
            string LastIdNganh = idNganh.Substring(7);


            if (count == 0)
            {
                lblMaMonHocMH.Text = "SUB" + LastIdKhoa + LastIdNganh + "01";
            }
            else if (count < 9)
            {
                string chuoi_id = "";
                int chuoi_id_key = 0;
                chuoi_id = Convert.ToString(dgvDanhSachMonHoc.Rows[count - 1].Cells[1].Value);
                chuoi_id_key = Convert.ToInt32(chuoi_id.Remove(0, 8));
                lblMaMonHocMH.Text = "SUB" + LastIdKhoa + LastIdNganh + "0" + (chuoi_id_key + 1);
            }
            else if (count >= 9)
            {
                string chuoi_id = "";
                int chuoi_id_key = 0;
                chuoi_id = Convert.ToString(dgvDanhSachMonHoc.Rows[count - 1].Cells[1].Value);
                chuoi_id_key = Convert.ToInt32(chuoi_id.Remove(0, 8));
                lblMaMonHocMH.Text = "SUB" + LastIdKhoa + LastIdNganh + (chuoi_id_key + 1);
            }
        }

        //xét điểm 
        public void XetDiem()
        {
            if (txtDiem70L2.Text.Trim() != "")
            {
                double D30 = Convert.ToDouble(txtDiem30.Text.Trim());
                //double D70L1 = Convert.ToDouble(txtDiem70L1.Text.Trim());
                double D70L2 = Convert.ToDouble(txtDiem70L2.Text.Trim());

                double valueTB = (D30 * 30 / 100) + (D70L2 * 70 / 100);
                DTB = Math.Round(valueTB, 2);

                double thangDiem4 = DTB * 4 / 10;
                Diem4 = Convert.ToString(thangDiem4);
            }
            else
            {

                double D30 = Convert.ToDouble(txtDiem30.Text.Trim());
                double D70L1 = Convert.ToDouble(txtDiem70L1.Text.Trim());
                //double D70L2 = Convert.ToDouble(txtDiem70L2.Text.Trim());

                double valueTB = (D30 * 30 / 100) + (D70L1 * 70 / 100);
                DTB = Math.Round(valueTB, 2);
                double thangDiem4 = DTB * 4 / 10;
                Diem4 = Convert.ToString(thangDiem4);
            }

            if (DTB >= 8.5)
            {
                DiemChu = "A";
                DiemSo = "4.0";
            }
            else if (DTB >= 8)
            {
                DiemChu = "B+";
                DiemSo = "3.5";
            }
            else if (DTB >= 7)
            {
                DiemChu = "B";
                DiemSo = "3.0";
            }
            else if (DTB >= 6.5)
            {
                DiemChu = "C+";
                DiemSo = "2.5";
            }
            else if (DTB >= 5.5)
            {
                DiemChu = "C";
                DiemSo = "2.0";
            }
            else if (DTB >= 5.0)
            {
                DiemChu = "D+";
                DiemSo = "1.5";
            }
            else if (DTB >= 4.0)
            {
                DiemChu = "D";
                DiemSo = "1.0";
            }
            else
            {
                DiemChu = "F";
                DiemSo = "0";
            }

            DiemMonHoc dmh = new DiemMonHoc();
            dmh.MaSV = lblMaSV.Text.Trim();
            dmh.MaMonHoc = cboChonMon_QLD.SelectedValue.ToString().Trim();
            dmh.Diem30 = txtDiem30.Text.Trim();
            dmh.Diem70L1 = txtDiem70L1.Text.Trim();
            dmh.Diem70L2 = txtDiem70L2.Text.Trim();
            dmh.DTB = Convert.ToString(DTB).Trim();
            dmh.Diem4 = Diem4.Trim(); 
            dmh.DiemChu = DiemChu.Trim();
            dmh.DiemSo = DiemSo.Trim();

            if (DTB >= 4)
            {
                dmh.GhiChu = "Pass";
            }
            else
            {
                dmh.GhiChu = "Fail";
            }
            if (string.IsNullOrEmpty(txtDiem70L2.Text.Trim()))
            {
                dmh.Diem70L2 = null;
            }
            diemMonHocService.UpdateDiemMonHoc(dmh);
        }

        //đếm số thứ tự môn học
        public void CountRowsMonHoc()
        {
            for(int i = 0; i < dgvDanhSachMonHoc.Rows.Count; i++)
            {
                dgvDanhSachMonHoc.Rows[i].Cells[0].Value = (i + 1);
            }
        }

        //đóng các button mặc định
        public void EnableFalseButton()
        {
            //tab mon hoc
            btnNewMonHoc.Enabled = false;
            btnSaveMonHoc.Enabled = false;
            btnUpdateMonHoc.Enabled = false;
            btnDeleteMonHoc.Enabled = false;

            //tab diem 
            txtDiem30.Enabled = false;
            txtDiem70L1.Enabled = false;
            txtDiem70L2.Enabled = false;
            btnSaveDiem.Enabled = false;
        }
        //-------------------------KẾT THÚC DS HÀM PUBLIC------------------------------//
        //--------------------------------------------------------------------------------------//

        private void timerMonHoc_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();

            int giay = Convert.ToInt32(lblGiay.Text);
            int phut = Convert.ToInt32(lblPhut.Text);
            giay++;
            if (giay > 59)
            {
                giay = 0;
                phut++;
            }

            if (giay < 10)
            {
                lblGiay.Text = "0" + giay;
            }
            else
            {
                lblGiay.Text = "" + giay;
            }
            if (phut < 10)
            {
                lblPhut.Text = "0" + phut;
            }
            else
            {
                lblPhut.Text = "" + phut;
            }

            if (giay % 2 == 0)
            {
                lblAnimation1.Text = "(^_^)";
                lblAnimation2.Text = "(+_+)";
                lblAnimation3.Text = "(-_^)";
            }
            else if (giay % 2 != 0)
            {
                lblAnimation2.Text = "(^_^)";
                lblAnimation1.Text = "(+_+)";
                lblAnimation3.Text = "(^_-)";
            }
            else
            {
                lblAnimation1.Text = ".";
                lblAnimation1.Text = "..";
                lblAnimation1.Text = "...";
                lblAnimation2.Text = ".";
                lblAnimation2.Text = "..";
                lblAnimation2.Text = "...";
            }
        }

        private void btnHomeMenu_Click(object sender, EventArgs e)
        {
            GoToGDUmanagement();
        }

        private void btnHomQLD_Click(object sender, EventArgs e)
        {
            GoToGDUmanagement();
        }

        private void frmDiemAndMonHoc_Load(object sender, EventArgs e)
        {
            LoadDataToCombox();
            EnableFalseButton();
        }

        private void cboChonKhoa_MH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboChonNganh_MH.Text = "";
            string maKhoa = cboChonKhoa_MH.SelectedValue.ToString();
            cboChonNganh_MH.DataSource = nganhHocService.GetNganhHocByKHOA(maKhoa);
            cboChonNganh_MH.DisplayMember = "TenNganh";
            cboChonNganh_MH.ValueMember = "MaNganh";
        }

        private void cboChonNganh_MH_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachMonHocToDatagridview();
            ShowDataMonHocTuGDgvToTextBox();
            btnNewMonHoc.Enabled = true;
        }

        private void dgvDanhSachMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataMonHocTuGDgvToTextBox();
        }

        private void dgvDanhSachMonHoc_MouseClick(object sender, MouseEventArgs e)
        {
            ShowDataMonHocTuGDgvToTextBox();
            btnUpdateMonHoc.Enabled = true;
            btnDeleteMonHoc.Enabled = true;
            btnSaveMonHoc.Enabled = false;
        }

        private void btnNewMonHoc_Click(object sender, EventArgs e)
        {
            AutoIDMonHoc();
            dgvDanhSachMonHoc.Enabled = true;
            btnSaveMonHoc.Enabled = true;
            btnDeleteMonHoc.Enabled = false;
            btnUpdateMonHoc.Enabled = false;
            LoadDanhSachMonHocToDatagridview();
            txtTenMon_MH.Text = "";
            txtTenMon_MH.Focus();
        }

        private void btnSaveMonHoc_Click(object sender, EventArgs e)
        {
            if (checkDataMonHoc())
            {
                MonHoc monHoc = new MonHoc();
                monHoc.MaMonHoc = lblMaMonHocMH.Text.Trim();
                monHoc.TenMonHoc = txtTenMon_MH.Text.Trim();
                monHoc.STC = Convert.ToInt32(numericSoTinChi_MH.Value.ToString());
                monHoc.MaNganh = cboChonNganh_MH.SelectedValue.ToString();
                monHocService.CreateMonHoc(monHoc);

                LoadDanhSachMonHocToDatagridview();
                MessageBox.Show("Đã Thêm [" + lblMaMonHocMH.Text + "]", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSaveMonHoc.Enabled = false;
                btnDeleteMonHoc.Enabled = true;
                btnUpdateMonHoc.Enabled = true;

                //thêm sinh viên vào bảng điểm môn
                var listSV = sinhVienService.GetSinhVienByMaNganh(cboChonNganh_MH.SelectedValue.ToString().Trim()).ToList();
                foreach (var x in listSV)
                {
                    string maMon = lblMaMonHocMH.Text.Trim();
                    DiemMonHoc diemMonHoc = new DiemMonHoc();
                    diemMonHoc.MaSV = x.MaSV;
                    diemMonHoc.MaMonHoc = maMon;
                    diemMonHoc.Diem30 = null;
                    diemMonHoc.Diem70L1 = null;
                    diemMonHoc.Diem70L2 = null;
                    diemMonHoc.DTB = null;
                    diemMonHoc.Diem4 = null;
                    diemMonHoc.DiemSo = null;
                    diemMonHoc.DiemChu = null;
                    diemMonHoc.GhiChu = null;
                    diemMonHocService.AddDiemMonHoc(diemMonHoc);
                }
            }
            else
            {
                MessageBox.Show("Lỗi, Thêm Thất Bại...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateMonHoc_Click(object sender, EventArgs e)
        {
            if (checkDataMonHoc())
            {
                int soTC = Convert.ToInt32(numericSoTinChi_MH.Value.ToString());

                MonHoc monHoc = new MonHoc();
                monHoc.MaMonHoc = lblMaMonHocMH.Text.Trim();
                monHoc.TenMonHoc = txtTenMon_MH.Text.Trim();
                monHoc.STC = soTC;

                monHocService.UpdateMonHoc(monHoc);
                LoadDanhSachMonHocToDatagridview();

                MessageBox.Show("Cập nhật thông tin [" + lblMaMonHocMH.Text + "] thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSaveMonHoc.Enabled = false;
                btnDeleteMonHoc.Enabled = true;
                btnUpdateMonHoc.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lỗi, Cập nhật thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteMonHoc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa [" + lblMaMonHocMH.Text + "] ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string maMon;
                maMon = lblMaMonHocMH.Text.Trim();
                if (string.IsNullOrEmpty(lblMaMonHocMH.Text))
                {
                    MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    monHocService.DeleteMonHoc(maMon);
                    LoadDanhSachMonHocToDatagridview();
                    MessageBox.Show("Đã Xóa [" + lblMaMonHocMH.Text + "]", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblMaMonHocMH.Text = "null";
                    txtTenMon_MH.Text = "";
                    numericSoTinChi_MH.Value = 0;

                    btnNewMonHoc.Enabled = true;
                    btnSaveMonHoc.Enabled = false;
                    btnUpdateMonHoc.Enabled = false;
                    btnDeleteMonHoc.Enabled = true;
                }
            }
        }

        private void cboChonKhoa_QLD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoa = cboChonKhoa_QLD.SelectedValue.ToString();
            cboChonNganh_QLD.DataSource = nganhHocService.GetNganhHocByKHOA(maKhoa);
            cboChonNganh_QLD.DisplayMember = "TenNganh";
            cboChonNganh_QLD.ValueMember = "MaNganh";
        }

        private void cboChonNganh_QLD_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboChonKhoasHoc_QLD.DataSource = khoaHocService.GetAllKhoaHoc();
            cboChonKhoasHoc_QLD.DisplayMember = "TenKhoaHoc";
            cboChonKhoasHoc_QLD.ValueMember = "MaKhoaHoc";
        }

        private void cboChonKhoasHoc_QLD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNganh = cboChonNganh_QLD.SelectedValue.ToString();
            string maKhoasHoc = cboChonKhoasHoc_QLD.SelectedValue.ToString();

            cboChonLop_QLD.DataSource = lopService.GetDanhSachLopByMaNganhVaMaKhoaHoc(maNganh, maKhoasHoc);
            cboChonLop_QLD.DisplayMember = "TenLop";
            cboChonLop_QLD.ValueMember = "MaLop";
        }

        private void cboChonLop_QLD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNganh = cboChonNganh_QLD.SelectedValue.ToString();
            cboChonMon_QLD.DataSource = monHocService.GetMonHocByNganh(maNganh);
            cboChonMon_QLD.DisplayMember = "TenMonHoc";
            cboChonMon_QLD.ValueMember = "MaMonHoc";
            txtTimKiemDiemSinhVien_QLD.Enabled = true;
        }

        private void cboChonMon_QLD_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachDiemSinhVienToDatagridview();
        }

        private void dgvDanhSachDiemSinhVien_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvDanhSachDiemSinhVien.Rows.Count <= 0)
            {
                dgvDanhSachDiemSinhVien.Enabled = false;
                MessageBox.Show("khong sho");
            }
            else
            {
                MessageBox.Show("show len");
                dgvDanhSachDiemSinhVien.Enabled = true;
                btnSaveDiem.Enabled = true;
                lblMaSV.DataBindings.Clear();
                lblMaSV.DataBindings.Add("text", dgvDanhSachDiemSinhVien.DataSource, "MaSV");
                txtDiem30.DataBindings.Clear();
                txtDiem30.DataBindings.Add("text", dgvDanhSachDiemSinhVien.DataSource, "Diem30");
                txtDiem70L1.DataBindings.Clear();
                txtDiem70L1.DataBindings.Add("text", dgvDanhSachDiemSinhVien.DataSource, "Diem70L1");
                txtDiem70L2.DataBindings.Clear();
                txtDiem70L2.DataBindings.Add("text", dgvDanhSachDiemSinhVien.DataSource, "Diem70L2");
                //rtxtGhiChu.DataBindings.Clear();
                // rtxtGhiChu.DataBindings.Add("text", dgvDanhSachDiemSinhVien.DataSource, "GhiChu");

                SinhVien sv = new SinhVien();
                sv = sinhVienService.GetSinhVienByMaSinhVien(lblMaSV.Text.Trim());
                lbltenSV.Text = sv.TenSV;
                lblGioiTinh.Text = sv.GioiTinh;

                txtDiem30.Enabled = true;
                txtDiem70L1.Enabled = true;
                txtDiem70L2.Enabled = true;
            }   
        }

        private void btnSaveDiem_Click(object sender, EventArgs e)
        {
            if (CheckDataDiem())
            {
                XetDiem();
                LoadDanhSachDiemSinhVienToDatagridview();
                MessageBox.Show("Cập nhật điểm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }

        private void txtDiem70L2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiem70L1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiem30_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDiem30_MouseClick(object sender, MouseEventArgs e)
        {
            txtDiem30.Text.Trim();
        }

        private void txtDiem70L1_MouseClick(object sender, MouseEventArgs e)
        {
            txtDiem70L1.Text.Trim();
        }

        private void txtDiem70L2_MouseClick(object sender, MouseEventArgs e)
        {
            txtDiem70L2.Text.Trim();
        }

        private void txtTimKiemDiemSinhVien_QLD_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemDiemSinhVien_QLD.Text.Trim()))
            {
                LoadDanhSachDiemSinhVienToDatagridview();
            }
            else
            {
                maMonHoc = cboChonMon_QLD.SelectedValue.ToString().Trim();
                dgvDanhSachDiemSinhVien.DataSource = diemMonHocService.SearchDiemMonHocByMonHocAndMaSV(maMonHoc, txtTimKiemDiemSinhVien_QLD.Text.Trim()).ToList();
            }
        }

        private void txtDiem30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar.ToString() != ".")
            {
                e.Handled = true;
            }
        }

        private void txtDiem70L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar.ToString() != ".")
            {
                e.Handled = true;
            }
        }

        private void txtDiem70L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar.ToString() != ".")
            {
                e.Handled = true;
            }
        }

        private void btnEXIT_QLD_Click(object sender, EventArgs e)
        {

        }
    }
}
