using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.IDao;
using GDU_Management.Model;


namespace GDU_Management.DaoImpl
{
    class AdminImpl : IDaoAdmin
    {
        //tao ket noi database
        GDUDataConnectionsDataContext db = new GDUDataConnectionsDataContext();
        List<Admin> listAD;
        public Admin CreateAdmin(Admin ad)
        {
            db = new GDUDataConnectionsDataContext();
            db.Admins.InsertOnSubmit(ad);
            db.SubmitChanges();
            return ad;
        }

        //xóa admin
        public void DeleteAdmin(string maAD)
        {
            db = new GDUDataConnectionsDataContext();
            Admin ad = new Admin();
            ad = db.Admins.Single(p => p.MaAdmin == maAD);
            db.Admins.DeleteOnSubmit(ad);
            db.SubmitChanges();
        }

        //lấy thông tin admin theo email
        public Admin GetAdminByMaAdmin(string idAdmin)
        {
            db = new GDUDataConnectionsDataContext();
            Admin admin = new Admin();
            admin = db.Admins.Single(p => p.MaAdmin == idAdmin);
            return admin;
        }

        //lấy danh sách admin
        public List<Admin> GetAllAdmin()
        {
            db = new GDUDataConnectionsDataContext();
            var ad = from x in db.Admins select x;
            listAD = ad.ToList();
            return listAD;
        }

        //cập nhật thông tin tài khoản admin
        public void UpadteAccount(Admin admin)
        {
            db = new GDUDataConnectionsDataContext();
            Admin ad = new Admin();
            ad = db.Admins.Single(p => p.MaAdmin == admin.MaAdmin);
            ad.Password = admin.Password;
            //ad.Avt = admin.Avt;
            ad.StatusAcc = admin.StatusAcc;
            db.SubmitChanges();
        }

        //cập nhật thông tin cá nhân admin
        public void UpdateInfomation(Admin admin)
        {
            db = new GDUDataConnectionsDataContext();
            Admin ad = new Admin();
            ad = db.Admins.Single(p => p.MaAdmin == admin.MaAdmin);
            ad.TenAdmin = admin.TenAdmin;
            ad.GioiTinh = admin.GioiTinh;
            ad.NamSinh = admin.NamSinh;
            ad.SDT = admin.SDT;
            db.SubmitChanges();
        }

        //cập nhật tất cả thông tin admin
        public void UpdateAdmin(Admin admin)
        {
            db = new GDUDataConnectionsDataContext();
            Admin ad = new Admin();
            ad = db.Admins.Single(p => p.MaAdmin == admin.MaAdmin);
            ad.TenAdmin = admin.TenAdmin;
            ad.Avt = admin.Avt;
            ad.GioiTinh = admin.GioiTinh;
            ad.NamSinh = admin.NamSinh;
            ad.SDT = admin.SDT;
            ad.Email = admin.Email;
            //ad.Password = admin.Password;
            ad.DiaChi = admin.DiaChi;
            ad.GhiChu = admin.GhiChu;
            ad.StatusAcc = admin.StatusAcc;
            db.SubmitChanges();
        }

        //đếm số lượng admin
        public int CountAdmin()
        {
            db = new GDUDataConnectionsDataContext();
            int countsAD = db.Admins.Count();
            return countsAD;
        }

        //tìm kiếm admin theo email
        public List<Admin> SearchAdminEmail(string email)
        {
            db = new GDUDataConnectionsDataContext();
            var searchAd = from x in db.Admins.Where(p=>p.Email.Contains(email)) select x ;
            listAD = searchAd.ToList();
            return listAD;
        }


        //lay ad dang nhap vaof system
        public List<Admin> LoginToSystem(string acc, string pass)
        {
            db = new GDUDataConnectionsDataContext();
            var adLogin = from x in db.Admins where x.Email == acc && x.Password == pass select x;
            listAD = adLogin.ToList();
            return listAD;
        }

        //lấy thông tim admin theo email
        public Admin GetAdminByEmail(string email)
        {
            db = new GDUDataConnectionsDataContext();
            Admin admin = new Admin();
            admin = db.Admins.Single(p => p.Email == email);
            return admin;
        }

        //update trạng thái acc
        public void UpdateStatusAccountByEmail(Admin admin)
        {
            db = new GDUDataConnectionsDataContext();
            Admin ad = new Admin();
            ad = db.Admins.Single(p => p.MaAdmin == admin.MaAdmin);
            ad.StatusAcc = admin.StatusAcc;
            db.SubmitChanges();
        }
    }
}
