
Alter PROC [dbo].[SP_ReadPhieuKhamBenh]
@ngayKham datetime,
@isAll bit
AS
BEGIN

if (@isAll = 1)
begin

	select p.ID, p.NgayKham, bn.Ma, ds.HoTen 
		,ds.GioiTinh as Nam, (Case when ds.GioiTinh = 1 then 0 else 1 end) as Nu
		, ds.NgaySinh, p.TrieuChung, b.LoaiBenh, nv.HoTen as NhanVien
		, p.IDNhanVien, p.IDDoanBenh
	from PhieuKhamBenh as p
	inner join DSKhamBenh as ds on ds.ID = p.IDBenhNhan
	inner join BenhNhan as bn on ds.IDBenhNhan = bn.ID
	inner join LoaiBenh as b on p.IDDoanBenh = b.ID
	inner join NhanVien as nv on p.IDNhanVien = nv.ID
	order by p.NgayKham
end
else
begin
	select p.ID, p.NgayKham, bn.Ma, ds.HoTen 
		,ds.GioiTinh as Nam, (Case when ds.GioiTinh = 1 then 0 else 1 end) as Nu
		, ds.NgaySinh, p.TrieuChung, b.LoaiBenh, nv.HoTen as NhanVien
		, p.IDNhanVien, p.IDDoanBenh
	from PhieuKhamBenh as p
	inner join DSKhamBenh as ds on ds.ID = p.IDBenhNhan
	inner join BenhNhan as bn on ds.IDBenhNhan = bn.ID
	inner join LoaiBenh as b on p.IDDoanBenh = b.ID
	inner join NhanVien as nv on p.IDNhanVien = nv.ID
	where p.NgayKham = @ngayKham
	order by p.NgayKham

end
	
	
END
