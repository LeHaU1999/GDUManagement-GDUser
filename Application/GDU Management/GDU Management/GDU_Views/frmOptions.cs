using GDU_Management.GDU_View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDU_Management.GDU_Views
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        string _emailAdmin;
        public void FunDataOption(string emailAd)
        {
            _emailAdmin = emailAd;
        }

        private void lblManagerAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccount frm_acc = new frmAccount();
            frm_acc.ShowDialog();
        }

        private void lblContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmContacts frm_cts = new frmContacts();
            frm_cts.ShowDialog();
        }

        private void lblCloseOption_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
