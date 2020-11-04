using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;

namespace GDU_Management.IDao
{
    interface IDaoLop
    {
        List<Lop> getAllLop();
        Lop CreateLop(Lop lop);
        void DeleteLop(string maLop);
        void UpdateLop(Lop lop);
        List<Lop> GetDanhSachLopByMaNganhVaMaKhoaHoc(string maNganh, string maKhoaHoc);
        List<Lop> SearchLopHocByTenLop(string maNganh, string tenLop);
        Lop GetLopByMaLop(string maLop);
        void DeleteAllLopInNganh(string maKhoasHoc, string maNganh);
    }
}
