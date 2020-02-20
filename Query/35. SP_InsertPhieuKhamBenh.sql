
Create PROC [dbo].[SP_InsertPhieuKhamBenh]
@idDSKham bigint,
@ngayKham datetime,
@trieuChung nvarchar(250),
@idDoanBenh int,
@idNhanVien int
as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		insert into PhieuKhamBenh(IDBenhNhan, NgayKham, TrieuChung, IDDoanBenh, IDNhanVien)
		values(@idDSKham, @ngayKham, @trieuChung, @idDoanBenh, @idNhanVien)

		set @resurlt=(select @@Identity)

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt