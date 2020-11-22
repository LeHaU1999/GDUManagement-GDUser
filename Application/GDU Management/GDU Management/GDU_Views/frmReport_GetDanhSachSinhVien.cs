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
    public partial class frmReport_GetDanhSachSinhVien : Form
    {
        public frmReport_GetDanhSachSinhVien()
        {
            InitializeComponent();
        }

        KhoaService khoaService = new KhoaService();
        NganhHocService nganhHocService = new NganhHocService();
        KhoasHocService khoasHocService = new KhoasHocService();
        LopService lopService = new LopService();

        GDUManagement dt = new GDUManagement();

        private void frmReport_GetDanhSachSinhVien_Load(object sender, EventArgs e)
        {
            cboChonKhoa.DataSource = khoaService.GetAllKhoa();
            cboChonKhoa.DisplayMember = "TenKhoa";
            cboChonKhoa.ValueMember = "MaKhoa";
            
        }

        private void cboChonKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoa = cboChonKhoa.SelectedValue.ToString();
            cboChonNganh.DataSource = nganhHocService.GetNganhHocByKHOA(maKhoa);
            cboChonNganh.DisplayMember = "TenNganh";
            cboChonNganh.ValueMember = "MaNganh";
        }

        private void cboChonNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboChonKhoaHoc.DataSource = khoasHocService.GetAllKhoaHoc();
            cboChonKhoaHoc.DisplayMember = "TenKhoaHoc";
            cboChonKhoaHoc.ValueMember = "MaKhoaHoc";
        }

        private void cboChonKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNganh = cboChonNganh.SelectedValue.ToString();
            string maKhoaHoc = cboChonKhoaHoc.SelectedValue.ToString();
            cboChonLop.DataSource = lopService.GetDanhSachLopByMaNganhVaMaKhoaHoc(maNganh, maKhoaHoc);
            cboChonLop.DisplayMember = "TenLop";
            cboChonLop.ValueMember = "MaLop";
        }

        private void cboChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.get_SinhVienLopKhoaHocTableAdapter.Fill(this.reporting.Get_SinhVienLopKhoaHoc, cboChonLop.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
