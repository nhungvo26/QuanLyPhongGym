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


