using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDU_Management.Controller;
using System.Security.Cryptography;

namespace GDU_Management.GDU_Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //controller
        EncodingPasswordController encodingPasswordController = new EncodingPasswordController();

        string chuoiMaHoc;
        string maHoaMD5;
        string maHocDES;
        string giaiMaDES;

        Bitmap image;
        string base64Text;


        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image imageOut = Image.FromStream(ms);
                return imageOut;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG, *JPEG)|*.BMP;*.JPG;*.PNG" +
            "|All files(*.*)|*.*";
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = (Image)image;

                byte[] imageArray = System.IO.File.ReadAllBytes(dialog.FileName);
                base64Text = Convert.ToBase64String(imageArray); //base64Text must be global but I'll use  richtext
                richTextBox1.Text = base64Text;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = Convert.FromBase64String(richTextBox1.Text);
           pictureBox2.Image = ByteArrayToImage(imageBytes);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = ColorTranslator.FromHtml("#957254");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Blue;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                button2.Enabled = true;
            }
        }

       

        public string MD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }
            MessageBox.Show("ma hoa md5: "+str_md5);
            return str_md5;
        }


        public string Encrypt(string source, string key)
        {
            TripleDESCryptoServiceProvider desCryptoProvider = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();
            byte[] byteHash;
            byte[] byteBuff;

            byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
            desCryptoProvider.Key = byteHash;
            desCryptoProvider.Mode = CipherMode.ECB; //CBC, CFB
            byteBuff = Encoding.UTF8.GetBytes(source);

            string encoded =
                Convert.ToBase64String(desCryptoProvider.CreateEncryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            return encoded;
        }

        public static string Decrypt(string encodedText, string key)
        {
            TripleDESCryptoServiceProvider desCryptoProvider = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();

            byte[] byteHash;
            byte[] byteBuff;

            byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
            desCryptoProvider.Key = byteHash;
            desCryptoProvider.Mode = CipherMode.ECB; //CBC, CFB
            byteBuff = Convert.FromBase64String(encodedText);

            string plaintext = Encoding.UTF8.GetString(desCryptoProvider.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            return plaintext;
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            maHoaMD5 = MD5(txtChuoiNhapVao.Text.Trim());
            maHocDES = Encrypt(txtChuoiNhapVao.Text.Trim(), "GDUmanagement-User");
            string maHoaMD5DES = MD5(maHocDES);
            txtMaHoaMD5.Text = maHoaMD5;
            txtMaHoaDES.Text = maHocDES;
            txtMD5DES.Text = maHoaMD5DES;
        }

        private void tnGiaiMa_Click(object sender, EventArgs e)
        {
            giaiMaDES = Decrypt(maHocDES, "GDUmanagement");
            txtGiaiMaDES.Text = giaiMaDES;
        }


        //---------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------


    }
}
    

