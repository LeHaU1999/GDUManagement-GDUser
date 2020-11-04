using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDU_Management.IDao
{
    interface IDaoKhoasHoc
    {
        List<KhoasHoc> GetAllKhoaHoc();
        KhoasHoc CreateKhoaHoc(KhoasHoc khoaHoc);
        void DeleteKhoaHoc(string maKhoaHoc);
        void UpdateKhoaHoc(KhoasHoc khoaHoc);
        List<KhoasHoc> SearchKhoaHocByMaKhoaHoc(string maKhoaHoc);
        List<KhoasHoc> SearchKhoaHocByTenKhoaHoc(string tenKhoaHoc);
        List<KhoasHoc> SearchKhoaHocByNienKhoa(string nienKhoa);
        void DeleteAllKhoasHocByMaKhoasHoc(string maKhoasHoc);

        KhoasHoc GetKhoaHocByMaKhoaHoc(string maKhoasHoc);
    }
}
