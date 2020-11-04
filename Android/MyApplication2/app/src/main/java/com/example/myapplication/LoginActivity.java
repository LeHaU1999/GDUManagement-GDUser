package com.example.myapplication;

import androidx.appcompat.app.ActionBar;
import androidx.appcompat.app.AppCompatActivity;
import androidx.cardview.widget.CardView;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.os.Handler.Callback;
import android.util.Log;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;

import com.example.myapplication.model.LoginImp;
import com.example.myapplication.present.LoginPresent;

import java.sql.ResultSet;

public class LoginActivity extends AppCompatActivity implements LoginImp.View, View.OnClickListener {
private CardView cvLogin;

    private EditText edtUserName, edtPassword;
    private RadioButton rdbSinhVien, rdbGiangVien;
    private TextView tvResult;
    private ResultSet resultSet;
    SharedPreferences sharedPreferences;

    boolean quyen=false;
    boolean trangThai=false;
    private LoginPresent button_login;
    final int CHAN_PW_CODE = 4;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        ActionBar actionBar = getSupportActionBar();
        actionBar.hide(); //Ẩn ActionBar nếu muốn
        cvLogin = findViewById(R.id.cvLogin);
        Context context;

        initView();
        registerListener();
        initPresenter();


    }
    private void initView(){
        cvLogin = (CardView) this.findViewById( R.id.cvLogin );
        edtUserName = (EditText) this.findViewById( R.id.user );
        edtPassword = (EditText) this.findViewById( R.id.password );
        rdbSinhVien = (RadioButton) findViewById( R.id.rdbSinhVien );
        rdbGiangVien = (RadioButton) findViewById( R.id.rdbGiangVien );
    }
    private void registerListener() {
        cvLogin.setOnClickListener( (View.OnClickListener) this );
    }
    private void initPresenter() {
        button_login = new LoginPresent();
        button_login.setView(this);
    }
    @Override
    public void onClick(View v) {
        switch (v.getId()) {
            case R.id.cvLogin:
                Animation animation = AnimationUtils.loadAnimation(this,R.anim.anim_alpha );
                v.startAnimation( animation );
                login();
                break;
            default:
                break;
        }
    }
    private void login() {
        String useid = edtUserName.getText().toString(); // biến cục bộ, xài cục bộ
        String password = edtPassword.getText().toString(); // như trên
        if (useid.isEmpty() || password.isEmpty()) {
            Toast.makeText(this,
                    "Username or Password is Empty!", Toast.LENGTH_SHORT).show();
        }else {
            if(rdbSinhVien.isChecked()){
                quyen=false;
                button_login.handleLogin(useid, password);

            }if(rdbGiangVien.isChecked()) {
                button_login.gvLogin( useid,password );
                quyen = true;

            }else {
            }
        }

    }

    @Override
    public void loginSuccsess(String useid,String password) {
//        SessionManagement sessionManagement = new SessionManagement( LoginActivity.this );
//        sessionManagement.saveSession( useid );

        Intent intent= new Intent(this, MainActivity.class);
        intent.setFlags( Intent.FLAG_ACTIVITY_CLEAR_TASK|Intent.FLAG_ACTIVITY_CLEAR_TOP );
        intent.putExtra( "Email", useid);
        intent.putExtra( "Password", password );
        intent.putExtra( "Check","SV" );
        startActivityForResult(intent,CHAN_PW_CODE);
        Toast.makeText(this, "Sign In Success!", Toast.LENGTH_SHORT).show();
    }

    @Override
    public void loginGvSuccsess(String useid,String password) {
        Intent intent= new Intent(this, MainActivityGV.class);
        intent.setFlags( Intent.FLAG_ACTIVITY_CLEAR_TASK|Intent.FLAG_ACTIVITY_CLEAR_TOP );
        intent.putExtra( "Email", useid);
        intent.putExtra( "Password", password );
        intent.putExtra( "Check","GV" );
        startActivityForResult(intent,CHAN_PW_CODE);
        Toast.makeText(this, "Sign In Success!", Toast.LENGTH_SHORT).show();

    }

    @Override
    public void loginFail(String error) {
        Toast.makeText(this, "Sign In Failse!", Toast.LENGTH_SHORT).show();

    }
}