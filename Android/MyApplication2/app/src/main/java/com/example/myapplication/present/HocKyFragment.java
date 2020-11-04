package com.example.myapplication.present;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.fragment.app.Fragment;


import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;
import androidx.lifecycle.ViewModelProviders;


import com.example.myapplication.MainActivity;
import com.example.myapplication.R;
import com.example.myapplication.model.HocKyViewModel;


public class HocKyFragment extends Fragment {

    private HocKyViewModel hocKyViewModel;
    private ConstraintLayout txtHk1;
    private ConstraintLayout txtHk2;
    private ConstraintLayout txtHk3;
    private ConstraintLayout txtHk4;
    private ConstraintLayout txtHk5;
    private ConstraintLayout txtHk6;
    private ConstraintLayout txtHk7;
    private ConstraintLayout txtHk8;
    String uss,kiemtra;
    String us;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        hocKyViewModel =
                ViewModelProviders.of(this).get(HocKyViewModel.class);
        View view = inflater.inflate(R.layout.activity_hoc_ky, container, false);
        MainActivity mainActivity = (MainActivity) getActivity();
        Bundle bundle = mainActivity.getMyData();

        // Set title bar
        ((MainActivity) getActivity())
                .setActionBarTitle("Thời Khóa Biểu");

        if(bundle!= null){
            uss = bundle.getString( "Email" );
        }else {
            Toast.makeText( getActivity() ,"Ko nhận đc email gửi về" ,Toast.LENGTH_SHORT ).show();
        }

