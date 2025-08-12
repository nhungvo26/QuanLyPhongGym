USE QlGym
GO

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

--
-- 1. Lấy tất cả lớp học
CREATE PROCEDURE usp_LayTatCaLopHoc
AS
BEGIN
    SELECT * FROM LopHoc;
END
GO

-- 2. Lấy lớp học theo ID
CREATE PROCEDURE usp_LayLopHocTheoID
    @idLopHoc INT
AS
BEGIN
    SELECT * FROM LopHoc
    WHERE idLopHoc = @idLopHoc;
END
GO

-- 3. Lấy lớp học theo HLV
CREATE PROCEDURE usp_LayLopHocTheoHLV
    @idHLV INT
AS
BEGIN
    SELECT * 
    FROM LopHoc
    WHERE idHLV = @idHLV;
END
GO

-- 4. Thêm lớp học
CREATE PROCEDURE usp_ThemLopHoc
    @tenLopHoc NVARCHAR(100),
    @idTLLH INT,
    @idHLV INT,
    @lichHoc NVARCHAR(50),
    @soLuongHV INT,
    @donGia DECIMAL(18,2),
    @ngayBatDau DATE,
    @ngayKetThuc DATE,
    @moTa NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO LopHoc (tenLopHoc, idTLLH, idHLV, lichHoc, soLuongHV, donGia, ngayBatDau, ngayKetThuc, moTa)
    VALUES (@tenLopHoc, @idTLLH, @idHLV, @lichHoc, @soLuongHV, @donGia, @ngayBatDau, @ngayKetThuc, @moTa);
END
GO

-- 5. Cập nhật lớp học
CREATE PROCEDURE usp_CapNhatLopHoc
    @idLopHoc INT,
    @tenLopHoc NVARCHAR(100),
    @idTLLH INT,
    @idHLV INT,
    @lichHoc NVARCHAR(50),
    @soLuongHV INT,
    @donGia DECIMAL(18,2),
    @ngayBatDau DATE,
    @ngayKetThuc DATE,
    @moTa NVARCHAR(MAX)
   
AS
BEGIN
    UPDATE LopHoc
    SET tenLopHoc = @tenLopHoc,
        idTLLH = @idTLLH,
        idHLV = @idHLV,
        lichHoc = @lichHoc,
        soLuongHV = @soLuongHV,
        donGia = @donGia,
        ngayBatDau = @ngayBatDau,
        ngayKetThuc = @ngayKetThuc,
        moTa = @moTa
       -- idPhongTap = @idPhongTap
    WHERE idLopHoc = @idLopHoc;
END
GO

-- 6. Xóa lớp học
CREATE PROCEDURE usp_XoaLopHoc
    @idLopHoc INT
AS
BEGIN
    DELETE FROM LopHoc
    WHERE idLopHoc = @idLopHoc;
END
GO
--- HLV--
CREATE PROCEDURE LayDanhSachHuanLuyenVien
AS
BEGIN
    SELECT 
        nd.idNguoiDung,
        nd.hoNguoiDung,
        nd.tenNguoiDung,
        nd.gioiTinh,
        nd.ngaySinh,
        nd.sdt,
        nd.email,
        ISNULL(lh.tenLopHoc, N'Chua co lop nao') AS tenLopHoc
    FROM NguoiDung nd
    LEFT JOIN LopHoc lh ON nd.idNguoiDung = lh.idHLV
    WHERE nd.vaiTro = N'Huấn luyện viên'
    ORDER BY nd.idNguoiDung
END
GO
---
CREATE PROCEDURE LayHuanLuyenVienTheoId
    @IdNguoiDung INT
AS
BEGIN
    SELECT 
        nd.idNguoiDung,
        nd.hoNguoiDung,
        nd.tenNguoiDung,
        nd.gioiTinh,
        nd.ngaySinh,
        nd.sdt,
        nd.email,
        ISNULL(lh.tenLopHoc, N'Chua co lop nao') AS tenLopHoc
    FROM NguoiDung nd
    LEFT JOIN LopHoc lh ON nd.idNguoiDung = lh.idHLV
    WHERE nd.vaiTro = N'Huấn luyện viên' AND nd.idNguoiDung = @IdNguoiDung
