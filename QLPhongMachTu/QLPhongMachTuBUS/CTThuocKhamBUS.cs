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
    public class CTThuocKhamBUS
    {
        CTThuocKhamDAO nvDAO = new CTThuocKhamDAO();

        public DataTable LoadData(Int64 _idPhieu)
        {
            return nvDAO.LoadData(_idPhieu);
        }

        public Int64 Insert(CTThuocKhamDTO _nv)
        {
            return nvDAO.Insert(_nv);
        }

        public Int64 Update(CTThuocKhamDTO _nv)
        {
            return nvDAO.Update(_nv);
        }

        public Int64 Delete(CTThuocKhamDTO _nv)
        {
            return nvDAO.Delete(_nv.id);
        }

        public Int64 Delete(Int64 _id)
        {
            return nvDAO.Delete(_id);
        }
    }
}
