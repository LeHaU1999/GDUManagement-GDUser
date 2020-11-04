package com.example.myapplication.present;

import android.os.Bundle;
import android.util.Log;
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

import com.example.myapplication.MainActivityGV;
import com.example.myapplication.R;
import com.example.myapplication.model.AdapterLichDay;
import com.example.myapplication.model.LichDay;
import com.example.myapplication.model.LichDayViewModel;
import com.example.myapplication.model.SERVER;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class LichDayFragment extends Fragment {
    String uss;
    String us;
    private RecyclerView rclView;
    ResultSet resultSet;
    private LichDayViewModel lichDayViewModel;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        lichDayViewModel =
                ViewModelProviders.of(this).get( LichDayViewModel.class);
        View view = inflater.inflate( R.layout.fragment_lichday, container, false);
        MainActivityGV mainGVActivity = (MainActivityGV) getActivity();
        Bundle bundle = mainGVActivity.getMyData1();
        if(bundle!= null){
            uss = bundle.getString( "Email" );
            Log.e( "CheckEmail: ", uss );
        }else {
            Toast.makeText( getActivity() ,"Ko nhận đc email gửi về" ,Toast.LENGTH_SHORT ).show();
        }
        rclView = view.findViewById( R.id.recyclerView_lichday );
        return view;
    }

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated( view, savedInstanceState );
        List<LichDay> lstLichDay = new ArrayList<LichDay>();
        try {
            Connection con = SERVER.Connect();

            if (con == null) {
            }else {
                String query = "select tkb.ThoiGianHoc, lp.TenLop, gv.MaGV, gv.TenGV, hk.MaHocKy, mh.TenMonHoc, mh.STC, tkb.MaPhongHoc, tkb.NgayHoc, tkb.NgayBatDau, tkb.NgayKetThuc from GiangVien gv " +
                        "inner join ThoiKhoaBieu tkb on tkb.MaGV = gv.MaGV " +
                        "inner join MonHoc mh on mh.MaMonHoc = tkb.MaMonHoc " +
                        "inner join HocKy hk on hk.MaHocKy = tkb.MaHocKy " +
                        "inner join Lop lp on lp.MaLop = tkb.MaLop " +
                        "where gv.Email ='"+uss+"'";
                Statement stmt = con.createStatement();
                resultSet = stmt.executeQuery( query );
                while (resultSet.next()){
                    String Thu=resultSet.getString("NgayHoc");
                    String MonHoc=resultSet.getString( "TenMonHoc");
                    String Ca = resultSet.getString( "ThoiGianHoc" );
                    String PhongHoc = resultSet.getString( "MaPhongHoc" );
                    String NgayBatDau = resultSet.getString( "NgayBatDau" );
                    String NgayKetThuc = resultSet.getString( "NgayKetThuc" );
                    String Lop = resultSet.getString( "TenLop" );
                    LichDay lichDay = new LichDay( Thu, MonHoc,Ca,PhongHoc,NgayBatDau,NgayKetThuc,Lop );
                    lstLichDay.add(lichDay);

//                    Log.e("ERROR","lỗi thực thi câu1: "+ ngayHoc);
//                    Log.e("ERROR","lỗi thực thi câu2: "+ tenMH);

                }
            }


        } catch (SQLException e) {
            e.printStackTrace();
        }

//        Log.e("ERROR","lỗi thực thi câu12: "+ lstTKB.size());
        // AdapterTKB adapter = new AdapterTKB( lstTKB);
        AdapterLichDay adapter = new AdapterLichDay( lstLichDay );
        LinearLayoutManager layoutManager=new LinearLayoutManager(getActivity());
        layoutManager.setOrientation(LinearLayoutManager.VERTICAL);
        rclView.setLayoutManager(layoutManager);
        rclView.setAdapter(adapter);
        adapter.notifyDataSetChanged();
    }
}