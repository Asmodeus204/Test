using BUS_QLBanHang;
using GUI_QLBanHang.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtEmali.Text.Trim().Length == 0 || txtMatKhau.Text.Trim().Length == 0)
            {
                DialogHelper.Alert(" Bạn cân f nhập đầy đủ thông tin đăng nhập");
                return;
            }
            string matkhau = StringHelper.MD5Hash(txtMatKhau.Text);
            frmMain.nhanVien = BUS_NhanVien.DangNhap(txtEmali.Text, matkhau);
            if(frmMain.nhanVien != null )
            {
                DialogHelper.Alert(" Đăng nhập thành công");
                this.Close();
            }    
            else
            {
                DialogHelper.Alert("Sai thông tin đăng nhập");
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            if(txtEmali.Text.Trim() == "")
            {
                DialogHelper.Alert("Bạn cần nhập Email nhận thông tin phục hồi mật khẩu");
                txtEmali.Focus();
                return;
            }
            if(!EmailHelper.IsValidEmail(txtEmali.Text))
            {
                DialogHelper.Alert("Địa chỉ email không hợp lệ");
                txtEmali.Focus();
                return;
            }
            string email = txtEmali.Text.Trim();
            if (BUS_NhanVien.DaTonTaiEmail(email) == false)
            {
                DialogHelper.Alert("Địa chỉ  email không tồn tại");
                txtEmali.Focus();
                return;
            }
            string matKhauMoi = StringHelper.GetRandomString(8);
            string subject = "Bạn đã sử dụng tính năng quên mật khẩu";
            string msg = "Chào anh/chị. Mật khẩu mới truy cập phần mền là: " + matKhauMoi;
            string result = EmailHelper.SendMail(txtEmali.Text.Trim(), subject, msg);
            if (result == "")
            {
                DialogHelper.Alert("Một email phục hồi mật khẩu đã được gửi đến bạn");
                if (BUS_NhanVien.CreatePassword(txtEmali.Text.Trim(), StringHelper.MD5Hash(matKhauMoi)) > 0)
                {
                    DialogHelper.Alert("Mật khẩu mới của bạn đã được tạo");
                }
            }
            else
                DialogHelper.Alert("Lỗi gửi Eamil: " + result);

        }
    }
}
