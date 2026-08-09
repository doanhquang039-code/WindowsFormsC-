CREATE DATABASE QuanLyPhongKham;
GO

USE QuanLyPhongKham;
GO

-- 1. TaiKhoan
CREATE TABLE TaiKhoan (
    MaTaiKhoan INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(50) NOT NULL UNIQUE,
    MatKhau NVARCHAR(255) NOT NULL,
    VaiTro INT NOT NULL, -- 1: BenhNhan, 2: NhanVien, 3: BacSi
    TrangThai BIT DEFAULT 1
);
GO

-- 2. ChuyenKhoa
CREATE TABLE ChuyenKhoa (
    MaChuyenKhoa INT IDENTITY(1,1) PRIMARY KEY,
    TenChuyenKhoa NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(500)
);
GO

-- 3. BacSi
CREATE TABLE BacSi (
    MaBacSi INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    SoDienThoai NVARCHAR(20),
    Email NVARCHAR(100),
    MaChuyenKhoa INT FOREIGN KEY REFERENCES ChuyenKhoa(MaChuyenKhoa),
    TrinhDo NVARCHAR(100),
    DiaChi NVARCHAR(255),
    TrangThai BIT DEFAULT 1
);
GO

-- 4. BenhNhan
CREATE TABLE BenhNhan (
    MaBenhNhan INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    SoDienThoai NVARCHAR(20),
    DiaChi NVARCHAR(255),
    Email NVARCHAR(100),
    CCCD NVARCHAR(20)
);
GO

-- 5. NhanVien
CREATE TABLE NhanVien (
    MaNhanVien INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    SoDienThoai NVARCHAR(20),
    Email NVARCHAR(100),
    DiaChi NVARCHAR(255),
    ChucVu NVARCHAR(100),
    TrangThai BIT DEFAULT 1
);
GO

-- 6. LichKham
CREATE TABLE LichKham (
    MaLichKham INT IDENTITY(1,1) PRIMARY KEY,
    MaBenhNhan INT FOREIGN KEY REFERENCES BenhNhan(MaBenhNhan),
    MaBacSi INT FOREIGN KEY REFERENCES BacSi(MaBacSi),
    NgayKham DATE NOT NULL,
    GioKham TIME,
    TrangThai INT DEFAULT 1,
    LyDoKham NVARCHAR(500)
);
GO

-- 7. PhieuKham
CREATE TABLE PhieuKham (
    MaPhieuKham INT IDENTITY(1,1) PRIMARY KEY,
    MaLichKham INT FOREIGN KEY REFERENCES LichKham(MaLichKham),
    MaBenhNhan INT FOREIGN KEY REFERENCES BenhNhan(MaBenhNhan),
    MaBacSi INT FOREIGN KEY REFERENCES BacSi(MaBacSi),
    NgayKham DATE NOT NULL,
    TrieuChung NVARCHAR(500),
    ChanDoan NVARCHAR(500),
    KetLuan NVARCHAR(500),
    GhiChu NVARCHAR(500)
);
GO

-- 8. HoaDon
CREATE TABLE HoaDon (
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    MaBenhNhan INT FOREIGN KEY REFERENCES BenhNhan(MaBenhNhan),
    MaPhieuKham INT FOREIGN KEY REFERENCES PhieuKham(MaPhieuKham),
    NgayLap DATETIME DEFAULT GETDATE(),
    TienKham DECIMAL(18,2) DEFAULT 0,
    TienThuoc DECIMAL(18,2) DEFAULT 0,
    TongTien DECIMAL(18,2) DEFAULT 0,
    TrangThai INT DEFAULT 1
);
GO

-- 9. DonThuoc
CREATE TABLE DonThuoc (
    MaDonThuoc INT IDENTITY(1,1) PRIMARY KEY,
    MaPhieuKham INT FOREIGN KEY REFERENCES PhieuKham(MaPhieuKham),
    NgayKe DATETIME DEFAULT GETDATE(),
    GhiChu NVARCHAR(500)
);
GO

-- 10. Thuoc
CREATE TABLE Thuoc (
    MaThuoc INT IDENTITY(1,1) PRIMARY KEY,
    TenThuoc NVARCHAR(200) NOT NULL,
    DonViTinh NVARCHAR(50),
    DonGia DECIMAL(18,2) DEFAULT 0,
    SoLuongTon INT DEFAULT 0,
    CachDung NVARCHAR(500),
    TrangThai BIT DEFAULT 1
);
GO

-- 11. ChiTietDonThuoc
CREATE TABLE ChiTietDonThuoc (
    MaDonThuoc INT FOREIGN KEY REFERENCES DonThuoc(MaDonThuoc),
    MaThuoc INT FOREIGN KEY REFERENCES Thuoc(MaThuoc),
    SoLuong INT DEFAULT 1,
    LieuDung NVARCHAR(200),
    CachDung NVARCHAR(500),
    DonGia DECIMAL(18,2) DEFAULT 0,
    PRIMARY KEY(MaDonThuoc, MaThuoc)
);
GO

-- Insert Dummy Data
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, VaiTro, TrangThai) VALUES ('admin', 'admin', 2, 1);
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, VaiTro, TrangThai) VALUES ('bacsi1', '123', 3, 1);

INSERT INTO ChuyenKhoa (TenChuyenKhoa, MoTa) VALUES (N'Nội khoa', N'Khám các bệnh nội khoa');
INSERT INTO ChuyenKhoa (TenChuyenKhoa, MoTa) VALUES (N'Ngoại khoa', N'Khám các bệnh ngoại khoa');

INSERT INTO BacSi (HoTen, SoDienThoai, Email, MaChuyenKhoa, TrinhDo, DiaChi, TrangThai) 
VALUES (N'Nguyễn Văn A', '0123456789', 'nguyenvana@gmail.com', 1, N'Thạc sĩ', N'Hà Nội', 1);

INSERT INTO BenhNhan (HoTen, NgaySinh, GioiTinh, SoDienThoai, DiaChi, Email, CCCD)
VALUES (N'Trần Thị B', '1990-01-01', N'Nữ', '0987654321', N'Hải Phòng', 'tranthib@gmail.com', '031190000000');
