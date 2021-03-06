
Alter PROC [dbo].[SP_InsertNhanVien]
@ma nvarchar(20),
@hoTen nvarchar(100),
@gioiTinh int,
@ngaySinh datetime,
@diaChi nvarchar(250),
@chucVu int,
@username nvarchar(50),
@pass nvarchar(50),
@chuVuText nvarchar(50)

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		if Exists(select ID From NhanVien where Ma = @ma or Username = @username)
		begin
			set @resurlt= -2
		end
		else
		begin

		insert into NhanVien(Ma, HoTen, GioiTinh, NgaySinh, DiaChi, ChucVu, Username, Pass, ChucVuText)
		values(@ma, @hoTen, @gioiTinh, @ngaySinh, @diaChi, @chucVu, @username, @pass, @chuVuText)

		set @resurlt=(select @@Identity)

		end
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt