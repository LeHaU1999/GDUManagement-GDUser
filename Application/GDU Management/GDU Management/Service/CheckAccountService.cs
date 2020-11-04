using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;
using GDU_Management.IDao;
using GDU_Management.DaoImpl;

namespace GDU_Management.Service
{
    class CheckAccountService
    {
        IDaoCheckAccount checkAccIDao = new CheckAccountImpl();

        public CheckAccount CheckAcc(CheckAccount chkAcc)
        {
            return checkAccIDao.CheckAcc(chkAcc);
        }

        public void DeleteVerificationCode()
        {
            checkAccIDao.DeleteVerificationCode();
        }

        public List<CheckAccount> GetVerificationCode()
        {
            return checkAccIDao.GetVerificationCode();
        }
    }
}
