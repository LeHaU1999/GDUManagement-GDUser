package com.example.myapplication.model;

public class TienTrinh {
    private String tenMonHoc;
    private String soTinChi;
    private String tinhTrang;
    public String getTenMonHoc() {
        return tenMonHoc;
    }

    public void setTenMonHoc(String tenMonHoc) {
        this.tenMonHoc = tenMonHoc;
    }

    public String getSoTinChi() {
        return soTinChi;
    }

    public void setSoTinChi(String soTinChi) {
        this.soTinChi = soTinChi;
    }



    public TienTrinh(String tenMonHoc, String soTinChi,String tinhTrang) {
        this.tenMonHoc = tenMonHoc;
        this.soTinChi = soTinChi;
        this.tinhTrang = tinhTrang;
    }


    public String getTinhTrang() {
        return tinhTrang;
    }

    public void setTinhTrang(String tinhTrang) {
        this.tinhTrang = tinhTrang;
    }







}
