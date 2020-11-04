package com.example.myapplication.model;

public class XemDiem {

    public static final int HOC_KY = 0;
    public static final int XEM_DIEM = 1;

    public int type;

    public int getType() {
        return type;
    }

    public void setType(int type) {
        this.type = type;
    }



    private String hocKy;

    public XemDiem(int type, String hocKy) {
        this.type = type;
        this.hocKy = hocKy;
    }



    private String monHoc;
    private String diem30;
    private String diem70l1;
    private String diem70l2;
    private String diemTong;
    public XemDiem(int type, String monHoc, String diem30, String diem70l1, String diem70l2, String diemTong) {
        this.type = type;
        this.monHoc = monHoc;
        this.diem30 = diem30;
        this.diem70l1 = diem70l1;
        this.diem70l2 = diem70l2;
        this.diemTong = diemTong;
    }

    public String getHocKy() {
        return hocKy;
    }

    public void setHocKy(String hocKy) {
        this.hocKy = hocKy;
    }

    public String getMonHoc() {
        return monHoc;
    }

    public void setMonHoc(String monHoc) {
        this.monHoc = monHoc;
    }

    public String getDiem30() {
        return diem30;
    }

    public void setDiem30(String diem30) {
        this.diem30 = diem30;
    }

    public String getDiem70l1() {
        return diem70l1;
    }

    public void setDiem70l1(String diem70l1) {
        this.diem70l1 = diem70l1;
    }

    public String getDiem70l2() {
        return diem70l2;
    }

    public void setDiem70l2(String diem70l2) {
        this.diem70l2 = diem70l2;
    }

    public String getDiemTong() {
        return diemTong;
    }

    public void setDiemTong(String diemTong) {
        this.diemTong = diemTong;
    }
}
