Alter PROC [dbo].[SP_ReadNhanVien]
AS
BEGIN
	select ID, Ma,HoTen, GioiTinh as Nam,
						 (Case when GioiTinh = 1 then 0 else 1 end) as Nu
		, NgaySinh, DiaChi, ChucVuText as ChucVu, Username, ChucVu as IDChucVu
	from NhanVien
	order by Ma, HoTen
END
