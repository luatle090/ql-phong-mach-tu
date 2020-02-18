
Alter PROC [dbo].[SP_UpdateThuoc]
@tenThuoc nvarchar(100),
@gia money,
@id int
as
Declare @resurlt int
Begin tran
	begin try
	set @resurlt= 0
		
		update Thuoc set TenThuoc = @tenThuoc, GIa = @gia
		where ID = @id
		
		set @resurlt=@id
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt