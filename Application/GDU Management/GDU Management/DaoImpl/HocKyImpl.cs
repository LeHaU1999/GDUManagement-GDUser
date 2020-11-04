using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;
using GDU_Management.IDao;

namespace GDU_Management.DaoImpl
{
    class HocKyImpl : IDaoHocKy
    {
        GDUDataConnectionsDataContext db;
        List<HocKy> listHocKy;

        //lấy danh sách học kỳ
        public List<HocKy> GetAllHocKy()
        {
            db = new GDUDataConnectionsDataContext();
            var hocKy = from x in db.HocKies select x;
            listHocKy = hocKy.ToList();
            return listHocKy;
        }
    }
}