END
GO
--
CREATE PROCEDURE LayHuanLuyenVienTheoTen
    @TenNguoiDung NVARCHAR(50)
AS
BEGIN
    SELECT 
        nd.idNguoiDung,
        nd.hoNguoiDung,
        nd.tenNguoiDung,
        nd.gioiTinh,
        nd.ngaySinh,
        nd.sdt,
        nd.email,
        ISNULL(lh.tenLopHoc, N'Chua co lop nao') AS tenLopHoc
    FROM NguoiDung nd
    LEFT JOIN LopHoc lh ON nd.idNguoiDung = lh.idHLV
    WHERE nd.vaiTro = N'Huấn luyện viên' AND nd.tenNguoiDung = @TenNguoiDung
END
GO
--
CREATE PROCEDURE GetAllCategories
AS
BEGIN
    SET NOCOUNT ON;
    SELECT idTLLH, tenTLLH
    FROM TheLoai_LopHoc
END
GO


CREATE PROCEDURE uspGetAllNhanVien
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        nd.idNguoiDung        AS User_id,
        nd.username           AS Username,
	    nd.hoNguoiDung        AS HoNguoiDung,
		nd.tenNguoiDung       AS TenNguoiDung,
		(nd.hoNguoiDung + N' ' + nd.tenNguoiDung) AS Full_name,
        nd.gioiTinh           AS Gender,
        nd.ngaySinh           AS DOB,
        nd.sdt                AS Phone,
        nd.email              AS Email,
        nd.diaChi             AS Address, -- no Address column in your schema
        nv.vaiTro             AS Role
    FROM NhanVien nv
    INNER JOIN NguoiDung nd ON nv.idNguoiDung = nd.idNguoiDung;
END
GO

-- 2. Lấy 1 nhân viên theo id (idNguoiDung)
CREATE PROCEDURE uspGetNhanVienById
    @UserId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        nd.idNguoiDung        AS User_id,
        nd.username           AS Username,
         nd.hoNguoiDung        AS HoNguoiDung,
		nd.tenNguoiDung       AS TenNguoiDung,
		(nd.hoNguoiDung + N' ' + nd.tenNguoiDung) AS Full_name,
        nd.ngaySinh           AS DOB,
        nd.sdt                AS Phone,
        nd.email              AS Email,
        nd.diaChi             AS Address,
        nv.vaiTro             AS Role
    FROM NhanVien nv
    INNER JOIN NguoiDung nd ON nv.idNguoiDung = nd.idNguoiDung
    WHERE nd.idNguoiDung = @UserId;
END
GO

-- 3. Tìm kiếm theo tên (Full_name contains)
CREATE PROCEDURE uspSearchNhanVienByName
    @TuKhoa NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        nd.idNguoiDung        AS User_id,
        nd.username           AS Username,
        nd.hoNguoiDung        AS HoNguoiDung,
		nd.tenNguoiDung       AS TenNguoiDung,
		(nd.hoNguoiDung + N' ' + nd.tenNguoiDung) AS Full_name,
        nd.gioiTinh           AS Gender,
        nd.ngaySinh           AS DOB,
        nd.sdt                AS Phone,
        nd.email              AS Email,
        nd.diaChi             AS Address,
        nv.vaiTro             AS Role
    FROM NhanVien nv
    INNER JOIN NguoiDung nd ON nv.idNguoiDung = nd.idNguoiDung
    WHERE (nd.hoNguoiDung + N' ' + nd.tenNguoiDung) LIKE N'%' + @TuKhoa + N'%';
END
GO

