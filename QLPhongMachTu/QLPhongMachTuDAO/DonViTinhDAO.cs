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
    public class DonViTinhDAO
    {
        public DataTable LoadData()
        {
            DataProvider db = new DataProvider();
            return db.ReadDataNoParam("SP_ReadDonViTinh", 100);
        }

        public Int64 Insert(DonViTinhDTO _nv)
        {
            string[] str = new string[1];
            object[] val = new object[1];

            str[0] = "@ten";
            val[0] = _nv.ten;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_InsertDonViTinh", str, val, 50);
        }

        public Int64 Update(DonViTinhDTO _nv)
        {
            string[] str = new string[2];
            object[] val = new object[2];

            str[0] = "@ten";
            val[0] = _nv.ten;

            str[1] = "@id";
            val[1] = _nv.id;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_UpdateDonViTinh", str, val, 50);
        }

        public Int64 Delete(int _id)
        {
            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_DeleteDonViTinh", new string[1] { "@id" }, new object[1] { _id }, 50);
        }
    }
}
