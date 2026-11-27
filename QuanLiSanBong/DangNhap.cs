using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSanBong
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ((txtTenDangNhap.Text == "") || (txtMatKhau.Text == ""))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu, vui lòng nhập lại","Thông báo");
                txtTenDangNhap.Focus();
            }
            else
            {
                // Quyền admin
                if (txtTenDangNhap.Text == "admin" && txtMatKhau.Text == "admin123")
                {
                    MessageBox.Show("Đăng nhập admin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Main main = new Main("Admin");

                    this.Hide();
                    main.ShowDialog();
                    this.Show(); // Hiện lại form login khi tắt Main (tùy chọn)
                }
                // Quyền nhân viên
                else if (txtTenDangNhap.Text == "nhanvien" && txtMatKhau.Text == "123")
                {
                    MessageBox.Show("Đăng nhập nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Main main = new Main("NhanVien");

                    this.Hide();
                    main.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDangNhap.ResetText();
                    txtMatKhau.ResetText();
                    txtTenDangNhap.Focus();
                }
            }
        }
    }
}
