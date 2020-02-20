using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongMachTuDTO
{
    public class CTThuocKhamDTO
    {
        public Int64 id { get; set; }
        public Int64 idPhieu { get; set; }
        public int idThuoc { get; set; }
        public int idDVT { get; set; }
        public int idCachDung { get; set; }
        public double soLuong { get; set; }

        public CTThuocKhamDTO()
        {
            this.id = -1;
            this.idPhieu = -1;
            this.idThuoc = -1;

            this.idDVT = -1;
            this.idCachDung = -1;
            this.soLuong = 0;
        }

        public CTThuocKhamDTO(Int64 _id, Int64 _idPhieu, int _idThuoc, int _idDVT, int _idCachDung, double _soLuong)
        {
            this.id = _id;
            this.idPhieu = _idPhieu;
            this.idThuoc = _idThuoc;

            this.idDVT = _idDVT;
            this.idCachDung = _idCachDung;
            this.soLuong = _soLuong;
        }
    }
}
