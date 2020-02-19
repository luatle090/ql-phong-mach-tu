
Create PROC [dbo].[SP_ReadDSKhamBenh]
@ngayKham datetime,
@isAll bit
AS
BEGIN

if (@isAll = 1)
begin
	select ds.ID, ds.NgayKham, bn.Ma, ds.HoTen
		,ds.GioiTinh as Nam, (Case when ds.GioiTinh = 1 then 0 else 1 end) as Nu
		, ds.NgaySinh, ds.DiaChi
		, ds.IDBenhNhan, ds.IDNhanVien
	 from DSKhamBenh as ds
	 inner join BenhNhan as bn on ds.IDBenhNhan = bn.ID
	 order by ds.NgayKham
end
else
begin
	select ds.ID, ds.NgayKham, bn.Ma, ds.HoTen
		,ds.GioiTinh as Nam, (Case when ds.GioiTinh = 1 then 0 else 1 end) as Nu
		, ds.NgaySinh, ds.DiaChi
		, ds.IDBenhNhan, ds.IDNhanVien
	 from DSKhamBenh as ds
	 inner join BenhNhan as bn on ds.IDBenhNhan = bn.ID
	 where NgayKham = @ngayKham
	 order by ds.NgayKham
end
	
	
END
