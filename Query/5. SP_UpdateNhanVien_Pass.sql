
Alter PROC [dbo].[SP_UpdateNhanVien_Pass]

@username nvarchar(50),
@pass nvarchar(50),
@id int
as
Declare @resurlt int
Begin tran
	begin try
	set @resurlt= 0
		
		if not Exists(select ID From NhanVien where Username = @username and ID = @id)
		begin
			set @resurlt= -1
		end
		else
		begin

		update NhanVien set Pass = @pass
		where ID = @id
		
		set @resurlt=@id

		end
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt