
Create PROC [dbo].[SP_ReadThanhToan]
@ngayThanhToan datetime,
@isAll bit
AS
BEGIN

if (@isAll = 1)
begin

	select tt.NgayKham as NgayThanhToan , tt.HoTen, p.NgayKham, tt.TienKham, tt.TienThuoc
	from HoaDonThanhToan as tt
	inner join PhieuKhamBenh as p on tt.IDPhieu = p.ID
	order by tt.NgayKham
end
else
begin
	select tt.NgayKham as NgayThanhToan , tt.HoTen, p.NgayKham, tt.TienKham, tt.TienThuoc
	from HoaDonThanhToan as tt
	inner join PhieuKhamBenh as p on tt.IDPhieu = p.ID
	where tt.NgayKham = @ngayThanhToan
	order by tt.NgayKham

end
	
	
END
