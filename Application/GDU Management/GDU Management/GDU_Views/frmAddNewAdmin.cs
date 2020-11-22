using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDU_Management.GDU_View;
using GDU_Management.Service;
using GDU_Management.Model;
using GDU_Management.Controller;
using System.IO;
using System.Text.RegularExpressions;

namespace GDU_Management.GDU_Views
{
    public partial class frmAddNewAdmin : Form
    {
        public frmAddNewAdmin()
        {
            InitializeComponent();
        }

        //controller
        SendMessageController sendMessageController = new SendMessageController();
        EncodingPasswordController encodingPasswordController = new EncodingPasswordController();

        //khai báo các service
        AdminService adminService = new AdminService();
        ContactService contactService = new ContactService();

        //delegate
        delegate void SendInforToFrmOther(string email);

        //public value
        string _Id_Admin;
        string _email;

        //---------------------------DANH SÁCH HÀM PUBLIC------------------------------//
        //__________________________________________________________//
        
        //nhận id admin từ frmAccount
        public void FunDataId(string IDAdmin)
        {
            _Id_Admin = IDAdmin;
            lblIDAdmin.Text =_Id_Admin;
        }

        //hàm nhận email;
        public void FunDataEmail(string email)
        {
            _email = email;
        }

        //load thông tin admin vào form
        public void LoadAdmin()
        {
            if(lblIDAdmin.Text != "???")
            {
                //MessageBox.Show(_Id_Admin);
                Admin ad = new Admin();
                ad = adminService.GetAdminByMaAdmin(_Id_Admin);
                txtTenAdmin.Text = ad.TenAdmin;
                txtSdt.Text = ad.SDT;
                txtEmail.Text = ad.Email;
                dtpNamSinh.Text = ad.NamSinh;
                rtxtDicChi.Text = ad.DiaChi;
                dtpStartingDate.Text = ad.StartDay;
                rtxtGhiChu.Text = ad.GhiChu;
                picAvtAdmin.Image = ByteArrayToImage(ad.Avt.ToArray());

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
            }
            else
            {
                AutoIdAdmin();
            }                
        }

        //auto ID Admin
        public void AutoIdAdmin()
        {
            int count = adminService.CountAdmin();
            if(count < 10)
            {
                lblIDAdmin.Text = "GDU00" + (count + 1);
            }
            else if(count < 100)
            {
                lblIDAdmin.Text = "GDU0" + (count + 1);
            }
            else if (count < 1000)
            {
                lblIDAdmin.Text = "GDU0" + (count + 1);
            }
        }


