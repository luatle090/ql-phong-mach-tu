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
    public class ConfigDAO
    {
        public DataTable LoadData()
        {
            DataProvider dp = new DataProvider();
            return dp.Fillbang("select QuiDinh, DoiTuong, GiaTri from Config order by QuiDinh");
        }

        public Int32 GetGiaTriQuiDinh(string _QD)
        {
            DataProvider dp = new DataProvider();
            DataTable dt = new DataTable();
            dt = dp.Fillbang("select QuiDinh, DoiTuong, GiaTri from Config where QuiDinh = N'" + _QD + "' order by QuiDinh");

            return Convert.ToInt32(dt.Rows[0]["GiaTri"].ToString());
        }

        public Int64 Update(ConfigDTO _nv)
        {
            string[] str = new string[3];
            object[] val = new object[3];

            str[0] = "@quiDinh";
            val[0] = _nv.quyDinh;

            str[2] = "@giaTri";
            val[2] = _nv.giaTri;

            DataProvider dp = new DataProvider();
            return dp.WriteDataAddParam("SP_UpdateConfig", str, val, 50);
        }

       
    }
}
