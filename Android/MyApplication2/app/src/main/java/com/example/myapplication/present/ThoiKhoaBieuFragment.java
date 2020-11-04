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

import com.example.myapplication.MainActivity;
import com.example.myapplication.R;
import com.example.myapplication.model.AdapterTKB;
import com.example.myapplication.model.SERVER;
import com.example.myapplication.model.TKB;
import com.example.myapplication.model.ThoiKhoaBieuModel;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class ThoiKhoaBieuFragment extends Fragment  {
    private RecyclerView listView;
    ResultSet resultSet;
    String uss,hk;
    String us;
    private ThoiKhoaBieuModel slideshowViewModel;
    List<TKB> lstTKB = new ArrayList<TKB>();
    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        slideshowViewModel =
                ViewModelProviders.of(this).get(ThoiKhoaBieuModel.class);
        View view = inflater.inflate(R.layout.fragment_thoikhoabieu, container, false);
        listView = view.findViewById( R.id.recyclerView_view );

        // Set title bar
        ((MainActivity) getActivity())
                .setActionBarTitle("Thời Khóa Biểu");

        Bundle bundle = getArguments();
        if(bundle != null){
            uss = getArguments().getString( "Email" );
            hk= getArguments().getString( "HK" );
        }else{
            Toast.makeText( getActivity(), "Ko nhan dc hk", Toast.LENGTH_SHORT ).show();
        }

        return view;
    }




    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated( view, savedInstanceState );

        try {
            Connection con = SERVER.Connect();

            if (con == null) {
            }else {
                String query = "select tkb.NgayHoc, mh.TenMonHoc,tkb.NgayBatDau,tkb.NgayKetThuc,tkb.ThoiGianHoc,tkb.MaPhongHoc,gv.TenGV " +
                        "from GiangVien as gv ,Lop as l, MonHoc as mh, ThoiKhoaBieu as tkb, SinhVien as sv " +
                        "where l.MaLop=tkb.MaLop and gv.MaGV = tkb.MaGV  and sv.MaLop = l.MaLop and l.MaNganh = mh.MaNganh and mh.MaMonHoc = tkb.MaMonHoc and MaHocKy='"+hk+"' and sv.Email ='"+uss+"'";
                Statement stmt = con.createStatement();
                resultSet = stmt.executeQuery( query );
                while (resultSet.next()){
                    String ngayHoc=resultSet.getString("NgayHoc");
                    String tenMH=resultSet.getString( "TenMonHoc");
                    String thoiGianKT = resultSet.getString( "NgayKetThuc" );
                    String thoiGianHoc = resultSet.getString( "ThoiGianHoc" );
                    String thoiGianBD = resultSet.getString( "NgayBatDau" );

                    String tenGV = resultSet.getString( "TenGV" );
                    String maPhongHoc = resultSet.getString( "MaPhongHoc" );

                    Log.e("ERROR","lỗi thực thi câu1: "+ ngayHoc);
                    Log.e("ERROR","lỗi thực thi câu2: "+ tenMH);
                    TKB thoikhoabieu=new TKB( tenMH, ngayHoc,maPhongHoc,thoiGianHoc,tenGV,thoiGianBD,thoiGianKT);
                    lstTKB.add( thoikhoabieu );

                }
            }



        } catch (SQLException e) {
            e.printStackTrace();
        }

        Log.e("ERROR","lỗi thực thi câu12: "+ lstTKB.size());
        AdapterTKB adapter = new AdapterTKB( lstTKB);
        LinearLayoutManager layoutManager=new LinearLayoutManager(getActivity());
        layoutManager.setOrientation(LinearLayoutManager.VERTICAL);
        listView.setLayoutManager(layoutManager);
        listView.setAdapter(adapter);
        adapter.notifyDataSetChanged();

    }

}