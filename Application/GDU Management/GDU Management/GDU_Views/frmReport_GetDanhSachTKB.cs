using GDU_Management.Service;
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
    public partial class frmReport_GetDanhSachTKB : Form
    {
        public frmReport_GetDanhSachTKB()
        {
            InitializeComponent();
        }
        LopService lopService = new LopService();
        HocKyService hocKyService = new HocKyService();

        GDUManagement dt = new GDUManagement();
        private void frmReport_GetDanhSachTKB_Load(object sender, EventArgs e)
        {
            cboChonLop.DisplayMember = "TenLop";
            cboChonLop.ValueMember = "MaLop";
            cboChonLop.DataSource = lopService.GetAllLop();
            
        }

        private void cboChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
           cboChonHK.DisplayMember = "TenHocKy";
            cboChonHK.ValueMember = "MaHocKy";
            cboChonHK.DataSource = hocKyService.GetAllHocKy();
            
        }

        private void cboChonHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.get_ThoiKhoaBieuByHocKiTableAdapter.Fill(this.reporting.Get_ThoiKhoaBieuByHocKi, cboChonHK.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
