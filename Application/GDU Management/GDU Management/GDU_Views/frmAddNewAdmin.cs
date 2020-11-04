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

        //khai báo các service
        AdminService adminService = new AdminService();
        ContactService contactService = new ContactService();

        //public value
        string Id_Admin;

        //---------------------------DANH SÁCH HÀM PUBLIC------------------------------//
        //__________________________________________________________//
        
        //nhận id admin từ frmAccount
        public void FunData(string IDAdmin)
        {
            lblIDAdmin.Text = IDAdmin;
            Id_Admin = IDAdmin;
        }

        //load thông tin admin vào form
        public void LoadAdmin()
        {
            if(lblIDAdmin.Text != "??")
            {
                Admin ad = new Admin();
                ad = adminService.GetAdminByMaAdmin(lblIDAdmin.Text);
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
            this.Hide();
            frmAccount frm_acc = new frmAccount();
            frm_acc.ShowDialog();
        }

        private void frmAddNewAdmin_Load(object sender, EventArgs e)
        {
            LoadAdmin();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            if(Id_Admin == lblIDAdmin.Text)
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
                ad.StatusAcc = "Activate";

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
            else
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
                ad.Password = lblIDAdmin.Text.Trim();
                ad.StatusAcc = "Activate";
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
                LoadAdmin();
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
            picAvtAdmin.Image = Image.FromFile(@"..\..\Resources\avt006_admin_default_160x193.jpg");
        }
    }
}
