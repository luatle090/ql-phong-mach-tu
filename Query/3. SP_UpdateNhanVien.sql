
Alter PROC [dbo].[SP_UpdateNhanVien]
@ma nvarchar(20),
@hoTen nvarchar(100),
@gioiTinh int,
@ngaySinh datetime,
@diaChi nvarchar(250),
@chucVu int,
--@username nvarchar(50),
--@pass nvarchar(50),
@id int,
@chuVuText nvarchar(50)
as
Declare @resurlt int
Begin tran
	begin try
	set @resurlt= 0
		
		if Exists(select ID From NhanVien where Ma = @ma and ID <> @id)
		begin
			set @resurlt= -2
		end
		else
		begin

		update NhanVien set Ma = @ma , HoTen = @hoTen, GioiTinh = @gioiTinh, NgaySinh = @ngaySinh, DiaChi = @diaChi
			, ChucVu = @chucVu, ChucVuText = @chuVuText
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