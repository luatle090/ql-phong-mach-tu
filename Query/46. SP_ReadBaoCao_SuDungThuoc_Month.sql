
Alter PROC [dbo].[SP_ReadBaoCao_SuDungThuoc_Month]
@month datetime
AS
BEGIN

declare @thang int
declare @nam int
set @thang = MONTH(@month)
set @nam = YEAR(@month)

	select ROW_NUMBER() OVER (ORDER BY t.TenThuoc) AS STT,
		 t.TenThuoc, dvt.TenDonViTinh, ct.SoLuong, cd.TenCachDung
	from ChiTietPhieuKhamBenh as ct
	inner join PhieuKhamBenh as p on ct.IDPhieu = p.ID
	inner join Thuoc as t on ct.IDThuoc = t.ID
	inner join DonViTinh as dvt on ct.IDDonViThuoc = dvt.ID
	inner join CachDung as cd on ct.IDCachDung = cd.ID
	where MONTH(p.NgayKham) = @Thang and Year(p.NgayKham) = @Nam
	group by t.TenThuoc, dvt.TenDonViTinh, ct.SoLuong, cd.TenCachDung
END
