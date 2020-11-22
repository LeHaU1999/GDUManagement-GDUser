﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;

namespace GDU_Management.IDao
{
    interface IDaoThoiKhoaBieu
    {
        ThoiKhoaBieu CreateThoiKhoaBieu(ThoiKhoaBieu tkb);
        List<ThoiKhoaBieu> GetTKBByMaLop(string maLop);
        void UpdateThoiKhoaBieu(ThoiKhoaBieu tkb);
        void DeleteThoiKhoaBieu(string maLop, string maMonHoc);
        ThoiKhoaBieu GetThoiKhoaBieuByMaLopMaMonHoc(string maLop, string maMH);
        List<ThoiKhoaBieu> GetAllMaMonHocInTKB();
        void DeleteThoiKhoaBieuByLop(string maLop);
        List<ThoiKhoaBieu> GetTKBByMaLopAndMaHK(string maLop, string maHK);
        void DeleteThoiKhoaBieuByMaMonHoc(string maMonHoc);
        void DeleteThoiKhoaBieuByGiangVien(string maGV);
    }
}
