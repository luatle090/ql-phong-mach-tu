
Create PROC [dbo].[SP_ReadSoLuongKhamBenh_Ngay]
@ngayKham datetime
AS
BEGIN

	select COUNT(ID) as Value from DSKhamBenh where NgayKham = @ngayKham
	
END
