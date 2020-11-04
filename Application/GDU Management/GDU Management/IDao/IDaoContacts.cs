using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;

namespace GDU_Management.IDao
{
    interface IDaoContacts
    {
        List<InforContact> GetAllContact();
        void InsertContacts(InforContact contacts);
        InforContact InfoContact(string idContacts);
    }
}
