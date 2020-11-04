using GDU_Management.DaoImpl;
using GDU_Management.IDao;
using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDU_Management.Service
{
    class SinhVienService
    {
        IDaoSinhVien sinhVienIDao = new SinhVienImpl();

        //lấy tất cả sinh viên
        public List<SinhVien> GetAllSinhVien()
        {
            return sinhVienIDao.GetAllSinhVien();
        }

        //thêm mới một sinh viên
        public SinhVien CreateSinhVien(SinhVien sinhVien)
        {
            return sinhVienIDao.CreateSinhVien(sinhVien);
        }

        //xóa sinh viên
        public void DeleteSinhVien(string maSV)
        {
            sinhVienIDao.DeleteSinhVien(maSV);
        }

        //cập nhật sinh viên
        public void UpdateSinhVien(SinhVien sinhVien)
        {
            sinhVienIDao.UpdateSinhVien(sinhVien);
        }

        //lấy danh sách sinh viên theo mã lớp
        public List<SinhVien> GetSinhVienByMaLop(string maLop)
        {
            return sinhVienIDao.GetSinhVienByMaLop(maLop);
        }

        //tìm kiếm sinh viên theo tên
        public List<SinhVien> SearchSinhVienByTenSinhVien(string maLop, string tenSV)
        {
            return sinhVienIDao.SearchSinhVienByTenSinhVien(maLop, tenSV);
        }

        //xóa tất cả sinh viên
        public void DeleteAllSinhVienByMaLop(string maLop)
        {
            sinhVienIDao.DeleteAllSinhVienByMaLop(maLop);
        }

        //đếm số lượng sinh viên
        public int CountSinhVien()
        {
            return sinhVienIDao.CountSinhVien();
        }

        //lấy thông tin sinh viên theo mã sv
        public SinhVien GetSinhVienByMaSinhVien(string maSV)
        {
            return sinhVienIDao.GetSinhVienByMaSinhVien(maSV);
        }

        //search điếm sinh viên theo tên sinh viên
        public List<SinhVien> SearchDiemSinhVienByTenSV(string tenSV)
        {
            return sinhVienIDao.SearchDiemSinhVienByTenSV(tenSV);
        }

        //cập nhật thông tin account sinh viên
        public void UpdateAccountSinhVien(SinhVien sinhVien)
        {
            sinhVienIDao.UpdateAccountSinhVien(sinhVien);
        }

        //tìm kiếm tài khoản sinh viên
        public List<SinhVien> SearchAccountSinhVienByEmail(string email)
        {
            return sinhVienIDao.SearchAccountSinhVienByEmail(email);
        }

        //lấy danh sách sinh viên theo ngành
        public List<SinhVien> GetSinhVienByMaNganh(string maNganh)
        {
            return sinhVienIDao.GetSinhVienByMaNganh(maNganh);
        }

        //tìm kiếm thông tin tất cả sinh viên
        public List<SinhVien> SearchAllSinhVien(string maSV, string tenSV)
        {
            return sinhVienIDao.SearchAllSinhVien(maSV, tenSV);
        }
    }
}
