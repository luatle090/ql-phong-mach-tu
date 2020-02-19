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
    public class BenhNhanDAO
    {
        public DataTable LoadData()
        {
            DataProvider db = new DataProvider();
            return db.ReadDataNoParam("SP_ReadBenhNhan", 100);
        }

        public BenhNhanDTO GetBenhNhan(string maBN)
        {
            DataProvider db = new DataProvider();
            DataTable dt = new DataTable();
            dt = db.ReadDataAddPram("SP_ReadBenhNhan_ByMa", new string[1] { "@ma"}, new object[1] { maBN} , 100);

            BenhNhanDTO bn = new BenhNhanDTO();

            if (dt.Rows.Count > 0 )
            {
                bn.id = Convert.ToInt16(dt.Rows[0]["ID"]);
                bn.ma = dt.Rows[0]["Ma"].ToString();
                bn.hoTen = dt.Rows[0]["HoTen"].ToString();
                bn.gioiTinh = Convert.ToInt16(dt.Rows[0]["Nam"]);
                bn.diaChi = dt.Rows[0]["DiaChi"].ToString();
                bn.ngaySinh = Convert.ToDateTime(dt.Rows[0]["NgaySinh"].ToString());
            }

            return bn;   
        }

        public Int64 Insert(BenhNhanDTO _nv)
        {
            string[] str = new string[5];
            object[] val = new object[5];

            str[0] = "@ma";
            str[1] = "@hoTen";
            str[2] = "@gioiTinh";
            str[3] = "@ngaySinh";
            str[4] = "@diaChi";
            

            val[0] = _nv.ma;
            val[1] = _nv.hoTen;
            val[2] = _nv.gioiTinh;
            val[3] = _nv.ngaySinh;
            val[4] = _nv.diaChi;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_InsertBenhNhan", str, val, 50);
        }

        public Int64 Update(BenhNhanDTO _nv)
        {
            string[] str = new string[6];
            object[] val = new object[6];

            str[0] = "@ma";
            str[1] = "@hoTen";
            str[2] = "@gioiTinh";
            str[3] = "@ngaySinh";
            str[4] = "@diaChi";
            str[5] = "@id";

            val[0] = _nv.ma;
            val[1] = _nv.hoTen;
            val[2] = _nv.gioiTinh;
            val[3] = _nv.ngaySinh;
            val[4] = _nv.diaChi;
            val[5] = _nv.id;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_UpdateBenhNhan", str, val, 50);
        }

        public Int64 Delete(int _id)
        {
            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_DeleteBenhNhan", new string[1] { "@id" }, new object[1] { _id }, 50);
        }
    }
}
