
Alter PROC [dbo].[SP_UpdateDSKhamBenh]
@id int,
@hoTen nvarchar(50),
@gioiTinh int,
@diaChi nvarchar(250),
@ngaySinh datetime,
--@idBenhNhan int,
@idNhanVien int
as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		update DSKhamBenh
		set HoTen = @hoTen, GioiTinh = @gioiTinh, DiaChi = @diaChi, NgaySinh = @ngaySinh, IDNhanVien = @idNhanVien
		where ID = @id

		set @resurlt= @id

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt