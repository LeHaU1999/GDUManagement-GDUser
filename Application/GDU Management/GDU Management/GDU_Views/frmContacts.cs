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
using System.Net;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Web;
using FluentValidation.Validators;


namespace GDU_Management.GDU_Views
{
    public partial class frmContacts : Form
    {
        public frmContacts()
        {
            InitializeComponent();
        }

        //khai báo các service 
        ContactService contactService = new ContactService();

        //khai báo các value public

        //các hàm public
        public void LoadContacts()
        {
            cboChonContacts.DataSource = contactService.GetAllContact().ToList();
            cboChonContacts.DisplayMember = "TenContacts";
            cboChonContacts.ValueMember = "ID";
         }

        //check data
        public bool checkDataContacts()
        {
            if (!string.IsNullOrEmpty(txtEmailContacts.Text))
            {
                checkEmail();
            }
            else
            {
                MessageBox.Show("Email không được để trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailContacts.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtEmailContacts.Text))
            {
                MessageBox.Show("Password Email không được để trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassContacts.Focus();
                return false;
            }
            return true;
        }

        //kiem tra maill
        public bool VerifyEmail(string emailVerify)
        {
            using (WebClient webclient = new WebClient())
            {
                string url = "http://verify-email.org/";
                NameValueCollection formData = new NameValueCollection();
                formData["check"] = emailVerify;
                byte[] responseBytes = webclient.UploadValues(url, "POST", formData);
                string response = Encoding.ASCII.GetString(responseBytes);
                if (response.Contains("Result: Ok"))
                {
                    return true;
                }
                return false;
            }
        }

        public bool  checkEmail()
        {
            //string input = txtEmailContacts.Text;
            //string pattern = "\n";
            //string[] emails = Regex.Split(input, pattern);

            //for (int i = 0; i < emails.Length; i++)
            //{
            //    ListViewItem itemp = new ListViewItem(emails[i]);
            //    bool check = VerifyEmail(emails[i]);
            //    if (check == true)
            //    {
            //        MessageBox.Show("email ton tai");
            //        return true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("email KHOONG ton tai");
            //        return false;
            //    }
            //}
            return true;
        }


       
        //kết thúc các hàm public

        private void frmContacts_Load(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkDataContacts())
            {
                InforContact contacts = new InforContact();
                MessageBox.Show(cboChonContacts.SelectedValue.ToString());
                contacts.ID = cboChonContacts.SelectedValue.ToString().Trim();
                contacts.Email = txtEmailContacts.Text;
                contacts.Pass = txtPassContacts.Text;
                contacts.Subject = rtxtTitle.Text;
                contacts.Message = rtxtMessage.Text;
                contacts.InfoOther = rtxtInforOther.Text;
                contactService.InsertContacts(contacts);
                MessageBox.Show("Update successful </> !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtxtTitle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtTitle.Text))
            {
                rtxtTitle.Text = "Title";
            }
        }

        private void rtxtMessage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtMessage.Text))
            {
                rtxtMessage.Text = "Message";
            }
        }

        private void rtxtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtInforOther.Text))
            {
                rtxtInforOther.Text = "Information";
            }
        }

        private void cboChonContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cboChonContacts.SelectedValue.ToString();
            switch (id)
            {
                case "1":
                    {
                        InforContact InfoContacts = new InforContact();
                        InfoContacts = contactService.InfoContact(cboChonContacts.SelectedValue.ToString());
                        txtEmailContacts.Text = InfoContacts.Email;
                        txtPassContacts.Text = InfoContacts.Pass;
                        rtxtTitle.Text = InfoContacts.Subject;
                        rtxtMessage.Text = InfoContacts.Message;
                        rtxtInforOther.Text = InfoContacts.InfoOther;
                        break;
                    }
                case "2":
                    {
                        InforContact InfoContacts = new InforContact();
                        InfoContacts = contactService.InfoContact(cboChonContacts.SelectedValue.ToString());
                        txtEmailContacts.Text = InfoContacts.Email;
                        txtPassContacts.Text = InfoContacts.Pass;
                        rtxtTitle.Text = InfoContacts.Subject;
                        rtxtMessage.Text = InfoContacts.Message;
                        rtxtInforOther.Text = InfoContacts.InfoOther;
                        break;
                    }
                case "3":
                    {
                        InforContact InfoContacts = new InforContact();
                        InfoContacts = contactService.InfoContact(cboChonContacts.SelectedValue.ToString());
                        txtEmailContacts.Text = InfoContacts.Email;
                        txtPassContacts.Text = InfoContacts.Pass;
                        rtxtTitle.Text = InfoContacts.Subject;
                        rtxtMessage.Text = InfoContacts.Message;
                        rtxtInforOther.Text = InfoContacts.InfoOther;
                        break;
                    }
                case "4":
                    {
                        InforContact InfoContacts = new InforContact();
                        InfoContacts = contactService.InfoContact(cboChonContacts.SelectedValue.ToString());
                        txtEmailContacts.Text = InfoContacts.Email;
                        txtPassContacts.Text = InfoContacts.Pass;
                        rtxtTitle.Text = InfoContacts.Subject;
                        rtxtMessage.Text = InfoContacts.Message;
                        rtxtInforOther.Text = InfoContacts.InfoOther;
                        break;
                    }
                case "5":
                    {
                        InforContact InfoContacts = new InforContact();
                        InfoContacts = contactService.InfoContact(cboChonContacts.SelectedValue.ToString());
                        txtEmailContacts.Text = InfoContacts.Email;
                        txtPassContacts.Text = InfoContacts.Pass;
                        rtxtTitle.Text = InfoContacts.Subject;
                        rtxtMessage.Text = InfoContacts.Message;
                        rtxtInforOther.Text = InfoContacts.InfoOther;
                        break;
                    }
                case "6":
                    {
                        InforContact InfoContacts = new InforContact();
                        InfoContacts = contactService.InfoContact(cboChonContacts.SelectedValue.ToString());
                        txtEmailContacts.Text = InfoContacts.Email;
                        txtPassContacts.Text = InfoContacts.Pass;
                        rtxtTitle.Text = InfoContacts.Subject;
                        rtxtMessage.Text = InfoContacts.Message;
                        rtxtInforOther.Text = InfoContacts.InfoOther;
                        break;
                    }
                default: LoadContacts(); break;
            }
        }
    }
}
