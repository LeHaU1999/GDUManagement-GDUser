using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.IDao;
using GDU_Management.Model;

namespace GDU_Management.DaoImpl
{
    class CheckAccountImpl : IDaoCheckAccount
    {
        GDUDataConnectionsDataContext db;
        List<CheckAccount> listCodes;

        public CheckAccount CheckAcc(CheckAccount chkAcc)
        {
            db = new GDUDataConnectionsDataContext();
            db.CheckAccounts.InsertOnSubmit(chkAcc);
            db.SubmitChanges();
            return chkAcc;
        }

        public void DeleteVerificationCode()
        {
            db = new GDUDataConnectionsDataContext();
            var listDeleteCodes = from x in db.CheckAccounts select x;
            listCodes = listDeleteCodes.ToList();
            db.CheckAccounts.DeleteAllOnSubmit(listCodes);
            db.SubmitChanges();
        }

        public List<CheckAccount> GetVerificationCode()
        {
            db = new GDUDataConnectionsDataContext();
            var listCode = from x in db.CheckAccounts select x;
            listCodes = listCode.ToList();
            return listCodes;
        }
    }
}