        txtHk1 = view.findViewById( R.id.txtHk1 );
        txtHk2 = view.findViewById( R.id.txtHk2 );
        txtHk3 = view.findViewById( R.id.txtHk3 );
        txtHk4 = view.findViewById( R.id.txtHk4 );
        txtHk5 = view.findViewById( R.id.txtHk5 );
        txtHk6 = view.findViewById( R.id.txtHk6 );
        txtHk7 = view.findViewById( R.id.txtHk7 );
        txtHk8 = view.findViewById( R.id.txtHk8 );
        return view;
    }

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated( view, savedInstanceState );
        final FragmentManager fragmentManager = getFragmentManager();

        txtHk1.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                final FragmentTransaction fragmentTransaction = fragmentManager.beginTransaction();
                ThoiKhoaBieuFragment thoiKhoaBieuFragment = new ThoiKhoaBieuFragment();
                Bundle bundle = new Bundle();
                bundle.putString( "HK", "HK01" );
                bundle.putString( "Email", uss );
                thoiKhoaBieuFragment.setArguments( bundle );
                fragmentTransaction.replace(R.id.ctHK, thoiKhoaBieuFragment);
                fragmentTransaction.addToBackStack(null).commit();
                fragmentTransaction.setTransition(FragmentTransaction.TRANSIT_FRAGMENT_OPEN);

            }
        } );

        txtHk2.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                final FragmentTransaction  fragmentTransaction1 = fragmentManager.beginTransaction();
                ThoiKhoaBieuFragment thoiKhoaBieuFragment = new ThoiKhoaBieuFragment();
                Bundle bundle = new Bundle();
                bundle.putString( "HK", "HK02" );
                bundle.putString( "Email", uss );
                thoiKhoaBieuFragment.setArguments( bundle );

                fragmentTransaction1.replace(R.id.ctHK, thoiKhoaBieuFragment).addToBackStack(null).commit();
                fragmentTransaction1.setTransition(FragmentTransaction.TRANSIT_FRAGMENT_OPEN);
            }
        } );
        txtHk3.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                final FragmentTransaction  fragmentTransaction3 = fragmentManager.beginTransaction();
                ThoiKhoaBieuFragment thoiKhoaBieuFragment = new ThoiKhoaBieuFragment();
                Bundle bundle = new Bundle();
                bundle.putString( "HK", "HK03" );
                bundle.putString( "Email", uss );
                thoiKhoaBieuFragment.setArguments( bundle );
                //Navigation.findNavController( getActivity(), R.id.nav_host_fragment ).navigate( R.id.nav_hocky );

                fragmentTransaction3.add(R.id.ctHK, thoiKhoaBieuFragment).addToBackStack(null).commit();
                fragmentTransaction3.setTransition(FragmentTransaction.TRANSIT_FRAGMENT_OPEN);

            }
        } );
        txtHk4.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                final FragmentTransaction  fragmentTransaction4 = fragmentManager.beginTransaction();
                ThoiKhoaBieuFragment thoiKhoaBieuFragment = new ThoiKhoaBieuFragment();
                Bundle bundle = new Bundle();
                bundle.putString( "HK", "HK04" );
                bundle.putString( "Email", uss );
                thoiKhoaBieuFragment.setArguments( bundle );
                //Navigation.findNavController( getActivity(), R.id.nav_host_fragment ).navigate( R.id.nav_hocky );

                fragmentTransaction4.add(R.id.ctHK, thoiKhoaBieuFragment).addToBackStack(null).commit();
                fragmentTransaction4.setTransition(FragmentTransaction.TRANSIT_FRAGMENT_OPEN);
            }
        } );
        txtHk5.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                final FragmentTransaction  fragmentTransaction5 = fragmentManager.beginTransaction();
                ThoiKhoaBieuFragment thoiKhoaBieuFragment = new ThoiKhoaBieuFragment();
                Bundle bundle = new Bundle();
                bundle.putString( "HK", "HK05" );
                bundle.putString( "Email", uss );
                thoiKhoaBieuFragment.setArguments( bundle );
                //Navigation.findNavController( getActivity(), R.id.nav_host_fragment ).navigate( R.id.nav_hocky );

                fragmentTransaction5.add(R.id.ctHK, thoiKhoaBieuFragment).addToBackStack(null).commit();
                fragmentTransaction5.setTransition(FragmentTransaction.TRANSIT_FRAGMENT_OPEN);
            }
        } );
        txtHk6.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                final FragmentTransaction  fragmentTransaction6 = fragmentManager.beginTransaction();
                ThoiKhoaBieuFragment thoiKhoaBieuFragment = new ThoiKhoaBieuFragment();
                Bundle bundle = new Bundle();
                bundle.putString( "HK", "HK06" );
                bundle.putString( "Email", uss );
                thoiKhoaBieuFragment.setArguments( bundle );
                //Navigation.findNavController( getActivity(), R.id.nav_host_fragment ).navigate( R.id.nav_hocky );

                fragmentTransaction6.add(R.id.ctHK, thoiKhoaBieuFragment).addToBackStack(null).commit();
                fragmentTransaction6.setTransition(FragmentTransaction.TRANSIT_FRAGMENT_OPEN);
            }
        } );
        txtHk7.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                final FragmentTransaction  fragmentTransaction7 = fragmentManager.beginTransaction();
                ThoiKhoaBieuFragment thoiKhoaBieuFragment = new ThoiKhoaBieuFragment();
                Bundle bundle = new Bundle();
                bundle.putString( "HK", "HK07" );
                bundle.putString( "Email", uss );
                thoiKhoaBieuFragment.setArguments( bundle );
                //Navigation.findNavController( getActivity(), R.id.nav_host_fragment ).navigate( R.id.nav_hocky );

                fragmentTransaction7.add(R.id.ctHK, thoiKhoaBieuFragment).addToBackStack(null).commit();
                fragmentTransaction7.setTransition(FragmentTransaction.TRANSIT_FRAGMENT_OPEN);
            }
        } );
        txtHk8.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                final FragmentTransaction  fragmentTransaction8 = fragmentManager.beginTransaction();
                ThoiKhoaBieuFragment thoiKhoaBieuFragment = new ThoiKhoaBieuFragment();
                Bundle bundle = new Bundle();
                bundle.putString( "HK", "HK08" );
                bundle.putString( "Email", uss );
                thoiKhoaBieuFragment.setArguments( bundle );
                //Navigation.findNavController( getActivity(), R.id.nav_host_fragment ).navigate( R.id.nav_hocky );

                fragmentTransaction8.add(R.id.ctHK, thoiKhoaBieuFragment).addToBackStack(null).commit();
                fragmentTransaction8.setTransition(FragmentTransaction.TRANSIT_FRAGMENT_OPEN);
            }
        } );
    }

}