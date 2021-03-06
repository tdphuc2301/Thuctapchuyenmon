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
GO
CREATE TABLE KhachHang
(
	MaKH VARCHAR(16) PRIMARY KEY,
	TenKH NVARCHAR(256) NOT NULL,
	SoDienThoai VARCHAR(32),
	DiaChi NVARCHAR(256)
)
GO
CREATE TABLE Ban
(
	MaBan VARCHAR(16) PRIMARY KEY,
	TenBan NVARCHAR(256) NOT NULL,
	SoLuongNguoi DECIMAL,
	GhiChu NVARCHAR(256)
)
GO
CREATE TABLE HoaDon
(
	MaHD VARCHAR(16) PRIMARY KEY,
	MaBan VARCHAR(16) FOREIGN KEY REFERENCES Ban(MaBan) NOT NULL,
	MaKH VARCHAR(16) FOREIGN KEY REFERENCES KhachHang(MaKH) NOT NULL,
	MaTK_NV VARCHAR(16) FOREIGN KEY REFERENCES TaiKhoan_NhanVien(MaTK_NV) NOT NULL,
	NgayHoaDon Datetime,
	MaDo_Uong VARCHAR(16) FOREIGN KEY REFERENCES DoUong(MaDo_Uong) NOT NULL,
	DonGia DECIMAL ,
	SoLuong DECIMAL,
	ThanhTien DECIMAL,
	TrangThai CHAR(1) -- 0 : chưa tính tiền, 1 : đã tính tiền
)
GO
INSERT INTO Quyen (MaQuyen,TenQuyen)VALUES(N'ADMIN',N'Quản trị viên')
INSERT INTO Quyen (MaQuyen,TenQuyen)VALUES(N'NGUOIDUNG',N'Người dùng')
GO
INSERT INTO TaiKhoan_NhanVien (MaTK_NV,TenTK_NV,MatKhau,SoDienThoai,DiaChi,Quyen)VALUES(N'11',N'22',N'33',N'44',N'55',N'NGUOIDUNG')
INSERT INTO TaiKhoan_NhanVien (MaTK_NV,TenTK_NV,MatKhau,SoDienThoai,DiaChi,Quyen)VALUES(N'ADMIN',N'Quản trị viên',N'000',N'0124512356',N'Vũng Tàu',N'ADMIN')
INSERT INTO TaiKhoan_NhanVien (MaTK_NV,TenTK_NV,MatKhau,SoDienThoai,DiaChi,Quyen)VALUES(N'NV01',N'Phương Trinh',N'000',N'0124541256',N'Bình Dương',N'NGUOIDUNG')
GO
INSERT INTO Ban (MaBan,TenBan,SoLuongNguoi,GhiChu)VALUES(N'BAN1',N'Bàn số 1',1,N'')
INSERT INTO Ban (MaBan,TenBan,SoLuongNguoi,GhiChu)VALUES(N'BAN2',N'Bàn số 2',2,N'')
INSERT INTO Ban (MaBan,TenBan,SoLuongNguoi,GhiChu)VALUES(N'BAN3',N'Bàn số 3',4,N'')
INSERT INTO Ban (MaBan,TenBan,SoLuongNguoi,GhiChu)VALUES(N'BAN4',N'Bàn số 4',4,N'')
GO
INSERT INTO DoUong (MaDo_Uong,TenDo_Uong,DonGia,SoLuongTon,GhiChu)VALUES(N'CAFEDEN',N'Cà phê đen',15000,50,N'')
INSERT INTO DoUong (MaDo_Uong,TenDo_Uong,DonGia,SoLuongTon,GhiChu)VALUES(N'CAFESUA',N'Cà phê sữa',20000,50,N'')
GO
INSERT INTO KhachHang (MaKH,TenKH,SoDienThoai,DiaChi)VALUES(N'KHACHVANGLAI',N'Khách vãng lai',N'',N'')
INSERT INTO KhachHang (MaKH,TenKH,SoDienThoai,DiaChi)VALUES(N'KHTEST',N'Khách hàng test',N'',N'')

