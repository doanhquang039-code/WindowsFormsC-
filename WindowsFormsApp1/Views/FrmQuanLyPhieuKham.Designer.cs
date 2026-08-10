namespace WindowsFormsApp1.Views
{
    partial class FrmQuanLyPhieuKham
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
            this.dgvPhieuKham = new System.Windows.Forms.DataGridView();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtKetLuan = new System.Windows.Forms.TextBox();
            this.lblKetLuan = new System.Windows.Forms.Label();
            this.txtChanDoan = new System.Windows.Forms.TextBox();
            this.lblChanDoan = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.txtNgayKham = new System.Windows.Forms.TextBox();
            this.lblNgayKham = new System.Windows.Forms.Label();
            this.txtMaBacSi = new System.Windows.Forms.TextBox();
            this.lblMaBacSi = new System.Windows.Forms.Label();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.lblMaBenhNhan = new System.Windows.Forms.Label();
            this.txtMaLichKham = new System.Windows.Forms.TextBox();
            this.lblMaLichKham = new System.Windows.Forms.Label();
            this.txtMaPhieuKham = new System.Windows.Forms.TextBox();
            this.lblMaPhieuKham = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            
            // dgvPhieuKham
            this.dgvPhieuKham.AllowUserToAddRows = false;
            this.dgvPhieuKham.AllowUserToDeleteRows = false;
            this.dgvPhieuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuKham.Location = new System.Drawing.Point(12, 210);
            this.dgvPhieuKham.Name = "dgvPhieuKham";
            this.dgvPhieuKham.ReadOnly = true;
            this.dgvPhieuKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuKham.Size = new System.Drawing.Size(776, 228);
            this.dgvPhieuKham.TabIndex = 0;
            this.dgvPhieuKham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuKham_CellClick);
            
            // grpThongTin
            this.grpThongTin.Controls.Add(this.txtGhiChu);
            this.grpThongTin.Controls.Add(this.lblGhiChu);
            this.grpThongTin.Controls.Add(this.txtKetLuan);
            this.grpThongTin.Controls.Add(this.lblKetLuan);
            this.grpThongTin.Controls.Add(this.txtChanDoan);
            this.grpThongTin.Controls.Add(this.lblChanDoan);
            this.grpThongTin.Controls.Add(this.txtTrieuChung);
            this.grpThongTin.Controls.Add(this.lblTrieuChung);
            this.grpThongTin.Controls.Add(this.txtNgayKham);
            this.grpThongTin.Controls.Add(this.lblNgayKham);
            this.grpThongTin.Controls.Add(this.txtMaBacSi);
            this.grpThongTin.Controls.Add(this.lblMaBacSi);
            this.grpThongTin.Controls.Add(this.txtMaBenhNhan);
            this.grpThongTin.Controls.Add(this.lblMaBenhNhan);
            this.grpThongTin.Controls.Add(this.txtMaLichKham);
            this.grpThongTin.Controls.Add(this.lblMaLichKham);
            this.grpThongTin.Controls.Add(this.txtMaPhieuKham);
            this.grpThongTin.Controls.Add(this.lblMaPhieuKham);
            this.grpThongTin.Location = new System.Drawing.Point(13, 13);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(775, 160);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin Phiếu Khám";
            
            // Textboxes & Labels
            this.lblMaPhieuKham.AutoSize = true;
            this.lblMaPhieuKham.Location = new System.Drawing.Point(20, 25);
            this.lblMaPhieuKham.Text = "Mã Phiếu";
            this.txtMaPhieuKham.Location = new System.Drawing.Point(110, 22);
            this.txtMaPhieuKham.ReadOnly = true;
            this.txtMaPhieuKham.Size = new System.Drawing.Size(120, 20);
            
            this.lblMaLichKham.AutoSize = true;
            this.lblMaLichKham.Location = new System.Drawing.Point(20, 50);
            this.lblMaLichKham.Text = "Mã Lịch Khám";
            this.txtMaLichKham.Location = new System.Drawing.Point(110, 47);
            this.txtMaLichKham.Size = new System.Drawing.Size(120, 20);
            
            this.lblMaBenhNhan.AutoSize = true;
            this.lblMaBenhNhan.Location = new System.Drawing.Point(20, 75);
            this.lblMaBenhNhan.Text = "Mã Bệnh Nhân";
            this.txtMaBenhNhan.Location = new System.Drawing.Point(110, 72);
            this.txtMaBenhNhan.Size = new System.Drawing.Size(120, 20);
            
            this.lblMaBacSi.AutoSize = true;
            this.lblMaBacSi.Location = new System.Drawing.Point(20, 100);
            this.lblMaBacSi.Text = "Mã Bác Sĩ";
            this.txtMaBacSi.Location = new System.Drawing.Point(110, 97);
            this.txtMaBacSi.Size = new System.Drawing.Size(120, 20);
            
            this.lblNgayKham.AutoSize = true;
            this.lblNgayKham.Location = new System.Drawing.Point(20, 125);
            this.lblNgayKham.Text = "Ngày Khám";
            this.txtNgayKham.Location = new System.Drawing.Point(110, 122);
            this.txtNgayKham.Size = new System.Drawing.Size(120, 20);
            
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Location = new System.Drawing.Point(250, 25);
            this.lblTrieuChung.Text = "Triệu Chứng";
            this.txtTrieuChung.Location = new System.Drawing.Point(330, 22);
            this.txtTrieuChung.Size = new System.Drawing.Size(350, 20);
            
            this.lblChanDoan.AutoSize = true;
            this.lblChanDoan.Location = new System.Drawing.Point(250, 50);
            this.lblChanDoan.Text = "Chẩn Đoán";
            this.txtChanDoan.Location = new System.Drawing.Point(330, 47);
            this.txtChanDoan.Size = new System.Drawing.Size(350, 20);
            
            this.lblKetLuan.AutoSize = true;
            this.lblKetLuan.Location = new System.Drawing.Point(250, 75);
            this.lblKetLuan.Text = "Kết Luận";
            this.txtKetLuan.Location = new System.Drawing.Point(330, 72);
            this.txtKetLuan.Size = new System.Drawing.Size(350, 20);
            
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(250, 100);
            this.lblGhiChu.Text = "Ghi Chú";
            this.txtGhiChu.Location = new System.Drawing.Point(330, 97);
            this.txtGhiChu.Size = new System.Drawing.Size(350, 20);
            
            // btnThem
            this.btnThem.Location = new System.Drawing.Point(13, 180);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            
            // btnSua
            this.btnSua.Location = new System.Drawing.Point(100, 180);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            
            // btnLamMoi
            this.btnLamMoi.Location = new System.Drawing.Point(187, 180);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            
            // FrmQuanLyPhieuKham
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.dgvPhieuKham);
            this.Name = "FrmQuanLyPhieuKham";
            this.Text = "Quản lý Phiếu Khám";
            this.Load += new System.EventHandler(this.FrmQuanLyPhieuKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvPhieuKham;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtMaPhieuKham;
        private System.Windows.Forms.Label lblMaPhieuKham;
        private System.Windows.Forms.TextBox txtMaLichKham;
        private System.Windows.Forms.Label lblMaLichKham;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.Label lblMaBenhNhan;
        private System.Windows.Forms.TextBox txtMaBacSi;
        private System.Windows.Forms.Label lblMaBacSi;
        private System.Windows.Forms.TextBox txtNgayKham;
        private System.Windows.Forms.Label lblNgayKham;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label lblTrieuChung;
        private System.Windows.Forms.TextBox txtChanDoan;
        private System.Windows.Forms.Label lblChanDoan;
        private System.Windows.Forms.TextBox txtKetLuan;
        private System.Windows.Forms.Label lblKetLuan;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
    }
}
