using GDU_Management.DaoImpl;
using GDU_Management.IDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model; 

namespace GDU_Management.Service
{
    class MonHocService
    {
        IDaoMonHoc monHocIDao = new MonHocImpl();

        //lấy tất cả môn học
        public List<MonHoc> GetAllMonHoc()
        {
            return monHocIDao.GetAllMonHoc();
        }
        //thêm mới một môn học
        public MonHoc CreateMonHoc(MonHoc monHoc)
        {
            return monHocIDao.CreateMonHoc(monHoc);
        }
        //xóa môn học
        public void DeleteMonHoc(string maMonHoc)
        {
            monHocIDao.DeleteMonHoc(maMonHoc);
        }
        //cập nhật môn học
        public void UpdateMonHoc(MonHoc monHoc)
        {
            monHocIDao.UpdateMonHoc(monHoc);
        }

        public List<MonHoc> GetMonHocByNganh(string maNganh)
        {
            return monHocIDao.GetMonHocByNganh(maNganh);
        }

        //lấy thông tin môn học theo mã môn học
        public MonHoc GetMonHocByMaMonHoc(string maMonHoc)
        {
            return monHocIDao.GetMonHocByMaMonHoc(maMonHoc);
        }

        //xóa môn học theo ngành
        public void DeleteMonHocByNganh(string maNganh)
        {
            monHocIDao.DeleteMonHocByNganh(maNganh);
        }
    }
}
