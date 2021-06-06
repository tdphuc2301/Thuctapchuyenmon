CREATE DATABASE DB_QuanLyQuanCafe
GO
USE DB_QuanLyQuanCafe
GO
CREATE TABLE Quyen
(
	MaQuyen VARCHAR(16) PRIMARY KEY,
	TenQuyen NVARCHAR(64) NOT NULL
)

CREATE TABLE TaiKhoan_NhanVien
(
	MaTK_NV VARCHAR(16) PRIMARY KEY,
	TenTK_NV NVARCHAR(256) NOT NULL,
	MatKhau NVARCHAR(256) NOT NULL,
	SoDienThoai VARCHAR(32),
	DiaChi NVARCHAR(256),
	Quyen VARCHAR(16) FOREIGN KEY REFERENCES Quyen(MaQuyen) NOT NULL
)
GO
CREATE TABLE DoUong
(
	MaDo_Uong VARCHAR(16) PRIMARY KEY,
	TenDo_Uong NVARCHAR(256) NOT NULL,
	DonGia DECIMAL NOT NULL,
	SoLuongTon DECIMAL,
	GhiChu NVARCHAR(256)
)