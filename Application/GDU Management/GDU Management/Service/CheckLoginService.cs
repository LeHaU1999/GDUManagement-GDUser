using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;
using GDU_Management.DaoImpl;
using GDU_Management.IDao;

namespace GDU_Management.Service
{
    class CheckLoginService
    {
        IDaoCheckLogin checkLoginIDao = new CheckLoginImpl();


        //tạo check login
        public CheckLogin CreateCheckLogin(CheckLogin chkLogin)
        {
            return checkLoginIDao.CreateCheckLogin(chkLogin);
        }

        //xóa check login
        public void DeleteCheckLogin()
        {
            checkLoginIDao.DeleteCheckLogin();
        }

        //lấy check Login
        public List<CheckLogin> GetCheckLogin()
        {
            return checkLoginIDao.GetCheckLogin();
        }
    }
}
