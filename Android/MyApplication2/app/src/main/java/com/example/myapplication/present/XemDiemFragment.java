package com.example.myapplication.present;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProviders;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;


import com.example.myapplication.MainActivity;
import com.example.myapplication.R;
import com.example.myapplication.model.AdapterXemDiem;
import com.example.myapplication.model.SERVER;
import com.example.myapplication.model.XemDiem;
import com.example.myapplication.model.XemDiemViewModel;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class XemDiemFragment extends Fragment {
    private RecyclerView rclXemDiem;
    String uss,hocKyTruoc="Học Kỳ 0";
    ResultSet resultSet;
    String us;

    private XemDiemViewModel xemDiemViewModel;
    List<XemDiem> lstXemDiem= new ArrayList<>();
    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        xemDiemViewModel =
                ViewModelProviders.of(this).get(XemDiemViewModel.class);
        MainActivity mainActivity = (MainActivity) getActivity();
        Bundle bundle = mainActivity.getMyData();
        if(bundle!= null){
            uss = bundle.getString( "Email" );
        }else {
            Toast.makeText( getActivity() ,"Ko nhận đc email gửi về" ,Toast.LENGTH_SHORT ).show();
        }
        View view = inflater.inflate(R.layout.fragment_xemdiem, container, false);
        rclXemDiem = view.findViewById(R.id.rclXemDiem);

        LinearLayoutManager layoutManager=new LinearLayoutManager(getActivity());
        layoutManager.setOrientation(LinearLayoutManager.VERTICAL);
        rclXemDiem.setLayoutManager(layoutManager);
        return view;
    }

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated( view, savedInstanceState );
        Connection con = SERVER.Connect();
        if(con == null){

        }else {
            try {
                String query="select DISTINCT mh.TenMonHoc, dmh.Diem30, dmh.Diem70L1, dmh.Diem70L2, dmh.DTB , hk.TenHocKy from HocKy hk, DiemMonHoc dmh, SinhVien sv , ThoiKhoaBieu tkb, MonHoc mh " +
                        " where  sv.MaSV = dmh.MaSV and mh.MaMonHoc = dmh.MaMonHoc and mh.MaMonHoc = tkb.MaMonHoc and hk.MaHocKy = tkb.MaHocKy and Email ='"+uss+"'";
                Statement stmt = con.createStatement();
                resultSet = stmt.executeQuery( query );

                while (resultSet.next()) {
                    String hocKy;
                    String monHoc;
                    String diem30;
                    String diem70l1;
                    String diem70l2;
                    String diemTong;

                    hocKy =resultSet.getString( "TenHocKy" );
                    monHoc=resultSet.getString( "TenMonHoc" );
                    diem30=resultSet.getString( "Diem30" );
                    diem70l1=resultSet.getString( "Diem70L1" );
                    diem70l2=resultSet.getString( "Diem70L2" );
                    diemTong=resultSet.getString( "DTB" );
                    // Log.e("ERROR123","lỗi thực: "+ hocKy+ monHoc);

                    if(!hocKy.equals(hocKyTruoc)){
                        hocKyTruoc=hocKy;
                        lstXemDiem.add(new XemDiem(0,hocKy));
                        lstXemDiem.add(new XemDiem(1,"Tên Môn Học","Điểm 30","Điểm 70L1","Điểm 70L2","Tổng Điểm" ));
                        lstXemDiem.add(new XemDiem(1,monHoc,diem30,diem70l1,diem70l2,diemTong ));
                    }else {
                        lstXemDiem.add(new XemDiem(1,monHoc,diem30,diem70l1,diem70l2,diemTong ));
                    }

                }


            } catch (SQLException e) {
                e.printStackTrace();
            }

            AdapterXemDiem adapterXemDiem=new AdapterXemDiem( lstXemDiem );
            rclXemDiem.setAdapter(adapterXemDiem  );
            adapterXemDiem.notifyDataSetChanged();

        }
    }
}