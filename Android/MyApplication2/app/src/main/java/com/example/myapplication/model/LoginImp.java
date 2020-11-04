package com.example.myapplication.model;

public interface LoginImp {

    interface View{

        void loginSuccsess(String useid, String password);
        void loginGvSuccsess(String useid, String password);
        void loginFail(String error);

    }

    interface Present{
        void handleLogin(String email, String password);
        void gvLogin(String email, String password);
    }
}
