package com.example.myapplication.present;

import androidx.appcompat.app.AppCompatActivity;

import com.example.myapplication.model.MainImpl;


public class MainPresent extends AppCompatActivity implements MainImpl.Present {
    private MainImpl.View mview;
    public void setView (MainImpl.View view){
        mview = view;
    }

    @Override
    public void handleHome() {
        mview.Home();
    }

    @Override
    public void handleThongTin() {

        mview.ThongTin();
    }

    @Override
    public void handleXemDiem() {
        mview.XemDiem();
    }

    @Override
    public void handleHocKy() {
        mview.HocKy();
    }

    @Override
    public void handleTKB() {
        mview.TKB();
    }

    @Override
    public void handleTienTrinh() {
        mview.TienTrinh();
    }

    @Override
    public void handleLogout() {
        mview.Logout();
    }


}
