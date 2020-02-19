
Create PROC [dbo].[SP_InsertDSKhamBenh]
@ngayKham datetime,
@hoTen nvarchar(50),
@gioiTinh int,
@diaChi nvarchar(250),
@ngaySinh datetime,
@idBenhNhan int,
@idNhanVien int
as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		insert into DSKhamBenh(NgayKham, HoTen, GioiTinh, DiaChi, NgaySinh, IDBenhNhan, IDNhanVien)
		values(@ngayKham, @hoTen, @gioiTinh, @diaChi, @ngaySinh, @idBenhNhan, @idNhanVien)

		set @resurlt=(select @@Identity)

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt