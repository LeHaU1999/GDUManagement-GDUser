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
    class ContactService
    {
        IDaoContacts contactsIdao = new ContactsImpl();
        public List<InforContact> GetAllContact()
        {
            return contactsIdao.GetAllContact();
        }

        public void InsertContacts(InforContact contacts)
        {
            contactsIdao.InsertContacts(contacts);
        }

        public InforContact InfoContact(string idContacts)
        {
            return contactsIdao.InfoContact(idContacts);
        }
    }
}
