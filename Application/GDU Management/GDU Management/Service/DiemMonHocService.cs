using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.DaoImpl;
using GDU_Management.IDao;
using GDU_Management.Model;

namespace GDU_Management.Service
{
    class DiemMonHocService
    {
        IDaoDiemMonHoc diemMonHocIDao = new DiemMonHocImpl();

        //lấy tất cả điểm môn học
        public List<DiemMonHoc> GetAllDiemMonHoc()
        {
            return diemMonHocIDao.GetAllDiemMonHoc();
        }

        //thêm mới một  điểm môn học
        public DiemMonHoc AddDiemMonHoc(DiemMonHoc diemMonHoc)
        {
            return diemMonHocIDao.AddDiemMonHoc(diemMonHoc);
        }

        //xóa điểm môn học
        public void DeleteDiemMonHoc(string maSV, string maDiemMonHoc)
        {
            diemMonHocIDao.DeleteDiemMonHoc(maSV,maDiemMonHoc);
        }

        //cập nhật điểm môn học
        public void UpdateDiemMonHoc(DiemMonHoc diemMonHoc)
        {
            diemMonHocIDao.UpdateDiemMonHoc(diemMonHoc);
        }

        //lấy danh sách điểm theo mã môn học và mã sinh viên
        public List<DiemMonHoc> GetDanhSachMonByMaLopAndMaMonHoc(string maLop, string maMonHoc)
        {
            return diemMonHocIDao.GetDanhSachMonByMaLopAndMaMonHoc(maLop, maMonHoc);
        }

        //xoa danh sach diem theo ma sinh vien
        public void DeleteAllDiemMonHocByMaSinhVien(string maSV)
        {
            diemMonHocIDao.DeleteAllDiemMonHocByMaSinhVien(maSV);
        }


        //tìm kiếm điểm theo mã môn và mã sv
        public List<DiemMonHoc> SearchDiemMonHocByMonHocAndMaSV(string maMonHoc, string MaSV)
        {
            return diemMonHocIDao.SearchDiemMonHocByMonHocAndMaSV(maMonHoc, MaSV);
        }
    }
}
