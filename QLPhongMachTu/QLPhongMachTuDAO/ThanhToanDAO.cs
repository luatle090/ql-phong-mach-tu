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
    public class ThanhToanDAO
    {
        public DataTable LoadData(DateTime _time, bool _isAll)
        {
            DataProvider db = new DataProvider();
            return db.ReadDataAddPram("SP_ReadThanhToan", new string[2] { "@ngayThanhToan", "@isAll" }
                                                         , new object[2] { _time, _isAll }, 100);
        }

        public Int64 Insert(ThanhToanDTO _nv)
        {
            string[] str = new string[6];
            object[] val = new object[6];

            str[0] = "@idPhieu";
            str[1] = "@tienKham";
            str[2] = "@tienThuoc";
            str[3] = "@hoTen";
            str[4] = "@ngayThanhToan";
            str[5] = "@idNhanVien";

            val[0] = _nv.idPhieu;
            val[1] = _nv.tienKham;
            val[2] = _nv.tienThuoc;
            val[3] = _nv.hoTen;
            val[4] = _nv.ngayThanhToan;
            val[5] = _nv.idNhanVien;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_InsertThanhToan", str, val, 50);
        }

    }
}
