
Alter PROC [dbo].[SP_UpdatePhieuKhamBenh]
@idDSKham bigint,
@ngayKham datetime,
@trieuChung nvarchar(250),
@idDoanBenh int,
@idNhanVien int,
@id bigint
as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		update PhieuKhamBenh
		set TrieuChung = @trieuChung, IDDoanBenh = @idDoanBenh, IDNhanVien= @idNhanVien
		where ID = @id

		set @resurlt= @id

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt