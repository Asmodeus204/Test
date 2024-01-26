using BUS_QLBanHang;
using DTO_QLBanHang;
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
    public partial class frmQLNhanVien : Form
    {
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void NapDanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(DialogHelper.Confirm("Bạn chắc chắn muốn xoá khôg? ") == DialogResult.Yes)
            {
                var row = dgvNhanVien.CurrentRow;
                if (row != null)
                {
                    string maNV = row.Cells["maNV"].Value.ToString();
                    NhanVien nv = BUS_NhanVien.Get(maNV);
                    if (BUS_NhanVien.Delete(nv) > 0)
                    {
                        NapDanhSachNhanVien();
                        DialogHelper.Alert("Xoá nhân viên thành công");
                    }
                    else
                        DialogHelper.Alert("Không thể xoá nhân viên vì có các dữ liên hệ liên quan");
                }    
            }    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void txtTimSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTimNV.Text == "Mã hoặc Tên") ;
            txtTimNV.Text = "";
        }
        private void NapDanhSachNhanVien()
        {
            string key = txtTimNV.Text.Trim();
            if (key == "Mã Hoặc Tên")
                key = "";
            List<NhanVien> listNhanVien;
            listNhanVien = BUS_NhanVien.Search(key);
            var listHienthi = (from n in listNhanVien
                               select new
                               {
                                   n.Id,
                                   n.MaNV,
                                   n.TenNV,
                                   n.Email,
                                   n.DiaChi,
                                   n.VaiTro,
                                   n.TinhTrang,
                               });
            dgvNhanVien.DataSource = listHienthi;

            dgvNhanVien.Columns[0].Visible = false;
            dgvNhanVien.Columns[1].HeaderText = "Ma NV";
            dgvNhanVien.Columns[1].Width = 70;
            dgvNhanVien.Columns[2].HeaderText = "Tên NV";
            dgvNhanVien.Columns[2].Width = 150;
            dgvNhanVien.Columns[3].HeaderText = "Email";
            dgvNhanVien.Columns[3].Width = 150;
            dgvNhanVien.Columns[4].HeaderText = "Địa chi";
            dgvNhanVien.Columns[4].Width = 150;
            dgvNhanVien.Columns[5].HeaderText = "Vai trò";
            dgvNhanVien.Columns[5].Width = 50;
            dgvNhanVien.Columns[6].HeaderText = "Tình trạng";
            dgvNhanVien.Columns[6].Width = 50;
        }
    }
}
