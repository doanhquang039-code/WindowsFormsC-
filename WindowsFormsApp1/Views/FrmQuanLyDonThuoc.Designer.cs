namespace WindowsFormsApp1.Views
{
    partial class FrmQuanLyDonThuoc
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
            this.dgvDonThuoc = new System.Windows.Forms.DataGridView();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtNgayKe = new System.Windows.Forms.TextBox();
            this.lblNgayKe = new System.Windows.Forms.Label();
            this.txtMaPhieuKham = new System.Windows.Forms.TextBox();
            this.lblMaPhieuKham = new System.Windows.Forms.Label();
            this.txtMaDonThuoc = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            
            // dgvDonThuoc
            this.dgvDonThuoc.AllowUserToAddRows = false;
            this.dgvDonThuoc.AllowUserToDeleteRows = false;
            this.dgvDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonThuoc.Location = new System.Drawing.Point(12, 160);
            this.dgvDonThuoc.Name = "dgvDonThuoc";
            this.dgvDonThuoc.ReadOnly = true;
            this.dgvDonThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonThuoc.Size = new System.Drawing.Size(776, 278);
            this.dgvDonThuoc.TabIndex = 0;
            this.dgvDonThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonThuoc_CellClick);
            
            // grpThongTin
            this.grpThongTin.Controls.Add(this.txtGhiChu);
            this.grpThongTin.Controls.Add(this.lblGhiChu);
            this.grpThongTin.Controls.Add(this.txtNgayKe);
            this.grpThongTin.Controls.Add(this.lblNgayKe);
            this.grpThongTin.Controls.Add(this.txtMaPhieuKham);
            this.grpThongTin.Controls.Add(this.lblMaPhieuKham);
            this.grpThongTin.Controls.Add(this.txtMaDonThuoc);
            this.grpThongTin.Controls.Add(this.lblMa);
            this.grpThongTin.Location = new System.Drawing.Point(13, 13);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(775, 100);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin Đơn Thuốc";
            
            // Textboxes & Labels
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(20, 25);
            this.lblMa.Text = "Mã Đơn Thuốc";
            this.txtMaDonThuoc.Location = new System.Drawing.Point(110, 22);
            this.txtMaDonThuoc.ReadOnly = true;
            this.txtMaDonThuoc.Size = new System.Drawing.Size(200, 20);
            
            this.lblMaPhieuKham.AutoSize = true;
            this.lblMaPhieuKham.Location = new System.Drawing.Point(20, 50);
            this.lblMaPhieuKham.Text = "Mã Phiếu Khám";
            this.txtMaPhieuKham.Location = new System.Drawing.Point(110, 47);
            this.txtMaPhieuKham.Size = new System.Drawing.Size(200, 20);
            
            this.lblNgayKe.AutoSize = true;
            this.lblNgayKe.Location = new System.Drawing.Point(350, 25);
            this.lblNgayKe.Text = "Ngày Kê (yyyy-MM-dd)";
            this.txtNgayKe.Location = new System.Drawing.Point(480, 22);
            this.txtNgayKe.Size = new System.Drawing.Size(200, 20);
            
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(350, 50);
            this.lblGhiChu.Text = "Ghi Chú";
            this.txtGhiChu.Location = new System.Drawing.Point(480, 47);
            this.txtGhiChu.Size = new System.Drawing.Size(200, 20);
            
            // btnThem
            this.btnThem.Location = new System.Drawing.Point(13, 125);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            
            // btnSua
            this.btnSua.Location = new System.Drawing.Point(100, 125);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            
            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(187, 125);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            
            // btnLamMoi
            this.btnLamMoi.Location = new System.Drawing.Point(274, 125);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            
            // FrmQuanLyDonThuoc
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.dgvDonThuoc);
            this.Name = "FrmQuanLyDonThuoc";
            this.Text = "Quản lý Đơn Thuốc";
            this.Load += new System.EventHandler(this.FrmQuanLyDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvDonThuoc;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtMaDonThuoc;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMaPhieuKham;
        private System.Windows.Forms.Label lblMaPhieuKham;
        private System.Windows.Forms.TextBox txtNgayKe;
        private System.Windows.Forms.Label lblNgayKe;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}
