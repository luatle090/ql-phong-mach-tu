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
    public class ThanhToanBUS
    {
        ThanhToanDAO nvDAO = new ThanhToanDAO();

        public DataTable LoadData(DateTime _time, bool _isAll)
        {
            return nvDAO.LoadData(_time, _isAll);
        }

        public Int64 Insert(ThanhToanDTO _nv)
        {
            return nvDAO.Insert(_nv);
        }
        
    }
}
