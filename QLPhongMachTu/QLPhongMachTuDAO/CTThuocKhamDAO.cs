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
    public class CTThuocKhamDAO
    {
        public DataTable LoadData(Int64 _idPhieu)
        {
            DataProvider db = new DataProvider();
            return db.ReadDataAddPram("SP_ReadCTThuocKham_IDPhieu", new string[1] { "@idPhieu"}, new object[1] { _idPhieu} ,100);
        }

        public Int64 Insert(CTThuocKhamDTO _nv)
        {
            string[] str = new string[5];
            object[] val = new object[5];

            str[0] = "@idPhieu";
            str[1] = "@idThuoc";
            str[2] = "@soLuong";
            str[3] = "@idDVT";
            str[4] = "@idCachDung";
           
            val[0] = _nv.idPhieu;
            val[1] = _nv.idThuoc;
            val[2] = _nv.soLuong;
            val[3] = _nv.idDVT;
            val[4] = _nv.idCachDung;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_InsertCTThuocKham", str, val, 50);
        }

        public Int64 Update(CTThuocKhamDTO _nv)
        {
            string[] str = new string[6];
            object[] val = new object[6];

            str[0] = "@idPhieu";
            str[1] = "@idThuoc";
            str[2] = "@soLuong";
            str[3] = "@idDVT";
            str[4] = "@idCachDung";
            str[5] = "@id";

            val[0] = _nv.idPhieu;
            val[1] = _nv.idThuoc;
            val[2] = _nv.soLuong;
            val[3] = _nv.idDVT;
            val[4] = _nv.idCachDung;
            val[5] = _nv.id;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_UpdateCTThuocKham", str, val, 50);
        }

        public Int64 Delete(Int64 _id)
        {
            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_DeleteCTThuocKham", new string[1] { "@id" }, new object[1] { _id }, 50);
        }
    }
}
