using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDU_Management.Service;
using GDU_Management.Model;
using System.Text.RegularExpressions;
using System.IO;
using GDU_Management.GDU_Views;

namespace GDU_Management.GDU_View
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }
        //khai báo các class service 
        AdminService adminService = new AdminService();
        GiangVienService giangVienService = new GiangVienService();
        SinhVienService sinhVienService = new SinhVienService();

        //public value
        string ID_Admin;
        string ID_GV;
        string ID_SV;
        bool showPass = false;

        //delegate truyền id qua form khác(AddNewAdmin)
        delegate void SendIdADmin(string dlgIDAdmin);
        delegate void SendIdSV(string dlgIDSV);


        //---------------------------DANH SÁCH HÀM PUBLIC------------------------------//
        //__________________________________________________________//

        //chuyển hình từ kiểu Image sang kiểu ByteArray
        private byte[] ImageToByteArray(System.Drawing.Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        //chuyển hình từ kiểu ByteArray sang kiểu Image 
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image imageOut = Image.FromStream(ms);
                return imageOut;
            }
        }

        public void HideForm()
        {
            this.Hide();
        }
        public void ShowForm()
        {
            this.ShowDialog();
        }

        //hàm load data Admin vào dgv
        public void LoadAdminToDgv()
        {
            dgvDanhSachAccount.DataSource = adminService.GetAllAdmin();
            CountRowsAdmin();
        }

        //load data giảng viên vào dgv
        public void LoadGiangVienToDgv()
        {
            dgvDSAccountGiangVien.DataSource = giangVienService.GetAllGiangVien().ToList();
            CountRowsGV();
        }

        public void LoadSinhVienToDgv()
        {
            dgvDSAccountSinhVien.DataSource = sinhVienService.GetAllSinhVien().ToList();
            CountRowsSV();
        }

        //hiện data admin lên các field
        public void ShowInfoAdmin()
        {
            MessageBox.Show("id ad min" + dgvDanhSachAccount.CurrentRow.Cells[1].Value.ToString().Trim());
            ID_Admin = dgvDanhSachAccount.CurrentRow.Cells[1].Value.ToString().Trim();
            MessageBox.Show("id ad min" + ID_Admin);
            Admin admin = new Admin();
            admin = adminService.GetAdminByMaAdmin(ID_Admin);
            txtEmailAdmin.Text = admin.Email;
            txtPassAdmin.Text = admin.Password;
            picAvtAdmin.Image = ByteArrayToImage(admin.Avt.ToArray());
            lblIdAdmin.Text = admin.MaAdmin;
            txtTenAdmin.Text = admin.TenAdmin;
            dtpNamSinhAdmin.Text = admin.NamSinh;
            txtSDTAdmin.Text = admin.SDT;
            lblStartDayAdmin.Text = admin.StartDay;

            string gioiTinh = admin.GioiTinh;
            if(gioiTinh == "Nam")
            {
                radNam.Checked = true;
                radNu.Checked = false;
            }
            else
            {
                radNam.Checked = false;
                radNu.Checked = true;
            }

            string status = admin.StatusAcc;
            if(status == "Activate")
            {
                lblStatusAdmin.BackColor = Color.Lime;
            }
            else if (status == "Lock")
            {
                lblStatusAdmin.BackColor = Color.Red;
            }
            else
            {
                lblStatusAdmin.BackColor = Color.Violet;
            }
            //CountRowsAdmin();
        }

        //show data giảng viên lên các field
        public void ShowInfoGiangVien()
        {
            ID_GV = dgvDSAccountGiangVien.CurrentRow.Cells[1].Value.ToString().Trim();
            GiangVien gv = new GiangVien();
            gv = giangVienService.GetGiangVienByMaGV(ID_GV);
            txtEmailGiangVien.Text = gv.Email;
            txtPassGiangVien.Text = gv.Password;
            lblMaGV.Text = gv.MaGV;
            lblTenGV.Text = gv.TenGV;
            lblGioiTinhGV.Text = gv.GioiTinh;
            lblNamSinhGV.Text = gv.NamSinh;
            lblSdtGV.Text = gv.SDT;
            lblStartDayGV.Text = gv.NgayBatDau;

            string status = gv.StatusAcc;
            if (status == "Activate")
            {
                lblStatusGV.BackColor = Color.Lime;
            }
            else if (status == "Lock")
            {
                lblStatusGV.BackColor = Color.Red;
            }
            else
            {
                lblStatusGV.BackColor = Color.Violet;
            }
        }

        //show data Sinh viên lên các field
        public void ShowInfoSinhVien()
        {
            ID_SV = dgvDSAccountSinhVien.CurrentRow.Cells[1].Value.ToString();
            SinhVien sv = new SinhVien();
            sv = sinhVienService.GetSinhVienByMaSinhVien(ID_SV);
            txtEmailSV.Text = sv.Email;
            txtPassSV.Text = sv.Password;
            lblMaSV.Text = sv.MaSV;
            lblTenSV.Text = sv.TenSV;
            lblGioiTinhSV.Text = sv.GioiTinh;
            lblNamSinhSV.Text = sv.NamSinh;
            lblSdtSV.Text = sv.SDT;
            lblLop.Text = sv.MaLop;

            string status = sv.StatusAcc;
            if (status == "Activate")
            {
                lblStatusSV.BackColor = Color.Lime;
            }
            else if (status == "Lock")
            {
                lblStatusSV.BackColor = Color.Red;
            }
            else
            {
                lblStatusSV.BackColor = Color.Violet;
            }
        }

        //hàm check data account admin
        public bool checkDataAccountAdmin()
        {
            if (string.IsNullOrEmpty(txtPassAdmin.Text.Trim()))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống, (-_-)!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassAdmin.Focus();
                return false;
            }
            return true;
        }

        //hàm check data cá nhân admin
        public bool checkDataInfoAdmin()
        {
            if (string.IsNullOrEmpty(txtTenAdmin.Text.Trim()))
            {
                MessageBox.Show("Tên admin không được bỏ trống, (-_-)!!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenAdmin.Focus();
                return false;
            }
            if (!string.IsNullOrEmpty(txtSDTAdmin.Text))
            {
                Regex isValidInput = new Regex(@"^\d{10}$");
                string sdt = txtSDTAdmin.Text.Trim();
                if (!isValidInput.IsMatch(sdt))
                {
                    MessageBox.Show("SĐT bao gồm 10 số và không có kí tự, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDTAdmin.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("SĐT Không được bỏ trống, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDTAdmin.Focus();
                return false;
            }
            return true;
        }

        //hàm đếm số thứ tự Admin
        public void CountRowsAdmin()
        {
            for(int i = 0; i < dgvDanhSachAccount.Rows.Count; i++)
            {
                dgvDanhSachAccount.Rows[i].Cells[0].Value = (i + 1);
            }
        }

        //hàm đếm số thứ tự Giảng Viên
        public void CountRowsGV()
        {
            for (int i = 0; i < dgvDSAccountGiangVien.Rows.Count; i++)
            {
                dgvDSAccountGiangVien.Rows[i].Cells[0].Value = (i + 1);
            }
        }

        //hàm đếm số thứ tự Sinh Viên
        public void CountRowsSV()
        {
            for (int i = 0; i < dgvDSAccountSinhVien.Rows.Count; i++)
            {
                dgvDSAccountSinhVien.Rows[i].Cells[0].Value = (i + 1);
            }
        }
        //-------------------------KẾT THÚC DS HÀM PUBLIC------------------------------//
        //_________________________________________________________//

        private void picAvtAdmin_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picAvtAdmin.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            LoadAdminToDgv();
            LoadGiangVienToDgv();
            LoadSinhVienToDgv();
        }

        private void dgvDanhSachAccount_MouseClick(object sender, MouseEventArgs e)
        {
            //if (dgvDanhSachAccount.Rows.Count == 0)
            //{
            //    dgvDanhSachAccount.Enabled = false;
            //    MessageBox.Show("false");
            //}
            //else
            //{
            //    MessageBox.Show("" + dgvDanhSachAccount.Rows.Count);
            //    dgvDanhSachAccount.Enabled = true;
            //    MessageBox.Show("true");
            //    ShowInfoAdmin();
            //}
        }

        private void dgvDSAccountGiangVien_Click(object sender, EventArgs e)
        {
            if (dgvDSAccountGiangVien.Rows.Count == 0)
            {
                dgvDSAccountGiangVien.Enabled = false;
            }
            else
            {
                dgvDSAccountGiangVien.Enabled = true;
                ShowInfoGiangVien();
                CountRowsGV();
            } 
        }

        private void dgvDSAccountSinhVien_Click(object sender, EventArgs e)
        {
            if (dgvDSAccountSinhVien.Rows.Count == 0)
            {
                dgvDSAccountSinhVien.Enabled = false;
            }
            else
            {
                dgvDSAccountSinhVien.Enabled = true;
                ShowInfoSinhVien();
                CountRowsSV();
            }
            
        }

        private void lblExitAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblExitGV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblExitSV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblStatusAdmin_Click(object sender, EventArgs e)
        {
            if(lblStatusAdmin.BackColor == Color.Lime)
            {
                lblStatusAdmin.BackColor = Color.Red;
            }
            else if (lblStatusAdmin.BackColor == Color.Red)
            {
                lblStatusAdmin.BackColor = Color.Lime;
            }
        }

        private void lblStatusGV_Click(object sender, EventArgs e)
        {
            if (lblStatusAdmin.BackColor == Color.Lime)
            {
                lblStatusAdmin.BackColor = Color.Red;
            }
            else if (lblStatusAdmin.BackColor == Color.Red)
            {
                lblStatusAdmin.BackColor = Color.Lime;
            }
        }

        private void lblStatusSinhVien_Click(object sender, EventArgs e)
        {
            if (lblStatusAdmin.BackColor == Color.Lime)
            {
                MessageBox.Show("doi mau lock");
                lblStatusAdmin.BackColor = Color.Red;
            }
            else if (lblStatusAdmin.BackColor == Color.Red)
            {
                MessageBox.Show("doi mau acctive");
                lblStatusAdmin.BackColor = Color.Lime;
            }
        }

        private void lblShowPassword_Click(object sender, EventArgs e)
        {
            if (showPass)
            {
                txtPassAdmin.PasswordChar = '*';
                lblShowPassword.Image = Image.FromFile(@"..\..\Resources\icons8-eye-24.png");
                showPass = false;
            }
            else
            {
                showPass = true;
                txtPassAdmin.PasswordChar = '\0';
                lblShowPassword.Image = Image.FromFile(@"..\..\Resources\icons8-forgot-password-24.png");
            }
        }

        private void btnSaveAccountAdmin_Click(object sender, EventArgs e)
        {
            if (checkDataAccountAdmin())
            {
                string statusAcc;
                if (lblStatusAdmin.BackColor == Color.Lime)
                {
                    statusAcc = "Activate";
                }
                else if (lblStatusAdmin.BackColor == Color.Red)
                {
                    statusAcc = "Lock";
                }
                else
                {
                    statusAcc = "Null";
                }

                byte[] Image_admin = ImageToByteArray(picAvtAdmin.Image);
                System.Data.Linq.Binary img = new System.Data.Linq.Binary(Image_admin);

                Admin admin = new Admin();
                admin.MaAdmin = lblIdAdmin.Text.Trim();
                admin.Password = txtPassAdmin.Text;
                //admin.Avt = img;
                admin.StatusAcc = statusAcc;
                adminService.UpadteAccount(admin);
                LoadAdminToDgv();
            }
        }

        private void lblUpdateAdmin_Click(object sender, EventArgs e)
        {
            if (checkDataInfoAdmin())
            {
                string gioiTinh;
                if (radNam.Checked)
                {
                    gioiTinh = "Nam";
                }
                else
                {
                    gioiTinh = "Nữ";
                }

                Admin admin = new Admin();
                admin.MaAdmin = lblIdAdmin.Text.Trim();
                admin.TenAdmin = txtTenAdmin.Text.Trim();
                admin.GioiTinh = gioiTinh;
                admin.NamSinh = dtpNamSinhAdmin.Text.ToString().Trim();
                admin.SDT = txtSDTAdmin.Text.Trim();
                adminService.UpdateInfomation(admin);
                LoadAdminToDgv();
                ShowInfoAdmin();
            }
        }

        private void btnSaveAccountGiangVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassGiangVien.Text.Trim()))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống, (-_-)!!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassGiangVien.Focus();
            }
            else
            {
                string statusGVAcc;
                if (lblStatusGV.BackColor == Color.Lime)
                {
                    statusGVAcc = "Activate";
                }
                else if (lblStatusGV.BackColor == Color.Red)
                {
                    statusGVAcc = "Lock";
                }
                else
                {
                    statusGVAcc = "Null";
                }

                GiangVien gv = new GiangVien();
                gv.MaGV = lblMaGV.Text;
                gv.Password = txtPassGiangVien.Text.Trim();
                gv.StatusAcc = statusGVAcc;
                giangVienService.UpdateAccountGiangVien(gv);
                ShowInfoGiangVien();
            }
        }

        private void btnSaveAccountSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassSV.Text.Trim()))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống, (-_-)!!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassSV.Focus();
            }
            else
            {
                string statusSVAcc;
                if (lblStatusSV.BackColor == Color.Lime)
                {
                    statusSVAcc = "Activate";
                }
                else if (lblStatusSV.BackColor == Color.Red)
                {
                    statusSVAcc = "Lock";
                }
                else
                {
                    statusSVAcc = "Null";
                }

                SinhVien sv = new SinhVien();
                sv.MaSV = lblMaSV.Text;
                sv.Password = txtPassSV.Text.Trim();
                sv.StatusAcc = statusSVAcc;
                sinhVienService.UpdateAccountSinhVien(sv);
            }
        }

        private void lblShowPassGiangVien_Click(object sender, EventArgs e)
        {
            if (showPass)
            {
                txtPassGiangVien.PasswordChar = '*';
                lblShowPassGiangVien.Image = Image.FromFile(@"..\..\Resources\icons8-eye-24.png");
                showPass = false;
            }
            else
            {
                showPass = true;
                txtPassGiangVien.PasswordChar = '\0';
                lblShowPassGiangVien.Image = Image.FromFile(@"..\..\Resources\icons8-forgot-password-24.png");
            }
        }

        private void lblShowPassSV_Click(object sender, EventArgs e)
        {
            if (showPass)
            {
                txtPassSV.PasswordChar = '*';
                lblShowPassSV.Image = Image.FromFile(@"..\..\Resources\icons8-eye-24.png");
                showPass = false;
            }
            else
            {
                showPass = true;
                txtPassSV.PasswordChar = '\0';
                lblShowPassSV.Image = Image.FromFile(@"..\..\Resources\icons8-forgot-password-24.png");
            }
        }

        private void lblAddNewAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddNewAdmin frm_AddNewAdmin = new frmAddNewAdmin();
            SendIdADmin sendID = new SendIdADmin(frm_AddNewAdmin.FunData);
            sendID(this.lblIdAdmin.Text);
            frm_AddNewAdmin.ShowDialog();
        }

        private void txtTimKiemAdmin_Click(object sender, EventArgs e)
        {
            txtTimKiemAdmin.Clear();
        }

        private void txtTimKiemAdmin_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiemAdmin.Text.Equals(""))
            {
                LoadAdminToDgv();
            }
            else
            {
                dgvDanhSachAccount.DataSource = adminService.SearchAdminEmail(txtTimKiemAdmin.Text.Trim()) ;
            }
        }

        private void txtTimKiemAdmin_Leave(object sender, EventArgs e)
        {
            txtTimKiemAdmin.Text = "Nhập email để tìm kiếm";
        }

        private void txtTimKiemAccountGV_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemAccountGV.Text))
            {
                LoadGiangVienToDgv();
            }
            else
            {
                dgvDSAccountGiangVien.DataSource = giangVienService.SearchGiangVienByEmail(txtTimKiemAccountGV.Text.Trim()).ToList();
            }
        }

        private void txtTimKiemAccountGV_Leave(object sender, EventArgs e)
        {
            txtTimKiemAccountGV.Text = "Nhập email để tìm kiếm";
        }

        private void txtTimKiemAccountSV_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemAccountSV.Text))
            {
                LoadGiangVienToDgv();
            }
            else
            {
                dgvDSAccountSinhVien.DataSource = sinhVienService.SearchAccountSinhVienByEmail(txtTimKiemAccountSV.Text.Trim()).ToList();
            }
        }

        private void txtTimKiemAccountSV_Leave(object sender, EventArgs e)
        {
            txtTimKiemAccountGV.Text = "Nhập email để tìm kiếm";
        }

        private void lblUserSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Activate();
            frmInformaitonSinhVien frm_InfoSV = new frmInformaitonSinhVien();
            SendIdSV sendIdSV = new SendIdSV(frm_InfoSV.FunData);
            sendIdSV(this.lblMaSV.Text);
            frm_InfoSV.ShowDialog();
        }

        private void dgvDanhSachAccount_Click(object sender, EventArgs e)
        {
            //if(dgvDanhSachAccount.Rows.Count == 0)
            //{
            //    dgvDanhSachAccount.Enabled = false;
            //    MessageBox.Show("false");
            //}
            //else
            //{
            MessageBox.Show("" + dgvDanhSachAccount.Rows.Count);
            dgvDanhSachAccount.Enabled = true;
            MessageBox.Show("true");
            ShowInfoAdmin();
            //}
        }
    }
}
