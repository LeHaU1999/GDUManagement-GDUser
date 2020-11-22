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
    public partial class frmReport_GetGiangVien : Form
    {
        public frmReport_GetGiangVien()
        {
            InitializeComponent();
        }

        KhoaService khoaService = new KhoaService();
        NganhHocService nganhHocService = new NganhHocService();

        GDUManagement dt = new GDUManagement();

        private void frmReport_GetGiangVien_Load(object sender, EventArgs e)
        {
            cboChonKhoa.DisplayMember = "TenKhoa";
            cboChonKhoa.ValueMember = "MaKhoa";
            cboChonKhoa.DataSource = khoaService.GetAllKhoa();

            
        }

        private void cboChonKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboChonNganh.DataSource = nganhHocService.GetNganhHocByKHOA(cboChonKhoa.SelectedValue.ToString().Trim());
            cboChonNganh.DisplayMember = "TenNganh";
            cboChonNganh.ValueMember = "MaNganh";
        }

        private void cboChonNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.get_GiangVienByNganhTableAdapter.Fill(this.reporting.Get_GiangVienByNganh, cboChonNganh.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
