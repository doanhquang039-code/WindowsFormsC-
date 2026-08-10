namespace WindowsFormsApp1.Views
{
    partial class FrmQuanLyThuoc
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
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.lblCachDung = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.lblTenThuoc = new System.Windows.Forms.Label();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            
            // dgvThuoc
            this.dgvThuoc.AllowUserToAddRows = false;
            this.dgvThuoc.AllowUserToDeleteRows = false;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Location = new System.Drawing.Point(12, 190);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.ReadOnly = true;
            this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuoc.Size = new System.Drawing.Size(776, 248);
            this.dgvThuoc.TabIndex = 0;
            this.dgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellClick);
            
            // grpThongTin
            this.grpThongTin.Controls.Add(this.txtTrangThai);
            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.txtCachDung);
            this.grpThongTin.Controls.Add(this.lblCachDung);
            this.grpThongTin.Controls.Add(this.txtSoLuongTon);
            this.grpThongTin.Controls.Add(this.lblSoLuongTon);
            this.grpThongTin.Controls.Add(this.txtDonGia);
            this.grpThongTin.Controls.Add(this.lblDonGia);
            this.grpThongTin.Controls.Add(this.txtDonViTinh);
            this.grpThongTin.Controls.Add(this.lblDonViTinh);
            this.grpThongTin.Controls.Add(this.txtTenThuoc);
            this.grpThongTin.Controls.Add(this.lblTenThuoc);
            this.grpThongTin.Controls.Add(this.txtMaThuoc);
            this.grpThongTin.Controls.Add(this.lblMa);
            this.grpThongTin.Location = new System.Drawing.Point(13, 13);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(775, 130);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin Thuốc";
            
            // Textboxes & Labels
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(20, 25);
            this.lblMa.Text = "Mã Thuốc";
            this.txtMaThuoc.Location = new System.Drawing.Point(100, 22);
            this.txtMaThuoc.ReadOnly = true;
            this.txtMaThuoc.Size = new System.Drawing.Size(200, 20);
            
            this.lblTenThuoc.AutoSize = true;
            this.lblTenThuoc.Location = new System.Drawing.Point(20, 50);
            this.lblTenThuoc.Text = "Tên Thuốc";
            this.txtTenThuoc.Location = new System.Drawing.Point(100, 47);
            this.txtTenThuoc.Size = new System.Drawing.Size(200, 20);
            
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Location = new System.Drawing.Point(20, 75);
            this.lblDonViTinh.Text = "ĐVT";
            this.txtDonViTinh.Location = new System.Drawing.Point(100, 72);
            this.txtDonViTinh.Size = new System.Drawing.Size(200, 20);
            
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(20, 100);
            this.lblDonGia.Text = "Đơn Giá";
            this.txtDonGia.Location = new System.Drawing.Point(100, 97);
            this.txtDonGia.Size = new System.Drawing.Size(200, 20);
            
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Location = new System.Drawing.Point(350, 25);
            this.lblSoLuongTon.Text = "Số Lượng Tồn";
            this.txtSoLuongTon.Location = new System.Drawing.Point(430, 22);
            this.txtSoLuongTon.Size = new System.Drawing.Size(200, 20);
            
            this.lblCachDung.AutoSize = true;
            this.lblCachDung.Location = new System.Drawing.Point(350, 50);
            this.lblCachDung.Text = "Cách Dùng";
            this.txtCachDung.Location = new System.Drawing.Point(430, 47);
            this.txtCachDung.Size = new System.Drawing.Size(200, 20);
            
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(350, 75);
            this.lblTrangThai.Text = "Trạng Thái (True/False)";
            this.txtTrangThai.Location = new System.Drawing.Point(430, 72);
            this.txtTrangThai.Size = new System.Drawing.Size(200, 20);
            
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
            
            // FrmQuanLyThuoc
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.dgvThuoc);
            this.Name = "FrmQuanLyThuoc";
            this.Text = "Quản lý Thuốc";
            this.Load += new System.EventHandler(this.FrmQuanLyThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Label lblTenThuoc;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.Label lblCachDung;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}
