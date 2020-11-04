package com.example.myapplication.present;

import androidx.appcompat.app.AppCompatActivity;

import com.example.myapplication.model.MainGvImpl;


public class MainGVPresent extends AppCompatActivity implements MainGvImpl.Present {
    private MainGvImpl.View mview;
    public void setView (MainGvImpl.View view){
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
    public void handleLichDay() {
        mview.LichDay();
    }

    @Override
    public void handleLichCongTac() {
        mview.LichCongTac();
    }

    @Override
    public void handleLogout() {
        mview.Logout();
    }

}
