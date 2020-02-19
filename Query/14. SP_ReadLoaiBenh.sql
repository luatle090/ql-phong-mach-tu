
Create PROC [dbo].[SP_ReadLoaiBenh]
AS
BEGIN

	select ID, LoaiBenh from LoaiBenh
	order by LoaiBenh

	
END
