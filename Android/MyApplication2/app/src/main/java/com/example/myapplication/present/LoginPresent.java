package com.example.myapplication.present;

import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.content.pm.Signature;
import android.util.Base64;
import android.util.Log;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;


import com.example.myapplication.model.LoginImp;
import com.example.myapplication.model.SERVER;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class LoginPresent extends AppCompatActivity implements LoginImp.Present {
    private LoginImp.View mView;
    ResultSet resultSet;
    final int CHAN_PW_CODE = 4;
    public void setView(LoginImp.View view) {
        mView = view;
    }

    @Override
    public void handleLogin(String useid, String password) {

        try {
        Connection con = SERVER.Connect();
        if(con==null){
            Toast.makeText( this, "Không có kết nối!",Toast.LENGTH_SHORT ).show();
        }

            String query = "select * from SinhVien where Email='" + useid + "' and Password='" + password + "'";
            Statement stmt = con.createStatement();
            resultSet = stmt.executeQuery( query );
            if(resultSet.next()){

                mView.loginSuccsess(useid,password);

                con.close();
            }
            else {
                mView.loginFail( "Lỗi" );
                con.close();
            }
            } catch (SQLException e) {
                e.printStackTrace();
            }

    }

    @Override
    public void gvLogin(String useid, String password) {
        try {
            Connection con = SERVER.Connect();
            if(con==null){
                Toast.makeText( this, "Không có kết nối!",Toast.LENGTH_SHORT ).show();
            }
            String query = "select * from GiangVien where Email='" + useid + "' and Password='" + password + "'";
            Statement stmt = con.createStatement();
            resultSet = stmt.executeQuery( query );
            if(resultSet.next()){
                mView.loginGvSuccsess(useid,password);
                con.close();
            }
            else {
                mView.loginFail( "Lỗi" );
                con.close();
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

}