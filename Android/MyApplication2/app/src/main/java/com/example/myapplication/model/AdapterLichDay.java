package com.example.myapplication.model;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;


import com.example.myapplication.R;

import java.util.List;

public class AdapterLichDay extends RecyclerView.Adapter<AdapterLichDay.ViewHolder> {
    private List<LichDay> lstLichDay;
    public AdapterLichDay(List<LichDay> lstLichDay){
        this.lstLichDay = lstLichDay;
    }
    @NonNull
    @Override
    public AdapterLichDay.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate( R.layout.item_lichday, parent, false);
        return new ViewHolder( view );
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder holder, int position) {
        holder.setLichDay( lstLichDay.get( position ).getThu(),
                lstLichDay.get( position ).getMonDay(),
                lstLichDay.get( position ).getCaDay(),
                lstLichDay.get( position ).getPhongDay(),
                lstLichDay.get( position ).getNgayBatDau(),
                lstLichDay.get( position ).getNgayKetThuc(),
                lstLichDay.get( position ).getLop());
    }


    @Override
    public int getItemCount() {
        return lstLichDay.size();
    }
    public class ViewHolder extends RecyclerView.ViewHolder{
        private TextView txtThu;
        private TextView txtMonHoc;
        private TextView txtCa;
        private TextView txtPhongDay;
        private TextView txtNgayBatDau;
        private TextView txtNgayKetThuc;
        private TextView txtLopDay;

        public ViewHolder(@NonNull View itemView) {
            super(itemView);

            txtThu = itemView.findViewById(R.id.txtThu);
            txtMonHoc = itemView.findViewById(R.id.txtMonHoc);
            txtCa = itemView.findViewById(R.id.txtCa);
            txtPhongDay = itemView.findViewById(R.id.txtPhongHoc);
            txtNgayBatDau = itemView.findViewById( R.id.txtNgayBatDau );
            txtNgayKetThuc = itemView.findViewById( R.id.txtNgayKetThuc );
            txtLopDay = itemView.findViewById( R.id.txtLopDay );

        }

        private void setLichDay(String Thu, String MonDay, String Ca, String PhongDay, String NgayBatDau, String NgayKetThuc, String LopDay){
           txtThu.setText( Thu );
           txtMonHoc.setText( MonDay );
           txtCa.setText( Ca );
           txtPhongDay.setText( PhongDay );
           txtNgayBatDau.setText( NgayBatDau );
           txtNgayKetThuc.setText( NgayKetThuc );
           txtLopDay.setText( LopDay );
        }

    }
}
