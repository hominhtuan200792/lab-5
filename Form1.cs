using System.Diagnostics;

namespace buoi_5
{
    public partial class Form1 : Form
    {
        private decimal[] hocphithang = { 800000, 700000, 750000, 650000 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            khoahoc.Items.Add("C# WinForms cơ bản 800.000 VND/tháng");
            khoahoc.Items.Add("SQL Server cơ bản 700.000 VND/tháng");
            khoahoc.Items.Add("Web Frontend cơ bản 750.000 VND/tháng");
            khoahoc.Items.Add("Lập trình Python cơ bản 650.000 VND/tháng");
            khoahoc.SelectedIndex = 0;
            online.Checked = true;



        }
        private void TinhTongHocPhi()
        {
            if (khoahoc.SelectedIndex < 0) return;

            decimal giaThang = hocphithang[khoahoc.SelectedIndex];
            decimal tongTien = giaThang * thanghoc.Value;

            tonghocphi.Text =  tongTien.ToString("N0") + " VNĐ";
        }
        private void rdoOffline_CheckedChanged(object sender, EventArgs e)
        {
            online.Checked = true;
            offline.Checked = false;

        }
        private void khoahoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tongtien_TextChanged(object sender, EventArgs e)
        {

        }
        private void rdoOnline_CheckedChanged(object sender, EventArgs e)
        {
            online.Checked = true;
            offline.Checked = false;


        }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void thongtinhocvien_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void khoahoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TinhTongHocPhi();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(hoten.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hoten.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(sdt.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sdt.Focus();
                return;
            }


            if (khoahoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn khóa học!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                khoahoc.Focus();
                return;
            }


            decimal giaThang = hocphithang[khoahoc.SelectedIndex];
            decimal tongTien = giaThang * thanghoc.Value;

            string hinhThuc = online.Checked ? "Online" : "Trực tiếp (Offline)";
            string nhanEmail = nhanemail.Checked ? "Có" : "Không";

            string phieuDangKy =
                "=== PHIẾU ĐĂNG KÝ KHÓA HỌC ===\n\n" +
                "Họ tên học viên: " + hoten.Text + "\n" +
                "Số điện thoại: " + sdt.Text + "\n" +
                "Ngày sinh: " + ngaysinh.Value.ToShortDateString() + "\n" +
                "Khóa học: " + khoahoc.SelectedItem.ToString() + "\n" +
                "Hình thức học: " + hinhThuc + "\n" +
                "Số tháng đăng ký: " + thanghoc.Value + "\n" +
                "Tổng học phí: " + tongTien.ToString("N0") + " VNĐ\n" +
                "Nhận email thông báo: " + nhanEmail;

            MessageBox.Show(phieuDangKy, "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void tonghp_Click(object sender, EventArgs e)
        {

            {
                if (khoahoc.SelectedIndex < 0) return;
                decimal giathang = hocphithang[khoahoc.SelectedIndex];
                decimal tongtien = giathang * thanghoc.Value;
                tonghocphi.Text = tongtien.ToString("N0") + " VNĐ";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hoten.Clear();
            sdt.Clear();
            ngaysinh.Value = DateTime.Now;
            khoahoc.SelectedIndex = 0;
            thanghoc.Value = 1;
            online.Checked = true;
            offline.Checked = false;
            nhanemail.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
        "Bạn có chắc chắn muốn thoát chương trình?",
        "Xác nhận thoát",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void thanghoc_ValueChanged(object sender, EventArgs e)
        {
            TinhTongHocPhi();
        }
    }
}