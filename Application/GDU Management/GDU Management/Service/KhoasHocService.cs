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
    class KhoasHocService
    {
        IDaoKhoasHoc khoaHocIDao = new KhoasHocImpl();

        //lấy danh sách khóa học
       public  List<KhoasHoc> GetAllKhoaHoc()
        {
            return khoaHocIDao.GetAllKhoaHoc();
        }

        //tạo khóa học
        public KhoasHoc CreateKhoaHoc(KhoasHoc khoaHoc)
        {
            return khoaHocIDao.CreateKhoaHoc(khoaHoc);
        }

        //xóa khóa học
        public void DeleteKhoaHoc(string maKhoaHoc)
        {
            khoaHocIDao.DeleteKhoaHoc(maKhoaHoc);
        }

        //cập nhật khóa học
        public void UpdateKhoaHoc(KhoasHoc khoaHoc)
        {
            khoaHocIDao.UpdateKhoaHoc(khoaHoc);
        }

        //tìm kiếm khóa học bằng mã khóa học
        public List<KhoasHoc> SearchKhoaHocByMaKhoaHoc(string maKhoaHoc)
        {
            return khoaHocIDao.SearchKhoaHocByMaKhoaHoc(maKhoaHoc);
        }

        //tìm kiếm khóa học bằng tên khóa học
        public List<KhoasHoc> SearchKhoaHocByTenKhoaHoc(string tenKhoaHoc)
        {
            return khoaHocIDao.SearchKhoaHocByTenKhoaHoc(tenKhoaHoc);
        }

        //tìm kiếm khóa học bằng mã khóa học
        public List<KhoasHoc> SearchKhoaHocByNienKhoa(string nienKhoa)
        {
            return khoaHocIDao.SearchKhoaHocByNienKhoa(nienKhoa);
        }

        //lấy thông tin khóa học
        public KhoasHoc GetKhoaHocByMaKhoaHoc(string maKhoasHoc)
        {
            return khoaHocIDao.GetKhoaHocByMaKhoaHoc(maKhoasHoc);
        }
    }
}
