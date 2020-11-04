package com.example.myapplication.model;

        import androidx.lifecycle.LiveData;
        import androidx.lifecycle.MutableLiveData;
        import androidx.lifecycle.ViewModel;

public class EditSVViewModel extends ViewModel {

    private MutableLiveData<String> mText;

    public EditSVViewModel() {
        mText = new MutableLiveData<>();
    }

    public LiveData<String> getText() {
        return mText;
    }
}