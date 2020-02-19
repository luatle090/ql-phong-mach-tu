using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhongMachTuDAO;
using QLPhongMachTuDTO;
using System.Data;


namespace QLPhongMachTuBUS
{
    public class ConfigBUS
    {
        ConfigDAO nvDAO = new ConfigDAO();

        public DataTable LoadData()
        {
            return nvDAO.LoadData();
        }

        public Int32 GetGiaTriQuiDinh(string _QD)
        {
            return nvDAO.GetGiaTriQuiDinh(_QD);
        }

        public Int64 Update(ConfigDTO _nv)
        {
            return nvDAO.Update(_nv);
        }
    }
}
