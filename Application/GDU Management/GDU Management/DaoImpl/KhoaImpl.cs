using GDU_Management.IDao;
using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDU_Management.DaoImpl
{
    class KhoaImpl : IDaoKhoa
    {
        //tạo kết nối database 
        GDUDataConnectionsDataContext db;
        List<Khoa> listKhoas;

        //lấy database từ cơ sở dữ liệu
        public KhoaImpl()
        {
            db = new GDUDataConnectionsDataContext();
            using (db)
            {
                var khoa = from x in db.Khoas select x;
                db.DeferredLoadingEnabled = true;
                listKhoas = khoa.ToList();
            }
        }

        public List<Khoa> CheckExistsKhoa(string maKhoa)
        {
            return null;
        }

        //tạo một khoa mới
        public Khoa CreateKhoa(Khoa khoa)
        {
            db = new GDUDataConnectionsDataContext();
            Khoa kh = new Khoa();
            kh = khoa;
            db.Khoas.InsertOnSubmit(kh);
            db.SubmitChanges();
            return kh;
        }

        public void DeleteAllKhoaByMaKhoa(string maKhoa)
        {
            throw new NotImplementedException();
        }

        public void DeleteAllKhoasHocByMaKhoasHoc(string maKhoasHoc)
        {
            throw new NotImplementedException();
        }

        //xóa khoa
        public void DeleteKhoa(string maKhoa)
        {
            db = new GDUDataConnectionsDataContext();
            Khoa kh = new Khoa();
            kh = db.Khoas.Single(x => x.MaKhoa == maKhoa);
            db.Khoas.DeleteOnSubmit(kh);
            db.SubmitChanges();
        }

        //lấy tất cả danh sách khoa
        public List<Khoa> GetAllKhoa()
        {
            db = new GDUDataConnectionsDataContext();
            var k = from x in db.Khoas select x;
            listKhoas = k.ToList();
            return listKhoas;
        }

        //lấy thông tin khoa theo mã khoa
        public Khoa GetKhoaByMaKhoa(string maKhoa)
        {
            db = new GDUDataConnectionsDataContext();
            Khoa kh = new Khoa();
            kh = db.Khoas.Single(p=>p.MaKhoa == maKhoa);
            return kh;
        }

        public List<Khoa> SearchKhoaByMaKhoa(string maKhoa)
        {
            db = new GDUDataConnectionsDataContext();
            var khoa = from x in db.Khoas where x.MaKhoa.Contains(maKhoa) select x;
            listKhoas = khoa.ToList();
            return listKhoas;
        }

        public List<Khoa> SearchKhoaByTenKhoa(string tenKhoa)
        {
            db = new GDUDataConnectionsDataContext();
            var khoa = from x in db.Khoas where x.TenKhoa.Contains(tenKhoa) select x;
            listKhoas = khoa.ToList();
            return listKhoas;
        }

        //update khoa
        public void UpdateKhoa(Khoa khoa)
        {
            db = new GDUDataConnectionsDataContext();
            Khoa kh = new Khoa();
            kh = db.Khoas.Single(x => x.MaKhoa == khoa.MaKhoa);
            kh.TenKhoa = khoa.TenKhoa;
            db.SubmitChanges();
        }


    }
}
