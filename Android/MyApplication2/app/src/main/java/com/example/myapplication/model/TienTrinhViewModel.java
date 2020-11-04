package com.example.myapplication.model;

        import androidx.lifecycle.LiveData;
        import androidx.lifecycle.MutableLiveData;
        import androidx.lifecycle.ViewModel;

public class TienTrinhViewModel extends ViewModel {

    private MutableLiveData<String> mText;

    public TienTrinhViewModel() {
        mText = new MutableLiveData<>();
    }

    public LiveData<String> getText() {
        return mText;
    }
}