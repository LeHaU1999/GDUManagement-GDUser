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
using GDU_Management.Controller;

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

        //controller
        EncodingPasswordController encodingPasswordController = new EncodingPasswordController();

        //public value
        string _ID_Admin;
        string _ID_GV;
        string _ID_SV;
        string _email;
        string _passAd;
        string _passGV;
        string _passSV;
        bool _showPassAdmin = true;
        bool _showPassGV = true;
        bool _showPassSV = true;

        //delegate truyền id qua form khác(AddNewAdmin)
        delegate void SendInforADmin(string inforAd );
        delegate void SendIdSV(string dlgIDSV);


        //---------------------------DANH SÁCH HÀM PUBLIC------------------------------//
        //__________________________________________________________//

        //nhận email ddac gửi từ form khác đến
        public void FunDataFrmOther(string emailAD)
        {
            _email = emailAD;
        }

        public void StartDefault()
        {
            lblShowPassAdmin.Hide();
            lblShowPassGiangVien.Hide();
            lblShowPassSinhVien.Hide();
        }

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

        //hàm load data Admin vào dgv
        public void LoadAdminToDgv()
        {
            dgvDanhSachAccountAdmin.DataSource = adminService.GetAllAdmin();
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
            _ID_Admin = dgvDanhSachAccountAdmin.CurrentRow.Cells[1].Value.ToString().Trim();
            Admin admin = new Admin();
            admin = adminService.GetAdminByMaAdmin(_ID_Admin);
            txtEmailAdmin.Text = admin.Email;
            txtPassAdmin.Text = "????????";
            if(admin.Avt != null)
            {
                picAvtAdmin.Image = ByteArrayToImage(admin.Avt.ToArray());
            }
            else
            {
                picAvtAdmin.Image = Image.FromFile(@"..\..\Resources\avt006_admin_default_160x193.jpg");
            }
           
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
        }

        //show data giảng viên lên các field
        public void ShowInfoGiangVien()
        {
            
            _ID_GV = dgvDSAccountGiangVien.CurrentRow.Cells[1].Value.ToString().Trim();
            GiangVien gv = new GiangVien();
            gv = giangVienService.GetGiangVienByMaGV(_ID_GV);
            txtEmailGiangVien.Text = gv.Email;
            txtPassGiangVien.Text = "????????";
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
            _ID_SV = dgvDSAccountSinhVien.CurrentRow.Cells[1].Value.ToString();
            SinhVien sv = new SinhVien();
            sv = sinhVienService.GetSinhVienByMaSinhVien(_ID_SV);
            txtEmailSV.Text = sv.Email;
            txtPassSV.Text = "????????";
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
            for(int i = 0; i < dgvDanhSachAccountAdmin.Rows.Count; i++)
            {
                dgvDanhSachAccountAdmin.Rows[i].Cells[0].Value = (i + 1);
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


        //kiểm tra quyền người đang đăng nhập
        public bool CheckRoleUserLogin()
        {
            Admin ad = new Admin();
            ad = adminService.GetAdminByEmail(_email);
            if(ad.Role != "Ad")
            {
                return false;
            }
            return true;
        }

        //show thông tin user không phải là admin
        public void ShowInfoUserNonAdmin(string email)
        {
            Admin ad = new Admin();
            ad = adminService.GetAdminByEmail(_email);
            txtEmailAdmin.Text = ad.Email;
            txtPassAdmin.Text = "????????";
            lblIdAdmin.Text = ad.MaAdmin;
            txtTenAdmin.Text = ad.TenAdmin;

            string gioiTinh = ad.GioiTinh;
            if (gioiTinh == "Nam")
            {
                radNam.Checked = true;
                radNu.Checked = false;
            }
            else
            {
                radNam.Checked = false;
                radNu.Checked = true;
            }

            if (ad.Avt != null)
            {
                picAvtAdmin.Image = ByteArrayToImage(ad.Avt.ToArray());
            }
            else
            {
                picAvtAdmin.Image = Image.FromFile(@"..\..\Resources\avt006_admin_default_160x193.jpg");
            }

            dtpNamSinhAdmin.Text = ad.NamSinh;
            txtSDTAdmin.Text = ad.SDT;
            lblStartDayAdmin.Text = ad.StartDay;
        }

        //mã hóa pass user
        public string EncodingPasswordUser(string password)
        {
            string maHoaDES = encodingPasswordController.EncryptionByDES(password, "GDUmanagement-User");
            string maHoaMD5 = encodingPasswordController.EncryptionByMD5(maHoaDES);
            string passEncoding = maHoaDES + maHoaMD5;
            return passEncoding;
        }

        //mã hóa pass giảng viên
        public string EncodingPasswordLecturers(string password)
        {
            string maHoaDES = encodingPasswordController.EncryptionByDES(password, "GDUmanagement-Lecturers");
            string maHoaMD5 = encodingPasswordController.EncryptionByMD5(maHoaDES);
            string passEncoding = maHoaDES + maHoaMD5;
            return passEncoding;
        }

        //mã hóa pass sinh viên
        public string EncodingPasswordStudent(string password)
        {
            string maHoaDES = encodingPasswordController.EncryptionByDES(password, "GDUmanagement-Student");
            string maHoaMD5 = encodingPasswordController.EncryptionByMD5(maHoaDES);
            string passEncoding = maHoaDES + maHoaMD5;
            return passEncoding;
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
            if (CheckRoleUserLogin())
            {
                LoadAdminToDgv();
                
            }
            else
            {
                dgvDanhSachAccountAdmin.Enabled = false;
                ShowInfoUserNonAdmin(_email);
                lblStatusAdmin.Hide();
            }
            LoadGiangVienToDgv();
            LoadSinhVienToDgv();
            StartDefault();
        }

        private void dgvDanhSachAccount_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvDanhSachAccountAdmin.Rows.Count == 0)
            {
                dgvDanhSachAccountAdmin.Enabled = false;
            }
            else
            {
                dgvDanhSachAccountAdmin.Enabled = true;
                ShowInfoAdmin();
                lblAddNewAdmin.Enabled = true;
            }
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
            if (lblStatusGV.BackColor == Color.Lime)
            {
                lblStatusGV.BackColor = Color.Red;
            }
            else if (lblStatusGV.BackColor == Color.Red)
            {
                lblStatusGV.BackColor = Color.Lime;
            }
        }

        private void lblStatusSinhVien_Click(object sender, EventArgs e)
        {
            if (lblStatusSV.BackColor == Color.Lime)
            {
                lblStatusSV.BackColor = Color.Red;
            }
            else if (lblStatusSV.BackColor == Color.Red)
            {
                lblStatusSV.BackColor = Color.Lime;
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
                    statusAcc = "Not Exist";
                }

                byte[] Image_admin = ImageToByteArray(picAvtAdmin.Image);
                System.Data.Linq.Binary img = new System.Data.Linq.Binary(Image_admin);

                Admin admin = new Admin();
                admin.MaAdmin = lblIdAdmin.Text.Trim();
                // mã hóa password
                admin.Password = EncodingPasswordUser(_passAd);
                //admin.Avt = img;
                admin.StatusAcc = statusAcc;
                adminService.UpadteAccount(admin);
                lblShowPassAdmin.Hide();
                LoadAdminToDgv();
                MessageBox.Show("Update Account Successfully </> ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblUpdateAdmin_Click(object sender, EventArgs e)
        {
            if(txtEmailAdmin.Text == _email)
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
                    if (checkDataAccountAdmin())
                    {
                        LoadAdminToDgv();
                        ShowInfoAdmin();
                    }
                    else
                    {
                        ShowInfoUserNonAdmin(_email);
                    }
                    MessageBox.Show("Update Information  Successfully </> ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                //mã hóa pass
                // gv.Password = EncodingPasswordLecturers(_passGV);
                gv.Password = txtPassGiangVien.Text;
                gv.StatusAcc = statusGVAcc;
                giangVienService.UpdateAccountGiangVien(gv);
                ShowInfoGiangVien();
                MessageBox.Show("Update Successfully </> ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                // sv.Password = EncodingPasswordStudent(_passSV);
                sv.Password = txtPassSV.Text;
                sv.StatusAcc = statusSVAcc;
                sinhVienService.UpdateAccountSinhVien(sv);
                MessageBox.Show("Update Successfully </> ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblAddNewAdmin_Click(object sender, EventArgs e)
        {
            frmAddNewAdmin frm_AddNewAdmin = new frmAddNewAdmin();
            SendInforADmin sendID = new SendInforADmin(frm_AddNewAdmin.FunDataId);
            sendID(this.lblIdAdmin.Text);

            SendInforADmin sendEmail = new SendInforADmin(frm_AddNewAdmin.FunDataEmail);
            sendEmail(this._email);

            frm_AddNewAdmin.ShowDialog();
            this.Hide();
            this.Close();
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

        }

        private void txtPassAdmin_Click(object sender, EventArgs e)
        {
            txtPassAdmin.Clear();
        }

        private void txtPassGiangVien_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassGiangVien.Clear();

        }

        private void txtPassSV_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassSV.Clear();
        }

        private void txtPassAdmin_TextChanged(object sender, EventArgs e)
        {
            _passAd = txtPassAdmin.Text.Trim();
            if (txtPassAdmin.Text != "????????")
            {
                lblShowPassAdmin.Show();
            }
        }

        private void txtPassGiangVien_TextChanged(object sender, EventArgs e)
        {
            _passGV = txtPassGiangVien.Text.Trim();
            if (txtPassGiangVien.Text != "????????")
            {
                lblShowPassGiangVien.Show();
            }
        }

        private void txtPassSV_TextChanged(object sender, EventArgs e)
        {
            _passSV = txtPassSV.Text.Trim();
            if (txtPassSV.Text != "????????")
            {
                lblShowPassSinhVien.Show();
            }
        }

        private void lblShowPassAdmin_Click(object sender, EventArgs e)
        {
            if (_showPassAdmin)
            {
                txtPassAdmin.PasswordChar = '\0';
                lblShowPassAdmin.Image = Image.FromFile(@"..\..\Resources\icons8-forgot-password-24.png");
                _showPassAdmin = false;
            }
            else
            {
                txtPassAdmin.PasswordChar = '●';
                lblShowPassAdmin.Image = Image.FromFile(@"..\..\Resources\icons8-eye-24.png");
                _showPassAdmin = true;
            }
        }

        private void lblShowPassGiangVien_Click(object sender, EventArgs e)
        {
            if (_showPassGV)
            {
                txtPassGiangVien.PasswordChar = '\0';
                lblShowPassGiangVien.Image = Image.FromFile(@"..\..\Resources\icons8-forgot-password-24.png");
                _showPassGV = false;
            }
            else
            {
                txtPassGiangVien.PasswordChar = '●';
                lblShowPassGiangVien.Image = Image.FromFile(@"..\..\Resources\icons8-eye-24.png");
                _showPassGV = true;
            }
        }

        private void lblShowPassSinhVien_Click(object sender, EventArgs e)
        {
            if (_showPassSV)
            {
                txtPassSV.PasswordChar = '\0';
                lblShowPassSinhVien.Image = Image.FromFile(@"..\..\Resources\icons8-forgot-password-24.png");
                _showPassSV = false;
            }
            else
            {
                txtPassSV.PasswordChar = '●';
                lblShowPassSinhVien.Image = Image.FromFile(@"..\..\Resources\icons8-eye-24.png");
                _showPassSV = true;
            }
        }

       
    }
}
