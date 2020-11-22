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
    class SendMessageController
    {
        //khai bao cac service 
        ContactService contactService = new ContactService();

        //kiểm tra máy có kết nối internet hay không
        public bool IsConnectedToInternet()
        {
            try
            {
                System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Gui Maill Thông báo Sinh Viên tk đã đc đk
        public void SendMaillAddSinhVien(string from, string to, string subject, string message)
        {
            if (IsConnectedToInternet())
            {
                InforContact contact = new InforContact();
                contact = contactService.InfoContact("1");
                MailMessage maillMessage = new MailMessage(from, to, subject, message);
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(contact.Email, contact.Pass);
                client.Send(maillMessage);
            }
        }

        public void SendMaillUpdateSinhVien(string from, string to, string subject, string message)
        {
            if (IsConnectedToInternet())
            {
                InforContact contact = new InforContact();
                contact = contactService.InfoContact("2");
                MailMessage maillMessage = new MailMessage(from, to, subject, message);
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(contact.Email, contact.Pass);
                client.Send(maillMessage);
            }
        }

        public void SendMaillAddGiangVien(string from, string to, string subject, string message)
        {/*
            if (IsConnectedToInternet())
            {
                InforContact contact = new InforContact();
                contact = contactService.InfoContact("3");
                MailMessage maillMessage = new MailMessage(from, to, subject, message);
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(contact.Email, contact.Pass);
                client.Send(maillMessage);
            }
            */
        }

        public void SendMaillUpdateGiangVien(string from, string to, string subject, string message)
        {
            /*
            if (IsConnectedToInternet())
            {
                InforContact contact = new InforContact();
                contact = contactService.InfoContact("4");
                MailMessage maillMessage = new MailMessage(from, to, subject, message);
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(contact.Email, contact.Pass);
                client.Send(maillMessage);
            }
            */
        }

        public void SendVerificationCode(string from, string to, string subject, string message)
        {
            /*
            if (IsConnectedToInternet())
            {
                InforContact contact = new InforContact();
                contact = contactService.InfoContact("5");
                MailMessage maillMessage = new MailMessage(from, to, subject, message);
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(contact.Email, contact.Pass);
                client.Send(maillMessage);
            }
            */
        }

        public void SendMailAddAdmin(string from, string to, string subject, string message)
        {
            /*
            if (IsConnectedToInternet())
            {
                InforContact contact = new InforContact();
                contact = contactService.InfoContact("6");
                MailMessage maillMessage = new MailMessage(from, to, subject, message);
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(contact.Email, contact.Pass);
                client.Send(maillMessage);
            }
            */
        }
    }
}