-- 4. Tìm kiếm theo số điện thoại
CREATE PROCEDURE uspSearchNhanVienByPhone
    @TuKhoa NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        nd.idNguoiDung        AS User_id,
        nd.username           AS Username,
         nd.hoNguoiDung        AS HoNguoiDung,
		nd.tenNguoiDung       AS TenNguoiDung,
		(nd.hoNguoiDung + N' ' + nd.tenNguoiDung) AS Full_name,
        nd.gioiTinh           AS Gender,
        nd.ngaySinh           AS DOB,
        nd.sdt                AS Phone,
        nd.email              AS Email,
        nd.diaChi             AS Address,
        nv.vaiTro             AS Role
    FROM NhanVien nv
    INNER JOIN NguoiDung nd ON nv.idNguoiDung = nd.idNguoiDung
    WHERE nd.sdt LIKE '%' + @TuKhoa + '%';
END
GO

-- 5. Kiểm tra trùng username hoặc email 
CREATE PROCEDURE uspKiemTraTrung
    @Username NVARCHAR(50),
    @Email NVARCHAR(100),
    @Count INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT @Count = COUNT(*)
    FROM NguoiDung
    WHERE username = @Username OR email = @Email;
END
GO

-- 6. Thêm người dùng + thêm nhân viên 
CREATE PROCEDURE uspAddNhanVien
    @Username NVARCHAR(50),
    @Password NVARCHAR(100),
    @HoNV NVARCHAR(50),
    @TenNV NVARCHAR(50),
    @GioiTinh NVARCHAR(10) = NULL,
    @DOB DATETIME = NULL,
    @Phone NVARCHAR(20) = NULL,
    @Email NVARCHAR(100),
	
	@Address NVARCHAR(50)= NULL,
    @Role NVARCHAR(50),
    @NewUserId INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO NguoiDung (hoNguoiDung, tenNguoiDung, gioiTinh, ngaySinh, sdt, email, diaChi, username, password, vaiTro)
    VALUES (@HoNV, @TenNV, @GioiTinh, @DOB, @Phone, @Email,@Address, @Username, @Password, @Role);

    SET @NewUserId = SCOPE_IDENTITY();

    INSERT INTO NhanVien (idNguoiDung, vaiTro) VALUES (@NewUserId, @Role);
END
GO

-- 7. Cập nhật người dùng + nhân viên
CREATE PROCEDURE uspUpdateNhanVien
    @UserId INT,
    @Username NVARCHAR(50),
    @HoNV NVARCHAR(50),
    @TenNV NVARCHAR(50),
    @GioiTinh NVARCHAR(10) = NULL,
    @DOB DATETIME = NULL,
    @Phone NVARCHAR(20) = NULL,
    @Email NVARCHAR(100),
    @Password NVARCHAR(20) = NULL,  -- Cho phép null
    @Address NVARCHAR(50)= NULL,
    @Role NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE NguoiDung
    SET username = @Username,
        hoNguoiDung = @HoNV,
        tenNguoiDung = @TenNV,
        gioiTinh = @GioiTinh,
        ngaySinh = @DOB,
        sdt = @Phone,
        diaChi= @Address,
        email = @Email,
        password = CASE WHEN @Password IS NULL THEN password ELSE @Password END, -- Giữ nguyên nếu NULL
        vaiTro = @Role
    WHERE idNguoiDung = @UserId;

    UPDATE NhanVien
    SET vaiTro = @Role
    WHERE idNguoiDung = @UserId;

    SELECT @@ROWCOUNT;
END
GO


-- 8. Xóa nhân viên 

CREATE PROCEDURE uspDeleteNhanVien
    @UserId INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM NhanVien WHERE idNguoiDung = @UserId;

    DELETE FROM NguoiDung WHERE idNguoiDung = @UserId;

    SELECT @@ROWCOUNT;  -- trả về số dòng bị xóa ở bảng NguoiDung
END
GO


-- 9. Thêm vào NhanVien 
CREATE PROCEDURE uspThemVaoEmployees
    @UserId INT,
    @Role NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO NhanVien (idNguoiDung, vaiTro) VALUES (@UserId, @Role);
END
GO