package com.example.myapplication.present;

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
import com.example.myapplication.model.EditGVViewModel;
import com.example.myapplication.model.SERVER;

import java.sql.Connection;
import java.sql.PreparedStatement;

public class EditGVFragment extends Fragment {
    private EditText txtEditGVGioiTinh;
    private EditText txtEditGVNamSinh;
    private EditText txtEditGVDiaChi;
    private EditText txtEditGVSDT;
    private EditText txtEditGVTrinhDo;
    private Button btnCapNhatGV;
    private EditGVViewModel editGVViewModel;
    String gioiTinh,diaChi,namSinh,sDT,email,trinhDo;
    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        editGVViewModel =
                ViewModelProviders.of(this).get( EditGVViewModel.class);
        View view = inflater.inflate( R.layout.fragment_editgv, container, false);
        txtEditGVGioiTinh = view.findViewById( R.id.txtEditGVGioiTinh );
        txtEditGVNamSinh = view.findViewById( R.id.txtEditGVNamSinh );
        txtEditGVDiaChi = view.findViewById( R.id.txtEditGVDiaChi );
        txtEditGVSDT = view.findViewById( R.id.txtEditGVSDT);
        txtEditGVTrinhDo = view.findViewById( R.id.txtEditGVTrinhDo );
        btnCapNhatGV = view.findViewById( R.id.btnCapNhatGV );

        Bundle bundle = getArguments();
        gioiTinh = bundle.getString( "GioiTinh" );
        namSinh =bundle.getString( "NamSinh" );
        diaChi = bundle.getString( "DiaChi" );
        sDT = bundle.getString( "SDT" );
        email = bundle.getString( "Email" );
        trinhDo = bundle.getString( "TrinhDo" );
        Log.e( "onCreateView: ", email  );
        return view;

    }

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated( view, savedInstanceState );
        txtEditGVGioiTinh.setText(gioiTinh);
        txtEditGVNamSinh.setText( namSinh );
        txtEditGVDiaChi.setText( diaChi );
        txtEditGVSDT.setText( sDT );
        txtEditGVTrinhDo.setText( trinhDo );
        btnCapNhatGV.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                try {
                    Connection con = SERVER.Connect();
                    if(con == null){

                    }else {
                        String gt = txtEditGVGioiTinh.getText().toString();
                        Log.e( "GT: ",gt );
                        String ns = txtEditGVNamSinh.getText().toString();
                        String dc = txtEditGVDiaChi.getText().toString();
                        String sdt = txtEditGVSDT.getText().toString();
                        String td = txtEditGVTrinhDo.getText().toString();
                        String query = "Update GiangVien set GioiTinh = '" + gt + "', NamSinh ='" + ns + "', DiaChi= '"+dc+"', " +
                                "SDT = '"+ sdt +"', TrinhDo='"+ td +"' where Email ='"+email+"'";

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