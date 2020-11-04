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

        public List<ThoiKhoaBieu> GetTKBByMaLopAndMaHK(string maLop, string maHK)
        {
            db = new GDUDataConnectionsDataContext();
            var tkb = from x in db.ThoiKhoaBieus where x.MaLop == maLop && x.MaHocKy == maHK select x;
            listTKB = new List<ThoiKhoaBieu>();
            listTKB = tkb.ToList();
            return listTKB;
        }



        public void UpdateThoiKhoaBieu(ThoiKhoaBieu tkb)
        {
            db = new GDUDataConnectionsDataContext();
            ThoiKhoaBieu thoiKhoaBieu = new ThoiKhoaBieu();
            thoiKhoaBieu = db.ThoiKhoaBieus.Single(p => p.MaLop == tkb.MaLop && p.MaMonHoc == tkb.MaMonHoc);
            thoiKhoaBieu.MaGV = tkb.MaGV;
            thoiKhoaBieu.NgayHoc = tkb.NgayHoc;
            Console.WriteLine("cahu vo day r");
            thoiKhoaBieu.MaPhongHoc = tkb.MaPhongHoc;
            thoiKhoaBieu.ThoiGianHoc = tkb.ThoiGianHoc;
            thoiKhoaBieu.NgayBatDau = tkb.NgayBatDau;
            thoiKhoaBieu.NgayKetThuc = tkb.NgayKetThuc;
            thoiKhoaBieu.GhiChu = tkb.GhiChu;
            db.SubmitChanges();
        }
    }
}
