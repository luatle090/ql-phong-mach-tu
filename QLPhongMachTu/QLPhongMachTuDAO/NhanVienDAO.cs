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
            str[8] = "@chuVuText";
            // str[8] = "";

            val[0] = _nv.ma;
            val[1] = _nv.hoTen;
            val[2] = _nv.gioiTinh;
            val[3] = _nv.ngaySinh;
            val[4] = _nv.diaChi;
            val[5] = _nv.idchucVu;
            val[6] = _nv.username;
            val[7] = _nv.pass;
            val[8] = _nv.chucVu;
            // val[8] = "";

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_InsertNhanVien", str, val, 50);
        }

        public Int64 Update(NhanVienDTO _nv)
        {
            string[] str = new string[10];
            object[] val = new object[10];

            str[0] = "@ma";
            str[1] = "@hoTen";
            str[2] = "@gioiTinh";
            str[3] = "@ngaySinh";
            str[4] = "@diaChi";
            str[5] = "@chucVu";
           //str[6] = "@username";
            //str[7] = "@pass";
            str[8] = "@id";
            str[9] = "@chuVuText";

            val[0] = _nv.ma;
            val[1] = _nv.hoTen;
            val[2] = _nv.gioiTinh;
            val[3] = _nv.ngaySinh;
            val[4] = _nv.diaChi;
            val[5] = _nv.idchucVu;
            //val[6] = _nv.username;
            //val[7] = _nv.pass;
            val[8] = _nv.id;
            val[9] = _nv.chucVu;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_UpdateNhanVien", str, val, 50);
        }

        public Int64 UpdatePass(NhanVienDTO _nv)
        {
            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_UpdateNhanVien_Pass", new string[3] { "@username", "@pass", "@id" }, new object[3] { _nv.username, _nv.pass, _nv.id }, 50);
        }

        public Int64 Delete(NhanVienDTO _nv)
        {
            return Delete(_nv.id);
        }

        public Int64 Delete(int _idNhanVien)
        {
            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_DeleteNhanVien", new string[1] { "@id" }, new object[1] { _idNhanVien }, 50);
        }
    }
}
