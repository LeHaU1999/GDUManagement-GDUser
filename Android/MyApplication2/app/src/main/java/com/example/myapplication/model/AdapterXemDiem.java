package com.example.myapplication.model;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;


import com.example.myapplication.R;

import java.util.List;

public class AdapterXemDiem extends RecyclerView.Adapter<AdapterXemDiem.ViewHolder> {
    private List<XemDiem> lstXemDiem;

    public AdapterXemDiem(List<XemDiem> lstXemDiem) {
        this.lstXemDiem = lstXemDiem;
    }

    @Override
    public int getItemViewType(int position) {
        switch (lstXemDiem.get( position ).getType()) {
            case 0:
                return XemDiem.HOC_KY;
            case 1:
                return XemDiem.XEM_DIEM;
            default:
                return -1;
        }
    }

    @NonNull
    @Override
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        switch (viewType) {
            case XemDiem.HOC_KY:
                View view1 = LayoutInflater.from(parent.getContext()).inflate( R.layout.hocky_title, parent, false);
                return new ViewHolder( view1 );
            case XemDiem.XEM_DIEM:
               View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.item_diem, parent, false);
               return new ViewHolder( view );

            default:
                return null;
        }
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder holder, int position) {
        switch (lstXemDiem.get( position ).getType()) {
            case XemDiem.HOC_KY:
                String tenHocKy=lstXemDiem.get( position ).getHocKy();
                holder.setHocKy( tenHocKy );
                break;
            case XemDiem.XEM_DIEM:
                String monHoc = lstXemDiem.get( position ).getMonHoc();
                String diem30 = lstXemDiem.get( position ).getDiem30();
                String diem70l1 = lstXemDiem.get( position ).getDiem70l1();
                String diem70l2 = lstXemDiem.get( position ).getDiem70l2();
                String diemTong = lstXemDiem.get( position ).getDiemTong();
                holder.setDiem( monHoc, diem30, diem70l1, diem70l2, diemTong );
                break;
            default:
                return;
        }
    }

    @Override
    public int getItemCount() {
        return lstXemDiem.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder {

        private TextView txtHocKy;
        private TextView txtMonHoc;
        private TextView txtDiem30;
        private TextView txtDiem70l1;
        private TextView txtDiem70l2;
        private TextView txtDiemTong;

        public ViewHolder(@NonNull View itemView) {
            super( itemView );

            txtHocKy = itemView.findViewById( R.id.txtTenHocKY );
            txtMonHoc = itemView.findViewById( R.id.txtTenMonHoc );
            txtDiem30 = itemView.findViewById( R.id.txtDiem30 );
            txtDiem70l1 = itemView.findViewById( R.id.txtDiem70l1 );
            txtDiem70l2 = itemView.findViewById( R.id.txtDiem70l2 );
            txtDiemTong = itemView.findViewById( R.id.txtDiemTB );

        }

        private void setDiem(String monHoc, String diem30, String diem70l1, String diem70l2, String diemTong) {

            txtMonHoc.setText( monHoc );
            txtDiem30.setText( diem30 );
            txtDiem70l1.setText( diem70l1 );
            txtDiem70l2.setText( diem70l2 );
            txtDiemTong.setText( diemTong );
        }
        private void setHocKy(String hocKy){
            txtHocKy.setText( hocKy );
        }
    }
}
