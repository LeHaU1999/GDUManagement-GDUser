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

namespace GDU_Management
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //delegate
        delegate void SendEmailAdminToFrmOther(string emailAdmin);

        // service
        AdminService adminService = new AdminService();

        public void checkLogin()
        {
            if (string.IsNullOrEmpty(txtPassword.Text)  || string.IsNullOrEmpty(txtUsername.Text))
            {
                btnLogin.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
            }
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            txtUsername.Text = "1";
            txtPassword.Text = "1";
        }

        private void lblReset_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            var login = adminService.LoginToSystem(txtUsername.Text, txtPassword.Text);
            if (login.Any())
            {
                ad = adminService.GetAdminByEmail(txtUsername.Text);
                if (ad.StatusAcc.Equals("Lock"))
                {
                    MessageBox.Show("Tài Khoản đã bị khóa. Liên hệ admin để mở khóa tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Hide();
                    GDUManagement gdu = new GDUManagement();
                    SendEmailAdminToFrmOther sendEmailAdminToFrm = new SendEmailAdminToFrmOther(gdu.FunData);
                    sendEmailAdminToFrm(txtUsername.Text.ToString().Trim());
                    gdu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Sai Tên tài khoản hoặc mật khẩu. (-__-) !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }          
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }


        //--------------------Design Hover Start-------------------------------------//
        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            this.btnExit.ForeColor = Color.DarkOrchid;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.ForeColor = Color.DarkSlateBlue;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            
            this.btnLogin.ForeColor = Color.SlateBlue;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogin.ForeColor = Color.Blue;
        }
        //--------------------Design Hover End-------------------------------------//
      
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            checkLogin();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            checkLogin();
        }


       
    }
}
