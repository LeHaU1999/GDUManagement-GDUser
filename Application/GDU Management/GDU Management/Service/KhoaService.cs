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
    class KhoaService
    {
        IDaoKhoa khoaIDao = new KhoaImpl();

        //lấy danh sách khoa
        public List<Khoa> GetAllKhoa()
        {
            return khoaIDao.GetAllKhoa();
        }

        //tạo khoa
        public Khoa CreateKhoa(Khoa khoa)
        {
            return khoaIDao.CreateKhoa(khoa);
        }

        //xóa khoa
        public void DeleteKhoa(string maKhoa)
        {
            khoaIDao.DeleteKhoa(maKhoa);
        }

        //cập nhật khoa
        public void UpdateKhoa(Khoa khoa)
        {
            khoaIDao.UpdateKhoa(khoa);
        }

        //lấy danh sách khoa theo mã khoa
        public Khoa GetKhoaByMaKhoa(string maKhoa)
        {
            return khoaIDao.GetKhoaByMaKhoa(maKhoa);
        }

        //tìm kiếm theo tên khoa
        public List<Khoa> SearchKhoaByTenKhoa(string tenKhoa)
        {
            return khoaIDao.SearchKhoaByTenKhoa(tenKhoa);
        }

        //tìm kiếm theo mã khoa
        public List<Khoa> SearchKhoaByMaKhoa(string maKhoa)
        {
            return khoaIDao.SearchKhoaByMaKhoa(maKhoa);
        }

    }
}
