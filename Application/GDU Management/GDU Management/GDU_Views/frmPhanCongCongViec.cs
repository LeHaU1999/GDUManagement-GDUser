using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDU_Management
{
    public partial class frmPhanCongCongViec : Form
    {
        public frmPhanCongCongViec()
        {
            InitializeComponent();
        }

        private void lblReturnGDU_Click(object sender, EventArgs e)
        {
            this.Hide();
            GDUManagement gdu = new GDUManagement();
            gdu.ShowDialog();
        }
    }
}
