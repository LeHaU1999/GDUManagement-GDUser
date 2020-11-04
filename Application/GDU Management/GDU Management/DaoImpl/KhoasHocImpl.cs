using GDU_Management.IDao;
using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GDU_Management.DaoImpl
{
    class KhoasHocImpl : IDaoKhoasHoc
    {
        //tạo kết nối database 
        GDUDataConnectionsDataContext db;
        List<KhoasHoc> listkhoaHoc;

        public KhoasHocImpl()
        {
            db = new GDUDataConnectionsDataContext();
            using (db)
            {
                var khoaHoc = from x in db.KhoasHocs select x;
                db.DeferredLoadingEnabled = true;
                listkhoaHoc = khoaHoc.ToList();
            }
        }
        public KhoasHoc CreateKhoaHoc(KhoasHoc khoaHoc)
        {
            db = new GDUDataConnectionsDataContext();
            db.KhoasHocs.InsertOnSubmit(khoaHoc);
            db.SubmitChanges();
            return khoaHoc;
        }


        public void DeleteAllKhoasHocByMaKhoasHoc(string maKhoasHoc)
        {
            db = new GDUDataConnectionsDataContext();
        }

        public void DeleteKhoaHoc(string maKhoaHoc)
        {
            db = new GDUDataConnectionsDataContext();
            KhoasHoc khoaHoc = new KhoasHoc();
            khoaHoc = db.KhoasHocs.Single(x => x.MaKhoaHoc == maKhoaHoc);
            db.KhoasHocs.DeleteOnSubmit(khoaHoc);
            db.SubmitChanges();
        }

        public List<KhoasHoc> GetAllKhoaHoc()
        {
            db = new GDUDataConnectionsDataContext();
            var kh = from x in db.KhoasHocs select x;
            listkhoaHoc = kh.ToList();
            return listkhoaHoc; ;
        }

        //lấy thông tin khóa học
        public KhoasHoc GetKhoaHocByMaKhoaHoc(string maKhoasHoc)
        {
            db = new GDUDataConnectionsDataContext();
            KhoasHoc kh = new KhoasHoc();
            kh = db.KhoasHocs.Single(p => p.MaKhoaHoc == maKhoasHoc);
            return kh;
        }

        public List<KhoasHoc> SearchKhoaHocByMaKhoaHoc(string maKhoaHoc)
        {
            db = new GDUDataConnectionsDataContext();
            var khoaHoc = from x in db.KhoasHocs where x.MaKhoaHoc.Contains(maKhoaHoc) select x;
            listkhoaHoc = khoaHoc.ToList();
            return listkhoaHoc;
        }

        public List<KhoasHoc> SearchKhoaHocByNienKhoa(string nienKhoa)
        {
            db = new GDUDataConnectionsDataContext();
            var khoaHoc = from x in db.KhoasHocs where x.NienKhoa.Contains(nienKhoa) select x;
            listkhoaHoc = khoaHoc.ToList();
            return listkhoaHoc;
        }

        public List<KhoasHoc> SearchKhoaHocByTenKhoaHoc(string tenKhoaHoc)
        {
            db = new GDUDataConnectionsDataContext();
            var khoaHoc = from x in db.KhoasHocs where x.TenKhoaHoc.Contains(tenKhoaHoc) select x;
            listkhoaHoc = khoaHoc.ToList();
            return listkhoaHoc;
        }

        public void UpdateKhoaHoc(KhoasHoc khoaHoc)
        {
            db = new GDUDataConnectionsDataContext();
            KhoasHoc khoaHocs = new KhoasHoc();
            khoaHocs = db.KhoasHocs.Single(x => x.MaKhoaHoc == khoaHoc.MaKhoaHoc);
            khoaHocs.TenKhoaHoc = khoaHoc.TenKhoaHoc;
            khoaHocs.NienKhoa = khoaHoc.NienKhoa;
            db.SubmitChanges();
        }
    }
}
