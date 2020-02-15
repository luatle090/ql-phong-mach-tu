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
    public class NhanVienBUS
    {
        NhanVienDAO nvDAO = new NhanVienDAO();

        public DataTable LoadDataNhanVien()
        {
            return nvDAO.LoadDataNhanVien();
        }

        public Int64 Insert(NhanVienDTO _nv)
        {
            return nvDAO.Insert(_nv);
        }

        public Int64 Update(NhanVienDTO _nv)
        {
            return nvDAO.Update(_nv);
        }

        public Int64 Delete(NhanVienDTO _nv)
        {
            return nvDAO.Delete(_nv);
        }

        public Int64 Delete(int _idNhanVien)
        {
            return nvDAO.Delete(_idNhanVien);
        }
    }
}
