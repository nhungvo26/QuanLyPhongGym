IF NOT EXISTS (SELECT name FROM sys.databases WHERE name ='QLGym')
CREATE DATABASE QlGym
GO
 
USE QlGym
GO

---------------BẢNG NGƯỜI DÙNG---------------
CREATE TABLE NguoiDung (
		idNguoiDung int IDENTITY(1,1) PRIMARY KEY,
		hoNguoiDung nvarchar(20) NOT NULL,
		tenNguoiDung nvarchar(20) NOT NULL,
		gioiTinh nvarchar(10),
		ngaySinh datetime,
		sdt varchar(10),
		email nvarchar(50) UNIQUE NOT NULL,
		username nvarchar(20) UNIQUE NOT NULL,
		password nvarchar(20) NOT NULL,
		vaiTro nvarchar(20) NOT NULL CHECK (vaiTro IN (N'Chủ phòng gym', N'Lễ tân', N'Nhân viên kỹ thuật', N'Huấn luyện viên'))
)
GO

---------------NHẬP DỮ LIỆU---------------
INSERT INTO NguoiDung VALUES 
(N'Trần', N'Quốc Bảo', N'Nam', '1994-02-22', '0338471934', N'admin@gmail.com', N'admin', N'Admin@123', N'Chủ phòng gym'),
(N'Võ', N'Đan Thi', N'Nữ', '1996-05-10', '0988428576', N'letan@gmail.com', N'letan', N'Letan@123', N'Lễ tân'),
(N'Nguyễn', N'Tuyết Băng', N'Nữ', '1995-12-09', '0388477979', N'nvkt@gmail.com', N'nvkt', N'Nvkt@123', N'Nhân viên kỹ thuật'),
(N'Phạm', N'Đức', N'Nam', '1998-06-17', '0338538589', N'hlv@gmail.com', N'hlv', N'Hlv@123', N'Huấn luyện viên')
GO

---------------XEM BẢNG NGƯỜI DÙNG---------------
/*SELECT * FROM NguoiDung
GO*/

---------------BẢNG NHÂN VIÊN---------------
CREATE TABLE NhanVien (
		idNhanVien int IDENTITY(1,1) PRIMARY KEY,
		idNguoiDung int FOREIGN KEY REFERENCES NguoiDung(idNguoiDung) ON DELETE CASCADE, 
		vaiTro nvarchar(20) NOT NULL CHECK (vaiTro IN (N'Chủ phòng gym', N'Lễ tân', N'Nhân viên kỹ thuật', N'Huấn luyện viên'))
)
GO

---------------NHẬP DỮ LIỆU---------------
INSERT INTO NhanVien VALUES 
('1', N'Chủ phòng gym'),
('2', N'Lễ tân'),
('3', N'Nhân viên kỹ thuật'),
('4', N'Huấn luyện viên')
GO

---------------XEM BẢNG NHÂN VIÊN---------------
/*SELECT * FROM NhanVien
GO*/

 ---------------BẢNG THỂ LOẠI_LỚP HỌC---------------
CREATE TABLE TheLoai_LopHoc (
		idTLLH int IDENTITY(1,1) PRIMARY KEY,
		tenTLLH nvarchar(20) NOT NULL
 )
GO

---------------NHẬP DỮ LIỆU---------------
INSERT INTO TheLoai_LopHoc VALUES 
(N'Yoga'), (N'Group'), (N'Aerobic'), (N'Pilates'), (N'Dance'), (N'Pump')
GO

---------------XEM BẢNG THỂ LOẠI_LỚP HỌC---------------
/*SELECT * FROM TheLoai_LopHoc
GO*/

---------------BẢNG PHÒNG TẬP---------------
CREATE TABLE PhongTap (
		idPhongTap int IDENTITY(1,1) PRIMARY KEY,
		tenPhongTap nvarchar(20),
		viTri nvarchar(20),
		trangThai nvarchar(20) DEFAULT N'Trống' CHECK (trangThai IN (N'Trống', N'Đang sử dụng', N'Đang bảo trì')),	
)
GO

---------------NHẬP DỮ LIỆU---------------
INSERT INTO PhongTap VALUES 
(N'Phòng A',N'Phòng 1, Tầng 1',N'Trống'),
(N'Phòng B',N'Phòng 2, Tầng 1',N'Đang sử dụng'),
(N'Phòng C',N'Phòng 3, Tầng 1',N'Đang bảo trì'),
(N'Phòng D',N'Phòng 1, Tầng 2',N'Trống'),
(N'Phòng E',N'Phòng 2, Tầng 2',N'Trống'),
(N'Phòng F',N'Phòng 3, Tầng 2',N'Đang sử dụng')
GO

---------------XEM BẢNG PHÒNG TẬP---------------
/*SELECT * FROM PhongTap
GO*/

---------------BẢNG LỚP HỌC---------------
CREATE TABLE LopHoc (
		idLopHoc int IDENTITY(1,1) PRIMARY KEY,
		tenLopHoc nvarchar(100) NOT NULL,
		idTLLH int FOREIGN KEY REFERENCES TheLoai_LopHoc(idTLLH),
		idHLV int FOREIGN KEY REFERENCES NguoiDung(idNguoiDung), 
		lichHoc nvarchar(255),
		soLuongHV int CHECK(soLuongHV > 0),
		donGia decimal CHECK(donGia >= 0),
		ngayBatDau datetime,
		ngayKetThuc datetime,
		moTa nvarchar(50),
		idPhongTap int FOREIGN KEY REFERENCES PhongTap(idPhongTap),
		CHECK(ngayKetThuc > ngayBatDau) 
)
GO

