namespace WindowsFormsApp1.Views
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBacSi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLichKham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuKham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChiTietDonThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            
            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuQuanLy});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            
            // mnuHeThong
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(69, 20);
            this.mnuHeThong.Text = "Hệ thống";
            
            // mnuThoat
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(180, 22);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            
            // mnuQuanLy
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBacSi,
            this.mnuBenhNhan,
            this.mnuLichKham,
            this.mnuPhieuKham,
            this.mnuThuoc,
            this.mnuChuyenKhoa,
            this.mnuNhanVien,
            this.mnuDonThuoc,
            this.mnuChiTietDonThuoc,
            this.mnuHoaDon});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(60, 20);
            this.mnuQuanLy.Text = "Quản lý";
            
            // mnuBacSi
            this.mnuBacSi.Name = "mnuBacSi";
            this.mnuBacSi.Size = new System.Drawing.Size(180, 22);
            this.mnuBacSi.Text = "Quản lý Bác Sĩ";
            this.mnuBacSi.Click += new System.EventHandler(this.mnuBacSi_Click);
            
            // mnuBenhNhan
            this.mnuBenhNhan.Name = "mnuBenhNhan";
            this.mnuBenhNhan.Size = new System.Drawing.Size(180, 22);
            this.mnuBenhNhan.Text = "Quản lý Bệnh Nhân";
            this.mnuBenhNhan.Click += new System.EventHandler(this.mnuBenhNhan_Click);
            
            // mnuLichKham
            this.mnuLichKham.Name = "mnuLichKham";
            this.mnuLichKham.Size = new System.Drawing.Size(180, 22);
            this.mnuLichKham.Text = "Quản lý Lịch Khám";
            this.mnuLichKham.Click += new System.EventHandler(this.mnuLichKham_Click);
            
            // mnuPhieuKham
            this.mnuPhieuKham.Name = "mnuPhieuKham";
            this.mnuPhieuKham.Size = new System.Drawing.Size(180, 22);
            this.mnuPhieuKham.Text = "Quản lý Phiếu Khám";
            this.mnuPhieuKham.Click += new System.EventHandler(this.mnuPhieuKham_Click);
            
            // mnuThuoc
            this.mnuThuoc.Name = "mnuThuoc";
            this.mnuThuoc.Size = new System.Drawing.Size(180, 22);
            this.mnuThuoc.Text = "Quản lý Thuốc";
            this.mnuThuoc.Click += new System.EventHandler(this.mnuThuoc_Click);
            
            // mnuChuyenKhoa
            this.mnuChuyenKhoa.Name = "mnuChuyenKhoa";
            this.mnuChuyenKhoa.Size = new System.Drawing.Size(180, 22);
            this.mnuChuyenKhoa.Text = "Quản lý Chuyên Khoa";
            this.mnuChuyenKhoa.Click += new System.EventHandler(this.mnuChuyenKhoa_Click);
            
            // mnuNhanVien
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(180, 22);
            this.mnuNhanVien.Text = "Quản lý Nhân Viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            
            // mnuDonThuoc
            this.mnuDonThuoc.Name = "mnuDonThuoc";
            this.mnuDonThuoc.Size = new System.Drawing.Size(180, 22);
            this.mnuDonThuoc.Text = "Quản lý Đơn Thuốc";
            this.mnuDonThuoc.Click += new System.EventHandler(this.mnuDonThuoc_Click);
            
            // mnuChiTietDonThuoc
            this.mnuChiTietDonThuoc.Name = "mnuChiTietDonThuoc";
            this.mnuChiTietDonThuoc.Size = new System.Drawing.Size(180, 22);
            this.mnuChiTietDonThuoc.Text = "Chi Tiết Đơn Thuốc";
            this.mnuChiTietDonThuoc.Click += new System.EventHandler(this.mnuChiTietDonThuoc_Click);
            
            // mnuHoaDon
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(180, 22);
            this.mnuHoaDon.Text = "Quản lý Hóa Đơn";
            this.mnuHoaDon.Click += new System.EventHandler(this.mnuHoaDon_Click);
            
            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Phòng Khám";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuBacSi;
        private System.Windows.Forms.ToolStripMenuItem mnuBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuLichKham;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuKham;
        private System.Windows.Forms.ToolStripMenuItem mnuThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenKhoa;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuDonThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuChiTietDonThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
    }
}
