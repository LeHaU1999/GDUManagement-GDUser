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
    class GiangVienService
    {
        IDaoGiangVien giangVienIDao = new GiangVienImpl();

        //lấy tất cả giảng viên
        public List<GiangVien> GetAllGiangVien()
        {
            return giangVienIDao.GetAllGiangVien();
        }

        //thêm mới một giảng viên
        public GiangVien CreateGiangVien(GiangVien giangVien)
        {
            return giangVienIDao.CreateGiangVien(giangVien);
        }

        //xóa giảng viên
        public void DeleteGiangVien(string maGV)
        {
            giangVienIDao.DeleteGiangVien(maGV);
        }

        //cập nhật giảng viên
        public void UpdateGiangVien(GiangVien giangVien)
        {
            giangVienIDao.UpdateGiangVien(giangVien);
        }

        //lấy danh sách giảng viên theo khoa
        public List<GiangVien> GetGiangVienByMaKhoa(string maKhoa)
        {
            return giangVienIDao.GetGiangVienByMaKhoa(maKhoa);
        }

        //lấy thông tin giảng viên theo mã gv
        public GiangVien GetGiangVienByMaGV(string maGV)
        {
            return giangVienIDao.GetGiangVienByMaGV(maGV);
        }

        //cập nhật tào khoản giảng viên
        public void UpdateAccountGiangVien(GiangVien giangVien)
        {
            giangVienIDao.UpdateAccountGiangVien(giangVien);
        }

        //tìm kiếm account giảng viên 
        public List<GiangVien> SearchGiangVienByEmail(string email)
        {
            return giangVienIDao.SearchGiangVienByEmail(email);
        }


        //xóa  danh sách giảng viên theo khoa
        public void DeleteListGiangVienByMaKhoa(string maKhoa)
        {
            giangVienIDao.DeleteListGiangVienByMaKhoa(maKhoa);
        }
    }
}
