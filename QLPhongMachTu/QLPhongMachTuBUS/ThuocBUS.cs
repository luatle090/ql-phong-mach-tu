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
    public class ThuocBUS
    {
        ThuocDAO nvDAO = new ThuocDAO();

        public DataTable LoadData()
        {
            return nvDAO.LoadData();
        }

        public Int64 Insert(ThuocDTO _nv)
        {
            return nvDAO.Insert(_nv);
        }

        public Int64 Update(ThuocDTO _nv)
        {
            return nvDAO.Update(_nv);
        }

        public Int64 Delete(ThuocDTO _nv)
        {
            return nvDAO.Delete(_nv.id);
        }

        public Int64 Delete(int _id)
        {
            return nvDAO.Delete(_id);
        }
    }
}
