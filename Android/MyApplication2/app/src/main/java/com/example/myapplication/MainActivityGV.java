package com.example.myapplication;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.drawerlayout.widget.DrawerLayout;
import androidx.navigation.NavController;
import androidx.navigation.Navigation;
import androidx.navigation.ui.AppBarConfiguration;
import androidx.navigation.ui.NavigationUI;

import com.example.myapplication.present.ImageProfileFragment;
import com.google.android.material.navigation.NavigationView;

public class MainActivityGV extends AppCompatActivity {

    private AppBarConfiguration mAppBarConfiguration;
    String us,check,pass;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView( R.layout.activity_main_gv);

//        FragmentManager fragmentManager = getFragmentManager();
//        final FragmentTransaction fragmentTransaction = fragmentManager.beginTransaction();
        Toolbar toolbar = findViewById( R.id.toolbar_gv);
        setSupportActionBar(toolbar);

        DrawerLayout drawer = findViewById( R.id.drawer_layout_gv);
        NavigationView navigationView = findViewById( R.id.nav_view_gv);
        // Passing each menu ID as a set of Ids because each
        // menu should be considered as top level destinations.
        mAppBarConfiguration = new AppBarConfiguration.Builder(
                R.id.nav_home_gv, R.id.nav_thongtingv, R.id.nav_lichday, R.id.nav_lichcongtac)
                .setDrawerLayout(drawer)
                .build();
        NavController navController = Navigation.findNavController(this, R.id.nav_host_fragment_gv);
        NavigationUI.setupActionBarWithNavController(this, navController, mAppBarConfiguration);
        NavigationUI.setupWithNavController(navigationView, navController);

        Bundle extras = getIntent().getExtras();
        us = extras.getString( "Email", "N/A" );
        pass = extras.getString( "Password", "N/A" );
        check = extras.getString( "Check","N/A" );

        Intent intent = new Intent( MainActivityGV.this, ImageProfileFragment.class );
        intent.putExtra( "Email", us );
        Log.e( "Show us: ", us  );

    }


    @Override
    public boolean onSupportNavigateUp() {
        NavController navController = Navigation.findNavController(this, R.id.nav_host_fragment_gv);
        return NavigationUI.navigateUp(navController, mAppBarConfiguration)
                || super.onSupportNavigateUp();
    }
    public Bundle getMyData1() {
        Bundle bundle = new Bundle();
        bundle.putString( "Email", us );
        bundle.putString( "Password", pass );
        return  bundle;
    }

}