using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDU_Management.GDU_View;
using GDU_Management.Service;
using GDU_Management.Model;

namespace GDU_Management.GDU_Views
{
    public partial class frmInformaitonSinhVien : Form
    {
        public frmInformaitonSinhVien()
        {
            InitializeComponent();
        }

        //khai báo các service 
        SinhVienService sinhVienService = new SinhVienService();
        LopService lopService = new LopService();
        KhoasHocService khoasHocService = new KhoasHocService();
        NganhHocService nganhHocService = new NganhHocService();
        KhoaService khoaService = new KhoaService();

        //public value
        string Id_SV;
        string maLop;
        string maKhoasHoc;
        string maNganh;
        string maKhoa;

        //---------------------------DANH SÁCH HÀM PUBLIC------------------------------//
        //__________________________________________________________//

        //nhận id sinh viên từ from frmAccount, frmQLSV
        public void FunData(string IdSV)
        {
            lblID.Text = IdSV;
            Id_SV = IdSV;
        }

        //load thông tin sinh viên lên form
        public void LoadSinhVien() 
        {
            if (Id_SV == lblID.Text & lblID.Text != "??")
            {
                SinhVien sv = new SinhVien();
                sv = sinhVienService.GetSinhVienByMaSinhVien(lblID.Text);
                lblTen.Text = sv.TenSV;
                lblGioiTinh.Text = sv.GioiTinh;
                lblEmail.Text = sv.Email;
                lblSdt.Text = sv.SDT;
                lblNamSinh.Text = sv.NamSinh;
                lblThongTinTaiKhoan.Text = sv.StatusAcc;
                lblDiaChi.Text = sv.DiaChi;
                lblGhiChu.Text = sv.GhiChu;

                //lấy tên lớp
                maLop = sv.MaLop;
                Lop lp = new Lop();
                lp = lopService.GetLopByMaLop(maLop);
                lblLop.Text = lp.TenLop;

                //lấy tên khóa + niên khóa
                maKhoasHoc = lp.MaKhoaHoc;
                KhoasHoc khoaHoc = new KhoasHoc();
                khoaHoc = khoasHocService.GetKhoaHocByMaKhoaHoc(maKhoasHoc);
                lblKhoasHoc.Text = khoaHoc.TenKhoaHoc + " - " + khoaHoc.NienKhoa;

                //lấy tên ngành
                maNganh = lp.MaNganh;
                NganhHoc nganhHoc = new NganhHoc();
                nganhHoc = nganhHocService.GetNganhHocByMaNganh(maNganh);
                lblChuyenNganh.Text = nganhHoc.TenNganh.ToUpper();

                //lấy tên khoa
                maKhoa = nganhHoc.MaKhoa;
                Khoa khoa = new Khoa();
                khoa = khoaService.GetKhoaByMaKhoa(maKhoa);
                lblKhoa.Text = khoa.TenKhoa.ToUpper();
            }
        }
            
        //---------------------------KẾT THÚC HÀM PUBLIC---------------------------------//
        //__________________________________________________________//

        private void frmInformaitonSinhVien_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
