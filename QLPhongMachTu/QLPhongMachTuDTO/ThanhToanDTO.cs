using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongMachTuDTO
{
    public class ThanhToanDTO
    {
        public Int64 id { get; set; }
        public Int64 idPhieu { get; set; }
        public decimal tienKham { get; set; }
        public decimal tienThuoc { get; set; }
        public string hoTen { get; set; }
        public DateTime ngayThanhToan { get; set; }
        public int idNhanVien { get; set; }
        
        public ThanhToanDTO()
        {
            this.id = -1;
            this.idPhieu = -1;
            this.tienKham = 0;
            this.tienThuoc = 0;
            this.hoTen = "";
            this.ngayThanhToan = DateTime.Now.Date;
            this.idNhanVien = -1;
          
        }

        public ThanhToanDTO(Int64 _id, Int64 _idPhieu, decimal _tienKham, decimal _tienThuoc, string _hoTen, DateTime _ngayThanhToan, int _idNhanVien)
        {
            this.id = _id;
            this.idPhieu = _idPhieu;
            this.tienKham = _tienKham;
            this.tienThuoc = _tienThuoc;
            this.hoTen = _hoTen;
            this.ngayThanhToan = _ngayThanhToan;
            this.idNhanVien = _idNhanVien;
        }
    }
}
