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
    public partial class frmOptionPrint : Form
    {
        public frmOptionPrint()
        {
            InitializeComponent();
        }

        private void btnInTheoMH_Click(object sender, EventArgs e)
        {
            frmReport_GetDanhSachDiemSinhVien xem = new frmReport_GetDanhSachDiemSinhVien();
            xem.ShowDialog();
        }

        private void btnInTheoSV_Click(object sender, EventArgs e)
        {
            frmReport_GetAllDiemBySinhVien xem = new frmReport_GetAllDiemBySinhVien();
            xem.ShowDialog();
        }
    }
}
