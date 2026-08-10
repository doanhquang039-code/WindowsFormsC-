namespace WindowsFormsApp1.Views
{
    partial class FrmQuanLyChuyenKhoa
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
            this.dgvChuyenKhoa = new System.Windows.Forms.DataGridView();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtTenChuyenKhoa = new System.Windows.Forms.TextBox();
            this.lblTenChuyenKhoa = new System.Windows.Forms.Label();
            this.txtMaChuyenKhoa = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenKhoa)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            
            // dgvChuyenKhoa
            this.dgvChuyenKhoa.AllowUserToAddRows = false;
            this.dgvChuyenKhoa.AllowUserToDeleteRows = false;
            this.dgvChuyenKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenKhoa.Location = new System.Drawing.Point(12, 160);
            this.dgvChuyenKhoa.Name = "dgvChuyenKhoa";
            this.dgvChuyenKhoa.ReadOnly = true;
            this.dgvChuyenKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyenKhoa.Size = new System.Drawing.Size(776, 278);
            this.dgvChuyenKhoa.TabIndex = 0;
            this.dgvChuyenKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenKhoa_CellClick);
            
            // grpThongTin
            this.grpThongTin.Controls.Add(this.txtMoTa);
            this.grpThongTin.Controls.Add(this.lblMoTa);
            this.grpThongTin.Controls.Add(this.txtTenChuyenKhoa);
            this.grpThongTin.Controls.Add(this.lblTenChuyenKhoa);
            this.grpThongTin.Controls.Add(this.txtMaChuyenKhoa);
            this.grpThongTin.Controls.Add(this.lblMa);
            this.grpThongTin.Location = new System.Drawing.Point(13, 13);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(775, 100);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin Chuyên Khoa";
            
            // Textboxes & Labels
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(20, 25);
            this.lblMa.Text = "Mã CK";
            this.txtMaChuyenKhoa.Location = new System.Drawing.Point(110, 22);
            this.txtMaChuyenKhoa.ReadOnly = true;
            this.txtMaChuyenKhoa.Size = new System.Drawing.Size(200, 20);
            
            this.lblTenChuyenKhoa.AutoSize = true;
            this.lblTenChuyenKhoa.Location = new System.Drawing.Point(20, 50);
            this.lblTenChuyenKhoa.Text = "Tên CK";
            this.txtTenChuyenKhoa.Location = new System.Drawing.Point(110, 47);
            this.txtTenChuyenKhoa.Size = new System.Drawing.Size(200, 20);
            
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(350, 25);
            this.lblMoTa.Text = "Mô Tả";
            this.txtMoTa.Location = new System.Drawing.Point(430, 22);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Size = new System.Drawing.Size(300, 50);
            
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
            
            // FrmQuanLyChuyenKhoa
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.dgvChuyenKhoa);
            this.Name = "FrmQuanLyChuyenKhoa";
            this.Text = "Quản lý Chuyên Khoa";
            this.Load += new System.EventHandler(this.FrmQuanLyChuyenKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenKhoa)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvChuyenKhoa;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtMaChuyenKhoa;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtTenChuyenKhoa;
        private System.Windows.Forms.Label lblTenChuyenKhoa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}
