package com.example.myapplication.ui.ThongTinSinhVien;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.util.Base64;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;

import com.example.myapplication.MainActivity;
import com.example.myapplication.R;
import com.example.myapplication.model.SERVER;
import com.example.myapplication.present.DoiMatKhauFragment;
import com.example.myapplication.present.EditSVFragment;
import com.example.myapplication.present.ImageProfileFragment;

import java.sql.Blob;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;

public class ThongTinSinhVienFragment extends Fragment {
    TextView txtMaSV, txtLop, txtGioiTinh, txtChuyenNganh, txtNienKhoa, txtDiaChi, txtSDT, txtTen, txtNamSinh,txteditSV, txtDoiMKSV;
    ImageView imgInfor;
    String uss,pass;
    String z;
    ResultSet resultSet;
    String gioiTinh, namSinh, diaChi,sDT;
    private ThongTinSinhVienModel galleryViewModel;

    public View onCreateView(@NonNull final LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        MainActivity mainActivity = (MainActivity) getActivity();

        // Set title bar
        ((MainActivity) getActivity())
                .setActionBarTitle("Thông Tin Sinh Viên");



        View view = inflater.inflate(R.layout.fragment_thongtinsinhvien, container, false);

        //Anh xa
        txtTen = (TextView) view.findViewById( R.id.txtTen);
        txtMaSV = (TextView) view.findViewById( R.id.txtMasv);
        txtLop = (TextView) view.findViewById( R.id.txtLop);
        txtGioiTinh = (TextView) view.findViewById( R.id.txtGioiTinh);
        txtChuyenNganh = (TextView) view.findViewById( R.id.txtChuyenNganh);
        txtNienKhoa = (TextView) view.findViewById( R.id.txtNienKhoa);
        txtDiaChi = (TextView) view.findViewById( R.id.txtDiaChi);
        txtSDT = (TextView) view.findViewById( R.id.txtSdt);
        txtNamSinh = (TextView) view.findViewById( R.id.txtNamSinh);
        txteditSV = view.findViewById( R.id.txteditSV );
        txtDoiMKSV = view.findViewById( R.id.txtDoiMKSV );

        //Bat su kien thay doi imageprofile
        imgInfor = view.findViewById(R.id.imgInfor1 );
        imgInfor.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(getActivity(), ImageProfileFragment.class);
                intent.putExtra( "Email", uss );
                intent.putExtra( "Check", "SinhVien" );
                startActivity( intent );

           }
        } );

        //Nhan du lieu từ main gui qua
        Bundle bundle = mainActivity.getMyData();
        if(bundle!= null){
            uss = bundle.getString( "Email" );
            pass = bundle.getString( "Password" );
        }else {
            Toast.makeText( getActivity() ,"Ko nhận đc email gửi về" ,Toast.LENGTH_SHORT ).show();
        }


        //Xư ly va gui du lieu toi fragment EditTTSV
        txteditSV.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                EditSVFragment editSVFragment = new EditSVFragment();
                Bundle bundle = new Bundle();
                bundle.putString(  "GioiTinh", gioiTinh );
                bundle.putString( "NamSinh", namSinh );
                bundle.putString( "DiaChi", diaChi );
                bundle.putString( "SDT", sDT );
                bundle.putString( "Email", uss );
                editSVFragment.setArguments( bundle );
                FragmentManager fragmentManager = getFragmentManager();
                FragmentTransaction fragmentTransaction= fragmentManager.beginTransaction();
                fragmentTransaction.replace(R.id.frgTT, editSVFragment);
                fragmentTransaction.addToBackStack(null);
                fragmentTransaction.commit();
            }
        } );

        //xu ly su kien doi mat khau va gui du lieu
        txtDoiMKSV.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                DoiMatKhauFragment doiMatKhauFragment = new DoiMatKhauFragment();
                Bundle bundle = new Bundle();
                bundle.putString( "Email", uss );
                bundle.putString( "Password", pass );
                doiMatKhauFragment.setArguments( bundle );
                FragmentManager fragmentManager = getFragmentManager();
                FragmentTransaction fragmentTransaction= fragmentManager.beginTransaction();
                fragmentTransaction.replace(R.id.frgTT, doiMatKhauFragment);
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
            z = "Ko thể connect server";
            if (con == null) {
            } else {
                String query = "Select sv.Avt, sv.Masv,sv.TenSV,l.TenLop,sv.GioiTinh,sv.NamSinh,sv.SDT,sv.DiaChi,ng.TenNganh,kh.NienKhoa" +
                        " from SinhVien as sv , Lop as l , NganhHoc as ng , KhoasHoc as kh "
                        + "where l.Malop = sv.Malop and l.MaNganh = ng.MaNganh and l.MaKhoaHoc = kh.MaKhoaHoc and Email='" + uss + "'";
                //String query = "select * from SinhVien where Email='" + uss + "'";
                byte b[];
                Blob blob;
                Statement stmt = con.createStatement();
                resultSet = stmt.executeQuery( query );
                while (resultSet.next()) {

                    txtTen.setText( resultSet.getString( "TenSV" ) );
                    txtMaSV.setText( resultSet.getString( "MaSV" ) );
                    txtLop.setText( resultSet.getString( "TenLop" ) );
                    txtGioiTinh.setText( resultSet.getString( "GioiTinh" ) );
                    txtChuyenNganh.setText( resultSet.getString( "TenNganh" ) );
                    txtNienKhoa.setText( resultSet.getString( "NienKhoa" ) );
                    txtDiaChi.setText( resultSet.getString( "DiaChi" ) );
                    txtSDT.setText( resultSet.getString( "SDT" ) );
                    txtNamSinh.setText( resultSet.getString( "NamSinh" ) );

                    gioiTinh = resultSet.getString( "GioiTinh" );
                    Log.e( "onViewCreated: ", gioiTinh  );
                    namSinh = resultSet.getString( "NamSinh" );
                    diaChi = resultSet.getString( "DiaChi" );
                    sDT = resultSet.getString( "SDT");

                    blob = resultSet.getBlob( "Avt" );
                    b = blob.getBytes( 1, (int) blob.length() );
                    byte[] decodeString = Base64.decode( b, Base64.DEFAULT );
                    Bitmap decodebitmap = BitmapFactory.decodeByteArray( decodeString, 0, decodeString.length );
                    imgInfor.setImageBitmap( decodebitmap );

                }

            }

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}