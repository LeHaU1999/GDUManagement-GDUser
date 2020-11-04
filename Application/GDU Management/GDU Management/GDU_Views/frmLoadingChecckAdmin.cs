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
using GDU_Management.Controller;
using GDU_Management.GDU_Views;

namespace GDU_Management.GDU_Views
{
    public partial class frmLoadingChecckAdmin : Form
    {
        public frmLoadingChecckAdmin()
        {
            InitializeComponent();
            timerLoading.Start();
        }
        //service 
        CheckAccountService checkAccountService = new CheckAccountService();
        ContactService contactService = new ContactService();
        AdminService adminService = new AdminService();

        //controller
        RandomCodeControlller rd = new RandomCodeControlller();
        SendMessageController sendMessage = new SendMessageController();

        //public value
        string _email;
        string _VerificationCode;
        int time = 0;
        int countSend = 0;



        //nhận email admin từ form login
        public void FunDataFromGDU(string emailAdmin)
        {
            _email = emailAdmin;
        }

        //hàm tạo mã xác nhận r lưu vào database
        public void CreateVerificationCode()
        {
            Admin ad = new Admin();
            ad = adminService.GetAdminByEmail(_email);
            _VerificationCode = rd.VerificationCode();
            CheckAccount chkAcc = new CheckAccount();
            chkAcc.MaAdmin = ad.MaAdmin;
            chkAcc.Code = _VerificationCode;
            checkAccountService.CheckAcc(chkAcc);
           
        }


        //gửi mã xác nhận đến admin
        public void SendVerificationCodeToAdmin()
        {
            CreateVerificationCode();
            InforContact contacts = new InforContact();
            contacts = contactService.InfoContact("5");
            string fromEmail = contacts.Email;
            string toEmail = _email;
            string subEmail = contacts.Subject;
            string messEmail = contacts.Message + "\n";
            string code = "-------------------" + "\n" + _VerificationCode + "\n" + "-------------------" + "\n" + contacts.InfoOther;
            sendMessage.SendVerificationCode(fromEmail, toEmail, subEmail, messEmail + code);
            countSend++;
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            time++;
           if(countSend == 1)
            {
                this.Close();
            }
           else
            {
                SendVerificationCodeToAdmin();
            }
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            
        }
    }
}
