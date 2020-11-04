package com.example.myapplication.ui;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.drawerlayout.widget.DrawerLayout;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;


import com.example.myapplication.R;
import com.example.myapplication.present.ThoiKhoaBieuFragment;
import com.google.android.material.navigation.NavigationView;


public class HocKyActivity extends AppCompatActivity {
    private ConstraintLayout txtHk1;
    private ConstraintLayout txtHk2;
    private ConstraintLayout txtHk3;
    private ConstraintLayout txtHk4;
    private ConstraintLayout txtHk5;
    private ConstraintLayout txtHk6;
    private ConstraintLayout txtHk7;
    private ConstraintLayout txtHk8;

    String uss,kiemtra;
    String backStateName = null;

    String us;
    private DrawerLayout drawerLayout;
    private NavigationView navigationView;
    private Toolbar toolbar;

    final int CHAN_PW_CODE = 4;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate( savedInstanceState );
        setContentView( R.layout.activity_hoc_ky );
        txtHk1 = findViewById( R.id.txtHk1 );
        txtHk2 = findViewById( R.id.txtHk2 );
        txtHk3 = findViewById( R.id.txtHk3 );
        txtHk4 = findViewById( R.id.txtHk4 );
        txtHk5 = findViewById( R.id.txtHk5 );
        txtHk6 = findViewById( R.id.txtHk6 );
        txtHk7 = findViewById( R.id.txtHk7 );
        txtHk8 = findViewById( R.id.txtHk8 );

        Intent intent = getIntent();
        Bundle extras = getIntent().getExtras();
        uss = extras.getString("Email", "N/A");

        Log.e("ERROR","lỗi thực thi câu12: "+ kiemtra);

            txtHk1.setOnClickListener( new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Bundle bundle = new Bundle();
                    bundle.putString( "HK", "HK01" );
                    bundle.putString("Email", uss);
                    replaceFragment(new ThoiKhoaBieuFragment());
                }
            } );
            txtHk2.setOnClickListener( new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Bundle bundle = new Bundle();
                    bundle.putString( "HK", "HK02" );
                    bundle.putString("Email", uss);
                    replaceFragment(new ThoiKhoaBieuFragment());

                }
            } );
            txtHk3.setOnClickListener( new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Intent intent = new Intent( HocKyActivity.this, ThoiKhoaBieuFragment.class );
                    Bundle extras = getIntent().getExtras();
                    uss = extras.getString( "Email", "N/A" );
                    intent.putExtra( "HK", "HK03" );
                    intent.putExtra( "Email", uss );
                    startActivity( intent );
                }
            } );
            txtHk4.setOnClickListener( new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Intent intent = new Intent( HocKyActivity.this, ThoiKhoaBieuFragment.class );
                    Bundle extras = getIntent().getExtras();
                    uss = extras.getString( "Email", "N/A" );
                    intent.putExtra( "HK", "HK04" );
                    intent.putExtra( "Email", uss );
                    startActivity( intent );
                }
            } );
            txtHk5.setOnClickListener( new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Intent intent = new Intent( HocKyActivity.this, ThoiKhoaBieuFragment.class );
                    Bundle extras = getIntent().getExtras();
                    uss = extras.getString( "Email", "N/A" );
                    intent.putExtra( "HK", "HK05" );
                    intent.putExtra( "Email", uss );
                    startActivity( intent );
                }
            } );
            txtHk6.setOnClickListener( new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Intent intent = new Intent( HocKyActivity.this, ThoiKhoaBieuFragment.class );
                    Bundle extras = getIntent().getExtras();
                    uss = extras.getString( "Email", "N/A" );
                    intent.putExtra( "HK", "HK06" );
                    intent.putExtra( "Email", uss );
                    startActivity( intent );
                }
            } );
            txtHk7.setOnClickListener( new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Intent intent = new Intent( HocKyActivity.this, ThoiKhoaBieuFragment.class );
                    Bundle extras = getIntent().getExtras();
                    uss = extras.getString( "Email", "N/A" );
                    intent.putExtra( "HK", "HK07" );
                    intent.putExtra( "Email", uss );
                    startActivity( intent );
                }
            } );
            txtHk8.setOnClickListener( new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Intent intent = new Intent( HocKyActivity.this, ThoiKhoaBieuFragment.class );
                    Bundle extras = getIntent().getExtras();
                    uss = extras.getString( "Email", "N/A" );
                    intent.putExtra( "HK", "HK08" );
                    intent.putExtra( "Email", uss );
                    startActivity( intent );
                }
            } );

    }
    //Xử lý tối nút home

    private void replaceFragment (Fragment fragment) {
        String backStateName = fragment.getClass().getName();

        FragmentManager manager = getSupportFragmentManager();
        boolean fragmentPopped = manager.popBackStackImmediate( backStateName, 0 );

        if (!fragmentPopped) { //fragment not in back stack, create it.
            FragmentTransaction ft = manager.beginTransaction();
            ft.replace( R.id.ctHK, fragment );
            ft.addToBackStack( backStateName );
            ft.commit();
        }
    }
    @Override
    public void onBackPressed() {
        if (getFragmentManager().getBackStackEntryCount() == 0) {
            this.finish();
        } else {
            super.onBackPressed(); //replaced
        }
    }
}
