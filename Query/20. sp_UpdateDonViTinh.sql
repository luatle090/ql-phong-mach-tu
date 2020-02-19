
ALTER PROC [dbo].[sp_UpdateDonViTinh]
@ten nvarchar(100),
@id int
as
Declare @resurlt int
Begin tran
	begin try
	set @resurlt= 0
		
		update DonViTinh set TenDonViTinh = @ten
		where ID = @id
		
		set @resurlt=@id
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt