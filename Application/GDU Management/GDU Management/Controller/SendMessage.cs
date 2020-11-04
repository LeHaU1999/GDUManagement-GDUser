using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using GDU_Management.Model;
using GDU_Management.Service;

namespace GDU_Management.Controller
{
    class SendMessage
    {
        //khai bao cac service 
        ContactService contactService = new ContactService();
        

        //Gui Maill Thông báo tk đã đc đk
        public void SendMaillToSinhVien(string from, string to, string title, string message)
        {
            Contact contact = new Contact();
            contact = contactService.GetContact();

            MailMessage maillMessage = new MailMessage(from, to, title, message);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(contact.Email, contact.Pass);
            client.Send(maillMessage);
        }
    }
}
