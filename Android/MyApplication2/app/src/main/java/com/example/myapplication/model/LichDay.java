package com.example.myapplication.model;

public class LichDay {
    private String Thu;
    private String MonDay;
    private String CaDay;
    private String PhongDay;
    private String NgayBatDau;
    private String NgayKetThuc;
    private String Lop;



    public String getThu() {
        return Thu;
    }

    public void setThu(String thu) {
        Thu = thu;
    }

    public String getMonDay() {
        return MonDay;
    }

    public void setMonDay(String monDay) {
        MonDay = monDay;
    }

    public String getCaDay() {
        return CaDay;
    }

    public void setCaDay(String caDay) {
        CaDay = caDay;
    }

    public String getPhongDay() {
        return PhongDay;
    }

    public void setPhongDay(String phongDay) {
        PhongDay = phongDay;
    }

    public String getNgayBatDau() {
        return NgayBatDau;
    }

    public void setNgayBatDau(String ngayBatDau) {
        NgayBatDau = ngayBatDau;
    }

    public String getNgayKetThuc() {
        return NgayKetThuc;
    }

    public void setNgayKetThuc(String ngayKetThuc) {
        NgayKetThuc = ngayKetThuc;
    }
    public String getLop() {
        return Lop;
    }

    public void setLop(String lop) {
        Lop = lop;
    }


    public LichDay(String thu, String monDay, String caDay, String phongDay, String ngayBatDau, String ngayKetThuc, String lop) {
        Thu = thu;
        MonDay = monDay;
        CaDay = caDay;
        PhongDay = phongDay;
        NgayBatDau = ngayBatDau;
        NgayKetThuc = ngayKetThuc;
        Lop = lop;
    }


}
