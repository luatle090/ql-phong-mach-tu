
Create PROC [dbo].[SP_ReadThuoc]
AS
BEGIN

	select ID, TenThuoc, GIa as Gia from Thuoc
	order by TenThuoc

	
END
