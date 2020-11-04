using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.IDao;
using GDU_Management.DaoImpl;
using GDU_Management.Model;

namespace GDU_Management.Service
{
    class PhongHocService
    {
        IDaoPhongHoc phongHocIdao = new PhongHocImpl();

        public List<PhongHoc> GetAllPhongHoc()
        {
            return phongHocIdao.GetAllPhongHoc() ;
        }

        public PhongHoc GetPhongHocByMaPhongHoc(string maPhongHoc)
        {
            return phongHocIdao.GetPhongHocByMaPhongHoc(maPhongHoc);
        }

        public PhongHoc AddClassRoom(PhongHoc phongHoc)
        {
            return phongHocIdao.AddClassRoom(phongHoc);
        }

        public void DeleteClassRoom(string maPH)
        {
            phongHocIdao.DeleteClassRoom(maPH);
        }

        public void UpdateClassRoom(PhongHoc phongHoc)
        {
            phongHocIdao.UpdateClassRoom(phongHoc);
        }

        public List<PhongHoc> SearchPhongHoc(string ph)
        {
            return phongHocIdao.SearchPhongHoc(ph);
        }
    }
}
