using GDU_Management.IDao;
using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GDU_Management.DaoImpl
{
    class KhoaHocImpl : IDaoKhoaHoc
    {
        //tạo kết nối database 
        GDUDataConnectionsDataContext db;
        List<KhoaHoc> listkhoaHoc;

        public KhoaHocImpl()
        {
            db = new GDUDataConnectionsDataContext();
            using (db)
            {
                var khoaHoc = from x in db.KhoaHocs select x;
                db.DeferredLoadingEnabled = true;
                listkhoaHoc = khoaHoc.ToList();
            }
        }
        public KhoaHoc CreateKhoaHoc(KhoaHoc khoaHoc)
        {
            db = new GDUDataConnectionsDataContext();
            db.KhoaHocs.InsertOnSubmit(khoaHoc);
            db.SubmitChanges();
            return khoaHoc;
        }

        public void DeleteKhoaHoc(string maKhoaHoc)
        {
            db = new GDUDataConnectionsDataContext();
            KhoaHoc khoaHoc = new KhoaHoc();
            khoaHoc = db.KhoaHocs.Single(x => x.MaKhoaHoc == maKhoaHoc);
            db.KhoaHocs.DeleteOnSubmit(khoaHoc);
            db.SubmitChanges();
        }

        public List<KhoaHoc> GetAllKhoaHoc()
        {
            db = new GDUDataConnectionsDataContext();
            var kh = from x in db.KhoaHocs select x;
            listkhoaHoc = kh.ToList();
            return listkhoaHoc; ;
        }

        public List<KhoaHoc> SearchKhoaHocByMaKhoaHoc(string maKhoaHoc)
        {
            db = new GDUDataConnectionsDataContext();
            var khoaHoc = from x in db.KhoaHocs where x.MaKhoaHoc.Contains(maKhoaHoc) select x;
            listkhoaHoc = khoaHoc.ToList();
            return listkhoaHoc;
        }

        public List<KhoaHoc> SearchKhoaHocByNienKhoa(string nienKhoa)
        {
            db = new GDUDataConnectionsDataContext();
            var khoaHoc = from x in db.KhoaHocs where x.NienKhoa.Contains(nienKhoa) select x;
            listkhoaHoc = khoaHoc.ToList();
            return listkhoaHoc;
        }

        public List<KhoaHoc> SearchKhoaHocByTenKhoaHoc(string tenKhoaHoc)
        {
            db = new GDUDataConnectionsDataContext();
            var khoaHoc = from x in db.KhoaHocs where x.TenKhoaHoc.Contains(tenKhoaHoc) select x;
            listkhoaHoc = khoaHoc.ToList();
            return listkhoaHoc;
        }

        public void UpdateKhoaHoc(KhoaHoc khoaHoc)
        {
            db = new GDUDataConnectionsDataContext();
            KhoaHoc khoaHocs = new KhoaHoc();
            khoaHocs = db.KhoaHocs.Single(x => x.MaKhoaHoc == khoaHoc.MaKhoaHoc);
            khoaHocs.TenKhoaHoc = khoaHoc.TenKhoaHoc;
            khoaHocs.NienKhoa = khoaHoc.NienKhoa;
            db.SubmitChanges();
        }
    }
}
