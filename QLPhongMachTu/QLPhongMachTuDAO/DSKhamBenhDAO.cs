using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Provider;
using QLPhongMachTuDTO;

namespace QLPhongMachTuDAO
{
    public class DSKhamBenhDAO
    {
        public DataTable LoadData(DateTime _time, bool _isAll)
        {
            DataProvider db = new DataProvider();
            return db.ReadDataAddPram("SP_ReadDSKhamBenh", new string[2] { "@ngayKham", "@isAll"}
                                                         , new object[2] { _time, _isAll }, 100);
        }

        //
        public int SoLuongKhamTrongNgay(DateTime _time)
        {
            DataProvider db = new DataProvider();
            DataTable dt = new DataTable();
            dt = db.ReadDataAddPram("SP_ReadSoLuongKhamBenh_Ngay", new string[1] { "@ngayKham"}, new object[1] { _time}, 100);

            return Convert.ToInt32(dt.Rows[0]["Value"].ToString());
        }

        public Int64 Insert(DSKhamBenhDTO _nv)
        {
            Int64 idBenhNhan = _nv.benhNhan.id;
            //them benh nhan neu chua co
            if (_nv.benhNhan.id < 1)
            {
                BenhNhanDAO bnDAO = new BenhNhanDAO();
                idBenhNhan = bnDAO.Insert(_nv.benhNhan);
            }

            string[] str = new string[7];
            object[] val = new object[7];

            str[0] = "@ngayKham";
            str[1] = "@hoTen";
            str[2] = "@gioiTinh";
            str[3] = "@diaChi";
            str[4] = "@ngaySinh";
            str[5] = "@idBenhNhan";
            str[6] = "@idNhanVien";

            val[0] = _nv.ngayKham;
            val[1] = _nv.benhNhan.hoTen;
            val[2] = _nv.benhNhan.gioiTinh;
            val[3] = _nv.benhNhan.diaChi;
            val[4] = _nv.benhNhan.ngaySinh;
            val[5] = idBenhNhan;
            val[6] = _nv.idNhanVien;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_InsertDSKhamBenh", str, val, 50);
        }

        public Int64 Update(DSKhamBenhDTO _nv)
        {
            string[] str = new string[7];
            object[] val = new object[7];

            str[0] = "@id";
            str[1] = "@hoTen";
            str[2] = "@gioiTinh";
            str[3] = "@diaChi";
            str[4] = "@ngaySinh";
            str[5] = "@idBenhNhan";
            str[6] = "@idNhanVien";

            val[0] = _nv.id;
            val[1] = _nv.benhNhan.hoTen;
            val[2] = _nv.benhNhan.gioiTinh;
            val[3] = _nv.benhNhan.diaChi;
            val[4] = _nv.benhNhan.ngaySinh;
            val[5] = _nv.benhNhan.id;
            val[6] = _nv.idNhanVien;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_UpdateDSKhamBenh", str, val, 50);
        }

        public Int64 Delete(int _id)
        {
            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_DeleteDSKhamBenh", new string[1] { "@id" }, new object[1] { _id }, 50);
        }
    }
}
