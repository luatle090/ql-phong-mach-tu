
Alter PROC [dbo].[SP_DeletePhieuKhamBenh]
@id int

as
Declare @resurlt int
Begin tran
	begin try
		
		if Exists(select ID from HoaDonThanhToan where IDPhieu = @id)
		begin
			set @resurlt = -2
		end
		else
		begin
			Delete from ChiTietPhieuKhamBenh where IDPhieu = @id 
			Delete from PhieuKhamBenh where ID = @id 
			set @resurlt= 1
		end

		
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt