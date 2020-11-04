using GDU_Management.DaoImpl;
using GDU_Management.IDao;
using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDU_Management.Service
{
    class NganhHocService
    {
        IDaoNganhHoc nganhHocIDao = new NganhHocImpl();
        //lấy danh sách ngành hoc
        public List<NganhHoc> GetAllNganhHoc()
        {
            return nganhHocIDao.GetAllNganhhoc();
        }
        //tạo ngành học
        public NganhHoc CreateNganhHoc(NganhHoc nganhHoc)
        {
            return nganhHocIDao.CreateNganhHoc(nganhHoc);
        }
        //xóa ngành học
        public void DeleteNganhHoc(string maNganhHoc)
        {
            nganhHocIDao.DeleteNganhHoc(maNganhHoc);
        }
        //cập nhật ngành học
        public void UpdateNganhHoc(NganhHoc nganhHoc)
        {
            nganhHocIDao.UpdateNganhHoc(nganhHoc);
        }

        //lấy ngành theo khoa
        public List<NganhHoc> GetNganhHocByKHOA(string maKhoa)
        {
            return nganhHocIDao.GetNganhHocByKHOA(maKhoa);
        }

        //tìm danh sách ngành học theo mã ngành
        public List<NganhHoc> SearchNganhHocByMaNganh(string maNganh)
        {
            return nganhHocIDao.SearchNganhHocByMaNganh(maNganh);
        }

        //tìm danh sách ngành học theo tên ngành
        public List<NganhHoc> SearchNganhHocByTenNganh(string maKhoa, string tenNganh)
        {
            return nganhHocIDao.SearchNganhHocByTenNganh(maKhoa, tenNganh);
        }

        //lấy thông tin ngành học
        public NganhHoc GetNganhHocByMaNganh(string maNganh)
        {
            return nganhHocIDao.GetNganhHocByMaNganh(maNganh);
        }
    }
}
