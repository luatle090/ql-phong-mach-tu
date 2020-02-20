Create PROC [dbo].[SP_ReadCTThuocKham_IDPhieu]
@idPhieu bigint
AS
BEGIN

	select ct.ID, t.TenThuoc, ct.SoLuong, dvt.TenDonViTinh, cd.TenCachDung,
			ct.IDThuoc, ct.IDDonViThuoc, ct.IDCachDung
	from ChiTietPhieuKhamBenh as ct
	inner join Thuoc as t on ct.IDThuoc = t.ID
	inner join DonViTinh as dvt on ct.IDDonViThuoc = dvt.ID
	inner join CachDung as cd on ct.IDCachDung = cd.ID
	where ct.IDPhieu = @idPhieu


END
