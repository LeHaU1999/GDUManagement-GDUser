using GDU_Management.GDU_Views;
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
    public partial class frmCheckAdmin2 : Form
    {
        public frmCheckAdmin2()
        {
            InitializeComponent();
        }

        private void btnTiepTuc2_Click(object sender, EventArgs e)
        {
            string checkText = txtKetQua2.Text;
            if (checkText.Equals("Phải"))
            {
                MessageBox.Show("Hay Lắm Thằng Ngu ạ, Câu trả lời đúng r", "Đúng Rồi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmOptions frm_option = new frmOptions();
                frm_option.ShowDialog();
            }
            else
            {
                MessageBox.Show("M thông minh lắm thằng ngu ạ, Nhưng sai r", "Sai Rồi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đéo đủ trình mà cùng đòi vô đây, Cút đê", "Cút Đê", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
