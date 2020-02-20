using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongMachTuDTO
{
    public class PhieuKhamBenhDTO
    {
        public Int64 id { get; set; }
        public Int64 idDSKhamBenh { get; set; }
        public DateTime ngayKham { get; set; }
        public string trieuChung { get; set; }
        public int idDoanBenh { get; set; }//1: nam, 0: nu
        public int idNhanVien { get; set; }
        
        public PhieuKhamBenhDTO()
        {
            this.id = -1;
            this.idDSKhamBenh = -1;
            this.ngayKham = DateTime.Now.Date;
            this.trieuChung = "";
            this.idDoanBenh = -1;
            this.idNhanVien = -1;

        }

        public PhieuKhamBenhDTO(Int64 _id, Int64 _idDSKhamBenh, DateTime _ngayKham, string _trieuChung, int _idDoanBenh, int _idNhanVien)
        {
            this.id = -1;
            this.idDSKhamBenh = _idDSKhamBenh;
            this.ngayKham = _ngayKham;
            this.trieuChung = _trieuChung;
            this.idDoanBenh = _idDoanBenh;
            this.idNhanVien = _idNhanVien;

        }
    }
}
