package com.example.myapplication.present;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.util.Base64;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;
import androidx.lifecycle.ViewModelProviders;

import com.example.myapplication.MainActivityGV;
import com.example.myapplication.R;
import com.example.myapplication.model.SERVER;
import com.example.myapplication.model.ThongTinGVViewModel;

import java.sql.Blob;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;

public class ThongTinGVFragment extends Fragment {
    TextView txtTengv, txtTrinhDo,txtMagv,txtGioiTinh,txtNamSinh,txtDiaChi,txtSDT,txtGhiChu, txtEditGV,txtDoiMKGV;
    ImageView imgGV ;
    String uss,pass;
    ResultSet resultSet;
    String gioiTinh, namSinh, diaChi,sDT,trinhDo;

    private ThongTinGVViewModel thongTinGVViewModel;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {


        thongTinGVViewModel =
                ViewModelProviders.of(this).get( ThongTinGVViewModel.class);
        View view = inflater.inflate( R.layout.fragment_thongtingv, container, false);
        imgGV = view.findViewById( R.id.imgGV );
        txtTengv = view.findViewById(R.id.txtTengv);
        txtTrinhDo = view.findViewById(R.id.txtTrinhDo);
        txtMagv = view.findViewById(R.id.txtMagv);
        txtGioiTinh = view.findViewById(R.id.txtGioiTinh);
        txtNamSinh = view.findViewById(R.id.txtNamSinh);
        txtDiaChi = view.findViewById(R.id.txtDiaChi);
        txtSDT = view.findViewById(R.id.txtSDT);
        txtGhiChu = view.findViewById(R.id.txtGhiChu);
        MainActivityGV mainGVActivity = (MainActivityGV) getActivity();
        Bundle bundle = mainGVActivity.getMyData1();
        if(bundle!= null){
            uss = bundle.getString( "Email" );
            pass =bundle.getString( "Password" );
            Log.e( "CheckEmail: ", uss );
        }else {
            Toast.makeText( getActivity() ,"Ko nhận đc email gửi về" ,Toast.LENGTH_SHORT ).show();
        }
        imgGV.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(getActivity(), ImageProfileFragment_gv.class);
                intent.putExtra( "Email", uss );
                intent.putExtra( "Check", "GiangVien" );
                startActivity( intent );
            }
        } );
        txtEditGV = view.findViewById( R.id.txtEditGV );
        txtEditGV.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                EditGVFragment editGVFragment = new EditGVFragment();
                Bundle bundle = new Bundle();
                bundle.putString(  "GioiTinh", gioiTinh );
                bundle.putString( "NamSinh", namSinh );
                bundle.putString( "DiaChi", diaChi );
                bundle.putString( "SDT", sDT );
                bundle.putString( "TrinhDo", trinhDo );
                bundle.putString( "Email", uss );
//                Log.e( "GioiTinh: ", gioiTinh  );
                editGVFragment.setArguments( bundle );
                FragmentManager fragmentManager = getFragmentManager();
                FragmentTransaction fragmentTransaction= fragmentManager.beginTransaction();
                fragmentTransaction.replace(R.id.frgTT, editGVFragment);
                fragmentTransaction.addToBackStack(null);
                fragmentTransaction.commit();
            }
        } );
        txtDoiMKGV = view.findViewById( R.id.txtDoiMKGV );
        txtDoiMKGV.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                DoiMatKhauGVFragment doiMatKhauGVFragment = new DoiMatKhauGVFragment();
                Bundle bundle = new Bundle();
                bundle.putString( "Email", uss );
                bundle.putString( "Password", pass );
                doiMatKhauGVFragment.setArguments( bundle );
                FragmentManager fragmentManager = getFragmentManager();
                FragmentTransaction fragmentTransaction= fragmentManager.beginTransaction();
                fragmentTransaction.replace(R.id.frgTT, doiMatKhauGVFragment);
                fragmentTransaction.addToBackStack(null);
                fragmentTransaction.commit();
            }
        } );
        return view;
    }

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated( view, savedInstanceState );
        try {
            Connection con = SERVER.Connect();
            if (con == null) {
            } else {
                String query = "select gv.Avt, gv.TenGV , gv.TrinhDo,gv.MaGV,gv.GioiTinh, gv.NamSinh,gv.DiaChi,gv.SDT,gv.GhiChu " +
                        "from GiangVien gv " +
                        "where Email ='"+uss+"'";
                byte b[];
                Blob blob;
                Statement stmt = con.createStatement();
                resultSet = stmt.executeQuery(query);
                while (resultSet.next()) {
                    txtTengv.setText(resultSet.getString("TenGV"));
                    txtTrinhDo.setText(resultSet.getString("TrinhDo"));
                    txtMagv.setText(resultSet.getString("MaGV"));
                    txtGioiTinh.setText(resultSet.getString("GioiTinh"));
                    txtNamSinh.setText(resultSet.getString("NamSinh"));
                    txtDiaChi.setText(resultSet.getString("DiaChi"));
                    txtSDT.setText(resultSet.getString("SDT"));
                    txtGhiChu.setText(resultSet.getString("GhiChu"));

                    gioiTinh = resultSet.getString( "GioiTinh" );
                    Log.e( "onViewCreated: ", gioiTinh  );
                    namSinh = resultSet.getString( "NamSinh" );
                    diaChi = resultSet.getString( "DiaChi" );
                    sDT = resultSet.getString( "SDT");
                    trinhDo = resultSet.getString( "TrinhDo" );

                    blob = resultSet.getBlob( "Avt" );
                    b = blob.getBytes( 1, (int) blob.length() );
//                    Bitmap bitmap = BitmapFactory.decodeByteArray(b, 0, b.length);
//
//                    imgInfor.setImageBitmap(bitmap);
                    byte[] decodeString = Base64.decode( b, Base64.DEFAULT );
                    Bitmap decodebitmap = BitmapFactory.decodeByteArray( decodeString, 0, decodeString.length );
                    imgGV.setImageBitmap( decodebitmap );

                }

            }

        } catch (Exception e) {
            Exception exception;
        }

    }
}