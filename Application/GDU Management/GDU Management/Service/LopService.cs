using GDU_Management.DaoImpl;
using GDU_Management.IDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;

namespace GDU_Management.Service
{
    class LopService
    {
        IDaoLop lopIDao = new LopImpl();

        //lấy danh sách lớp
        public List<Lop> GetAllLop()
        {
            return lopIDao.getAllLop();
        }
        //tạo lớp
        public Lop CreateLop(Lop lop)
        {
            return lopIDao.CreateLop(lop);
        }
        //xóa lớp
        public void DeleteLop(string maLop)
        {
            lopIDao.DeleteLop(maLop);
        }
        //cập nhật lớp
        public void UpdateLop(Lop lop)
        {
            lopIDao.UpdateLop(lop);
        }

        //lấy danh sách lớp theo mã ngành & mã khóa học
        public List<Lop> GetDanhSachLopByMaNganhVaMaKhoaHoc(string maNganh, string maKhoaHoc)
        {
            return lopIDao.GetDanhSachLopByMaNganhVaMaKhoaHoc(maNganh, maKhoaHoc);
        }

        //tìm kiếm lớp theo tên lớp
        public List<Lop> SearchLopHocByTenLop(string maNganh, string tenLop)
        {
            return lopIDao.SearchLopHocByTenLop(maNganh, tenLop);
        }

        //lấy thông tin Lớp
        public Lop GetLopByMaLop(string maLop)
        {
            return lopIDao.GetLopByMaLop(maLop);
        }

        //Xóa tất cả lớp trong ngành
        public void DeleteAllLopInNganh(string maKhoasHoc, string maNganh)
        {
            lopIDao.DeleteAllLopInNganh(maKhoasHoc, maNganh);
        }
    }
}
