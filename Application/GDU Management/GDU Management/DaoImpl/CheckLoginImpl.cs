using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;
using GDU_Management.IDao;

namespace GDU_Management.DaoImpl
{
    class CheckLoginImpl : IDaoCheckLogin
    {
        GDUDataConnectionsDataContext db;

        //tạo check login
        public  CheckLogin CreateCheckLogin(CheckLogin chkLogin)
        {
            db = new GDUDataConnectionsDataContext();
            db.CheckLogins.InsertOnSubmit(chkLogin);
            db.SubmitChanges();
            return chkLogin;
        }

        //xóa check login
        public void DeleteCheckLogin()
        {
            db = new GDUDataConnectionsDataContext();
            var listCheckLogin = from x in db.CheckLogins select x;
            db.CheckLogins.DeleteAllOnSubmit(listCheckLogin.ToList());
            db.SubmitChanges();
        }

        //lấy check Login
        public List<CheckLogin> GetCheckLogin()
        {
            db = new GDUDataConnectionsDataContext();
            var listCheckLogin = from x in db.CheckLogins select x;
            return listCheckLogin.ToList();
        }
    }
}
