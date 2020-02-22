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
    public class BaoCaoDAO
    {
        public DataTable BaoCao_DoanhThu_Month(DateTime _month)
        {
            DataProvider db = new DataProvider();
            return db.ReadDataAddPram("SP_ReadBaoCao_DoanhThu_Month", new string[1] { "@month" }
                                                         , new object[1] { _month }, 100);
        }

        public DataTable BaoCao_SuDungThuoc_Month(DateTime _month)
        {
            DataProvider db = new DataProvider();
            return db.ReadDataAddPram("SP_ReadBaoCao_SuDungThuoc_Month", new string[1] { "@month" }
                                                         , new object[1] { _month }, 100);
        }
    }
}
