using GDU_Management.IDao;
using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDU_Management.DaoImpl
{
    class ThoiKhoaBieuImpl : IDaoThoiKhoaBieu
    {
        GDUDataConnectionsDataContext db;
        List<ThoiKhoaBieu> listTKB;

        public ThoiKhoaBieu CreateThoiKhoaBieu(ThoiKhoaBieu tkb)
        {
            db = new GDUDataConnectionsDataContext();
            db.ThoiKhoaBieus.InsertOnSubmit(tkb);
            db.SubmitChanges();
            return tkb;
        }

        public void DeleteThoiKhoaBieu(string maLop, string maMonHoc)
        {
            db = new GDUDataConnectionsDataContext();
            ThoiKhoaBieu tkb = new ThoiKhoaBieu();
            tkb = db.ThoiKhoaBieus.Single(p => p.MaLop == maLop && p.MaMonHoc == maMonHoc);
            db.ThoiKhoaBieus.DeleteOnSubmit(tkb);
            db.SubmitChanges();
        }

        public void DeleteThoiKhoaBieuByGiangVien(string maGV)
        {
            db = new GDUDataConnectionsDataContext();
            var listDeleteThoiKhoaBieu = from x in db.ThoiKhoaBieus.Where(p => p.MaGV == maGV) select x;
            db.ThoiKhoaBieus.DeleteAllOnSubmit(listDeleteThoiKhoaBieu.ToList());
            db.SubmitChanges();
        }

        //xóa danh sách thời khóa biểu theo lớp.
        public void DeleteThoiKhoaBieuByLop(string maLop)
        {
            db = new GDUDataConnectionsDataContext();
            var listDeleteTKB = from x in db.ThoiKhoaBieus.Where(p => p.MaLop == maLop) select x;
            db.ThoiKhoaBieus.DeleteAllOnSubmit(listDeleteTKB.ToList());
            db.SubmitChanges();
        }

        //xóa thời khóa biểu theo môn học
        public void DeleteThoiKhoaBieuByMaMonHoc(string maMonHoc)
        {
            db = new GDUDataConnectionsDataContext();
            var listDeleteTKB = from x in db.ThoiKhoaBieus.Where(p => p.MaMonHoc == maMonHoc) select x;
            db.ThoiKhoaBieus.DeleteAllOnSubmit(listDeleteTKB.ToList());
            db.SubmitChanges();
        }

        public List<ThoiKhoaBieu> GetAllMaMonHocInTKB()
        {
            db = new GDUDataConnectionsDataContext();

            return null;
        }

        public ThoiKhoaBieu GetThoiKhoaBieuByMaLopMaMonHoc(string maLop, string maMH)
        {
            db = new GDUDataConnectionsDataContext();
            ThoiKhoaBieu InfoTKB = new ThoiKhoaBieu();
            InfoTKB = db.ThoiKhoaBieus.Single(p => p.MaLop == maLop && p.MaMonHoc == maMH);
            return InfoTKB;
        }

        public List<ThoiKhoaBieu> GetTKBByMaLop(string maLop)
        {
            db = new GDUDataConnectionsDataContext();
            var tkb = from x in db.ThoiKhoaBieus where x.MaLop == maLop select x;
            listTKB = new List<ThoiKhoaBieu>();
            listTKB = tkb.ToList();
            return listTKB;
        }

        //lấy danh sách thời khóa biểu theo mã lớp và mã hk
        public List<ThoiKhoaBieu> GetTKBByMaLopAndMaHK(string maLop, string maHK)
        {
            db = new GDUDataConnectionsDataContext();
            var listMonHocByLopAndHK = from x in db.ThoiKhoaBieus.Where(p => p.MaLop == maLop && p.MaHocKy == maHK) select x;
            listTKB = listMonHocByLopAndHK.ToList();
            return listTKB;
        }

        public void UpdateThoiKhoaBieu(ThoiKhoaBieu tkb)
        {
            db = new GDUDataConnectionsDataContext();
            ThoiKhoaBieu thoiKhoaBieu = new ThoiKhoaBieu();
            thoiKhoaBieu = db.ThoiKhoaBieus.Single(p => p.MaLop == tkb.MaLop && p.MaMonHoc == tkb.MaMonHoc);
            thoiKhoaBieu.MaGV = tkb.MaGV;
            thoiKhoaBieu.NgayHoc = tkb.NgayHoc;
            thoiKhoaBieu.MaPhongHoc = tkb.MaPhongHoc;
            thoiKhoaBieu.ThoiGianHoc = tkb.ThoiGianHoc;
            thoiKhoaBieu.NgayBatDau = tkb.NgayBatDau;
            thoiKhoaBieu.NgayKetThuc = tkb.NgayKetThuc;
            thoiKhoaBieu.GhiChu = tkb.GhiChu;
            db.SubmitChanges();
        }
    }
}
