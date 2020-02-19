
Create PROC [dbo].[SP_ReadDonViTinh]
AS
BEGIN

	select ID, TenDonViTinh from DonViTinh
	order by TenDonViTinh
	
END
	