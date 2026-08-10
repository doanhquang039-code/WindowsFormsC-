namespace WindowsFormsApp1.Views
{
    partial class FrmQuanLyHoaDon
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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTienThuoc = new System.Windows.Forms.TextBox();
            this.lblTienThuoc = new System.Windows.Forms.Label();
            this.txtTienKham = new System.Windows.Forms.TextBox();
            this.lblTienKham = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.txtMaPhieuKham = new System.Windows.Forms.TextBox();
            this.lblMaPhieuKham = new System.Windows.Forms.Label();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.lblMaBenhNhan = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            
            // dgvHoaDon
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 190);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(776, 248);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            
            // grpThongTin
            this.grpThongTin.Controls.Add(this.txtTrangThai);
            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.txtTongTien);
            this.grpThongTin.Controls.Add(this.lblTongTien);
            this.grpThongTin.Controls.Add(this.txtTienThuoc);
            this.grpThongTin.Controls.Add(this.lblTienThuoc);
            this.grpThongTin.Controls.Add(this.txtTienKham);
            this.grpThongTin.Controls.Add(this.lblTienKham);
            this.grpThongTin.Controls.Add(this.txtNgayLap);
            this.grpThongTin.Controls.Add(this.lblNgayLap);
            this.grpThongTin.Controls.Add(this.txtMaPhieuKham);
            this.grpThongTin.Controls.Add(this.lblMaPhieuKham);
            this.grpThongTin.Controls.Add(this.txtMaBenhNhan);
            this.grpThongTin.Controls.Add(this.lblMaBenhNhan);
            this.grpThongTin.Controls.Add(this.txtMaHoaDon);
            this.grpThongTin.Controls.Add(this.lblMa);
            this.grpThongTin.Location = new System.Drawing.Point(13, 13);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(775, 130);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin Hóa Đơn";
            
            // Textboxes & Labels
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(20, 25);
            this.lblMa.Text = "Mã Hóa Đơn";
            this.txtMaHoaDon.Location = new System.Drawing.Point(110, 22);
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.Size = new System.Drawing.Size(150, 20);
            
            this.lblMaBenhNhan.AutoSize = true;
            this.lblMaBenhNhan.Location = new System.Drawing.Point(20, 50);
            this.lblMaBenhNhan.Text = "Mã Bệnh Nhân";
            this.txtMaBenhNhan.Location = new System.Drawing.Point(110, 47);
            this.txtMaBenhNhan.Size = new System.Drawing.Size(150, 20);
            
            this.lblMaPhieuKham.AutoSize = true;
            this.lblMaPhieuKham.Location = new System.Drawing.Point(20, 75);
            this.lblMaPhieuKham.Text = "Mã Phiếu Khám";
            this.txtMaPhieuKham.Location = new System.Drawing.Point(110, 72);
            this.txtMaPhieuKham.Size = new System.Drawing.Size(150, 20);
            
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(20, 100);
            this.lblNgayLap.Text = "Ngày Lập";
            this.txtNgayLap.Location = new System.Drawing.Point(110, 97);
            this.txtNgayLap.Size = new System.Drawing.Size(150, 20);
            
            this.lblTienKham.AutoSize = true;
            this.lblTienKham.Location = new System.Drawing.Point(350, 25);
            this.lblTienKham.Text = "Tiền Khám";
            this.txtTienKham.Location = new System.Drawing.Point(430, 22);
            this.txtTienKham.Size = new System.Drawing.Size(150, 20);
            
            this.lblTienThuoc.AutoSize = true;
            this.lblTienThuoc.Location = new System.Drawing.Point(350, 50);
            this.lblTienThuoc.Text = "Tiền Thuốc";
            this.txtTienThuoc.Location = new System.Drawing.Point(430, 47);
            this.txtTienThuoc.Size = new System.Drawing.Size(150, 20);
            
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(350, 75);
            this.lblTongTien.Text = "Tổng Tiền";
            this.txtTongTien.Location = new System.Drawing.Point(430, 72);
            this.txtTongTien.Size = new System.Drawing.Size(150, 20);
            
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(350, 100);
            this.lblTrangThai.Text = "Trạng Thái (1/2)";
            this.txtTrangThai.Location = new System.Drawing.Point(430, 97);
            this.txtTrangThai.Size = new System.Drawing.Size(150, 20);
            
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
            
            // FrmQuanLyHoaDon
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.dgvHoaDon);
            this.Name = "FrmQuanLyHoaDon";
            this.Text = "Quản lý Hóa Đơn";
            this.Load += new System.EventHandler(this.FrmQuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.Label lblMaBenhNhan;
        private System.Windows.Forms.TextBox txtMaPhieuKham;
        private System.Windows.Forms.Label lblMaPhieuKham;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.TextBox txtTienKham;
        private System.Windows.Forms.Label lblTienKham;
        private System.Windows.Forms.TextBox txtTienThuoc;
        private System.Windows.Forms.Label lblTienThuoc;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}
