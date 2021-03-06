﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Provider;
using QLPhongMachTuDTO;

namespace QLPhongMachTuDAO
{
    public class ThuocDAO
    {
        public DataTable LoadData()
        {
            DataProvider db = new DataProvider();
            return db.ReadDataNoParam("SP_ReadThuoc", 100);
        }

        public Int64 Insert(ThuocDTO _nv)
        {
            string[] str = new string[2];
            object[] val = new object[2];

            str[0] = "@tenThuoc";
            str[1] = "@gia";

            val[0] = _nv.tenThuoc;
            val[1] = _nv.gia;
           

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_InsertThuoc", str, val, 50);
        }

        public Int64 Update(ThuocDTO _nv)
        {
            string[] str = new string[3];
            object[] val = new object[3];

            str[0] = "@tenThuoc";
            str[1] = "@gia";
            str[2] = "@id";

            val[0] = _nv.tenThuoc;
            val[1] = _nv.gia;
            val[2] = _nv.id;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_UpdateThuoc", str, val, 50);
        }

        public Int64 Delete(int _id)
        {
            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_DeleteThuoc", new string[1] { "@id" }, new object[1] { _id }, 50);
        }
    }
}
