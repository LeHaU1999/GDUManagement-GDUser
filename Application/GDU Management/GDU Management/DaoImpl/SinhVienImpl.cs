using GDU_Management.IDao;
using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDU_Management.DaoImpl
{
    class SinhVienImpl : IDaoSinhVien
    {
        //tao ket noi database
        GDUDataConnectionsDataContext db;
        List<SinhVien> listSinhViens;

        //đếm số lượng sinh viên
        public int CountSinhVien()
        {
            db = new GDUDataConnectionsDataContext();
            var SV = db.SinhViens.Count();
            int countSV = SV;
            return countSV;
        }

        //thêm mới một sinh viên
        public SinhVien CreateSinhVien(SinhVien sinhVien)
        {
            db = new GDUDataConnectionsDataContext();
            db.SinhViens.InsertOnSubmit(sinhVien);
            db.SubmitChanges();
            return null;
        }

        //xóa tất cả sinh viên
        public void DeleteAllSinhVienByMaLop(string  maLop)
        {
            db = new GDUDataConnectionsDataContext();
            List<SinhVien> sv = db.SinhViens.Where(p => p.MaLop.Equals(maLop)).ToList();
            listSinhViens = sv.ToList();
            db.SinhViens.DeleteAllOnSubmit(listSinhViens);
            db.SubmitChanges();
        }

        //xóa sinh viên
        public void DeleteSinhVien(string maSV)
        {
            db = new GDUDataConnectionsDataContext();
            SinhVien sv = new SinhVien();
            sv = db.SinhViens.Single(p => p.MaSV == maSV);
            db.SinhViens.DeleteOnSubmit(sv);
            db.SubmitChanges();
        }

        //lấy tất cả danh sách sinh viên
        public List<SinhVien> GetAllSinhVien()
        {
            db = new GDUDataConnectionsDataContext();
            var sv = from x in db.SinhViens select x;
            listSinhViens = sv.ToList();
            return listSinhViens;
        }

        //lấy danh sách sinh viên theo mã lớp
        public List<SinhVien> GetSinhVienByMaLop(string maLop)
        {
            db = new GDUDataConnectionsDataContext();
            List<SinhVien> sv = db.SinhViens.Where(p => p.MaLop.Equals(maLop)).ToList();
            listSinhViens = new List<SinhVien>();
            listSinhViens = sv;
            return listSinhViens;
        }

        //lấy thông tin sv theo mã sinh viên
        public SinhVien GetSinhVienByMaSinhVien(string maSV)
        {
            db = new GDUDataConnectionsDataContext();
            SinhVien sv = new SinhVien();
            sv = db.SinhViens.Single(p => p.MaSV == maSV);
            return sv;
        }

        public List<SinhVien> SearchDiemSinhVienByTenSV(string tenSV)
        {
            db = new GDUDataConnectionsDataContext();
            var tensv  = from x in db.SinhViens where x.TenSV.Contains(tenSV) select x;
            listSinhViens = tensv.ToList();
            return listSinhViens;
        }

        //tìm kiếm tài khoản sinh viên
        public List<SinhVien> SearchAccountSinhVienByEmail(string email)
        {
            db = new GDUDataConnectionsDataContext();
            var searchSV = from x in db.SinhViens.Where(p => p.Email.Contains(email)) select x;
            listSinhViens = new List<SinhVien>();
            listSinhViens = searchSV.ToList();
            return listSinhViens;
        }

        //tìm kiếm sinh viên theo tên
        public List<SinhVien> SearchSinhVienByTenSinhVien(string maLop, string tenSV)
        {
            db = new GDUDataConnectionsDataContext();
            var sv = from x in db.SinhViens.Where(p => p.MaLop == maLop & p.TenSV.Contains(tenSV)) select x;
            listSinhViens = sv.ToList();
            return listSinhViens;
        }

        //cập nhật thông tin account sinh viên
        public void UpdateAccountSinhVien(SinhVien sinhVien)
        {
            db = new GDUDataConnectionsDataContext();
            SinhVien sv = new SinhVien();
            sv = db.SinhViens.Single(p=>p.MaSV == sinhVien.MaSV);
            sv.Password = sinhVien.Password;
            sv.StatusAcc = sinhVien.StatusAcc;
            db.SubmitChanges();
        }

        //cập nhật sinh viên
        public void UpdateSinhVien(SinhVien sinhVien)
        {
            db = new GDUDataConnectionsDataContext();
            SinhVien sv = new SinhVien();
            sv = db.SinhViens.Single(p => p.MaSV == sinhVien.MaSV);
            sv.TenSV = sinhVien.TenSV;
            sv.GioiTinh = sinhVien.GioiTinh;
            sv.Email = sinhVien.Email;
            sv.NamSinh = sinhVien.NamSinh;
            sv.SDT = sinhVien.SDT;
            sv.DiaChi = sinhVien.DiaChi;
            sv.GhiChu = sinhVien.GhiChu;
            sv.MaLop = sinhVien.MaLop;
            db.SubmitChanges();
        }

        //lấy dang sách sinh viên theo ngành
        public List<SinhVien> GetSinhVienByMaNganh(string maNganh)
        {
            db = new GDUDataConnectionsDataContext();
            var listSV = from sv in db.SinhViens
                         join lp in db.Lops on sv.MaLop equals lp.MaLop
                         join ng in db.NganhHocs on lp.MaNganh equals ng.MaNganh
                         where ng.MaNganh == maNganh
                         select sv;
            listSinhViens = listSV.ToList();
            return listSinhViens;
        }

        //tìm kiếm thông tin tất cả sinh viên
        public List<SinhVien> SearchAllSinhVien(string maSV, string tenSV)
        {
            db = new GDUDataConnectionsDataContext();
            var searchAllSV = from x in db.SinhViens.Where(p=>p.MaSV.Contains(maSV) || p.TenSV.Contains(tenSV)) select x;
            listSinhViens = searchAllSV.ToList();
            return listSinhViens;
        }
    }
}