---------------NHẬP DỮ LIỆU---------------
INSERT INTO LopHoc VALUES 
    (N'Yoga A', 1, 4, N'Wed 08:00-10:00; Thu 08:00-10:00', 20, 200000, '2025-10-01', '2025-12-11', N'Lớp yoga dành cho mọi người.', 1),
    (N'HLV hướng dẫn tập luyện theo nhóm', 2 , 4, N'Mon 18:00-19:30; Thu 18:00-19:30', 10, 500000, '2025-07-28', '2025-09-04', N'Chương trình tập luyện theo nhóm.', 2)
GO

---------------BẢNG HỌC VIÊN---------------
CREATE TABLE HocVien (
		idHocVien int IDENTITY(1,1) PRIMARY KEY,
		tenHocVien nvarchar(20) NOT NULL,
		gioiTinh nvarchar(10),
		ngaySinh datetime,
		sdt varchar(10),
		email nvarchar(50) UNIQUE NOT NULL,
		diaChi nvarchar(50),
		ngayThamGia datetime DEFAULT GETDATE()
)
GO

---------------NHẬP DỮ LIỆU---------------
INSERT INTO HocVien VALUES 
    (N'Nguyễn A', N'Nữ', '1994-01-10','0983482345','nguyena@gmail.com',N'Quận 1, TP.HCM','2024-05-10 06:00:00'),
	(N'Phạm Đình B', N'Nam', '2000-10-06', '0338576948','phamb@gmail.com',N'Bình Thạnh, TP.HCM','2024-06-06 08:00:00')
GO

---------------BẢNG HỌC VIÊN_LỚP HỌC---------------
CREATE TABLE HocVien_LopHoc (
		idHVLH int IDENTITY(1,1) PRIMARY KEY,
		idHocVien int FOREIGN KEY REFERENCES HocVien(idHocVien) ON DELETE CASCADE,
		idLopHoc int FOREIGN KEY REFERENCES LopHoc(idLopHoc) ON DELETE CASCADE,
		ngayDangKy datetime DEFAULT GETDATE(),
		trangThai nvarchar(20) DEFAULT N'Đang hoạt động' CHECK (trangThai IN (N'Đang hoạt động', N'Đã hủy')),	
)
GO

---------------NHẬP DỮ LIỆU---------------
INSERT INTO HocVien_LopHoc VALUES 
    (1, 2, '2024-08-05 08:00:00', N'Đang hoạt động'),
    (2, 2, '2024-08-09 09:00:00', N'Đang hoạt động')
GO

---------------BẢNG HỌC VIÊN_GÓI TẬP---------------
CREATE TABLE HocVien_GoiTap (
		idHVGT int IDENTITY(1,1) PRIMARY KEY,	
		idHocVien int FOREIGN KEY REFERENCES HocVien(idHocVien) ON DELETE CASCADE,
		loaiGoiTap nvarchar(20) CHECK (loaiGoiTap IN (N'1 tháng', N'3 tháng', N'6 tháng', N'12 tháng')),
		ngayBatDau datetime,
		ngayKetThuc datetime,
		trangThai nvarchar(20) CHECK (trangThai IN (N'Còn hiệu lực', N'Chưa có gói', N'Hết hạn')),
		CHECK(ngayKetThuc > ngayBatDau)
)
GO

---------------NHẬP DỮ LIỆU---------------
INSERT INTO HocVien_GoiTap VALUES 
    (1, NULL, NULL, NULL, N'Chưa có gói'),
	(2, NULL, NULL, NULL, N'Chưa có gói')
GO


---------------BẢNG HÓA ĐƠN THANH TOÁN---------------
CREATE TABLE HoaDonThanhToan (
		idHoaDon int IDENTITY(1,1) PRIMARY KEY,
		donGia decimal,
		phuongThucThanhToan nvarchar(20) CHECK (phuongThucThanhToan IN (N'Tiền mặt', N'Chuyển khoản')),	
		loaiThanhToan nvarchar(20) CHECK (loaiThanhToan IN (N'Gói tập', N'Lớp học')),	
		ngayThanhToan datetime DEFAULT GETDATE(),
		trangThai nvarchar(20),
		idDKLH int,
		idHocVien int FOREIGN KEY REFERENCES HocVien(idHocVien) ON DELETE CASCADE
)
GO

---------------BẢNG THỂ LOẠI_THIẾT BỊ---------------
CREATE TABLE TheLoai_ThietBi (
		idTLTB int IDENTITY(1,1) PRIMARY KEY,
		tenTLTB nvarchar(20) NOT NULL
)
GO

---------------BẢNG THIẾT BỊ---------------
CREATE TABLE ThietBi (
		idThietBi int IDENTITY(1,1) PRIMARY KEY,
		tenThietBi nvarchar(20),
		donGia decimal CHECK(donGia >= 0),
		soLuongHV int,
		ngayMua datetime,
		trangThai nvarchar(20) DEFAULT N'Tốt' CHECK (trangThai IN (N'Tốt', N'Cần bảo trì', N'Hư hỏng')),	
		idTLTB int FOREIGN KEY REFERENCES TheLoai_ThietBi(idTLTB),
		idPhongTap int FOREIGN KEY REFERENCES PhongTap(idPhongTap)
)
GO

---------------BẢNG BẢO TRÌ---------------
CREATE TABLE BaoTri (
		idBaoTri int IDENTITY(1,1) PRIMARY KEY,
		idThietBi int FOREIGN KEY REFERENCES ThietBi(idThietBi),
		ngayBaoTri datetime,
		trangThai nvarchar(20) DEFAULT N'Đang bảo trì' CHECK (trangThai IN (N'Đang bảo trì', N'Hoàn tất'))
)
GO
