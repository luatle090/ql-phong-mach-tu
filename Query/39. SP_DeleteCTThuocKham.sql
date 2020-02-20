
Create PROC [dbo].[SP_DeleteCTThuocKham]

@id bigint

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		delete from ChiTietPhieuKhamBenh  where ID = @id
		
		set @resurlt= 1

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt