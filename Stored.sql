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