        //chuyển hình từ kiểu Image sang kiểu ByteArray  ==> Save image vào database
        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        //chuyển hình từ kiểu ByteArray sang kiểu Image  ==> Show image từ database lên form
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image imageOut = Image.FromStream(ms);
                return imageOut;
            }
        }

        public void SendMaillToAdmin()
        {
            InforContact inforContact = new InforContact();
            inforContact = contactService.InfoContact("6");
            string fromEmail = inforContact.Email;
            string toEmail = txtEmail.Text.Trim();
            string subEmail = inforContact.Subject;
            string InforAd = "----------------------------------------------------" + "\n" + txtTenAdmin.Text + " - " + lblIDAdmin.Text + "\n" + "----------------------------------------------------";
            string messEmail = inforContact.Message + "\n "+ InforAd+"\n"+inforContact.InfoOther ;
            sendMessageController.SendMailAddAdmin(fromEmail, toEmail, subEmail, messEmail);
        }

        //check quyền cảu user
        public bool CheckRoleUserLogin()
        {
            Admin ad = new Admin();
            ad = adminService.GetAdminByEmail(_email);
            if (ad.Role != "Ad")
            {
                return false;
            }
            return true;
        }

        public bool CheckDataAddUser()
        {
            if (string.IsNullOrEmpty(txtTenAdmin.Text.Trim()))
            {
                MessageBox.Show("Tên user không được bỏ trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenAdmin.Focus();
                return false;
            }

            //kiểm tra email
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                string email = txtEmail.Text;
                var value = email.EndsWith("@gmail.com");
                string reEmail = value.ToString();
                if (reEmail.Equals("False"))
                {
                    MessageBox.Show("Định dạng email không đúng, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
                var listEmailUser = adminService.GetAllAdmin();
                foreach (var emailUser in listEmailUser)
                {
                    if (txtEmail.Text.ToString() == emailUser.Email)
                    {
                        MessageBox.Show("Email Đã Tồn Tại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Email Không được bỏ trống, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            //kiểm tra sđt
            if (!string.IsNullOrEmpty(txtSdt.Text))
            {
                Regex isValidInput = new Regex(@"^\d{10}$");
                string sdt = txtSdt.Text.Trim();
                if (!isValidInput.IsMatch(sdt))
                {
                    MessageBox.Show("SĐT bao gồm 10 số và không có kí tự, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSdt.Focus();
                    return false;
                }
                var listSdtUser = adminService.GetAllAdmin();
                foreach (var sdtUser in listSdtUser)
                {
                    if (txtSdt.Text.ToString() == sdtUser.SDT)
                    {
                        MessageBox.Show("SĐT Đã Tồn Tại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

            }
            else
            {
                MessageBox.Show("SĐT Không được bỏ trống, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
                return false;
            }

            //kiem tra dia chi
            if (string.IsNullOrEmpty(rtxtDicChi.Text.Trim()))
            {
                MessageBox.Show("Địa chỉ không được bỏ trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtxtDicChi.Focus();
                return false;
            }

            return true;
        }

        public bool CheckDataUpdateUser()
        {
            if (string.IsNullOrEmpty(txtTenAdmin.Text.Trim()))
            {
                MessageBox.Show("Tên user không được bỏ trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenAdmin.Focus();
                return false;
            }

            //kiểm tra email
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                string email = txtEmail.Text;
                var value = email.EndsWith("@gmail.com");
                string reEmail = value.ToString();
                if (reEmail.Equals("False"))
                {
                    MessageBox.Show("Định dạng email không đúng, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Email Không được bỏ trống, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            //kiểm tra sđt
            if (!string.IsNullOrEmpty(txtSdt.Text))
            {
                Regex isValidInput = new Regex(@"^\d{10}$");
                string sdt = txtSdt.Text.Trim();
                if (!isValidInput.IsMatch(sdt))
                {
                    MessageBox.Show("SĐT bao gồm 10 số và không có kí tự, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSdt.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("SĐT Không được bỏ trống, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
                return false;
            }

            //kiem tra dia chi
            if (string.IsNullOrEmpty(rtxtDicChi.Text.Trim()))
            {
                MessageBox.Show("Địa chỉ không được bỏ trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtxtDicChi.Focus();
                return false;
            }

            return true;
        }

        //---------------------------KẾT THÚC HÀM PUBLIC---------------------------------//
        //__________________________________________________________//


        private void picAvtAdmin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picAvtAdmin.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmAccount frm_acc = new frmAccount();
            SendInforToFrmOther sendEmail = new SendInforToFrmOther(frm_acc.FunDataFrmOther);
            sendEmail(this._email);
            frm_acc.ShowDialog();
        }

        private void frmAddNewAdmin_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("id nhan dc: " + _Id_Admin + " - emal nhan dc: " + _email);
            LoadAdmin();
            if (CheckRoleUserLogin())
            {
                lblAddNewAdmin.Enabled = true;
                txtEmail.Enabled = true;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            if(_Id_Admin == lblIDAdmin.Text)
            {
                if (CheckDataUpdateUser())
                {

                //UPDATE
                ad.MaAdmin = lblIDAdmin.Text.Trim();
                ad.TenAdmin=txtTenAdmin.Text.Trim();
                ad.SDT=txtSdt.Text.Trim();
                ad.Email=txtEmail.Text.Trim();
                ad.DiaChi=rtxtDicChi.Text.Trim();
                ad.GhiChu=rtxtGhiChu.Text.Trim();
                ad.NamSinh = dtpNamSinh.Text.ToString().Trim();
                ad.StartDay = dtpStartingDate.Text.ToString().Trim();

                //update avatar
                byte[] Image_admin = ImageToByteArray(picAvtAdmin.Image);   //lấy image từ picturebox
                System.Data.Linq.Binary img = new System.Data.Linq.Binary(Image_admin);     //chuyển image từ kiểu image về kiểu ByteArray
                ad.Avt = img;

                //update gioi tinh
                string gioiTinh;
                if (radNam.Checked)
                {
                    gioiTinh = "Nam";
                }
                else
                {
                    gioiTinh = "Nữ";
                }
                ad.GioiTinh = gioiTinh;
                adminService.UpdateAdmin(ad);
                LoadAdmin();
                MessageBox.Show("Update Information Successfully...<-/>!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (CheckDataAddUser())
                {
                SendMaillToAdmin();
                //SAVE
                ad.MaAdmin = lblIDAdmin.Text.Trim();
                ad.TenAdmin = txtTenAdmin.Text.Trim();
                ad.SDT = txtSdt.Text.Trim();
                ad.Email = txtEmail.Text.Trim();
                ad.DiaChi = rtxtDicChi.Text.Trim();
                ad.GhiChu = rtxtGhiChu.Text.Trim();
                ad.NamSinh = dtpNamSinh.Text.ToString().Trim();
                ad.StartDay = dtpStartingDate.Text.ToString().Trim();
                ad.StatusAcc = "Activate";
                    ad.Role = "Emp";
                //mã hóa password
                string maHocDES = encodingPasswordController.EncryptionByDES(lblIDAdmin.Text.Trim(), "GDUmanagement-User");
                string maHoaMD5 = encodingPasswordController.EncryptionByMD5(maHocDES);
                ad.Password = maHocDES + maHoaMD5;
                
                //iamge
                byte[] Image_admin = ImageToByteArray(picAvtAdmin.Image);   //lấy image từ picturebox
                System.Data.Linq.Binary img = new System.Data.Linq.Binary(Image_admin);  //chuyển image từ kiểu image về kiểu ByteArray
                ad.Avt = img;

                string gioiTinh;
                if (radNam.Checked)
                {
                    gioiTinh = "Nam";
                }
                else
                {
                    gioiTinh = "Nữ";
                }
                ad.GioiTinh = gioiTinh;
                adminService.CreateAdmin(ad);
                MessageBox.Show("Saved Successfully...<-/>!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //LoadAdmin();
                }
            }
        }

        private void lblAddNewAdmin_Click(object sender, EventArgs e)
        {
            AutoIdAdmin();
            txtTenAdmin.Focus();
            txtTenAdmin.Clear();
            txtEmail.Clear();
            txtSdt.Clear();
            rtxtDicChi.Clear();
            rtxtGhiChu.Clear();
            txtEmail.Enabled = true;
            picAvtAdmin.Image = Image.FromFile(@"..\..\Resources\avt006_admin_default_160x193.jpg");
        }
    }
}
