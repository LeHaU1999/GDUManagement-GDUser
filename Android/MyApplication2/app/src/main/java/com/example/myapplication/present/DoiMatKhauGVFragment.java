package com.example.myapplication.present;

import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import com.example.myapplication.R;
import com.example.myapplication.model.DoiMatKhauGVViewModel;
import com.example.myapplication.model.SERVER;

import java.sql.Connection;
import java.sql.PreparedStatement;

public class DoiMatKhauGVFragment extends Fragment {
    String email,mkcu, mkmoi,mknmoi;
    private DoiMatKhauGVViewModel doiMatKhauGVViewModel;
    private EditText txtMKcu,txtMKmoi,txtNMKmoi;
    private Button btnXacNhanGV;
    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        View view = inflater.inflate( R.layout.fragment_doimkgv, container, false);
        txtMKcu = view.findViewById( R.id.txtMKcugv );
        txtMKmoi = view.findViewById( R.id.txtMKmoigv );
        txtNMKmoi = view.findViewById( R.id.txtNMKmoigv );
        btnXacNhanGV = view.findViewById( R.id.btnxacnhangv );

        //Lay du lieu
        Bundle bundle = getArguments();
        email = bundle.getString( "Email" );
        mkcu = bundle.getString( "Password" );
        return view;
    }
    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated( view, savedInstanceState );
        btnXacNhanGV.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String matkhaucu = txtMKcu.getText().toString();
                String matkhaumoi = txtMKmoi.getText().toString();
                Log.e( "GT: ", matkhaumoi );
                String matkhaunhaplaimoi = txtNMKmoi.getText().toString();

                try {
                    Connection con = SERVER.Connect();
                    if (con == null) {

                    } else {
                        String query = "Update GiangVien set Password = '" + matkhaunhaplaimoi + "' where Email ='" +
                                email + "' and '" + matkhaumoi + "' = '" + matkhaunhaplaimoi + "' " +
                                "and '" + matkhaucu + "' = '" + mkcu + "'";
                        Log.e( "onClick: ", matkhaunhaplaimoi );
                        PreparedStatement preStmt = con.prepareStatement( query );
                        preStmt.executeUpdate();
                        Toast.makeText( getActivity(), "Password Đổi Thành Công!", Toast.LENGTH_SHORT ).show();

                    }

                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        } );
    }
}