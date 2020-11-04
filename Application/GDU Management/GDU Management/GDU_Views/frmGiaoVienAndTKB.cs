using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDU_Management
{
    public partial class frmGiaoVienAndTKB : Form
    {
        public frmGiaoVienAndTKB()
        {
            InitializeComponent();
            timerGiangvien_TKB.Start();
        }

        //CÁC HÀM PUBLIC DÙNG TRONG FORM
        //1-hàm trở về Menu Chính - GDU Management
        public void goHomeMenu()
        {
            this.Hide();
            GDUManagement gdu =new GDUManagement();
            gdu.ShowDialog();
        }

        //KẾT THÚC CÁC HÀM PUBLIC DÙNG TRONG FORM
        private void timerGiangvien_TKB_Tick(object sender, EventArgs e)
        {
            //hàm lấy ngày giờ
            lblTime.Text = DateTime.Now.ToLongTimeString();
            //lblDay.Text = DateTime.Now.ToLongDateString();
            DateTime ngay = DateTime.Now;
            lblDay.Text = ngay.ToString("dd/MM/yyyy");

            //hàm bộ điếm thời gian online
            int giay_gv = Convert.ToInt32(lblGiay_gv.Text);
            int phut_gv = Convert.ToInt32(lblPhut_gv.Text);
            giay_gv++;

            int giay_tkb = Convert.ToInt32(lblGiay_tkb.Text);
            int phut_tkb = Convert.ToInt32(lblPhut_tkb.Text);
            giay_tkb++;

            if (giay_gv > 59 & giay_tkb > 59)
            {
                giay_gv = 0;
                phut_gv++;

                giay_tkb = 0;
                phut_tkb++;
            }
            
            if (giay_gv < 10 & giay_tkb < 10)
            {
                lblGiay_gv.Text = "0" + giay_gv;
                lblGiay_tkb.Text = "0" + giay_tkb;
            }
            else
            {
                lblGiay_gv.Text = "" + giay_gv;
                lblGiay_tkb.Text = "" + giay_tkb;
            }
            if (phut_gv < 10  & phut_tkb < 10)
            {
                lblPhut_gv.Text = "0" + phut_gv;
                lblPhut_tkb.Text = "0" + phut_tkb;
            }
            else
            {
                lblPhut_gv.Text = "" + phut_gv;
                lblPhut_tkb.Text = "" + phut_tkb;
            }
          
            if (giay_gv % 2 == 0  & giay_tkb % 2 == 0)
            {
                lblAnimation1_gv.Text = "(^_^)";
                lblAnimation2_gv.Text = "(+_+)";
                lblAnimation3_gv.Text = "(-_^)";

                lblAnimation1_tkb.Text = "(^_^)";
                lblAnimation2_tkb.Text = "(+_+)";
                lblAnimation3_tkb.Text = "(-_^)";
            }
            else if (giay_gv % 2 != 0  & giay_tkb % 2 != 0)
            {
                lblAnimation1_gv.Text = "(+_+)";
                lblAnimation2_gv.Text = "(^_^)";
                lblAnimation3_gv.Text = "(^_-)";

                lblAnimation1_tkb.Text = "(+_+)";
                lblAnimation2_tkb.Text = "(^_^)";
                lblAnimation3_tkb.Text = "(^_-)";
            }
        }

        private void btnHomTKB_Click(object sender, EventArgs e)
        {
            goHomeMenu();
        }

        private void btnHomeGV_Click(object sender, EventArgs e)
        {
            goHomeMenu();
        }

        private void btnExit_TKB_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnExit_GV_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
