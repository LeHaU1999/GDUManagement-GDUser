using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;

namespace GDU_Management.IDao
{
    interface IDaoAdmin
    {
        List<Admin> GetAllAdmin();
        Admin CreateAdmin(Admin ad);
        void DeleteAdmin(string maAD );
        Admin GetAdminByMaAdmin(string idAdmin);
        void UpadteAccount(Admin admin);
        void UpdateInfomation(Admin admin);
        void UpdateAdmin(Admin admin);
        int CountAdmin();
        List<Admin> SearchAdminEmail(string email);
        List<Admin> LoginToSystem(string acc, string pass);
        Admin GetAdminByEmail(string email);
        void UpdateStatusAccountByEmail(Admin admin);
        
    }
}
