
Create PROC [dbo].[SP_ReadCachDung]
AS
BEGIN

	select ID, TenCachDung, MoTa from CachDung
	order by TenCachDung

	
END
