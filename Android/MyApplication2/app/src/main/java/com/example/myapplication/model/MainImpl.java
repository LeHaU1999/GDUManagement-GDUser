package com.example.myapplication.model;

public interface MainImpl {
    interface View {
        void Home();
        void ThongTin();
        void XemDiem();
        void TKB();
        void HocKy();
        void TienTrinh();
        void Logout();
    }
    interface Present{
        void handleHome();
        void handleThongTin();
        void handleXemDiem();
        void handleHocKy();
        void handleTKB();
        void handleTienTrinh();
        void handleLogout();
    }

}
