select QuiDinh, DoiTuong, GiaTri from Config

insert into Config(QuiDinh, DoiTuong, GiaTri)values(N'QD1.1', N'Số lượng khám trong ngày', 40)

insert into Config(QuiDinh, DoiTuong, GiaTri)values(N'QD2.1', N'Số loại bệnh', 5)
insert into Config(QuiDinh, DoiTuong, GiaTri)values(N'QD2.2', N'Số thuốc', 30)
insert into Config(QuiDinh, DoiTuong, GiaTri)values(N'QD2.3', N'Số đơn vị tính', 2)--(viên, chai)
insert into Config(QuiDinh, DoiTuong, GiaTri)values(N'QD2.4', N'Số cách dùng', 4)-- cách dùng (1, 2, 3, 4)

insert into Config(QuiDinh, DoiTuong, GiaTri)values(N'QD4.1', N'Tiền khám', 30000)
insert into Config(QuiDinh, DoiTuong, GiaTri)values(N'QD4.2', N'Tiền thuốc', -1)

--QĐ1: Mỗi ngày chỉ khám tối đa 40 bệnh nhân
--QĐ2: Có 5 loại bệnh. Có 30 loại thuốc, 2 loại đơn vị (viên, chai), có 4 cách dùng (1, 2, 3, 4)
--QĐ4: Tiền khám 30.000. Tiến thuốc chỉ có khi bệnh nhân có dùng thuốc. Mỗi loại thuốc có đơn giá riêng.
--QĐ6: Ngƣời dùng có thể thay đổi các quy định nhƣ sau:
----QĐ1: Thay đổi số lƣợng bệnh nhân tối đa trong ngày.
----QĐ2: Thay đổi số lƣợng loại bệnh, thuốc, đơn vị tính, cách dùng
----QĐ4: Thay đổi tiền khám, đơn giá thuốc

Alter table DSKhamBenh add NgaySinh datetime;

