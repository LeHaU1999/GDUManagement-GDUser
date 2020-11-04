package com.example.myapplication.model;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;


import com.example.myapplication.R;

import java.util.List;

public class AdapterTienTrinh extends RecyclerView.Adapter<AdapterTienTrinh.ViewHolder> {
    private List <TienTrinh> lstTienTrinh;

    public AdapterTienTrinh(List<TienTrinh> lstTienTrinh) {
        this.lstTienTrinh = lstTienTrinh;
    }



    @NonNull
    @Override
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {

                View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.item_tien_trinh, parent, false);
                return new  ViewHolder( view );


    }

    @Override
    public void onBindViewHolder(@NonNull AdapterTienTrinh.ViewHolder holder, int position) {
        holder.setTienTrinh( lstTienTrinh.get( position ).getTenMonHoc(),
                lstTienTrinh.get( position ).getSoTinChi(),
                lstTienTrinh.get( position ).getTinhTrang());

    }
    @Override
    public int getItemCount() {
        return lstTienTrinh.size();
    }


    public class ViewHolder extends RecyclerView.ViewHolder {
        private TextView txttenMonHoc;
        private TextView txtsoTinChi;
        private TextView txtTT;
        public ViewHolder(@NonNull View itemView) {
            super( itemView );

            txttenMonHoc = itemView.findViewById( R.id.txtMonhoc );
            txtsoTinChi = itemView.findViewById( R.id.txtsotinchi );
            txtTT = itemView.findViewById( R.id.txtTT );
        }

        private void setTienTrinh(String tenMonHoc, String soTinChi,String tinhTrang) {
            txttenMonHoc.setText( tenMonHoc );
            txtsoTinChi.setText( soTinChi );
            txtTT.setText( tinhTrang );
        }


    }
}
