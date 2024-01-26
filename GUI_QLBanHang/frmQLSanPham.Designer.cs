namespace GUI_QLBanHang
{
    partial class frmQLSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSanPham));
            this.txtTimSP = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoatSp = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaBang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimSP
            // 
            this.txtTimSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimSP.Enabled = false;
            this.txtTimSP.Location = new System.Drawing.Point(155, 75);
            this.txtTimSP.Multiline = true;
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.Size = new System.Drawing.Size(608, 37);
            this.txtTimSP.TabIndex = 21;
            this.txtTimSP.Tag = "";
            this.txtTimSP.Text = "Nhập mã hoặc tên sản phẩm...";
            // 
            // btntim
            // 
            this.btntim.Image = ((System.Drawing.Image)(resources.GetObject("btntim.Image")));
            this.btntim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntim.Location = new System.Drawing.Point(769, 75);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(115, 36);
            this.btntim.TabIndex = 22;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSanPham,
            this.colTenSanPham,
            this.colSoLuong,
            this.colDonGiaNhap,
            this.colDonGiaBang,
            this.colHinhAnh,
            this.colGhiChu});
            this.dataGridView1.Location = new System.Drawing.Point(117, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(874, 199);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoatSp);
            this.groupBox1.Controls.Add(this.btnXoaSP);
            this.groupBox1.Controls.Add(this.btnSuaSP);
            this.groupBox1.Controls.Add(this.btnThemSP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(117, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 128);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công cụ";
            // 
            // btnThoatSp
            // 
            this.btnThoatSp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoatSp.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatSp.Image")));
            this.btnThoatSp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatSp.Location = new System.Drawing.Point(685, 45);
            this.btnThoatSp.Name = "btnThoatSp";
            this.btnThoatSp.Size = new System.Drawing.Size(126, 43);
            this.btnThoatSp.TabIndex = 23;
            this.btnThoatSp.Text = "Thoát";
            this.btnThoatSp.UseVisualStyleBackColor = true;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSP.Image")));
            this.btnXoaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaSP.Location = new System.Drawing.Point(475, 45);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(127, 43);
            this.btnXoaSP.TabIndex = 22;
            this.btnXoaSP.Text = "Xoá";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaSP.Image")));
            this.btnSuaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaSP.Location = new System.Drawing.Point(284, 45);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(119, 43);
            this.btnSuaSP.TabIndex = 21;
            this.btnSuaSP.Text = "Sửa ";
            this.btnSuaSP.UseVisualStyleBackColor = true;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSP.Image")));
            this.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSP.Location = new System.Drawing.Point(89, 45);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(116, 43);
            this.btnThemSP.TabIndex = 20;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.HeaderText = "Mã Sản Phẩm ";
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.ReadOnly = true;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.HeaderText = "Tên Sản Phẩm";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.ReadOnly = true;
            this.colTenSanPham.Width = 200;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colDonGiaNhap
            // 
            this.colDonGiaNhap.HeaderText = "Đơn Giá Nhập";
            this.colDonGiaNhap.Name = "colDonGiaNhap";
            this.colDonGiaNhap.ReadOnly = true;
            // 
            // colDonGiaBang
            // 
            this.colDonGiaBang.HeaderText = "Đơn Giá Báng";
            this.colDonGiaBang.Name = "colDonGiaBang";
            this.colDonGiaBang.ReadOnly = true;
            // 
            // colHinhAnh
            // 
            this.colHinhAnh.HeaderText = "Hình Ảnh";
            this.colHinhAnh.Name = "colHinhAnh";
            this.colHinhAnh.ReadOnly = true;
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            this.colGhiChu.Width = 130;
            // 
            // frmQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txtTimSP);
            this.Name = "frmQLSanPham";
            this.Text = "frmQLSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimSP;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoatSp;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaBang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}