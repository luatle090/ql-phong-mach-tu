using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Provider;
using QLPhongMachTuDTO;

namespace QLPhongMachTuBUS
{
    public class PhieuKhamBenhDAO
    {
        public DataTable LoadData(DateTime _time, bool _isAll)
        {
            DataProvider db = new DataProvider();
            return db.ReadDataAddPram("SP_ReadPhieuKhamBenh", new string[2] { "@ngayKham", "@isAll" }
                                                         , new object[2] { _time, _isAll }, 100);
        }

        public Int64 Insert(PhieuKhamBenhDTO _nv)
        {
            string[] str = new string[5];
            object[] val = new object[5];

            str[0] = "@idDSKham";
            str[1] = "@ngayKham";
            str[2] = "@trieuChung";
            str[3] = "@idDoanBenh";
            str[4] = "@idNhanVien";

            val[0] = _nv.idDSKhamBenh;
            val[1] = _nv.ngayKham;
            val[2] = _nv.trieuChung;
            val[3] = _nv.idDoanBenh;
            val[4] = _nv.idNhanVien;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_InsertPhieuKhamBenh", str, val, 50);
        }

        public Int64 Update(PhieuKhamBenhDTO _nv)
        {
            string[] str = new string[6];
            object[] val = new object[6];

            str[0] = "@idDSKham";
            str[1] = "@ngayKham";
            str[2] = "@trieuChung";
            str[3] = "@idDoanBenh";
            str[4] = "@idNhanVien";
            str[5] = "@id";

            val[0] = _nv.idDSKhamBenh;
            val[1] = _nv.ngayKham;
            val[2] = _nv.trieuChung;
            val[3] = _nv.idDoanBenh;
            val[4] = _nv.idNhanVien;
            val[5] = _nv.id;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_UpdatePhieuKhamBenh", str, val, 50);
        }

        public Int64 Delete(Int64 _id)
        {
            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_DeletePhieuKhamBenh", new string[1] { "@id" }, new object[1] { _id }, 50);
        }
    }
}
