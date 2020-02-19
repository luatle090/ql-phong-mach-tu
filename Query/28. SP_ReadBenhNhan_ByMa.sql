
Create PROC [dbo].[SP_ReadBenhNhan_ByMa]
@ma nvarchar(50)
AS
BEGIN

	select ID, Ma,HoTen, GioiTinh as Nam,
						 (Case when GioiTinh = 1 then 0 else 1 end) as Nu, NgaySinh, DiaChi
	 from BenhNhan
	 where Ma = @ma
	
END
