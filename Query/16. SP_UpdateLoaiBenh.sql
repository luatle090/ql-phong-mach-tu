
Alter PROC [dbo].[SP_UpdateLoaiBenh]
@ten nvarchar(100),
@id int
as
Declare @resurlt int
Begin tran
	begin try
	set @resurlt= 0
		
		update LoaiBenh set LoaiBenh = @ten
		where ID = @id
		
		set @resurlt=@id
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt