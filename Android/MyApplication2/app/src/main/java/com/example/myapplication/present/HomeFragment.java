package com.example.myapplication.present;

import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;
import androidx.lifecycle.ViewModelProviders;
import androidx.navigation.Navigation;

import com.example.myapplication.LoginActivity;
import com.example.myapplication.MainActivity;
import com.example.myapplication.R;
import com.example.myapplication.model.HomeViewModel;
import com.example.myapplication.ui.ThongTinSinhVien.ThongTinSinhVienFragment;

import java.sql.ResultSet;

public class HomeFragment extends Fragment {
    TextView txtMaSV, txtLop, txtGioiTinh, txtChuyenNganh, txtNienKhoa, txtDiaChi, txtSDT, txtTen, txtNamSinh;
    ImageView imgInfor;
    String uss;
    String z, a;
    ResultSet resultSet;
    String us;

    private DemoFragmentInterface listener;
    private ConstraintLayout gridviewMain;
    private HomeViewModel homeViewModel;
    private ConstraintLayout gridviewThongTin;
    private ConstraintLayout gridviewThoiKhoaBieu;
    private ConstraintLayout gridviewXemDiem;
    private ConstraintLayout gridviewTienTrinh;
    private LinearLayout gridviewLogout;
    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        homeViewModel =
                ViewModelProviders.of(this).get(HomeViewModel.class);
        View view = inflater.inflate(R.layout.fragment_home, container, false);

        // Set title bar
        ((MainActivity) getActivity())
                .setActionBarTitle("Trang Chủ");

        gridviewThongTin = (ConstraintLayout) view.findViewById( R.id.gridviewthongtin );
        gridviewThoiKhoaBieu = (ConstraintLayout) view.findViewById( R.id.gridviewtkb );
        gridviewXemDiem = (ConstraintLayout) view.findViewById( R.id.gridviewxemdiem );
        gridviewTienTrinh = (ConstraintLayout) view.findViewById( R.id.gridviewtientrinh );
        gridviewLogout = (LinearLayout) view.findViewById( R.id.gridviewlogout );
        return view;


    }

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated( view, savedInstanceState );
        final Animation animation = AnimationUtils.loadAnimation(getContext(),R.anim.anim_alpha );
        gridviewThongTin.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                ThongTinSinhVienFragment thongTinSinhVienFragment = new ThongTinSinhVienFragment();

                Navigation.findNavController( getActivity(), R.id.nav_host_fragment ).navigate( R.id.nav_thongtin );

            }
        });
        gridviewThoiKhoaBieu.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                HocKyFragment hocKyFragment = new HocKyFragment();
                final FragmentManager fragmentManager = getFragmentManager();
                final FragmentTransaction  fragmentTransaction = fragmentManager.beginTransaction();
                fragmentTransaction.replace(R.id.nav_host_fragment, hocKyFragment).addToBackStack(null).commit();
                fragmentTransaction.setTransition(FragmentTransaction.TRANSIT_FRAGMENT_OPEN);
                Bundle bundle = new Bundle();
//                Navigation.findNavController( getActivity(), R.id.nav_host_fragment ).navigate( R.id.nav_hocky );

            }
        } );

        gridviewXemDiem.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Animation animation = AnimationUtils.loadAnimation(getActivity(),R.anim.anim_alpha );
                view.startAnimation( animation );
                Navigation.findNavController( getActivity(), R.id.nav_host_fragment ).navigate( R.id.nav_xemdiem );
            }
        } );
        gridviewTienTrinh.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Animation animation = AnimationUtils.loadAnimation(getActivity(),R.anim.anim_alpha );
                view.startAnimation( animation );
                TienTrinhFragment tienTrinhFragment = new TienTrinhFragment();

                final FragmentManager fragmentManager = getFragmentManager();

                final FragmentTransaction  fragmentTransaction = fragmentManager.beginTransaction();
                fragmentTransaction.replace(R.id.nav_host_fragment, tienTrinhFragment).addToBackStack(null).commit();
                fragmentTransaction.setTransition(FragmentTransaction.TRANSIT_FRAGMENT_OPEN);
                }
        } );
        gridviewLogout.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Animation animation = AnimationUtils.loadAnimation(getActivity(),R.anim.anim_alpha );
                view.startAnimation( animation );
                Intent intent = new Intent(getActivity(), LoginActivity.class );
                intent.addFlags( Intent.FLAG_ACTIVITY_CLEAR_TOP );
                startActivity( intent );

                getActivity().finish();

            }
        } );
    }

public interface DemoFragmentInterface {
    void sendData(String email, String password);
}

}