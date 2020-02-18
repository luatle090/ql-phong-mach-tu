
Create PROC [dbo].[SP_ReadBenhNhan]
AS
BEGIN

	select ID, Ma,HoTen, GioiTinh as Nam,
						 (Case when GioiTinh = 1 then 0 else 1 end) as Nu, NgaySinh, DiaChi
	 from BenhNhan
	 order by Ma, HoTen

	
END
