package com.example.myapplication.present;

import android.app.AlertDialog.Builder;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.Observer;
import androidx.lifecycle.ViewModelProviders;

import com.example.myapplication.R;
import com.example.myapplication.model.EditSVViewModel;
import com.example.myapplication.model.SERVER;
import com.example.myapplication.ui.ThongTinSinhVien.ThongTinSinhVienFragment;

import java.sql.Connection;
import java.sql.PreparedStatement;

public class EditSVFragment extends Fragment {

    private EditText txtEditGioiTinh;
    private EditText txtEditNamSinh;
    private EditText txtEditDiaChi;
    private EditText txtEditSDT;
    private Button btnCapNhat;
    String gioiTinh,diaChi,namSinh,sDT,email;
    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate( R.layout.fragment_editsv, container, false);
        //Anh xa
        txtEditGioiTinh = (EditText) view.findViewById( R.id.txtEditGioiTinh);
        txtEditNamSinh = view.findViewById( R.id.txtEditNamSinh );
        txtEditDiaChi = view.findViewById( R.id.txtEditDiaChi );
        txtEditSDT = view.findViewById( R.id.txtEditSDT );
        btnCapNhat = view.findViewById( R.id.btnCapNhat );
        //Lay du lieu
        Bundle bundle = getArguments();
        gioiTinh = bundle.getString( "GioiTinh" );
        namSinh =bundle.getString( "NamSinh" );
        diaChi = bundle.getString( "DiaChi" );
        sDT = bundle.getString( "SDT" );
        email = bundle.getString( "Email" );
        Log.e( "onCreateView: ", email  );

        return view;

    }

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated( view, savedInstanceState );
        //Set text default cho form edit
        txtEditGioiTinh.setText(gioiTinh);
     //   Log.e( "Edit: ",gioiTinh );
        txtEditNamSinh.setText( namSinh );
        txtEditDiaChi.setText( diaChi );
        txtEditSDT.setText( sDT );

        //lay data sau khi edit


        btnCapNhat.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                try {
                    Connection con = SERVER.Connect();
                    if(con == null){

                    }else {
                        String gt = txtEditGioiTinh.getText().toString();
                        Log.e( "GT: ",gt );
                        String ns = txtEditNamSinh.getText().toString();
                        String dc = txtEditDiaChi.getText().toString();
                        String sdt = txtEditSDT.getText().toString();
                        String query = "Update SinhVien set GioiTinh = '" + gt + "', NamSinh ='" + ns + "', DiaChi= '"+dc+"', " +
                                "SDT = '"+ sdt +"' where Email ='"+email+"'";
                        //String query ="Update SinhVien set GioiTinh = '"+gt+"' where Email ='"+email+"'";
                        PreparedStatement preStmt = con.prepareStatement( query );
                        preStmt.executeUpdate();
                        Toast.makeText( getActivity(), "Thông tin đã được cập nhật!", Toast.LENGTH_SHORT ).show();
                    }

                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        } );
    }
}