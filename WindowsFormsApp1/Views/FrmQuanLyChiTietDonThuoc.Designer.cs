namespace WindowsFormsApp1.Views
{
    partial class FrmQuanLyChiTietDonThuoc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtMaDonThuoc = new System.Windows.Forms.TextBox();
            this.lblMaDonThuoc = new System.Windows.Forms.Label();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.lblMaThuoc = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtLieuDung = new System.Windows.Forms.TextBox();
            this.lblLieuDung = new System.Windows.Forms.Label();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.lblCachDung = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            
            // dgvChiTiet
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(12, 190);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(776, 248);
            this.dgvChiTiet.TabIndex = 0;
            this.dgvChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellClick);
            
            // grpThongTin
            this.grpThongTin.Controls.Add(this.txtMaDonThuoc);
            this.grpThongTin.Controls.Add(this.lblMaDonThuoc);
            this.grpThongTin.Controls.Add(this.txtMaThuoc);
            this.grpThongTin.Controls.Add(this.lblMaThuoc);
            this.grpThongTin.Controls.Add(this.txtSoLuong);
            this.grpThongTin.Controls.Add(this.lblSoLuong);
            this.grpThongTin.Controls.Add(this.txtLieuDung);
            this.grpThongTin.Controls.Add(this.lblLieuDung);
            this.grpThongTin.Controls.Add(this.txtCachDung);
            this.grpThongTin.Controls.Add(this.lblCachDung);
            this.grpThongTin.Controls.Add(this.txtDonGia);
            this.grpThongTin.Controls.Add(this.lblDonGia);
            this.grpThongTin.Location = new System.Drawing.Point(13, 13);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(775, 130);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin Chi Tiết Đơn Thuốc";
            
            // Textboxes & Labels
            this.lblMaDonThuoc.AutoSize = true;
            this.lblMaDonThuoc.Location = new System.Drawing.Point(20, 25);
            this.lblMaDonThuoc.Text = "Mã Đơn Thuốc";
            this.txtMaDonThuoc.Location = new System.Drawing.Point(120, 22);
            this.txtMaDonThuoc.Size = new System.Drawing.Size(150, 20);
            
            this.lblMaThuoc.AutoSize = true;
            this.lblMaThuoc.Location = new System.Drawing.Point(20, 50);
            this.lblMaThuoc.Text = "Mã Thuốc";
            this.txtMaThuoc.Location = new System.Drawing.Point(120, 47);
            this.txtMaThuoc.Size = new System.Drawing.Size(150, 20);
            
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(20, 75);
            this.lblSoLuong.Text = "Số Lượng";
            this.txtSoLuong.Location = new System.Drawing.Point(120, 72);
            this.txtSoLuong.Size = new System.Drawing.Size(150, 20);
            
            this.lblLieuDung.AutoSize = true;
            this.lblLieuDung.Location = new System.Drawing.Point(350, 25);
            this.lblLieuDung.Text = "Liều Dùng";
            this.txtLieuDung.Location = new System.Drawing.Point(430, 22);
            this.txtLieuDung.Size = new System.Drawing.Size(150, 20);
            
            this.lblCachDung.AutoSize = true;
            this.lblCachDung.Location = new System.Drawing.Point(350, 50);
            this.lblCachDung.Text = "Cách Dùng";
            this.txtCachDung.Location = new System.Drawing.Point(430, 47);
            this.txtCachDung.Size = new System.Drawing.Size(150, 20);
            
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(350, 75);
            this.lblDonGia.Text = "Đơn Giá";
            this.txtDonGia.Location = new System.Drawing.Point(430, 72);
            this.txtDonGia.Size = new System.Drawing.Size(150, 20);
            
            // btnThem
            this.btnThem.Location = new System.Drawing.Point(13, 155);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            
            // btnSua
            this.btnSua.Location = new System.Drawing.Point(100, 155);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            
            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(187, 155);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            
            // btnLamMoi
            this.btnLamMoi.Location = new System.Drawing.Point(274, 155);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            
            // FrmQuanLyChiTietDonThuoc
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.dgvChiTiet);
            this.Name = "FrmQuanLyChiTietDonThuoc";
            this.Text = "Quản lý Chi Tiết Đơn Thuốc";
            this.Load += new System.EventHandler(this.FrmQuanLyChiTietDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtMaDonThuoc;
        private System.Windows.Forms.Label lblMaDonThuoc;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label lblMaThuoc;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtLieuDung;
        private System.Windows.Forms.Label lblLieuDung;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.Label lblCachDung;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}
