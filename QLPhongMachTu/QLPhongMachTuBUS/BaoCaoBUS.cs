using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLPhongMachTuDAO;
using QLPhongMachTuDTO;

namespace QLPhongMachTuBUS
{
    public class BaoCaoBUS
    {
        BaoCaoDAO dao = new BaoCaoDAO();

        public DataTable BaoCao_DoanhThu_Month(DateTime _month)
        {
            return dao.BaoCao_DoanhThu_Month(_month);
        }
        public DataTable BaoCao_SuDungThuoc_Month(DateTime _month)
        {
            return dao.BaoCao_SuDungThuoc_Month(_month);
        }

    }
}
