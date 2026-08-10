namespace WindowsFormsApp1.Views
{
    partial class FrmQuanLyLichKham
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
            this.dgvLichKham = new System.Windows.Forms.DataGridView();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtLyDoKham = new System.Windows.Forms.TextBox();
            this.lblLyDoKham = new System.Windows.Forms.Label();
            this.txtNgayKham = new System.Windows.Forms.TextBox();
            this.lblNgayKham = new System.Windows.Forms.Label();
            this.txtMaBacSi = new System.Windows.Forms.TextBox();
            this.lblMaBacSi = new System.Windows.Forms.Label();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.lblMaBenhNhan = new System.Windows.Forms.Label();
            this.txtMaLichKham = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichKham)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            
            // dgvLichKham
            this.dgvLichKham.AllowUserToAddRows = false;
            this.dgvLichKham.AllowUserToDeleteRows = false;
            this.dgvLichKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichKham.Location = new System.Drawing.Point(12, 160);
            this.dgvLichKham.Name = "dgvLichKham";
            this.dgvLichKham.ReadOnly = true;
            this.dgvLichKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichKham.Size = new System.Drawing.Size(776, 278);
            this.dgvLichKham.TabIndex = 0;
            this.dgvLichKham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichKham_CellClick);
            
            // grpThongTin
            this.grpThongTin.Controls.Add(this.txtTrangThai);
            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.txtLyDoKham);
            this.grpThongTin.Controls.Add(this.lblLyDoKham);
            this.grpThongTin.Controls.Add(this.txtNgayKham);
            this.grpThongTin.Controls.Add(this.lblNgayKham);
            this.grpThongTin.Controls.Add(this.txtMaBacSi);
            this.grpThongTin.Controls.Add(this.lblMaBacSi);
            this.grpThongTin.Controls.Add(this.txtMaBenhNhan);
            this.grpThongTin.Controls.Add(this.lblMaBenhNhan);
            this.grpThongTin.Controls.Add(this.txtMaLichKham);
            this.grpThongTin.Controls.Add(this.lblMa);
            this.grpThongTin.Location = new System.Drawing.Point(13, 13);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(775, 100);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin Lịch Khám";
            
            // Textboxes & Labels
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(20, 25);
            this.lblMa.Text = "Mã Lịch Khám";
            this.txtMaLichKham.Location = new System.Drawing.Point(110, 22);
            this.txtMaLichKham.ReadOnly = true;
            this.txtMaLichKham.Size = new System.Drawing.Size(150, 20);
            
            this.lblMaBenhNhan.AutoSize = true;
            this.lblMaBenhNhan.Location = new System.Drawing.Point(20, 50);
            this.lblMaBenhNhan.Text = "Mã Bệnh Nhân";
            this.txtMaBenhNhan.Location = new System.Drawing.Point(110, 47);
            this.txtMaBenhNhan.Size = new System.Drawing.Size(150, 20);
            
            this.lblMaBacSi.AutoSize = true;
            this.lblMaBacSi.Location = new System.Drawing.Point(20, 75);
            this.lblMaBacSi.Text = "Mã Bác Sĩ";
            this.txtMaBacSi.Location = new System.Drawing.Point(110, 72);
            this.txtMaBacSi.Size = new System.Drawing.Size(150, 20);
            
            this.lblNgayKham.AutoSize = true;
            this.lblNgayKham.Location = new System.Drawing.Point(280, 25);
            this.lblNgayKham.Text = "Ngày Khám";
            this.txtNgayKham.Location = new System.Drawing.Point(360, 22);
            this.txtNgayKham.Size = new System.Drawing.Size(150, 20);
            
            this.lblLyDoKham.AutoSize = true;
            this.lblLyDoKham.Location = new System.Drawing.Point(280, 50);
            this.lblLyDoKham.Text = "Lý Do Khám";
            this.txtLyDoKham.Location = new System.Drawing.Point(360, 47);
            this.txtLyDoKham.Size = new System.Drawing.Size(150, 20);
            
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(280, 75);
            this.lblTrangThai.Text = "Trạng Thái (1/2/3)";
            this.txtTrangThai.Location = new System.Drawing.Point(360, 72);
            this.txtTrangThai.Size = new System.Drawing.Size(150, 20);
            
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
            
            // FrmQuanLyLichKham
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.dgvLichKham);
            this.Name = "FrmQuanLyLichKham";
            this.Text = "Quản lý Lịch Khám";
            this.Load += new System.EventHandler(this.FrmQuanLyLichKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichKham)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvLichKham;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtMaLichKham;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.Label lblMaBenhNhan;
        private System.Windows.Forms.TextBox txtMaBacSi;
        private System.Windows.Forms.Label lblMaBacSi;
        private System.Windows.Forms.TextBox txtNgayKham;
        private System.Windows.Forms.Label lblNgayKham;
        private System.Windows.Forms.TextBox txtLyDoKham;
        private System.Windows.Forms.Label lblLyDoKham;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}
