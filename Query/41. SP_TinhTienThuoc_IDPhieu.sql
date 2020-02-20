Create PROC [dbo].[SP_TinhTienThuoc_IDPhieu]
@idPhieu bigint
AS
BEGIN

	
select ISNULL(sum( t.GIa), 0) as TienThuoc
from ChiTietPhieuKhamBenh as ct
inner join Thuoc as t on ct.IDThuoc = t.ID
where ct.IDPhieu = @idPhieu


END
