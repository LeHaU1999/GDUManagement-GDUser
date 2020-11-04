package com.example.myapplication.model;

public class TKB {
    private String MonHoc;
    private String ThuNgay;
    private String PhongHoc;
    private String ThoiGianHoc;
    private String TenGV;
    private String NgayBD;
    private String NgayKT;

    public TKB(String monHoc, String thuNgay, String phongHoc, String thoiGianHoc, String tenGV, String ngayBD, String ngayKT) {
        MonHoc = monHoc;
        ThuNgay = thuNgay;
        PhongHoc = phongHoc;
        ThoiGianHoc = thoiGianHoc;
        TenGV = tenGV;
        NgayBD = ngayBD;
        NgayKT = ngayKT;
    }

    public TKB(String monHoc, String thuNgay) {
        this.MonHoc = monHoc;
        this.ThuNgay = thuNgay;

    }
    public String getMonHoc() {
        return MonHoc;
    }

    public void setMonHoc(String monHoc) {
        MonHoc = monHoc;
    }

    public String getThuNgay() {
        return ThuNgay;
    }

    public void setThuNgay(String thuNgay) {
        ThuNgay = thuNgay;
    }


    public String getPhongHoc() {
        return PhongHoc;
    }

    public void setPhongHoc(String phongHoc) {
        PhongHoc = phongHoc;
    }

    public String getThoiGianHoc() {
        return ThoiGianHoc;
    }

    public void setThoiGianHoc(String thoiGianHoc) {
        ThoiGianHoc = thoiGianHoc;
    }

    public String getTenGV() {
        return TenGV;
    }

    public void setTenGV(String tenGV) {
        TenGV = tenGV;
    }

    public String getNgayBD() {
        return NgayBD;
    }

    public void setNgayBD(String ngayBD) {
        NgayBD = ngayBD;
    }

    public String getNgayKT() {
        return NgayKT;
    }

    public void setNgayKT(String ngayKT) {
        NgayKT = ngayKT;
    }



}
