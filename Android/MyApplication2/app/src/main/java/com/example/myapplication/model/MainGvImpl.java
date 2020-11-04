package com.example.myapplication.model;

public interface MainGvImpl {
    interface View{
        void Home();
        void ThongTin();
        void LichDay();
        void LichCongTac();
        void Logout();
    }
    interface Present{
        void handleHome();
        void handleThongTin();
        void handleLichDay();
        void handleLichCongTac();
        void handleLogout();
    }

}
