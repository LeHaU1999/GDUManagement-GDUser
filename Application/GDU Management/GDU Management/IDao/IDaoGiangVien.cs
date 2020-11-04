using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;

namespace GDU_Management.IDao
{
    interface IDaoGiangVien
    {
        List<GiangVien> GetAllGiangVien();
        GiangVien CreateGiangVien(GiangVien giangVien);
        void DeleteGiangVien(string maGV);
        void UpdateGiangVien(GiangVien giangVien);
        List<GiangVien> GetGiangVienByMaKhoa(string maKhoa);
        GiangVien GetGiangVienByMaGV(string maGV);
        void UpdateAccountGiangVien(GiangVien giangVien);
        List<GiangVien> SearchGiangVienByEmail(string email);
        void DeleteListGiangVienByMaKhoa(string maKhoa);
    }
}
