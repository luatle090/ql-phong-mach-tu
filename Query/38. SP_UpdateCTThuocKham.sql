
Alter PROC [dbo].[SP_UpdateCTThuocKham]
@idPhieu bigint,
@idThuoc int,
@soLuong float,
@idDVT int,
@idCachDung int,
@id bigint

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		update ChiTietPhieuKhamBenh
		set IDThuoc = @idThuoc, SoLuong =  @soLuong, IDDonViThuoc =  @idDVT, IDCachDung = @idCachDung
		where ID = @id
		set @resurlt= @id

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt