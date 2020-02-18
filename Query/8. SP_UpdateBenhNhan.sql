
Create PROC [dbo].[SP_UpdateBenhNhan]
@ma nvarchar(20),
@hoTen nvarchar(100),
@gioiTinh int,
@ngaySinh datetime,
@diaChi nvarchar(250),
@id int
as
Declare @resurlt int
Begin tran
	begin try
	set @resurlt= 0
		
		if Exists(select ID From BenhNhan where Ma = @ma and ID <> @id)
		begin
			set @resurlt= -2
		end
		else
		begin

		update BenhNhan set Ma = @ma , HoTen = @hoTen, GioiTinh = @gioiTinh, NgaySinh = @ngaySinh, DiaChi = @diaChi
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