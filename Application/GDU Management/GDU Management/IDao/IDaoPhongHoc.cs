using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;

namespace GDU_Management.IDao
{
    interface IDaoPhongHoc
    {
        List<PhongHoc> GetAllPhongHoc();
        PhongHoc GetPhongHocByMaPhongHoc(string maPhongHoc);
        PhongHoc AddClassRoom(PhongHoc phongHoc);
        void UpdateClassRoom(PhongHoc phongHoc);
        void DeleteClassRoom(string maPH);
        List<PhongHoc> SearchPhongHoc(string ph);
    }
}
