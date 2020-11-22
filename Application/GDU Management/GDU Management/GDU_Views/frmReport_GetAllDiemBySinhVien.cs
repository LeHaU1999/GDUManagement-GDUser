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
    public partial class frmReport_GetAllDiemBySinhVien : Form
    {
        public frmReport_GetAllDiemBySinhVien()
        {
            InitializeComponent();
        }

        MonHocService monHocService = new MonHocService();
        LopService lopService = new LopService();
        HocKyService hocKyService = new HocKyService();
        SinhVienService sinhVienService = new SinhVienService();
        NganhHocService nganhHocService = new NganhHocService();
        KhoasHocService khoaHocService = new KhoasHocService();

        GDUManagement dt = new GDUManagement();

        private void frmReport_GetAllDiemBySinhVien_Load(object sender, EventArgs e)
        {
            cboChonNganh.DisplayMember = "TenNganh";
            cboChonNganh.ValueMember = "MaNganh";
            cboChonNganh.DataSource = nganhHocService.GetAllNganhHoc();
        }

        private void cboChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLop = cboChonLop.SelectedValue.ToString();
            cboChonSinhVien.DisplayMember = "TenSV";
            cboChonSinhVien.ValueMember = "MaSV";
            cboChonSinhVien.DataSource = sinhVienService.GetSinhVienByMaLop(maLop);

        }

        private void cboChonSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.get_AllDiemBySinhVien01TableAdapter.Fill(this.reporting.Get_AllDiemBySinhVien01, cboChonSinhVien.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void cboChonNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cboChonKhoaHoc.DisplayMember = "TenKhoaHoc";
            cboChonKhoaHoc.ValueMember = "MaKhoaHoc";
            cboChonKhoaHoc.DataSource = khoaHocService.GetAllKhoaHoc();
        }

        private void cboChonKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string maKhoaHoc = cboChonKhoaHoc.SelectedValue.ToString();
            cboChonLop.DisplayMember = "TenLop";
            cboChonLop.ValueMember = "MaLop";
            cboChonLop.DataSource = lopService.GetDanhSachLopByMaNganhVaMaKhoaHoc(cboChonNganh.SelectedValue.ToString(),cboChonKhoaHoc.SelectedValue.ToString());
        }
    }
}
