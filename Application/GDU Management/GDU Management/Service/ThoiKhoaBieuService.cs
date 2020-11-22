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
    class ThoiKhoaBieuService
    {
        IDaoThoiKhoaBieu TKBIdao = new ThoiKhoaBieuImpl();

        //tạo mới thời khóa biểu
        public ThoiKhoaBieu CreateThoiKhoaBieu(ThoiKhoaBieu tkb)
        {
            return TKBIdao.CreateThoiKhoaBieu(tkb);
        }

        //lấy danh sách thời khóa biểu theo mã lớp và mã học kì
        public List<ThoiKhoaBieu> GetTKBByMaLop(string maLop)
        {
            return TKBIdao.GetTKBByMaLop(maLop);
        }

        //cập nhật thời khóa biểu
        public void UpdateThoiKhoaBieu(ThoiKhoaBieu tkb)
        {
            TKBIdao.UpdateThoiKhoaBieu(tkb);
        }

        //xóa 1 trường thời khóa biểu
        public void DeleteThoiKhoaBieu(string maLop, string maMonHoc)
        {
            TKBIdao.DeleteThoiKhoaBieu(maLop, maMonHoc);
        }

        //lấy thông tin thời khóa biểu
        public ThoiKhoaBieu GetThoiKhoaBieuByMaLopMaMonHoc(string maLop, string maMH)
        {
            return TKBIdao.GetThoiKhoaBieuByMaLopMaMonHoc(maLop, maMH);
        }

        //xóa danh sách thời khóa biểu theo lớp.
        public void DeleteThoiKhoaBieuByLop(string maLop)
        {
            TKBIdao.DeleteThoiKhoaBieuByLop(maLop);
        }

        //lấy danh sách thời khóa biểu theo mã lớp và mã hk
        public List<ThoiKhoaBieu> GetTKBByMaLopAndMaHK(string maLop, string maHK)
        {
            return TKBIdao.GetTKBByMaLopAndMaHK(maLop, maHK);
        }

        //xóa thời khóa biểu theo môn học
        public void DeleteThoiKhoaBieuByMaMonHoc(string maMonHoc)
        {
            TKBIdao.DeleteThoiKhoaBieuByMaMonHoc(maMonHoc);
        }


        //xóa thời khóa bieeurtheo mã giảng viên
        public void DeleteThoiKhoaBieuByGiangVien(string maGV)
        {
            TKBIdao.DeleteThoiKhoaBieuByGiangVien(maGV);
        }
    }
}
