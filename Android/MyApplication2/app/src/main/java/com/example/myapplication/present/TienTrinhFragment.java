package com.example.myapplication.present;

import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProviders;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.myapplication.MainActivity;
import com.example.myapplication.R;
import com.example.myapplication.model.AdapterTienTrinh;
import com.example.myapplication.model.SERVER;
import com.example.myapplication.model.TienTrinh;
import com.example.myapplication.model.TienTrinhViewModel;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class TienTrinhFragment extends Fragment {
    private RecyclerView rclTienTrinh;
    String uss,hocKyTruoc="Học Kỳ 0";
    ResultSet resultSet;
    ResultSet resultSet1;
    String us;
    TextView txtTCHT;
    private TienTrinhViewModel tienTrinhViewModel;
    List<TienTrinh> lstTienTrinh= new ArrayList<>();

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        tienTrinhViewModel =
                ViewModelProviders.of(this).get( TienTrinhViewModel.class);
        //View view = inflater.inflate( R.layout.fragment_tientrinhhoctap, container, false);

        // Set title bar
        ((MainActivity) getActivity())
                .setActionBarTitle("Tiến Trình Học Tập");

        MainActivity mainActivity = (MainActivity) getActivity();
        Bundle bundle = mainActivity.getMyData();
        if(bundle!= null){
            uss = bundle.getString( "Email" );
        }else {
            Toast.makeText( getActivity() ,"Ko nhận đc email gửi về" ,Toast.LENGTH_SHORT ).show();
        }
        View view = inflater.inflate(R.layout.fragment_tientrinhhoctap, container, false);
        rclTienTrinh = view.findViewById(R.id.rclTienTrinh);
        txtTCHT = view.findViewById(R.id.txtTCHT);


        Connection con = SERVER.Connect();
        if (con == null) {
            Toast.makeText( getActivity(), "Connect Fail", Toast.LENGTH_SHORT ).show();
        } else {
            try {
                String query = "SELECT SUM(MH.STC) FROM SinhVien AS SV, MonHoc AS MH , DiemMonHoc AS DMH" +
                        " WHERE SV.MaSV = DMH.MaSV AND MH.MaMonHoc = DMH.MaMonHoc AND DMH.Diem30 IS NOT NULL AND DMH.Diem70L1 IS NOT NULL " +
                        " AND EMAIL ='" +uss+ "' ";
                Log.e( "onCreateView: ", uss );
                Statement stmt = con.createStatement();
                resultSet1 = stmt.executeQuery( query );

                while (resultSet1.next()) {
                    String test=resultSet1.getString( 1 );
                   // Toast.makeText( getActivity(), "Show"+test,Toast.LENGTH_SHORT ).show();

                    txtTCHT.setText( test );


                }

            } catch (SQLException e) {
                e.printStackTrace();
            }
        }

        LinearLayoutManager layoutManager=new LinearLayoutManager(getActivity());
        layoutManager.setOrientation(LinearLayoutManager.VERTICAL);
        rclTienTrinh.setLayoutManager(layoutManager);
        return view;
    }

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated( view, savedInstanceState );
        Connection con = SERVER.Connect();
        if(con == null){
            Toast.makeText( getActivity(), "Connect Fail",Toast.LENGTH_SHORT ).show();
        }else {
            try {
                String query="SELECT  MH.STC,mh.TenMonHoc, DMH.GhiChu FROM SinhVien AS SV, MonHoc AS MH , DiemMonHoc AS DMH " +
                        "WHERE SV.MaSV = DMH.MaSV AND MH.MaMonHoc = DMH.MaMonHoc AND DMH.Diem30 IS NOT NULL AND DMH.Diem70L1 IS NOT NULL " +
                        "AND EMAIL ='"+uss+"'";
                Statement stmt = con.createStatement();
                resultSet = stmt.executeQuery( query );
                lstTienTrinh.add(new TienTrinh("Tên Môn Học","STC","Tình Trạng"));
                while (resultSet.next()) {
                    String tenMonHoc;
                    String soTinChi;
                    String tinhTrang;
                    //hocKy =resultSet.getString( "TenHocKy" );
                    tenMonHoc = resultSet.getString( "TenMonHoc" );
                    soTinChi = resultSet.getString( "STC" );
                    tinhTrang= resultSet.getString( "GhiChu" );
                    // Log.e("ERROR123","lỗi thực: "+ hocKy+ monHoc);


                        lstTienTrinh.add(new TienTrinh(tenMonHoc,soTinChi,tinhTrang ));


                }

            } catch (SQLException e) {
                e.printStackTrace();
            }

            AdapterTienTrinh adapterTienTrinh=new AdapterTienTrinh( lstTienTrinh );
            rclTienTrinh.setAdapter(adapterTienTrinh );
            adapterTienTrinh.notifyDataSetChanged();

        }
    }


//
//        public void TC(){
//        Connection con = SERVER.Connect();
//        if (con == null) {
//            Toast.makeText( getActivity(), "Connect Fail", Toast.LENGTH_SHORT ).show();
//        } else {
//            try {
//                String query = "SELECT SUM(MH.STC) AS 'DM' FROM SinhVien AS SV, MonHoc AS MH , DiemMonHoc AS DMH" +
//                        "WHERE SV.MaSV = DMH.MaSV AND MH.MaMonHoc = DMH.MaMonHoc AND DMH.Diem30 IS NOT NULL AND DMH.Diem70L1 IS NOT NULL " +
//                        "AND EMAIL ='" + uss + "'";
//                Statement stmt = con.createStatement();
//                resultSet = stmt.executeQuery( query );
//
//                while (resultSet.next()) {
//
//                    txtTCHT.setText( resultSet.getString( 0 ) );
//                    Log.e( "onCreate: ", txtTCHT.toString() );
//                }
//
//            } catch (SQLException e) {
//                e.printStackTrace();
//            }
//        }
//    }
}