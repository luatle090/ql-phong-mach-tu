
Alter PROC [dbo].[SP_InsertThanhToan]
@idPhieu bigint,
@tienKham money,
@tienThuoc money,
@hoTen nvarchar(50),
@ngayThanhToan datetime,
@idNhanVien int
as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		if Exists(select ID from HoaDonThanhToan where IDPhieu =  @idPhieu)
		begin
			set @resurlt= -2
		end
		else
		begin
			insert into HoaDonThanhToan(IDPhieu, TienKham, TienThuoc, HoTen, NgayKham, IDNhanVien)
			values(@idPhieu, @tienKham, @tienThuoc, @hoTen, @ngayThanhToan, @idNhanVien)

			set @resurlt=(select @@Identity)
		end

		

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt