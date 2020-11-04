using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDU_Management.Model;
using GDU_Management.Service;
using GDU_Management.GDU_Views;
using GDU_Management.Controller;
using System.IO;

namespace GDU_Management
{
    public partial class frmGiaoVienAndTKB : Form
    {
        public frmGiaoVienAndTKB()
        {
            InitializeComponent();
            timerGiangvien_TKB.Start();
        }

        //khai báo các service
        GiangVienService giangVienService = new GiangVienService();
        ThoiKhoaBieuService thoiKhoaBieuService = new ThoiKhoaBieuService();
        HocKyService hocKyService = new HocKyService();
        KhoaService khoaService = new KhoaService();
        NganhHocService nganhHocService = new NganhHocService();
        KhoasHocService khoasHocService = new KhoasHocService();
        MonHocService monHocService = new MonHocService();
        LopService lopService = new LopService();
        PhongHocService phongHocService = new PhongHocService();
        ContactService contactService = new ContactService();

        //khai báo các controller
        SendMessageController sendMessage = new SendMessageController();

        //public value
        string maLop;
        string ca1, ca2, ca3, ca4, thoiGianHoc;
        string subEmail, messEmail;



        //---------------------------DANH SÁCH HÀM PUBLIC------------------------------//
        //---------------------------------------------------------------------------------------//
        public void goHomeMenu()
        {
            this.Hide();
            GDUManagement gdu =new GDUManagement();
            gdu.ShowDialog();
        }


        //chuyển hình từ kiểu Image sang kiểu ByteArray  ==> Save image vào database
        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        //chuyển hình từ kiểu ByteArray sang kiểu Image  ==> Show image từ database lên form
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image imageOut = Image.FromStream(ms);
                return imageOut;
            }
        }

            //lấy danh sách giảng viên đưa vào datagridview
            public void LoadDanhSachGiangVienToDgv()
        {
            dgvDanhSachGiangVien.DataSource = giangVienService.GetGiangVienByMaKhoa(cboChonKhoa_GV.SelectedValue.ToString().Trim()).ToList();
            CountRowsGiangVien();
        }

        //lấy danh sách lớp đưa vào treview
        public void LoadDanhSachLopHocToTreeview()
        {
            var listLp = lopService.GetDanhSachLopByMaNganhVaMaKhoaHoc(cboChonNganh_TKB.SelectedValue.ToString().Trim(),cboChonKhoasHoc_TKB.SelectedValue.ToString().Trim());
            trvDSLop.Nodes.Clear();
            foreach (var lp in listLp)
            {
                TreeNode treeNode = new TreeNode("Danh Sách Lớp", 0, 0);
                treeNode.Name = lp.MaLop;
                treeNode.Text = lp.TenLop;
                trvDSLop.Nodes.Add(treeNode);
            }
            trvDSLop.ExpandAll();
        }

        //lấy danh sách tkb đưa vào dgv
        public void LoadDanhSachThoiKhoaBieuToDgv()
        {
            
            dgvDanhSachTKB.DataSource = thoiKhoaBieuService.GetTKBByMaLopAndMaHK(maLop, cboChonHocKy_TKB.SelectedValue.ToString()).ToList();
            if (dgvDanhSachTKB.Rows.Count > 0)
            {
                LoadChiTietThoiKhoaBieu();
                CountRowsTKB();
            }  
        }

        public void LoadChiTietThoiKhoaBieu()
        {
                for (int i = 0; i < dgvDanhSachTKB.Rows.Count; i++)
                {
                    MonHoc monHoc = new MonHoc();
                    monHoc = monHocService.GetMonHocByMaMonHoc(dgvDanhSachTKB.Rows[i].Cells[2].Value.ToString());
                    dgvDanhSachTKB.Rows[i].Cells[3].Value = monHoc.TenMonHoc.ToString(); 
                    dgvDanhSachTKB.Rows[i].Cells[4].Value = monHoc.STC.ToString();

                    GiangVien gv = new GiangVien();
                    gv = giangVienService.GetGiangVienByMaGV(dgvDanhSachTKB.Rows[i].Cells[5].Value.ToString());
                    dgvDanhSachTKB.Rows[i].Cells[6].Value = gv.TenGV.ToString();
                }
        }

        //lấy danh sách data đưa vào các combobox
        public void LoadDataToCombobox()
        {
            //tab giảng viên
            cboChonKhoa_GV.DataSource = khoaService.GetAllKhoa();
            cboChonKhoa_GV.DisplayMember = "TenKhoa";
            cboChonKhoa_GV.ValueMember = "MaKhoa";
            LoadDanhSachGiangVienToDgv();

            //tab thời khóa biểu
            cboChonKhoa_TKB.DataSource = khoaService.GetAllKhoa();              //get khoa
            cboChonKhoa_TKB.DisplayMember = "TenKhoa";
            cboChonKhoa_TKB.ValueMember = "MaKhoa";

            cboChonHocKy_TKB.DataSource = hocKyService.GetAllHocKy();        //get học kỳ
            cboChonHocKy_TKB.DisplayMember = "TenHocKy";
            cboChonHocKy_TKB.ValueMember = "MaHocKy";

            cboChonPhongHoc_TKB.DataSource = phongHocService.GetAllPhongHoc();                  //get phòng học
            cboChonPhongHoc_TKB.DisplayMember = "MaPhongHoc";
            cboChonPhongHoc_TKB.ValueMember = "MaPhongHoc";
        }


        //laod môn học vạo combobox
        public void LoadMonHocToCbo()
        {
            cboChonMonHoc_TKB.ResetText();
            cboChonMonHoc_TKB.DataSource = monHocService.GetMonHocByNganh(cboChonNganh_TKB.SelectedValue.ToString()).ToList();
            cboChonMonHoc_TKB.DisplayMember = "TenMonHoc";
            cboChonMonHoc_TKB.ValueMember = "MaMonHoc";
        }


        //tự động tạo id giảng viên
        public void AutoIDGiangVien()
        {
            int countRows = dgvDanhSachGiangVien.Rows.Count;
            string LastIdKhoa = cboChonKhoa_GV.SelectedValue.ToString().Trim().Substring(8);    //lấy 2 số cuối mã khoa
            if(countRows == 0)
            {
                lblMaGV_GV.Text = "GDU"+LastIdKhoa+"01";
            }
            else if(countRows > 0 && countRows < 10)
            {
                string chuoi_id;
                int chuoi_id_key;
                chuoi_id = Convert.ToString(dgvDanhSachGiangVien.Rows[countRows - 1].Cells[1].Value);
                chuoi_id_key = Convert.ToInt32(chuoi_id.Remove(0, 5));
                lblMaGV_GV.Text = "GDU" + LastIdKhoa + "0" + (chuoi_id_key + 1);
            }
            else if (countRows >= 10)
            {
                string chuoi_id;
                int chuoi_id_key;
                chuoi_id = Convert.ToString(dgvDanhSachGiangVien.Rows[countRows - 1].Cells[1].Value);
                chuoi_id_key = Convert.ToInt32(chuoi_id.Remove(0, 4));

                lblMaGV_GV.Text = "GDU" + LastIdKhoa + (chuoi_id_key + 1);
            }
        }

        //check data Giảng Viên
        public bool checkDataGiangVien()
        {
            if (string.IsNullOrEmpty(txtTenGV.Text.Trim()))                 //kiểm tra tên giảng viên
            {
                MessageBox.Show("Tên Giảng Viên không được bỏ trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenGV.Focus();
                return false;
            }

           
            if (!string.IsNullOrEmpty(txtEmailGV.Text))          //kiểm tra email
            {
                string email = txtEmailGV.Text;
                var value = email.EndsWith("@gmail.com");
                string reEmail = value.ToString();
                if (reEmail.Equals("False"))
                {
                    MessageBox.Show("Định dạng email không đúng, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmailGV.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Email Không được bỏ trống, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailGV.Focus();
                return false;
            }

            
            if (!string.IsNullOrEmpty(txtSDT.Text))             //kiểm tra sdt
            {
                Regex isValidInput = new Regex(@"^\d{10}$");
                string sdt = txtSDT.Text.Trim();
                if (!isValidInput.IsMatch(sdt))
                {
                    MessageBox.Show("SĐT bao gồm 10 số và không có kí tự, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDT.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("SĐT Không được bỏ trống, vui lòng kiểm tra lại...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtxtDiaChi_GV.Text.Trim()))           //kiểm tra địa chỉ
            {
                MessageBox.Show("Địa chỉ không được bỏ trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtxtDiaChi_GV.Focus();
                return false;
            }

            return true;
        }

        //check data TKB
        public bool checkDataTKB()
        {
            if (string.IsNullOrEmpty(cboChonHocKy_TKB.Text))
            {
                MessageBox.Show("Chưa chọn học kỳ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(cboChonNgayHoc_TKB.Text))
            {
                MessageBox.Show("Thứ Không được bỏ trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(cboChonMonHoc_TKB.Text))
            {
                MessageBox.Show("Môn Học Không được bỏ trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(cboChonPhongHoc_TKB.Text))
            {
                MessageBox.Show("Phòng học Không được bỏ trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(cboChonGV_TKB.Text))
            {
                MessageBox.Show("Chưa chọn Giảng viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (thoiGianHoc == null)
            {
                MessageBox.Show("Chọn thời gian học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        //lấy danh sách môn học chưa có trong thòi khóa biểu
        public List<MonHoc> checkMonHoc()
        {
            List<MonHoc> listAllMonHocNganh = monHocService.GetMonHocByNganh(cboChonNganh_TKB.SelectedValue.ToString());
            var listTKB = thoiKhoaBieuService.GetTKBByMaLopAndMaHK(maLop, cboChonHocKy_TKB.SelectedValue.ToString());
            List<MonHoc> listNewMonHoc = new List<MonHoc>();

            foreach(var mhTkb in listTKB)
            {
                foreach(var mhAll in listAllMonHocNganh)
                {
                    if (mhTkb.MaMonHoc == mhAll.MaMonHoc)
                    {
                        listNewMonHoc.Add(mhAll);
                    }
                }
            }
            IEnumerable<MonHoc> otherSubject = listAllMonHocNganh.Except(listNewMonHoc);

            return otherSubject.ToList();
        } 

        //hiện dữ liệu lên các field
        public void ShowDataToField()
        {
            thoiGianHoc = dgvDanhSachTKB.CurrentRow.Cells[7].Value.ToString();
            cboChonNgayHoc_TKB.Text = dgvDanhSachTKB.CurrentRow.Cells[1].Value.ToString();
            dtpStartDay.DataBindings.Clear();
            dtpStartDay.DataBindings.Add("text", dgvDanhSachTKB.DataSource, "NgayBatDau");
            dtpEndDay.DataBindings.Clear();
            dtpEndDay.DataBindings.Add("text", dgvDanhSachTKB.DataSource, "NgayKetThuc");
            
            //môn học
            MonHoc mh = new MonHoc();
            mh = monHocService.GetMonHocByMaMonHoc(dgvDanhSachTKB.CurrentRow.Cells[2].Value.ToString());
            cboChonMonHoc_TKB.Text = mh.TenMonHoc;
            
            //giảng viên
            GiangVien gv = new GiangVien();
            gv = giangVienService.GetGiangVienByMaGV(dgvDanhSachTKB.CurrentRow.Cells[5].Value.ToString());
            cboChonGV_TKB.Text = gv.TenGV;

            //phòng học
            ThoiKhoaBieu tkb = new ThoiKhoaBieu();
            tkb = thoiKhoaBieuService.GetThoiKhoaBieuByMaLopMaMonHoc(maLop, dgvDanhSachTKB.CurrentRow.Cells[2].Value.ToString().Trim());
            cboChonPhongHoc_TKB.Text = tkb.MaPhongHoc; 

            //ngày học(thứ)
            switch (dgvDanhSachTKB.CurrentRow.Cells[1].Value.ToString().Trim())
            {
                case "Thứ 2":
                    cboChonNgayHoc_TKB.Text = "Thứ 2";
                    break;
                case "Thứ 3":
                    cboChonNgayHoc_TKB.Text = "Thứ 3";
                    break;
                case "Thứ 4":
                    cboChonNgayHoc_TKB.Text = "Thứ 4";
                    break;
                case "Thứ 5":
                    cboChonNgayHoc_TKB.Text = "Thứ 5";
                    break;
                case "Thứ 6":
                    cboChonNgayHoc_TKB.Text = "Thứ 6";
                    break;
                case "Thứ 7":
                    cboChonNgayHoc_TKB.Text = "Thứ 7";
                    break;
                case "Chủ NHật":
                    cboChonNgayHoc_TKB.Text = "Chủ NHật";
                    break;
                default : 
                    cboChonNgayHoc_TKB.Text = "Lỗi Hiển Thị..(-__-) ! !";
                    break;
            }

            //thời gian học
            switch (tkb.ThoiGianHoc)
            {
                case "Ca 1":
                    chkCa1.Checked = true;
                    chkCa2.Checked = false;
                    chkCa3.Checked = false;
                    chkCa4.Checked = false;
                    break;
                case "Ca 2":
                    chkCa1.Checked = false;
                    chkCa2.Checked = true;
                    chkCa3.Checked = false;
                    chkCa4.Checked = false;
                    break;
                case "Ca 3":
                    chkCa1.Checked = false;
                    chkCa2.Checked = false;
                    chkCa3.Checked = true;
                    chkCa4.Checked = false;
                    break;
                case "Ca 4":
                    chkCa1.Checked = false;
                    chkCa2.Checked = false;
                    chkCa3.Checked = false;
                    chkCa4.Checked = true;
                    break;
                case "Ca 1, Ca 2":
                    chkCa1.Checked = true;
                    chkCa2.Checked = true;
                    chkCa3.Checked = false;
                    chkCa4.Checked = false;
                    break;
                case "Ca 1, Ca 3":
                    chkCa1.Checked = true;
                    chkCa2.Checked = false;
                    chkCa3.Checked = true;
                    chkCa4.Checked = false;
                    break;
                case "Ca 1, Ca 4":
                    chkCa1.Checked = true;
                    chkCa2.Checked = false;
                    chkCa3.Checked = false;
                    chkCa4.Checked = true;
                    break;
                case "Ca 1, Ca 2, Ca 3":
                    chkCa1.Checked = true;
                    chkCa2.Checked = true;
                    chkCa3.Checked = true;
                    chkCa4.Checked = false;
                    break;
                case "Ca 1, Ca 2, Ca 4":
                    chkCa1.Checked = true;
                    chkCa2.Checked = true;
                    chkCa3.Checked = false;
                    chkCa4.Checked = true;
                    break;
                case "Ca 1, Ca 3, Ca 4":
                    chkCa1.Checked = true;
                    chkCa2.Checked = false;
                    chkCa3.Checked = true;
                    chkCa4.Checked = true;
                    break;
                case "Ca 1, Ca 2, Ca 3, Ca 4":
                    chkCa1.Checked = true;
                    chkCa2.Checked = true;
                    chkCa3.Checked = true;
                    chkCa4.Checked = true;
                    break;
                case "Ca 2, Ca 3":
                    chkCa1.Checked = false;
                    chkCa2.Checked = true;
                    chkCa3.Checked = true;
                    chkCa4.Checked = false;
                    break;
                case "Ca 2, Ca 4":
                    chkCa1.Checked = false;
                    chkCa2.Checked = true;
                    chkCa3.Checked = false;
                    chkCa4.Checked = true;
                    break;
                case "Ca 2, Ca 3, Ca 4":
                    chkCa1.Checked = false;
                    chkCa2.Checked = true;
                    chkCa3.Checked = true;
                    chkCa4.Checked = true;
                    break;
                case "Ca 3, Ca 4":
                    chkCa1.Checked = false;
                    chkCa2.Checked = false;
                    chkCa3.Checked = true;
                    chkCa4.Checked = true;
                    break;
            }

        }

        //đếm số thứ tự giảng viên
        public void CountRowsGiangVien()
        {
            for (int i = 0; i < dgvDanhSachGiangVien.Rows.Count; i++)
            {
                dgvDanhSachGiangVien.Rows[i].Cells[0].Value = (i + 1);
            }
        }

        //đếm số thứ tự thời khóa biểu
        public void CountRowsTKB()
        {
            for (int i = 0; i < dgvDanhSachTKB.Rows.Count; i++)
            {
                dgvDanhSachTKB.Rows[i].Cells[0].Value = (i + 1);
            }
        }

        //đóng các button mặc định
        public void EnableFalseButton()
        {
            //tab Giảng Viên
            btnSaveGV.Enabled = false;
            btnUpdateGV.Enabled = false;
            btnDeleteGV.Enabled = false;
            txtEmailGV.Enabled = false;

            //tab thời khóa biểu
            btnSaveTKB.Enabled = false;
            btnUpdateTKB.Enabled = false;
            btnDeleteTKB.Enabled = false;
            cboChonMonHoc_TKB.Enabled = false;

            chkCa1.Checked = false;
            chkCa2.Checked = false;
            chkCa3.Checked = false;
            chkCa2.Checked = false;
        }
        
        //maill service - gửi mail thông báo giảng viên tài khoảng đã được kích hoạt
        public void SendMailAddGiangVienSuccessfully()
        {
            //send maill
            InforContact contacts = new InforContact();
            contacts = contactService.InfoContact("3");
            string fromEmail = contacts.Email;
            string toEmail = txtEmailGV.Text.Trim();
            string subEmail = contacts.Subject;
            string InfoGV = "---------------------------------------------------------" + "\n" + txtTenGV.Text + " - " + lblMaGV_GV.Text + "\n" + "---------------------------------------------------------";
            string messEmail = contacts.Message +"\n"+InfoGV+"\n"+ contacts.InfoOther;
            // MessageBox.Show("from: "+ fromEmail);
            //MessageBox.Show("to: " + toEmail);
            //MessageBox.Show("sub: " + subEmail);
            //MessageBox.Show("mess: " + messEmail);
            sendMessage.SendMaillAddGiangVien(fromEmail, toEmail, subEmail, messEmail);
        }

        //maill service - gửi mail thông báo thông tin giảng viên đã được cập nhật
        public void SendMailUpdateGiangVienSuccessfully()
        {
            //gửi mail thông báo cập nhật thành công
            //
            string other = "Thông Tin Giảng viên đã được cập nhật:";
            string maGV = "-Mã SV: " + lblMaGV_GV.Text;
            string emailGV = "-Email: " + txtEmailGV.Text;
            string nameGV = "-Tên GV: " + txtTenGV.Text;
            string namSinh = "-Năm Sinh: " + dtpNamSinh_GV.Text.Trim();
            string trinhDo = "-Trình Độ: " + cboTrinhDo.SelectedItem.ToString().Trim();
            string sdtGV = "-SĐT: " + txtSDT.Text;
            string dcGV = "-Địa Chỉ: " + rtxtDiaChi_GV.Text;
            string startDay = "-Start Day: " + dtpBatDauCongViec_GV.Text.Trim();
            //
            InforContact contacts = new InforContact();
            contacts = contactService.InfoContact("4");
            string from = contacts.Email;
            string to = txtEmailGV.Text;
            string subject = contacts.Subject;
            string message = other + "\n" + maGV + "\n" + nameGV + "\n" + namSinh + "\n" + sdtGV + "\n" + emailGV + "\n" + trinhDo + "\n" + dcGV + "\n" + startDay + "\n" + contacts.InfoOther;
            sendMessage.SendMaillUpdateGiangVien(from, to, subject, message);
        }

        //-------------------------KẾT THÚC DS HÀM PUBLIC------------------------------//
        //_________________________________________________________//
        private void timerGiangvien_TKB_Tick(object sender, EventArgs e)
        {
            //hàm lấy ngày giờ
            lblTime.Text = DateTime.Now.ToLongTimeString();
            //lblDay.Text = DateTime.Now.ToLongDateString();
            DateTime ngay = DateTime.Now;
            lblDay.Text = ngay.ToString("dddd, dd-MM-yyyy");

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

        private void frmGiaoVienAndTKB_Load(object sender, EventArgs e)
        {
            EnableFalseButton();
            LoadDataToCombobox();
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



        private void btnNewGV_Click(object sender, EventArgs e)
        {
            AutoIDGiangVien();
            btnSaveGV.Enabled = true;
            btnUpdateGV.Enabled = false;
            btnDeleteGV.Enabled = false;
            txtTenGV.Clear();
            txtTenGV.Focus();
            txtSDT.Clear();
            txtEmailGV.Clear();
            rtxtDiaChi_GV.Clear();
            rtxtGhiChu_GV.Clear();
            txtEmailGV.Enabled = true;
        }

        private void btnSaveGV_Click(object sender, EventArgs e)
        {
            if (checkDataGiangVien())
            {
                //gửi maill đến giảng viên
                SendMailAddGiangVienSuccessfully();

                 //thêm giảng viên
                 GiangVien giangVien = new GiangVien();
                giangVien.MaGV = lblMaGV_GV.Text.Trim();
                giangVien.TenGV = txtTenGV.Text.Trim();
                giangVien.GioiTinh = cboGioiTinh.Text.Trim();
                giangVien.TrinhDo = cboTrinhDo.Text.Trim();
                giangVien.Email = txtEmailGV.Text.Trim();
                giangVien.NamSinh = dtpNamSinh_GV.Text.ToString();
                giangVien.SDT = txtSDT.Text.Trim();
                giangVien.GhiChu = rtxtGhiChu_GV.Text.Trim();
                giangVien.DiaChi = rtxtDiaChi_GV.Text.Trim();
                giangVien.Password = lblMaGV_GV.Text.Trim();
                giangVien.NgayBatDau = dtpBatDauCongViec_GV.Value.ToString();
                giangVien.MaKhoa = cboChonKhoa_GV.SelectedValue.ToString().Trim();
                giangVien.Avt = ImageToByteArray(picAvtGV.Image);
                giangVienService.CreateGiangVien(giangVien);

                LoadDanhSachGiangVienToDgv();
                MessageBox.Show("Save successful </> !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSaveGV.Enabled = false;
                btnDeleteGV.Enabled = true;
                btnUpdateGV.Enabled = true;
            }
            else
            {
                MessageBox.Show("Save Teacher Failed (-_-) !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateGV_Click(object sender, EventArgs e)
        {
            if (checkDataGiangVien())
            {
                //gửi mail  đến giảng viên
                SendMailUpdateGiangVienSuccessfully();

                GiangVien giangVien = new GiangVien();
                giangVien.MaGV = lblMaGV_GV.Text.Trim();
                giangVien.TenGV = txtTenGV.Text.Trim();
                giangVien.GioiTinh = cboGioiTinh.Text.Trim();
                giangVien.TrinhDo = cboTrinhDo.Text.Trim();
                giangVien.Email = txtEmailGV.Text.Trim();
                giangVien.NamSinh = dtpNamSinh_GV.Text.ToString();
                giangVien.SDT = txtSDT.Text.Trim();
                giangVien.GhiChu = rtxtGhiChu_GV.Text.Trim();
                giangVien.DiaChi = rtxtDiaChi_GV.Text.Trim();
                giangVien.Password = lblMaGV_GV.Text.Trim();
                giangVien.NgayBatDau = dtpBatDauCongViec_GV.Text.ToString();
                giangVien.MaKhoa = cboChonKhoa_GV.SelectedValue.ToString().Trim();

                giangVienService.UpdateGiangVien(giangVien);
                LoadDanhSachGiangVienToDgv();
                MessageBox.Show("Cập nhật thông tin ["+lblMaGV_GV.Text+"] thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSaveGV.Enabled = false;
                btnDeleteGV.Enabled = true;
                btnUpdateGV.Enabled = true;
            }
            else
            {
                MessageBox.Show("Cập nhật Giảng Viên thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSachGiangVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgvDanhSachGiangVien.Rows.Count == 0)
            {
                dgvDanhSachGiangVien.Enabled = false;
            }
            else
            {
                dgvDanhSachGiangVien.Enabled = true;
                lblMaGV_GV.DataBindings.Clear();
                lblMaGV_GV.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "MaGV");
                txtTenGV.DataBindings.Clear();
                txtTenGV.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "TenGV");
                txtEmailGV.DataBindings.Clear();
                txtEmailGV.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "Email");
                txtSDT.DataBindings.Clear();
                txtSDT.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "SDT");
                rtxtDiaChi_GV.DataBindings.Clear();
                rtxtDiaChi_GV.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "DiaChi");
                rtxtGhiChu_GV.DataBindings.Clear();
                rtxtGhiChu_GV.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "GhiChu");
                dtpNamSinh_GV.DataBindings.Clear();
                dtpNamSinh_GV.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "NamSinh");
                dtpBatDauCongViec_GV.DataBindings.Clear();
                dtpBatDauCongViec_GV.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "NgayBatDau");

                string gioiTinh = dgvDanhSachGiangVien.CurrentRow.Cells[3].Value.ToString();
                string trinhDo = dgvDanhSachGiangVien.CurrentRow.Cells[4].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    cboGioiTinh.SelectedIndex = 0;
                }
                else
                {
                    cboGioiTinh.SelectedIndex = 1;
                }

                if (trinhDo == "Thạc Sĩ")
                {
                    cboTrinhDo.SelectedIndex = 0;
                }
                else if (trinhDo == "Tiến Sĩ")
                {
                    cboTrinhDo.SelectedIndex = 1;
                }
                else
                {
                    cboTrinhDo.SelectedIndex = 2;
                }

                GiangVien gv = new GiangVien();
                gv = giangVienService.GetGiangVienByMaGV(lblMaGV_GV.Text);
                if(gv.Avt != null)
                {
                    picAvtGV.Image = ByteArrayToImage(gv.Avt.ToArray());
                }
                else
                {
                    picAvtGV.Image = Image.FromFile(@"..\..\Resources\avt011_default_teacher_160x190.jpgg");
                }
            }
        }

        private void cboChonKhoa_GV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachGiangVienToDgv();
            btnNewGV.Enabled = true;
        }

        private void dgvDanhSachGiangVien_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachGiangVien.Rows.Count == 0)
            {
                dgvDanhSachGiangVien.Enabled = false;
            }
            else
            {
                btnSaveGV.Enabled = false;
                btnUpdateGV.Enabled = true;
                btnDeleteGV.Enabled = true;
                dgvDanhSachGiangVien.Enabled = true;
                lblMaGV_GV.DataBindings.Clear();
                lblMaGV_GV.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "MaGV");
                txtTenGV.DataBindings.Clear();
                txtTenGV.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "TenGV");
                txtEmailGV.DataBindings.Clear();
                txtEmailGV.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "Email");
                txtSDT.DataBindings.Clear();
                txtSDT.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "SDT");
                rtxtDiaChi_GV.DataBindings.Clear();
                rtxtDiaChi_GV.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "DiaChi");
                rtxtGhiChu_GV.DataBindings.Clear();
                rtxtGhiChu_GV.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "GhiChu");
                dtpNamSinh_GV.DataBindings.Clear();
                dtpNamSinh_GV.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "NamSinh");
                dtpBatDauCongViec_GV.DataBindings.Clear();
                dtpBatDauCongViec_GV.DataBindings.Add("text", dgvDanhSachGiangVien.DataSource, "NgayBatDau");

                string gioiTinh = dgvDanhSachGiangVien.CurrentRow.Cells[3].Value.ToString();
                string trinhDo = dgvDanhSachGiangVien.CurrentRow.Cells[4].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    cboGioiTinh.SelectedIndex = 0;
                }
                else
                {
                    cboGioiTinh.SelectedIndex = 1;
                }

                if (trinhDo == "Thạc Sĩ")
                {
                    cboTrinhDo.SelectedIndex = 0;
                }
                else if (trinhDo == "Tiến Sĩ")
                {
                    cboTrinhDo.SelectedIndex = 1;
                }
                else
                {
                    cboTrinhDo.SelectedIndex = 2;
                }
            }
        }

        private void btnDeleteGV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa '" + lblMaGV_GV.Text + "' ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(lblMaGV_GV.Text.Trim()))
                {
                    MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    picAvtGV.Image = Image.FromFile(@"..\..\Resources\avt011_default_teacher_160x190.jpgg");
                    giangVienService.DeleteGiangVien(lblMaGV_GV.Text.Trim());
                    btnNewGV.Enabled = true;
                    btnSaveGV.Enabled = false;
                    btnUpdateGV.Enabled = false;
                    btnDeleteGV.Enabled = false;
                    LoadDanhSachGiangVienToDgv();
                    MessageBox.Show("Đã xóa giảng viên ["+lblMaGV_GV.Text+"]", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblMaGV_GV.Text = "???";
                    txtTenGV.Text = "";
                    txtEmailGV.Text = "";
                    txtSDT.Text = "";
                    rtxtDiaChi_GV.Text = "";
                    rtxtGhiChu_GV.Text = "";
                }
            }
        }

        private void cboChonKhoa_TKB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboChonNganh_TKB.DataSource = nganhHocService.GetNganhHocByKHOA(cboChonKhoa_TKB.SelectedValue.ToString().Trim());
            cboChonNganh_TKB.DisplayMember = "TenNganh";
            cboChonNganh_TKB.ValueMember = "MaNganh";

            cboChonGV_TKB.DataSource = giangVienService.GetGiangVienByMaKhoa(cboChonKhoa_TKB.SelectedValue.ToString()).ToList();
            cboChonGV_TKB.DisplayMember = "TenGV";
            cboChonGV_TKB.ValueMember = "MaGV";
        }

        private void cboChonNganh_TKB_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLop_TKB.Text = "???";
            cboChonNgayHoc_TKB.ResetText();
            cboChonMonHoc_TKB.ResetText();
            cboChonPhongHoc_TKB.ResetText();
            cboChonGV_TKB.ResetText();
            rtxtGhiChu_TKB.Text = "";


            cboChonKhoasHoc_TKB.DataSource = khoasHocService.GetAllKhoaHoc();
            cboChonKhoasHoc_TKB.DisplayMember = "TenKhoaHoc";
            cboChonKhoasHoc_TKB.ValueMember = "MaKhoaHoc";

            cboChonMonHoc_TKB.ResetText();
            cboChonMonHoc_TKB.DataSource = monHocService.GetMonHocByNganh(cboChonNganh_TKB.SelectedValue.ToString()).ToList();
            cboChonMonHoc_TKB.DisplayMember = "TenMonHoc";
            cboChonMonHoc_TKB.ValueMember = "MaMonHoc";

        }

        private void cboChonKhoasHoc_TKB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachLopHocToTreeview();
        }

        private void trvDSLop_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            maLop = e.Node.Name;
            lblLop_TKB.Text = e.Node.Text;
            cboChonHocKy_TKB.Enabled = true;
            LoadDanhSachThoiKhoaBieuToDgv();
            LoadMonHocToCbo();
            btnNewTKB.Enabled = true;
        }

        private void cboChoHocKy_TKB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachThoiKhoaBieuToDgv();
        }

        private void btnNewTKB_Click(object sender, EventArgs e)
        {
            cboChonMonHoc_TKB.DataSource = checkMonHoc();
            if (cboChonMonHoc_TKB.Text != "")
            {
                cboChonMonHoc_TKB.Enabled = true;
                cboChonMonHoc_TKB.SelectedItem.ToString();
                cboChonGV_TKB.ResetText();
                cboChonPhongHoc_TKB.ResetText();
                cboChonNgayHoc_TKB.ResetText();
                lblTinChi.Text = "???";
                rtxtGhiChu_TKB.Text = "";
                btnSaveTKB.Enabled = true;
                btnDeleteTKB.Enabled = false;
                btnUpdateTKB.Enabled = false;

                chkCa1.Enabled = true;
                chkCa2.Enabled = true;
                chkCa3.Enabled = true;
                chkCa4.Enabled = true;

                chkCa1.Checked = false;
                chkCa2.Checked = false;
                chkCa3.Checked = false;
                chkCa4.Checked = false;

                cboChonMonHoc_TKB.DataSource = checkMonHoc();
                cboChonMonHoc_TKB.DisplayMember = "TenMonHoc";
                cboChonMonHoc_TKB.ValueMember = "MaMonHoc";
            }
            else
            {
                MessageBox.Show("khong co mon hoc, vui long them mon hoc truoc khi khoi tạo tkb");
            }

        }

        private void btnSaveTKB_Click(object sender, EventArgs e)
        {
            if (checkDataTKB())
            {
                ThoiKhoaBieu tkb = new ThoiKhoaBieu();
                tkb.MaLop = maLop;
                tkb.MaHocKy = cboChonHocKy_TKB.SelectedValue.ToString();
                tkb.MaMonHoc = cboChonMonHoc_TKB.SelectedValue.ToString();
                tkb.MaGV = cboChonGV_TKB.SelectedValue.ToString();
                tkb.NgayHoc = cboChonNgayHoc_TKB.SelectedItem.ToString();
                tkb.MaPhongHoc = cboChonPhongHoc_TKB.SelectedValue.ToString();
                tkb.ThoiGianHoc = thoiGianHoc;
                tkb.NgayBatDau = dtpStartDay.Text.ToString();
                tkb.NgayKetThuc = dtpEndDay.Text.ToString();
                tkb.GhiChu = rtxtGhiChu_TKB.Text;

                thoiKhoaBieuService.CreateThoiKhoaBieu(tkb);
                LoadDanhSachThoiKhoaBieuToDgv();
                btnSaveTKB.Enabled = false;
                btnDeleteTKB.Enabled = true;
                btnUpdateTKB.Enabled = true;
                cboChonMonHoc_TKB.Enabled = false;
            }
        }

        private void btnUpdateTKB_Click(object sender, EventArgs e)
        {
            if (checkDataTKB())
            {
                ThoiKhoaBieu tkb = new ThoiKhoaBieu();
                tkb.MaLop = maLop;
                tkb.MaHocKy = cboChonHocKy_TKB.SelectedValue.ToString();
                tkb.MaMonHoc = cboChonMonHoc_TKB.SelectedValue.ToString();
                tkb.MaGV = cboChonGV_TKB.SelectedValue.ToString();
                tkb.NgayHoc = cboChonNgayHoc_TKB.Text.Trim();
                tkb.MaPhongHoc = cboChonPhongHoc_TKB.Text.ToString();
                tkb.ThoiGianHoc = thoiGianHoc;
                tkb.NgayBatDau = dtpStartDay.Text.ToString();
                tkb.NgayKetThuc = dtpEndDay.Text.ToString();
                tkb.GhiChu = rtxtGhiChu_TKB.Text;

                thoiKhoaBieuService.UpdateThoiKhoaBieu(tkb);
                LoadDanhSachThoiKhoaBieuToDgv();
            }
        }

        private void btnDeleteTKB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa  ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //MessageBox.Show("ma lop: "+maLop);
                //MessageBox.Show("ma mon hoc: " + cboChonMonHoc_TKB.SelectedValue.ToString());
                thoiKhoaBieuService.DeleteThoiKhoaBieu(maLop, cboChonMonHoc_TKB.SelectedValue.ToString());
                btnSaveTKB.Enabled = false;
                btnUpdateTKB.Enabled = false;
                btnDeleteTKB.Enabled = false;
                LoadDanhSachThoiKhoaBieuToDgv();
            }
        }

        private void dgvDanhSachTKB_MouseClick(object sender, MouseEventArgs e)
        {
            if(dgvDanhSachTKB.Rows.Count == 0)
            {
                dgvDanhSachTKB.Enabled = false;
            }
            else
            {
                cboChonMonHoc_TKB.Enabled = false;
                btnUpdateTKB.Enabled = true;
                btnDeleteTKB.Enabled = true;
                btnSaveTKB.Enabled = true;
                ShowDataToField();
            }
        }

        private void cboChonMonHoc_TKB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh = monHocService.GetMonHocByMaMonHoc(cboChonMonHoc_TKB.SelectedValue.ToString().Trim());
            lblTinChi.Text = Convert.ToString(mh.STC);
        }

        private void cboChonNgayHoc_TKB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblViewClass_Click(object sender, EventArgs e)
        {
           
            cboChonPhongHoc_TKB.DataSource = phongHocService.GetAllPhongHoc();                  //get phòng học
            cboChonPhongHoc_TKB.DisplayMember = "MaPhongHoc";
            cboChonPhongHoc_TKB.ValueMember = "MaPhongHoc";
        }

        private void cboChonPhongHoc_TKB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboChonPhongHoc_TKB.DataSource = phongHocService.GetAllPhongHoc();                  //get phòng học
            //cboChonPhongHoc_TKB.DisplayMember = "MaPhongHoc";
            //cboChonPhongHoc_TKB.ValueMember = "MaPhongHoc";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkMonHoc();
        }

        private void lblViewClass_DoubleClick(object sender, EventArgs e)
        {
            frmPhongHoc frmPH = new frmPhongHoc();
            frmPH.ShowDialog();
        }

        private void chkCa1_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkCa1.Checked)
            {
                ca1 = "Ca 1,";
            }
            else
            {
                ca1 = null;
            }
           thoiGianHoc = ca1 + ca2 + ca3 + ca4;
            thoiGianHoc = thoiGianHoc.TrimEnd(',');
            thoiGianHoc = thoiGianHoc.TrimStart(' ');
        }

        private void chkCa2_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkCa2.Checked)
            {
                ca2 = " Ca 2,";
            }
            else
            {
                ca2 = null;
            }
            thoiGianHoc = ca1 + ca2 + ca3 + ca4;
            thoiGianHoc = thoiGianHoc.TrimEnd(',');
            thoiGianHoc = thoiGianHoc.TrimStart(' ');
        }

        private void chkCa3_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkCa3.Checked)
            {
                ca3 = " Ca 3,";
            }
            else
            {
                ca3 = null;
            }
            thoiGianHoc = ca1 + ca2 + ca3 + ca4;
            thoiGianHoc = thoiGianHoc.TrimEnd(',');
            thoiGianHoc = thoiGianHoc.TrimStart(' ');
        }
        private void chkCa4_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkCa4.Checked)
            {
                ca4 = " Ca 4";
            }
            else
            {
                ca4 = null;
            }
            thoiGianHoc = ca1 + ca2 + ca3 + ca4;
            thoiGianHoc = thoiGianHoc.TrimEnd(',');
            thoiGianHoc = thoiGianHoc.TrimStart(' ');
        }
    }
}
