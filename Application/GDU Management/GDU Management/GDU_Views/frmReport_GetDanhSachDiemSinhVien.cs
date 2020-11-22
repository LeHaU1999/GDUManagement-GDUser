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
    public partial class frmReport_GetDanhSachDiemSinhVien : Form
    {
        public frmReport_GetDanhSachDiemSinhVien()
        {
            InitializeComponent();
        }

        MonHocService monHocService = new MonHocService();
        KhoaService khoaService = new KhoaService();
        NganhHocService nganhHocService = new NganhHocService();
        KhoasHocService khoaHocService = new KhoasHocService();
        LopService lopService = new LopService();

        GDUManagement dt = new GDUManagement();


        private void frmReport_GetDanhSachDiemSinhVien_Load(object sender, EventArgs e)
        {
            cboChonKhoa.DisplayMember = "TenKhoa";
            cboChonKhoa.ValueMember = "MaKhoa";
            cboChonKhoa.DataSource = khoaService.GetAllKhoa();

        }

        private void cboChonKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoa = cboChonKhoa.SelectedValue.ToString();
            cboChonNganh.DisplayMember = "TenNganh";
            cboChonNganh.ValueMember = "MaNganh";
            cboChonNganh.DataSource = nganhHocService.GetNganhHocByKHOA(maKhoa);
        }

        private void cboChonNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboChonKhoaHoc.DataSource = khoaHocService.GetAllKhoaHoc();
            cboChonKhoaHoc.DisplayMember = "TenKhoaHoc";
            cboChonKhoaHoc.ValueMember = "MaKhoaHoc";
        }

        private void cboChonKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNganh = cboChonNganh.SelectedValue.ToString();
            string maKhoasHoc = cboChonKhoaHoc.SelectedValue.ToString();

            cboChonLop.DataSource = lopService.GetDanhSachLopByMaNganhVaMaKhoaHoc(maNganh, maKhoasHoc);
            cboChonLop.DisplayMember = "TenLop";
            cboChonLop.ValueMember = "MaLop";
        }

        private void cboChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNganh = cboChonNganh.SelectedValue.ToString();
            cboChonMonHoc.DataSource = monHocService.GetMonHocByNganh(maNganh);
            cboChonMonHoc.DisplayMember = "TenMonHoc";
            cboChonMonHoc.ValueMember = "MaMonHoc";
        }

        private void cboChonMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.get_DiemSinhVienByMonHocTableAdapter.Fill(this.reporting.Get_DiemSinhVienByMonHoc, cboChonMonHoc.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
