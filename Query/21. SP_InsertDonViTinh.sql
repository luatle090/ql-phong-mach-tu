
Create PROC [dbo].[SP_InsertDonViTinh]
@ten nvarchar(100)

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		insert into DonViTinh(TenDonViTinh)
		values(@ten)

		set @resurlt=(select @@Identity)

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt