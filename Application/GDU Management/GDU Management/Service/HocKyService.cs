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
    class HocKyService
    {
        IDaoHocKy hocKyIdao = new HocKyImpl();

        //lấy danh sách học kỳ
        public List<HocKy> GetAllHocKy()
        {
            return hocKyIdao.GetAllHocKy();
        }
    }
}
