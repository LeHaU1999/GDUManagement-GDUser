package com.example.myapplication.ui.ThongTinSinhVien;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

public class ThongTinSinhVienModel extends ViewModel {

    private MutableLiveData<String> mText;

    public ThongTinSinhVienModel() {
        mText = new MutableLiveData<>();
    }

    public LiveData<String> getText() {
        return mText;
    }
}