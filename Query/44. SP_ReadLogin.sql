CREATE PROC [dbo].[SP_ReadLogin]
@username nvarchar(50),
@pass nvarchar(50)
AS
BEGIN

	select top 1 id, HoTen, Ma, ChucVu, ChucVuText
	from NhanVien
	where Username = @username and pass = @pass;
END
