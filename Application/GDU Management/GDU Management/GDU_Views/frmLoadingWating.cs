using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDU_Management.Controller;
using GDU_Management.Model;
using GDU_Management.Service;


namespace GDU_Management.GDU_Views
{
    public partial class frmLoadingWating : Form
    {
        public frmLoadingWating()
        {
            InitializeComponent();
            timerLoadingWaiting.Start();
        }

        //khai bao controller
        SendMessageController sendMessage = new SendMessageController();

        //khai bao service
        ContactService contactService = new ContactService();

        //public value
        string _email;
        string _name;
        string _Id;
        int _countSendMaill;

        //hàm fundata nhận email từ form QLSV
        public void FunDataEmailFromQLSV(string email, string id, string name)
        {
            _email = email;
            _Id = id;
            _name = name;
        }

        public void SendMaillAddSinhVienSuccessfully()
        {
            InforContact contacts = new InforContact();
            contacts = contactService.InfoContact("1");
            string from = contacts.Email;
            string to = _email;
            string subject = contacts.Subject;
            string InfoSV = "---------------------------------------------------------" + "\n" + _Id + " - " + _name + "\n" + "---------------------------------------------------------"+ "\n--------------------------------------------------------------------------------------";
            string message = contacts.Message + "\n" + InfoSV + "\n" + contacts.InfoOther;
            sendMessage.SendMaillAddSinhVien(from, to, subject, message);
            _countSendMaill++;
        }

        private void timerLoadingWaiting_Tick(object sender, EventArgs e)
        {
            if(_countSendMaill >= 1)
            {
                this.Close();
            }
            else
            {
                SendMaillAddSinhVienSuccessfully();
            }
        }
    }
}
