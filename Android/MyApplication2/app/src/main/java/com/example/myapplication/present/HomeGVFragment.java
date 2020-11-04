package com.example.myapplication.present;

import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProviders;
import androidx.navigation.Navigation;

import com.example.myapplication.LoginActivity;
import com.example.myapplication.R;
import com.example.myapplication.model.HomeGVViewModel;

public class HomeGVFragment extends Fragment {
    private ConstraintLayout gridviewThongTinGV;
    private ConstraintLayout gridviewLichDay;
    private ConstraintLayout gridviewLichCongTac;
    private ConstraintLayout gridviewLogout;
    private HomeGVViewModel homeGVViewModel;

    String us,gv;
    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        homeGVViewModel =
                ViewModelProviders.of(this).get( HomeGVViewModel.class);
        View view = inflater.inflate( R.layout.fragment_home_gv, container, false);
        gridviewThongTinGV = (ConstraintLayout) view.findViewById( R.id.gridviewthongtingv );
        gridviewLichDay =(ConstraintLayout) view.findViewById( R.id.gridviewlichday );
        gridviewLichCongTac = (ConstraintLayout)view.findViewById( R.id.gridviewlichcongtac );
        gridviewLogout =(ConstraintLayout) view.findViewById( R.id.gridviewlogout );
        return view;
    }

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated( view, savedInstanceState );
        gridviewThongTinGV.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Animation animation = AnimationUtils.loadAnimation(getActivity(),R.anim.anim_alpha );
                view.startAnimation( animation );
                Navigation.findNavController( getActivity(), R.id.nav_host_fragment_gv ).navigate( R.id.nav_thongtingv );
            }
        } );
        gridviewLichDay.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Animation animation = AnimationUtils.loadAnimation(getActivity(),R.anim.anim_alpha );
                view.startAnimation( animation );
                Navigation.findNavController( getActivity(), R.id.nav_host_fragment_gv ).navigate( R.id.nav_lichday );
            }
        } );
        gridviewLichCongTac.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Animation animation = AnimationUtils.loadAnimation(getActivity(),R.anim.anim_alpha );
                view.startAnimation( animation );
                Navigation.findNavController( getActivity(), R.id.nav_host_fragment_gv ).navigate( R.id.nav_lichcongtac );
            }
        } );
        gridviewLogout.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent( getActivity(), LoginActivity.class );
                intent.addFlags( Intent.FLAG_ACTIVITY_CLEAR_TOP );
                startActivity( intent );

                getActivity().finish();
            }
        } );
    }
}