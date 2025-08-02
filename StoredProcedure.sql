USE QlGym
GO

CREATE PROC TheLoaiLopHoc_Insert
@idTLLH int,
@tenTLLH nvarchar(20)
AS
BEGIN
	INSERT INTO TheLoai_LopHoc VALUES (@tenTLLH)
END	
GO

CREATE PROC TheLoaiLopHoc_Update
@idTLLH int,
@tenTLLH nvarchar(20)
AS
BEGIN
	UPDATE TheLoai_LopHoc
	SET tenTLLH = @tenTLLH
	WHERE idTLLH = @idTLLH 
END
GO

CREATE PROC TheLoaiLopHoc_Delete
@idTLLH int
AS
BEGIN
	DELETE TheLoai_LopHoc
	WHERE idTLLH = @idTLLH 
END
GO

CREATE PROC TheLoaiLopHoc_SelectAll
AS
BEGIN
	SELECT * FROM TheLoai_LopHoc
END
GO

CREATE PROC TheLoaiLopHoc_SelectById
@idTLLH int
AS
BEGIN
	SELECT * FROM TheLoai_LopHoc
	WHERE idTLLH = @idTLLH 
END
GO