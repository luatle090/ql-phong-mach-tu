
Create PROC [dbo].[SP_DeleteBenhNhan]
@id int

as
Declare @resurlt int
Begin tran
	begin try
		Delete from BenhNhan where ID = @id 
		set @resurlt= 1
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt