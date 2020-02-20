
Create PROC [dbo].[SP_InsertCTThuocKham]
@idPhieu bigint,
@idThuoc int,
@soLuong float,
@idDVT int,
@idCachDung int

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		insert into ChiTietPhieuKhamBenh(IDPhieu, IDThuoc, SoLuong, IDDonViThuoc, IDCachDung)
		values(@idPhieu, @idThuoc, @soLuong, @idDVT, @idCachDung)

		set @resurlt=(select @@Identity)

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt