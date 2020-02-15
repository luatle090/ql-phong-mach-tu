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
    public class NhanVienDAO
    {
        public DataTable LoadDataNhanVien()
        {
            DataProvider db = new DataProvider();
            return db.ReadDataNoParam("SP_ReadNhanVien", 100);
        }

        public Int64 Insert(NhanVienDTO _nv)
        {
            string[] str = new string[8];
            object[] val = new object[8];

            str[0] = "@ma";
            str[1] = "@hoTen";
            str[2] = "@gioiTinh";
            str[3] = "@ngaySinh";
            str[4] = "@diaChi";
            str[5] = "@chucVu";
            str[6] = "@username";
            str[7] = "@pass";
            // str[8] = "";

            val[0] = _nv.ma;
            val[1] = _nv.hoTen;
            val[2] = _nv.gioiTinh;
            val[3] = _nv.diaChi;
            val[4] = _nv.diaChi;
            val[5] = _nv.chucVu;
            val[6] = _nv.username;
            val[7] = _nv.pass;
            // val[8] = "";

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_InsertNhanVien", str, val, 50);
        }

        public Int64 Update(NhanVienDTO _nv)
        {
            string[] str = new string[9];
            object[] val = new object[9];

            str[0] = "@ma";
            str[1] = "@hoTen";
            str[2] = "@gioiTinh";
            str[3] = "@ngaySinh";
            str[4] = "@diaChi";
            str[5] = "@chucVu";
            str[6] = "@username";
            str[7] = "@pass";
            str[8] = "@id";

            val[0] = _nv.ma;
            val[1] = _nv.hoTen;
            val[2] = _nv.gioiTinh;
            val[3] = _nv.diaChi;
            val[4] = _nv.diaChi;
            val[5] = _nv.chucVu;
            val[6] = _nv.username;
            val[7] = _nv.pass;
            val[8] = _nv.id;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_UpdateNhanVien", str, val, 50);
        }

        public Int64 Delete(NhanVienDTO _nv)
        {
            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_UpdateNhanVien", new string[1] { "@id" }, new object[1] { _nv.id }, 50);
        }

        public Int64 Delete(int _idNhanVien)
        {
            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_UpdateNhanVien", new string[1] { "@id" }, new object[1] { _idNhanVien }, 50);
        }
    }
}
