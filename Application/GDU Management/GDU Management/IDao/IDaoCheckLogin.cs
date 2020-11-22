using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;

namespace GDU_Management.IDao
{
    interface IDaoCheckLogin
    {
         CheckLogin CreateCheckLogin(CheckLogin chkLogin);
        void DeleteCheckLogin();
        List<CheckLogin> GetCheckLogin();
    }
}
