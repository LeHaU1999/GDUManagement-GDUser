using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDU_Management.IDao;
using GDU_Management.Model;

namespace GDU_Management.DaoImpl
{
    class MonHocImpl: IDaoMonHoc
    {
        //tao ket noi database
        GDUDataConnectionsDataContext db;
        List<MonHoc> listMonHocs;

        public MonHoc CreateMonHoc(MonHoc monHoc)
        {
            db = new GDUDataConnectionsDataContext();
            db.MonHocs.InsertOnSubmit(monHoc);
            db.SubmitChanges();
            return monHoc;
        }

        //xóa môn học
        public void DeleteMonHoc(string maMonHoc)
        {
            db = new GDUDataConnectionsDataContext();
            MonHoc monhoc = new MonHoc();
            monhoc = db.MonHocs.Single(x => x.MaMonHoc == maMonHoc);
            db.MonHocs.DeleteOnSubmit(monhoc);
            db.SubmitChanges();
        }

        //xóa môn học theo ngành
        public void DeleteMonHocByNganh(string maNganh)
        {
            db = new GDUDataConnectionsDataContext();
            var listMonHocDelete = from x in db.MonHocs.Where(p => p.MaNganh == maNganh) select x;
            db.MonHocs.DeleteAllOnSubmit(listMonHocDelete.ToList());
            db.SubmitChanges();
        }

        public List<MonHoc> GetAllMonHoc()
        {
            //code content
            return null;
        }

        //lấy thông tin môn học theo mã môn học
        public MonHoc GetMonHocByMaMonHoc(string maMonHoc)
        {
            db = new GDUDataConnectionsDataContext();
            MonHoc mh = new MonHoc();
            mh = db.MonHocs.Single(p => p.MaMonHoc.Equals(maMonHoc));
            return mh;
        }

        public List<MonHoc> GetMonHocByNganh(string maNganh)
        {
            db = new GDUDataConnectionsDataContext();
            List<MonHoc> monHoc = db.MonHocs.Where(p => p.MaNganh.Equals(maNganh)).ToList();
            listMonHocs = new List<MonHoc>();
            listMonHocs = monHoc.ToList();
            return listMonHocs;
        }

        public void UpdateMonHoc(MonHoc monHoc)
        {
            db = new GDUDataConnectionsDataContext();
            MonHoc mh = new MonHoc();
            mh = db.MonHocs.Single(x => x.MaMonHoc == monHoc.MaMonHoc);
            mh.TenMonHoc = monHoc.TenMonHoc;
            mh.STC = monHoc.STC;
            db.SubmitChanges();
        }


    }
}
