using GDU_Management.IDao;
using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GDU_Management.DaoImpl
{
    class NganhHocImpl : IDaoNganhHoc
    {
        //tao ket noi database
        GDUDataConnectionsDataContext db;
        List<NganhHoc> listNganhHoc;

        //lấy database từ cơ sở dữ liệu
        public NganhHocImpl()
        {
            db = new GDUDataConnectionsDataContext();
            using (db)
            {
                var nganhHoc = from x in db.NganhHocs select x;
                db.DeferredLoadingEnabled = true;
                listNganhHoc = nganhHoc.ToList();
            }
        }

        public List<NganhHoc> CheckKhoaByNganh()
        {
            return null;
        }

        // thêm ngành
        public NganhHoc CreateNganhHoc(NganhHoc nganhHoc)
        {
            db = new GDUDataConnectionsDataContext();
            NganhHoc nh = new NganhHoc();
            nh = nganhHoc;
            db.NganhHocs.InsertOnSubmit(nh);
            db.SubmitChanges();
            return nh;
        }

        //xóa ngành
        public void DeleteNganhHoc(string maNganhHoc)
        {
            db = new GDUDataConnectionsDataContext();
            NganhHoc nh = new NganhHoc();
            nh = db.NganhHocs.Single(x => x.MaNganh == maNganhHoc);
            db.NganhHocs.DeleteOnSubmit(nh);
            db.SubmitChanges();
        }

        //lấy tất cả danh sách ngành học
        public List<NganhHoc> GetAllNganhhoc()
        {
            db = new GDUDataConnectionsDataContext();
            var nganhHoc = db.NganhHocs;
            listNganhHoc = nganhHoc.ToList();
            return listNganhHoc;
        }

        //lấy danh sách ngành học theo KHOA
        public List<NganhHoc> GetNganhHocByKHOA(string maKhoa)
        {
            db = new GDUDataConnectionsDataContext();
            List<NganhHoc> nganhHoc = db.NganhHocs.Where(p => p.MaKhoa.Equals(maKhoa)).ToList();
            listNganhHoc = new List<NganhHoc>();
            listNganhHoc = nganhHoc;
            return listNganhHoc;
        }

        //lấy thông tin ngành học
        public NganhHoc GetNganhHocByMaNganh(string maNganh)
        {
            db = new GDUDataConnectionsDataContext();
            NganhHoc nganhHoc = new NganhHoc();
            nganhHoc = db.NganhHocs.Single(p=>p.MaNganh == maNganh);
            return nganhHoc;
        }

        // tìm kiếm ngành học theo mã ngành
        public List<NganhHoc> SearchNganhHocByMaNganh(string maNganh)
        {
            db = new GDUDataConnectionsDataContext();
            var nganhHoc = from x in db.NganhHocs where x.MaNganh.Contains(maNganh) select x;
            listNganhHoc = nganhHoc.ToList();
            return listNganhHoc;
        }

        // tìm kiếm ngành học theo tên ngành
        public List<NganhHoc> SearchNganhHocByTenNganh(string maKhoa, string tenNganh)
        {
            db = new GDUDataConnectionsDataContext();
            var nganhHoc = from x in db.NganhHocs.Where(p=>p.MaKhoa == maKhoa & p.TenNganh.Contains(tenNganh)) select x;
            listNganhHoc = nganhHoc.ToList();
            return listNganhHoc;
        }

   
        //update ngành học
        public void UpdateNganhHoc(NganhHoc nganhHoc)
        {
            db = new GDUDataConnectionsDataContext();
            NganhHoc nh = new NganhHoc();
            nh = db.NganhHocs.Single(x => x.MaNganh == nganhHoc.MaNganh);
            nh.TenNganh = nganhHoc.TenNganh;
            db.SubmitChanges();
        }


    }
}
