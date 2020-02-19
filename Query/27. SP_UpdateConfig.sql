
Create PROC [dbo].[SP_UpdateConfig]
@quiDinh nvarchar(100),
@giaTri int
as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		update Config set GiaTri = @giaTri
		where QuiDinh = @quiDinh

		set @resurlt=1

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt