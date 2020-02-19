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
    public class CachDungDAO
    {
        public DataTable LoadData()
        {
            DataProvider db = new DataProvider();
            return db.ReadDataNoParam("SP_ReadCachDung", 100);
        }

        public Int64 Insert(CachDungDTO _nv)
        {
            string[] str = new string[2];
            object[] val = new object[2];

            str[0] = "@ten";
            val[0] = _nv.ten;

            str[1] = "@moTa";
            val[1] = _nv.moTa;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_InsertCachDung", str, val, 50);
        }

        public Int64 Update(CachDungDTO _nv)
        {
            string[] str = new string[3];
            object[] val = new object[3];

            str[0] = "@ten";
            val[0] = _nv.ten;

            str[1] = "@moTa";
            val[1] = _nv.moTa;

            str[2] = "@id";
            val[2] = _nv.id;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_UpdateCachDung", str, val, 50);
        }

        public Int64 Delete(int _id)
        {
            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_DeleteCachDung", new string[1] { "@id" }, new object[1] { _id }, 50);
        }
    }
}
