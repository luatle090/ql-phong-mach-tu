using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongMachTuDTO
{
    public class DSKhamBenhDTO
    {
        public int id { get; set; }
        public DateTime ngayKham { get; set; }
        public int idNhanVien { get; set; }
        public BenhNhanDTO benhNhan { get; set; }
        
        public DSKhamBenhDTO()
        {
            this.id = -1;
            this.ngayKham = DateTime.Now.Date;
            this.idNhanVien = -1;
            this.benhNhan = new BenhNhanDTO() ;
        }

        public DSKhamBenhDTO(int _id, DateTime _ngayKham, int _idNhanVien, BenhNhanDTO _benhNhan)
        {
            this.benhNhan = new BenhNhanDTO();

            this.id = _id;
            this.ngayKham = _ngayKham;
            this.idNhanVien = _idNhanVien;
            this.benhNhan = _benhNhan;
        }
    }
}
