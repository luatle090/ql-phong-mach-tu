
Alter PROC [dbo].[SP_UpdateCachDung]
@ten nvarchar(100),
@moTa nvarchar(100),
@id int
as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		update CachDung set TenCachDung = @ten, MoTa = @moTa
		where ID = @id



		set @resurlt=@id

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt