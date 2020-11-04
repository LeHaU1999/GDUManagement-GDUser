package com.example.myapplication.present;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.BitmapDrawable;
import android.net.Uri;
import android.os.AsyncTask;
import android.os.Bundle;
import android.os.Environment;
import android.provider.MediaStore;
import android.util.Base64;
import android.util.Log;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.ProgressBar;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;


import com.example.myapplication.MainActivity;
import com.example.myapplication.R;
import com.example.myapplication.model.SERVER;

import java.io.ByteArrayOutputStream;
import java.io.FileNotFoundException;
import java.io.InputStream;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;

public class ImageProfileFragment extends AppCompatActivity {

    // Declaring Layouts buttons, imageview extra
    private static final int RESULT_LOAD_IMAGE = 1;
    Button uploadpic;
    ImageView imagebox;
    final int CHAN_PW_CODE = 4;
    ProgressBar progressBar;
    // End Layouts buttons, imageview extra

    // Declaring connection variables and array,string to store data in them
    byte[] byteArray;
    String encodedImage;
    String email,check;
    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView( R.layout.activity_image_profile);

        Bundle extras = getIntent().getExtras();
        email = extras.getString("Email", "N/A");
        Log.e("Image: ",  email);
        check = extras.getString( "Check", "N/A" );
        Log.e("Image: ",  check);
        // Finding the declared layouts
        uploadpic = (Button) findViewById(R.id.button);
        progressBar = (ProgressBar) findViewById(R.id.progressBar);
        imagebox = (ImageView) findViewById(R.id.imnav );

        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);

        //End  Finding the declared layouts
        uploadpic.setOnClickListener(new View.OnClickListener()

        {
            @Override
            public void onClick(View v)
            {
                // Opening the Gallery and selecting media
                if (Environment.getExternalStorageState().equals( Environment.MEDIA_MOUNTED)&& !Environment.getExternalStorageState().equals( Environment.MEDIA_CHECKING))
                {
                    Intent galleryIntent = new Intent( Intent.ACTION_PICK, MediaStore.Images.Media.EXTERNAL_CONTENT_URI);
                    startActivityForResult(galleryIntent,RESULT_LOAD_IMAGE );

                    // this will jump to onActivity Function after selecting image
                }
                else
                {
                    Toast.makeText(ImageProfileFragment.this, "No activity found to perform this task", Toast.LENGTH_SHORT).show();
                }
                // End Opening the Gallery and selecting media
            }
        });

    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data)
    {
        super.onActivityResult(requestCode, resultCode, data);

        if (requestCode == RESULT_LOAD_IMAGE && resultCode == RESULT_OK  && null != data)
        {
            // getting the selected image, setting in imageview and converting it to byte and base 64
            progressBar.setVisibility(View.VISIBLE);
            Bitmap originBitmap = null;
            Uri selectedImage = data.getData();
            Toast.makeText(ImageProfileFragment.this, selectedImage.toString(), Toast.LENGTH_LONG).show();
            InputStream imageStream;
            try
            {
                imageStream = getContentResolver().openInputStream(selectedImage);
                originBitmap = BitmapFactory.decodeStream(imageStream);
            }
            catch (FileNotFoundException e)
            {
                System.out.println(e.getMessage().toString());
            }
            if (originBitmap != null)
            {
                this.imagebox.setImageBitmap(originBitmap);

                try
                {
                    Bitmap image = ((BitmapDrawable) imagebox.getDrawable()).getBitmap();
                    ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
                    image.compress( Bitmap.CompressFormat.JPEG,  90, byteArrayOutputStream);
                    byteArray = byteArrayOutputStream.toByteArray();
                    encodedImage = Base64.encodeToString(byteArray, Base64.DEFAULT);
                    Log.w("Warring",encodedImage);

                    // Calling the background process so that application wont slow down
                    UploadImage uploadImage = new UploadImage();
                    uploadImage.execute("");
                   // onBackPressed();
                    //End Calling the background process so that application wont slow down
                }
                catch (Exception e)
                {
                    Log.w("ERROR","exception");
                }
                Toast.makeText(ImageProfileFragment.this, "Conversion Done", Toast.LENGTH_SHORT).show();
            }
            // End getting the selected image, setting in imageview and converting it to byte and base 64
        }
        else
        {
            System.out.println("Error");
        }
    }

    public class UploadImage extends AsyncTask<String, String, String>
    {
        @Override
        protected void onPostExecute(String r)
        {
            // After successful insertion of image
            progressBar.setVisibility(View.GONE);
            //Toast.makeText(ImageProfileActivity.this , "Image Inserted Succesfully" , Toast.LENGTH_LONG).show();
            // End After successful insertion of image

        }
        @Override
        protected String doInBackground(String... params) {

            String msg = "unknown";

                try {
                    Connection con = SERVER.Connect();
                    if (con == null) {
                    } else {
                        String commands = "Update "+check+" set Avt ='" + encodedImage + "' where Email ='" + email + "'";
                        PreparedStatement preStmt = con.prepareStatement( commands );
                        preStmt.executeUpdate();
                        msg = "Thêm ảnh thành công";

                    }
                } catch (SQLException ex) {
                    msg = ex.getMessage().toString();
                    Log.d( "Error no 1:", msg );
                }

                System.out.println( msg );
                return "";
                //End Inserting in the database
            }


        }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
       // startActivity(new Intent(ImageProfileActivity.this, MainActivityGV.class));

        switch (item.getItemId())
        {
            case android.R.id.home:

                    Intent intent = new Intent(ImageProfileFragment.this, MainActivity.class);
                    intent.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TASK | Intent.FLAG_ACTIVITY_CLEAR_TOP);
                    intent.putExtra("Email", email);
                   startActivity(intent);
                    finish();
                    return true;

            default:
                break;
        }
        return super.onOptionsItemSelected(item);
    }
//    public void onBackPressed() {
//        moveTaskToBack(false);
//    }
}