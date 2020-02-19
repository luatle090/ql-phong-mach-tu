
Alter PROC [dbo].[SP_DeleteDonViTinh]
@id int

as
Declare @resurlt int
Begin tran
	begin try
		Delete from DonViTinh where ID = @id 
		set @resurlt= 1
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt