namespace GUI_QLBanHang
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoSoNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKeSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDanSuDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioiThieuPhanMen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChao = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuDanhMuc,
            this.mnuThongKe,
            this.mnuHuongDan,
            this.mnuChao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangnhap,
            this.mnuDangXuat,
            this.mnuHoSoNhanVien,
            this.mnuThoat});
            this.mnuHeThong.Image = ((System.Drawing.Image)(resources.GetObject("mnuHeThong.Image")));
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(87, 29);
            this.mnuHeThong.Text = "Hệ Thống";
            this.mnuHeThong.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // mnuDangnhap
            // 
            this.mnuDangnhap.Image = ((System.Drawing.Image)(resources.GetObject("mnuDangnhap.Image")));
            this.mnuDangnhap.Name = "mnuDangnhap";
            this.mnuDangnhap.Size = new System.Drawing.Size(180, 22);
            this.mnuDangnhap.Text = "Đăng Nhập";
            this.mnuDangnhap.Click += new System.EventHandler(this.mnuDangnhap_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("mnuDangXuat.Image")));
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(180, 22);
            this.mnuDangXuat.Text = "Đăng Xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuHoSoNhanVien
            // 
            this.mnuHoSoNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("mnuHoSoNhanVien.Image")));
            this.mnuHoSoNhanVien.Name = "mnuHoSoNhanVien";
            this.mnuHoSoNhanVien.Size = new System.Drawing.Size(180, 22);
            this.mnuHoSoNhanVien.Text = "Hồ Sơ Nhân Viên";
            this.mnuHoSoNhanVien.Click += new System.EventHandler(this.mnuHoSoNhanVien_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = ((System.Drawing.Image)(resources.GetObject("mnuThoat.Image")));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(180, 22);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSanPham,
            this.mnuNhanVien,
            this.mnuKhachHang});
            this.mnuDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("mnuDanhMuc.Image")));
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(90, 29);
            this.mnuDanhMuc.Text = "Danh Mục";
            this.mnuDanhMuc.Click += new System.EventHandler(this.danhMụcToolStripMenuItem_Click);
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.BackColor = System.Drawing.SystemColors.Control;
            this.mnuSanPham.Image = ((System.Drawing.Image)(resources.GetObject("mnuSanPham.Image")));
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.Size = new System.Drawing.Size(180, 22);
            this.mnuSanPham.Text = "Sản Phẩm ";
            this.mnuSanPham.Click += new System.EventHandler(this.mnuSanPham_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mnuNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("mnuNhanVien.Image")));
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(180, 22);
            this.mnuNhanVien.Text = "Nhân Viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("mnuKhachHang.Image")));
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(180, 22);
            this.mnuKhachHang.Text = "Khách Hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongKeSanPham});
            this.mnuThongKe.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongKe.Image")));
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(85, 29);
            this.mnuThongKe.Text = "Thống Kệ";
            // 
            // mnuThongKeSanPham
            // 
            this.mnuThongKeSanPham.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongKeSanPham.Image")));
            this.mnuThongKeSanPham.Name = "mnuThongKeSanPham";
            this.mnuThongKeSanPham.Size = new System.Drawing.Size(180, 22);
            this.mnuThongKeSanPham.Text = "Thống Kê Sản Phẩm";
            this.mnuThongKeSanPham.Click += new System.EventHandler(this.mnuThongKeSanPham_Click);
            // 
            // mnuHuongDan
            // 
            this.mnuHuongDan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHuongDanSuDung,
            this.mnuGioiThieuPhanMen});
            this.mnuHuongDan.Image = ((System.Drawing.Image)(resources.GetObject("mnuHuongDan.Image")));
            this.mnuHuongDan.Name = "mnuHuongDan";
            this.mnuHuongDan.Size = new System.Drawing.Size(96, 29);
            this.mnuHuongDan.Text = "Hướng Dẫn";
            // 
            // mnuHuongDanSuDung
            // 
            this.mnuHuongDanSuDung.Image = ((System.Drawing.Image)(resources.GetObject("mnuHuongDanSuDung.Image")));
            this.mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            this.mnuHuongDanSuDung.Size = new System.Drawing.Size(188, 22);
            this.mnuHuongDanSuDung.Text = "Hướng Dẫn Sử Dụng";
            this.mnuHuongDanSuDung.Click += new System.EventHandler(this.mnuHuongDanSuDung_Click);
            // 
            // mnuGioiThieuPhanMen
            // 
            this.mnuGioiThieuPhanMen.Image = ((System.Drawing.Image)(resources.GetObject("mnuGioiThieuPhanMen.Image")));
            this.mnuGioiThieuPhanMen.Name = "mnuGioiThieuPhanMen";
            this.mnuGioiThieuPhanMen.Size = new System.Drawing.Size(188, 22);
            this.mnuGioiThieuPhanMen.Text = "Giới Thiệu Phần Mềm";
            this.mnuGioiThieuPhanMen.Click += new System.EventHandler(this.mnuGioiThieuPhanMen_Click);
            // 
            // mnuChao
            // 
            this.mnuChao.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuChao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuChao.Name = "mnuChao";
            this.mnuChao.Size = new System.Drawing.Size(105, 29);
            this.mnuChao.Text = "Chào Abc";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dự Án Mẫu C# - Quán Lý Bán Hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = global::GUI_QLBanHang.Properties.Resources.fpoly;
            this.pictureBox1.Location = new System.Drawing.Point(313, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1080, 485);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain_QLBanHang";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuDangnhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuHoSoNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDanSuDung;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieuPhanMen;
        private System.Windows.Forms.ToolStripMenuItem mnuChao;
    }
}

