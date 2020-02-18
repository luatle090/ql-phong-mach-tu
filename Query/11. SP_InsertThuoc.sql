
Create PROC [dbo].[SP_InsertThuoc]
@tenThuoc nvarchar(100),
@gia money

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		insert into Thuoc(TenThuoc, GIa)
		values(@tenThuoc, @gia)

		set @resurlt=(select @@Identity)

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt