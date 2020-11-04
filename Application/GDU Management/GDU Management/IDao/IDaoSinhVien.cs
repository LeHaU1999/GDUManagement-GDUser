using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.IDao;
using GDU_Management.Model;

namespace GDU_Management.IDao
{
    interface IDaoSinhVien
    {
        List<SinhVien> GetAllSinhVien();
        SinhVien CreateSinhVien(SinhVien sinhVien);
        void DeleteSinhVien(string maSV);
        void UpdateSinhVien(SinhVien sinhVien);
        List<SinhVien> GetSinhVienByMaLop(string maLop);
        List<SinhVien> SearchSinhVienByTenSinhVien(string maLop ,  string tenSV);
        void DeleteAllSinhVienByMaLop(string maLop);
        int CountSinhVien();
        SinhVien GetSinhVienByMaSinhVien(string maSV);
        List<SinhVien> SearchDiemSinhVienByTenSV(string tenSV);
        List<SinhVien> GetSinhVienByMaNganh(string maNganh); 
        void UpdateAccountSinhVien(SinhVien sinhVien);
        List<SinhVien> SearchAccountSinhVienByEmail(string email);
        List<SinhVien> SearchAllSinhVien(string maSV, string tenSV);

    }
}
