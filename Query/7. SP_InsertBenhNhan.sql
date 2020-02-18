
Create PROC [dbo].[SP_InsertBenhNhan]
@ma nvarchar(20),
@hoTen nvarchar(100),
@gioiTinh int,
@ngaySinh datetime,
@diaChi nvarchar(250)

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		if Exists(select ID From BenhNhan where Ma = @ma)
		begin
			set @resurlt= -2
		end
		else
		begin

		insert into BenhNhan(Ma, HoTen, GioiTinh, NgaySinh, DiaChi)
		values(@ma, @hoTen, @gioiTinh, @ngaySinh, @diaChi)

		set @resurlt=(select @@Identity)

		end
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt