using GDU_Management.DaoImpl;
using GDU_Management.IDao;
using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDU_Management.Service
{
    class AdminService
    {
        IDaoAdmin adminIDao = new AdminImpl();

        //lấy tất cả admin
        public List<Admin> GetAllAdmin()
        {
            return adminIDao.GetAllAdmin();
        }

        //thêm mới một admin
        public Admin CreateAdmin(Admin ad)
        {
            return adminIDao.CreateAdmin(ad);
        }

        //xóa admin
        public void DeleteAdmin(string maAD)
        {
            adminIDao.DeleteAdmin(maAD);
        }

        //cập nhật admin
        public void UpdateAdmin(Admin ad)
        {
            adminIDao.UpdateAdmin(ad);
        }

        //cập nhật thông tin tài khoản admin
        public void UpadteAccount(Admin admin)
        {
            adminIDao.UpadteAccount(admin);
        }

        //cập nhật thông tin cá nhân admin
        public void UpdateInfomation(Admin admin)
        {
            adminIDao.UpdateInfomation(admin);
        }

        //lấy thông tin admin theo email
        public Admin GetAdminByMaAdmin(string idAdmin)
        {
            return adminIDao.GetAdminByMaAdmin(idAdmin);
        }

        //đếm số lượng admin
        public int CountAdmin()
        {
            return adminIDao.CountAdmin();
        }

        //tìm kiếm admin theo email
        public List<Admin> SearchAdminEmail(string email)
        {
            return adminIDao.SearchAdminEmail(email);
        }

        //đăng nhập vào hệ thống
        public List<Admin> LoginToSystem(string acc, string pass)
        {
            return adminIDao.LoginToSystem(acc, pass);
        }

        //lấy thông tin admin qua email
        public Admin GetAdminByEmail(string email)
        {
            return adminIDao.GetAdminByEmail(email);
        }

        //cập nhật trạng thái tài khoản
        public void UpdateStatusAccountByEmail(Admin admin)
        {
            adminIDao.UpdateStatusAccountByEmail(admin);
        }
    }
}
