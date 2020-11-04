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
    class LopImpl : IDaoLop
    {
        //tạo kết nối database 
        GDUDataConnectionsDataContext db;
        List<Lop> listLop;
        public Lop CreateLop(Lop lop)
        {
            db = new GDUDataConnectionsDataContext();
            db.Lops.InsertOnSubmit(lop);
            db.SubmitChanges();
            return lop;
        }

        //Xóa tất cả lớp trong ngành
        public void DeleteAllLopInNganh(string maKhoasHoc, string maNganh)
        {
            db = new GDUDataConnectionsDataContext();
            var listLop = from x in db.Lops.Where(p=>p.MaKhoaHoc == maKhoasHoc & p.MaNganh == maNganh) select x;
            List<Lop> listLopDeleteAll = new List<Lop>();
            listLopDeleteAll = listLop.ToList();
            db.Lops.DeleteAllOnSubmit(listLopDeleteAll);
            db.SubmitChanges();
        }

        public void DeleteLop(string maLop)
        {
            db = new GDUDataConnectionsDataContext();
            Lop lop = new Lop();
            lop = db.Lops.Single(x => x.MaLop == maLop);
            db.Lops.DeleteOnSubmit(lop);
            db.SubmitChanges();
        }

        public List<Lop> getAllLop()
        {
            db = new GDUDataConnectionsDataContext();
            var lop = db.Lops;
            listLop = lop.ToList();
            return listLop ;
        }

        //lấy danh sách lớp theo mã ngành và mã khóa học
        public List<Lop> GetDanhSachLopByMaNganhVaMaKhoaHoc(string maNganh, string maKhoaHoc)
        {
            db = new GDUDataConnectionsDataContext();
            var lop = from x in db.Lops where x.MaNganh == maNganh && x.MaKhoaHoc == maKhoaHoc select x;
            listLop = new List<Lop>();
            listLop = lop.ToList();
            return listLop;
        }

        //lấy thông tin Lớp
        public Lop GetLopByMaLop(string maLop)
        {
            db = new GDUDataConnectionsDataContext();
            Lop lp = new Lop();
            lp = db.Lops.Single(p => p.MaLop == maLop);
            return lp;
        }

        //tìm kiếm lớp theo tên lớp
        public List<Lop> SearchLopHocByTenLop(string maNganh, string tenLop)
        {
            db = new GDUDataConnectionsDataContext();
            var lop = from x in db.Lops.Where(p=>p.MaNganh == maNganh& p.TenLop.Contains(tenLop)) select x;
            listLop = lop.ToList();
            return listLop;
        }

        // update lop
        public void UpdateLop(Lop lop)
        {
            db = new GDUDataConnectionsDataContext();
            Lop lp = new Lop();
            lp = db.Lops.Single(x => x.MaLop == lop.MaLop);
            lp.TenLop = lop.TenLop;
            lp.MaKhoaHoc = lop.MaKhoaHoc;
            lp.MaNganh = lop.MaNganh;
            db.SubmitChanges();
        }


    }
}
