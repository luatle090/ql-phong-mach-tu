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
    public class DSKhamBenhBUS
    {
        DSKhamBenhDAO nvDAO = new DSKhamBenhDAO();

        public DataTable LoadData(DateTime _time, bool _isAll)
        {
            return nvDAO.LoadData(_time, _isAll);
        }

        public int SoLuongKhamTrongNgay(DateTime _time)
        {
            return nvDAO.SoLuongKhamTrongNgay(_time);
        }

        public Int64 Insert(DSKhamBenhDTO _nv)
        {
            return nvDAO.Insert(_nv);
        }

        public Int64 Update(DSKhamBenhDTO _nv)
        {
            return nvDAO.Update(_nv);
        }

        public Int64 Delete(DSKhamBenhDTO _nv)
        {
            return nvDAO.Delete(_nv.id);
        }

        public Int64 Delete(int _id)
        {
            return nvDAO.Delete(_id);
        }
    }
}
