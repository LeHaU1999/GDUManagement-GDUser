package com.example.myapplication.model;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;


import com.example.myapplication.R;

import java.util.List;

public class AdapterTKB extends RecyclerView.Adapter<AdapterTKB.ViewHolder>{

    private List<TKB> lstarray ;

    public AdapterTKB(List<TKB> lstarray) {
        this.lstarray = lstarray;
    }

    @NonNull
    @Override
    public AdapterTKB.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate( R.layout.item_mon_hoc, parent, false);
        return new ViewHolder( view );
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder holder, int position) {
        holder.setThongTin( lstarray.get(position).getMonHoc(),
                lstarray.get(position).getThuNgay(),
                lstarray.get( position ).getNgayBD(),
                lstarray.get( position ).getNgayKT(),
                lstarray.get( position ).getThoiGianHoc(),
                lstarray.get( position ).getPhongHoc(),
                lstarray.get( position ).getTenGV()
        );
    }

    @Override
    public int getItemCount() {
        return lstarray.size();
    }


    public class ViewHolder extends RecyclerView.ViewHolder{
        private TextView txtTenMH;
        private TextView txtThu;
        private TextView txtNgayBatDau;
        private TextView txtNgayKetThuc;
        private TextView txtThoiGianHoc;
        private TextView txtMaPhongHoc;
        private TextView txtTenGV;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            txtTenMH = itemView.findViewById(R.id.txtMonHoc);
            txtThu = itemView.findViewById(R.id.txtThu);
            txtNgayBatDau = itemView.findViewById( R.id.txtTGBatDau );
            txtNgayKetThuc = itemView.findViewById( R.id.txtTGKetThuc );
            txtThoiGianHoc = itemView.findViewById(R.id.txtCa);
            txtMaPhongHoc = itemView.findViewById(R.id.txtPhongHoc);
            txtTenGV = itemView.findViewById(R.id.txtGiaoVienDay);
        }

        private void setThongTin(String tenMH, String thu, String NgayBatDau, String NgayKetThuc, String ThoiGianHoc, String MaPhongHoc, String TenGV){
            txtTenMH.setText(tenMH);
            txtThu.setText(thu);
            txtNgayBatDau.setText( NgayBatDau );
            txtNgayKetThuc.setText( NgayKetThuc );
            txtThoiGianHoc.setText( ThoiGianHoc );
            txtMaPhongHoc.setText( MaPhongHoc );
            txtTenGV.setText( TenGV );
        }

    }
}
