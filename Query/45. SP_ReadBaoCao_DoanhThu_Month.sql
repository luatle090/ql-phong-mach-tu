
Alter PROC [dbo].[SP_ReadBaoCao_DoanhThu_Month]
@month datetime
AS
BEGIN

declare @thang int
declare @nam int
set @thang = MONTH(@month)
set @nam = YEAR(@month)

	select  ROW_NUMBER() OVER (ORDER BY NgayKham) AS STT
		,NgayKham, COUNT(HoTen) as SoBenhNhan, sum(TienKham + TienThuoc) as DoanhThu, 0 as TyLe
	from HoaDonThanhToan
	where (MONTH(NgayKham) = @thang and  YEAR(NgayKham) = @nam)
	group by NgayKham

END
