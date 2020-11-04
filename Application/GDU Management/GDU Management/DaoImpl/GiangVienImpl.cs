using GDU_Management.IDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;

namespace GDU_Management.DaoImpl
{
    class GiangVienImpl : IDaoGiangVien
    {
        //tao ket noi database
        GDUDataConnectionsDataContext db ;
        List<GiangVien> listGV;

        //tạo mới 1 giảng viên
        public GiangVien CreateGiangVien(GiangVien giangVien)
        {
            db = new GDUDataConnectionsDataContext();
            db.GiangViens.InsertOnSubmit(giangVien);
            db.SubmitChanges();
            return giangVien;
        }

        //xóa giảng viên
        public void DeleteGiangVien(string maGV)
        {
            db = new GDUDataConnectionsDataContext();
            GiangVien gv = new GiangVien();
            gv = db.GiangViens.Single(p => p.MaGV == maGV);
            db.GiangViens.DeleteOnSubmit(gv);
            db.SubmitChanges();
        }

        //xóa  danh sách giảng viên theo khoa
        public void DeleteListGiangVienByMaKhoa(string maKhoa)
        {
            db = new GDUDataConnectionsDataContext();
            var listGVDelete = from x in db.GiangViens.Where(p => p.MaKhoa == maKhoa) select x;
            db.GiangViens.DeleteAllOnSubmit(listGVDelete.ToList());
            db.SubmitChanges();
        }

        //lấy tất cả danh sách giảng viên
        public List<GiangVien> GetAllGiangVien()
        {
            db = new GDUDataConnectionsDataContext();
            var gv = from x in db.GiangViens select x;
            listGV = gv.ToList();
            return listGV;
        }

        //lấy thông tin giảng viên theo mã gv
        public GiangVien GetGiangVienByMaGV(string maGV)
        {
            db = new GDUDataConnectionsDataContext();
            GiangVien gv = new GiangVien();
            gv = db.GiangViens.Single(p => p.MaGV == maGV);
            return gv;
        }

        //lấy danh sách giảng viên theo khoa
        public List<GiangVien> GetGiangVienByMaKhoa(string maKhoa)
        {
            db = new GDUDataConnectionsDataContext();
            var lgv = db.GiangViens.Where(p => p.MaKhoa == maKhoa).ToList();
            listGV = lgv.ToList();
            return listGV;
        }

        //tìm kiếm account giảng viên 
        public List<GiangVien> SearchGiangVienByEmail(string email)
        {
            db = new GDUDataConnectionsDataContext();
            var searchGV = from x in db.GiangViens.Where(p => p.Email.Contains(email)) select x;
            listGV = new List<GiangVien>();
            return listGV;
        }

        //cập nhật tào khoản giảng viên
        public void UpdateAccountGiangVien(GiangVien giangVien)
        {
            db = new GDUDataConnectionsDataContext();
            GiangVien gv = new GiangVien();
            gv = db.GiangViens.Single(p => p.MaGV == giangVien.MaGV);
            gv.Password = giangVien.Password;
            gv.StatusAcc = giangVien.StatusAcc;
            db.SubmitChanges();
        }

        //cập nhật thông tin giảng viên
        public void UpdateGiangVien(GiangVien giangVien)
        {
            db = new GDUDataConnectionsDataContext();
            GiangVien gv = new GiangVien();
            gv = db.GiangViens.Single(p => p.MaGV == giangVien.MaGV);
            gv.TenGV = giangVien.TenGV;
            gv.GioiTinh = giangVien.GioiTinh;
            gv.NamSinh = giangVien.NamSinh;
            gv.TrinhDo = giangVien.TrinhDo;
            gv.SDT = giangVien.SDT;
            gv.Email = giangVien.Email;
            gv.DiaChi = giangVien.DiaChi;
            gv.GhiChu = giangVien.GhiChu;
            gv.NgayBatDau = giangVien.NgayBatDau;
            db.SubmitChanges();
        }
    }
}
