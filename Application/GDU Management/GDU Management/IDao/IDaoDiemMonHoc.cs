using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;

namespace GDU_Management.IDao
{
    interface IDaoDiemMonHoc
    {
        List<DiemMonHoc> GetAllDiemMonHoc();
        DiemMonHoc AddDiemMonHoc(DiemMonHoc diemMonHoc);
        void DeleteDiemMonHoc(string maMonHoc , string MaSV);
        void UpdateDiemMonHoc(DiemMonHoc diemMonHoc);
        List<DiemMonHoc> GetDanhSachMonByMaLopAndMaMonHoc(string maLop, string maMonHoc);
        void DeleteAllDiemMonHocByMaSinhVien(string maSV);
        List<DiemMonHoc> SearchDiemMonHocByMonHocAndMaSV(string maMonHoc, string MaSV); 
    }
}
