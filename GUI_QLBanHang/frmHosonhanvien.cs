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
    public partial class frmHosonhanvien : Form
    {
        public frmHosonhanvien()
        {
            InitializeComponent();
            //KiemTraDuLieuNhap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            string email = txtEmail.Text;
            string oldPass = StringHelper.MD5Hash(txtOldPass.Text.Trim());
            string newPass = StringHelper.MD5Hash(txtNewPass.Text.Trim());
            if( BUS_NhanVien.UpdatePassword(email, oldPass, newPass) >0 )
            {
                frmMain.nhanVien = null;
                string subject = "Cập nhật mật khẩu thành công";
                string message = "Bạn vừa cập nhật mật khẩu thành công, Mật khẩu mới của bạn là: " + txtNewPass.Text;
                EmailHelper.SendMail(email, subject, message);
                this.DialogResult = DialogResult.OK;
            }    
            else
            {
                DialogHelper.Error("Cập nhật mật khẩu thất bại. Sai mật khẩu cũ");
            }    
        }
        private bool KiemTraDuLieuNhap()
        {
            if (txtOldPass.Text.Trim().Length == 0)
            {
                DialogHelper.Alert("Bạn phải nhập mật khẩu cũ");
                txtOldPass.Focus();
                return false;
            }
            if(txtNewPass.Text.Trim().Length == 0)
            {
                DialogHelper.Alert("Bạn phải nhập mật khẩu mới");
                txtNewPass.Focus();
                return false;
            }
            if (txtReNewPass.Text.Trim().Length == 0)
            {
                DialogHelper.Alert("Bạn phải nhập lại mật khẩu mới");
                txtReNewPass.Focus();
                return false;
            }
            if (txtNewPass.Text.Trim() != txtReNewPass.Text.Trim())
            {
                DialogHelper.Alert("Mật Khẩu mới và đăng nhập lại mật khẩu mới không giống nhau");
                txtReNewPass.Focus();
                return false;
            }
            if (txtNewPass.Text.Trim() == txtOldPass.Text.Trim())
            {
                DialogHelper.Alert("Mật khẩu mới trùng với mật khẩu cũ");
                txtNewPass.Focus();
                return false;
            }
            return true;
        }
    }
}
