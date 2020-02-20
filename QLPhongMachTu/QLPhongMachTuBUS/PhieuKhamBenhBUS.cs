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
    public class PhieuKhamBenhBUS
    {
        PhieuKhamBenhDAO nvDAO = new PhieuKhamBenhDAO();

        public DataTable LoadData(DateTime _time, bool _isAll)
        {
            return nvDAO.LoadData(_time, _isAll);
        }

        public Int64 Insert(PhieuKhamBenhDTO _nv)
        {
            return nvDAO.Insert(_nv);
        }

        public Int64 Update(PhieuKhamBenhDTO _nv)
        {
            return nvDAO.Update(_nv);
        }

        public Int64 Delete(PhieuKhamBenhDTO _nv)
        {
            return nvDAO.Delete(_nv.id);
        }

        public Int64 Delete(Int64 _id)
        {
            return nvDAO.Delete(_id);
        }

        public decimal TinhTienThuoc(Int64 _id)
        {
            return nvDAO.TinhTienThuoc(_id);
        }
    }
}
