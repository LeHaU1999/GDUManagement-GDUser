using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;
using GDU_Management.IDao;

namespace GDU_Management.DaoImpl
{
    class PhongHocImpl : IDaoPhongHoc
    {
        GDUDataConnectionsDataContext db;
        List<PhongHoc> listPhongHoc;

        public PhongHoc AddClassRoom(PhongHoc phongHoc)
        {
            db = new GDUDataConnectionsDataContext();
            db.PhongHocs.InsertOnSubmit(phongHoc);
            db.SubmitChanges();
            return phongHoc;
        }

        public void DeleteClassRoom(string maPH)
        {
            db = new GDUDataConnectionsDataContext();
            PhongHoc ph = new PhongHoc();
            ph = db.PhongHocs.Single(x => x.MaPhongHoc == maPH);
            db.PhongHocs.DeleteOnSubmit(ph);
            db.SubmitChanges();
        }

        public List<PhongHoc> GetAllPhongHoc()
        {
            db = new GDUDataConnectionsDataContext();
            var ph = from x in db.PhongHocs select x;
            listPhongHoc = ph.ToList();
            return listPhongHoc;
        }

        public PhongHoc GetPhongHocByMaPhongHoc(string maPhongHoc)
        {
            db = new GDUDataConnectionsDataContext();
            PhongHoc ph = new PhongHoc();
            ph = db.PhongHocs.Single(p => p.MaPhongHoc == maPhongHoc);
            return ph;
        }

        public List<PhongHoc> SearchPhongHoc(string ph)
        {
            db = new GDUDataConnectionsDataContext();
            var sph = from x in db.PhongHocs.Where(p => p.MaPhongHoc.Contains(ph)) select x;
            listPhongHoc = sph.ToList();
            return listPhongHoc;
        }

        public void UpdateClassRoom(PhongHoc phongHoc)
        {
            db = new GDUDataConnectionsDataContext();
            PhongHoc ph = new PhongHoc();
            ph = db.PhongHocs.Single(p => p.MaPhongHoc == phongHoc.MaPhongHoc);
            ph.GhiChu = phongHoc.GhiChu;
            db.SubmitChanges();
        }
    }
}
