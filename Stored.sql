USE QLGym
GO

---------------KIỂM TRA ĐĂNG NHẬP---------------
CREATE PROC KiemTraDangNhap
@username nvarchar(20),
@password nvarchar(20)
AS
BEGIN
	SELECT idNguoiDung, username, password, vaiTro
	FROM NguoiDung 
	WHERE username = @username and password = @password
END
GO

---------------XEM PHÒNG TẬP---------------
CREATE PROC xemPhongTap
AS
BEGIN
	SELECT idPhongTap, tenPhongTap 
	FROM PhongTap
	WHERE trangThai = N'Trống' OR trangThai =  N'Đang sử dụng'
END
GO

---------------XEM THỂ LOẠI THIẾT BỊ---------------
CREATE PROC xemTheLoaiThietBi
AS
BEGIN
	SELECT * FROM TheLoai_ThietBi
END
GO

---------------THIẾT BỊ---------------
---------------XEM THIẾT BỊ---------------
CREATE PROC XemThietBi
AS
BEGIN
	SELECT * FROM ThietBi
END
GO

/*CREATE PROC XemIdThietBi
@idThietBi int
AS
BEGIN
	SELECT * FROM ThietBi
	WHERE idThietBi = @idThietBi 
END
GO*/

---------------THÊM THIẾT BỊ---------------
CREATE PROC ThemThietBi
@tenThietBi nvarchar(20),
@donGia decimal,
@ngayMua datetime,
@trangThai nvarchar(20),	
@idTLTB int,
@idPhongTap int
AS
BEGIN
	INSERT INTO ThietBi (tenThietBi, donGia, ngayMua , trangThai, idTLTB, idPhongTap)
	VALUES (@tenThietBi, @donGia, @ngayMua , @trangThai, @idTLTB, @idPhongTap)
END
GO

---------------SỬA THIẾT BỊ---------------
CREATE PROC SuaThietBi
@idThietBi int,
@tenThietBi nvarchar(20),
@donGia decimal,
@ngayMua datetime,
@trangThai nvarchar(20),	
@idTLTB int,
@idPhongTap int
AS
BEGIN
	UPDATE ThietBi
	SET tenThietBi = @tenThietBi, donGia = @donGia, ngayMua = @ngayMua, trangThai = @trangThai, idTLTB = @idTLTB, idPhongTap =@idPhongTap
	WHERE idThietBi = @idThietBi
END
GO

---------------XÓA THIẾT BỊ---------------
CREATE PROC XoaThietBi
@idThietBi int
AS
BEGIN
	DELETE FROM ThietBi
	WHERE idThietBi = @idThietBi
END
GO

---------------TÌM KIẾM THIẾT BỊ---------------
CREATE PROC TimKiemThietBi
@tuKhoa nvarchar(20)
AS
BEGIN	
	SELECT * FROM ThietBi
	WHERE tenThietBi LIKE N'%' + @tuKhoa + '%'
END
GO

---------------CẬP NHẬT TRẠNG THÁI THIẾT BỊ---------------
CREATE PROC CapNhatTrangThaiThietBi
@idThietBi int,
@trangThai nvarchar(20)
AS
BEGIN
	UPDATE ThietBi
	SET trangThai = @trangThai
	WHERE idThietBi = @idThietBi
END
GO

---------------HỌC VIÊN---------------
---------------XEM HỌC VIÊN---------------
CREATE PROC XemHocVien
AS
BEGIN
	SELECT * FROM HocVien
END
GO

---------------THÊM HỌC VIÊN---------------
CREATE PROC ThemHocVien
@tenHocVien nvarchar(20),
@gioiTinh nvarchar(10),
@ngaySinh datetime,
@sdt varchar(10),
@email nvarchar(50),
@diaChi nvarchar(50),
@ngayThamGia datetime
AS
BEGIN
	INSERT INTO HocVien (tenHocVien, gioiTinh, ngaySinh, sdt, email, diaChi, ngayThamGia)
	VALUES (@tenHocVien, @gioiTinh, @ngaySinh, @sdt, @email, @diaChi, @ngayThamGia)
END
GO

---------------SỬA HỌC VIÊN---------------
CREATE PROC SuaHocVien
@idHocVien int,
@tenHocVien nvarchar(20),
@gioiTinh nvarchar(10),
@ngaySinh datetime,
@sdt varchar(10),
@email nvarchar(50),
@diaChi nvarchar(50),
@ngayThamGia datetime
AS
BEGIN
	UPDATE HocVien
	SET tenHocVien = @tenHocVien, gioiTinh = @gioiTinh, ngaySinh = @ngaySinh, sdt = @sdt, email = @email, diaChi = @diaChi, ngayThamGia = @ngayThamGia
	WHERE idHocVien = @idHocVien
END
GO

---------------XÓA HỌC VIÊN---------------
CREATE PROC XoaHocVien
@idHocVien int
AS
BEGIN
	DELETE FROM HocVien
	WHERE idHocVien = @idHocVien
END
GO

---------------TÌM KIẾM HỌC VIÊN---------------
CREATE PROC TimKiemHocVien
@tuKhoa nvarchar(20)
AS
BEGIN	
	SELECT * FROM HocVien
	WHERE tenHocVien LIKE N'%' + @tuKhoa + '%'
END
GO
