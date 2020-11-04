using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;
using GDU_Management.IDao;

namespace GDU_Management.DaoImpl
{
    class ContactsImpl:IDaoContacts
    {
        GDUDataConnectionsDataContext db = new GDUDataConnectionsDataContext();
        List<InforContact> listContact;

        //lấy tất cả contacts
        public List<InforContact> GetAllContact()
        {
            db = new GDUDataConnectionsDataContext();
            var ltContact = from x in db.InforContacts select x;
            listContact = ltContact.ToList();
            return listContact;
        }

        //lấy thông tin contacts theo id
        public InforContact InfoContact(string idContacts)
        {
            db = new GDUDataConnectionsDataContext();
            InforContact infoContact = new InforContact();
            infoContact = db.InforContacts.Single(p=>p.ID ==idContacts );
            return infoContact;
        }

        //insert contacts
        public void InsertContacts(InforContact contacts)
        {
            db = new GDUDataConnectionsDataContext();
            InforContact cts = new InforContact();
            cts = db.InforContacts.Single(p => p.ID == contacts.ID);
            cts.Email = contacts.Email;
            cts.Pass = contacts.Pass;
            cts.Subject = contacts.Subject;
            cts.Message = contacts.Message;
            cts.InfoOther = contacts.InfoOther;
            db.SubmitChanges();
        }
    }
}
