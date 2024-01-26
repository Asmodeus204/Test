using DTO_QLBanHang;
using GUI_QLBanHang.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class frmMain : Form
    {
        public static NhanVien nhanVien;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            resetMenu();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void resetMenu()
        {
            if(nhanVien == null)
            {
                //Thệ Thống
                mnuDangnhap.Enabled = true;
                mnuDangXuat.Enabled = false;
                mnuHoSoNhanVien.Enabled = false;
                //Danh mục
                mnuDanhMuc.Visible = false;
                mnuSanPham.Enabled = false;
                mnuNhanVien.Enabled = false;
                mnuKhachHang.Enabled = false;
                //Thống kê
                mnuThongKe.Visible = false;
                mnuThongKeSanPham.Enabled = false;
                //Chao
                mnuChao.Visible = false;
                mnuGioiThieuPhanMen.Enabled = false;
                mnuDangXuat.Enabled = false;
            }
            else
            {
                mnuDangXuat.Enabled = true;
                mnuDangnhap.Enabled = false;
                mnuHoSoNhanVien.Enabled = true;
                //Danh mục
                mnuDanhMuc.Visible = true;
                mnuSanPham.Enabled = true;
                mnuHoSoNhanVien.Enabled = nhanVien.VaiTro == 1 ? true : false;
                mnuKhachHang.Enabled = true;
                //Thống kê
                mnuThongKe.Visible = true;
                mnuThongKeSanPham.Enabled = nhanVien.VaiTro == 1 ? true : false;
                //Chào
                mnuChao.Visible = true;
                mnuGioiThieuPhanMen.Enabled = true;
                mnuDangXuat.Enabled = true;
                mnuChao.Text = "Chao" + nhanVien.Email;

            }
        }
        private void OpenOrActiveForm(Form frm)
        {
            Form frm1 = this.MdiChildren.FirstOrDefault(f => f.Name == frm.Name);
            if (frm1 != null)
            {
                frm1.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
        private void DangNhap()
        {
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            resetMenu();
        }
        private void DangXuat()
        {
            nhanVien = null;
            foreach (var f in this.MdiChildren)
            {
                f.Close();
            }
            resetMenu();
        }

        private void mnuDangnhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }
        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat();
        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnuHoSoNhanVien_Click(object sender, EventArgs e)
        {
            frmHosonhanvien frm = new frmHosonhanvien();
            OpenOrActiveForm(frm);
        }

        private void mnuHuongDanSuDung_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Application.StartupPath + @"\Docs\help.pdf";
                System.Diagnostics.Process.Start(filePath);
            }
            catch(Exception ex)
            {
                DialogHelper.Error("Lỗi: " + ex.Message);
            }
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            frmQLSanPham frm = new frmQLSanPham();
            OpenOrActiveForm(frm);
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien frm = new frmQLNhanVien();
            OpenOrActiveForm(frm);
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmQLKhacHang frm = new frmQLKhacHang();
            OpenOrActiveForm(frm);
        }

        private void mnuThongKeSanPham_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            OpenOrActiveForm(frm);
        }

        private void mnuGioiThieuPhanMen_Click(object sender, EventArgs e)
        {

        }
    }
}
