using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongMachTuDTO
{
    public class ThuocDTO
    {
        public int id { get; set; }
        public string tenThuoc { get; set; }
        public decimal gia { get; set; }
        

        public ThuocDTO()
        {
            this.id = -1;
            this.tenThuoc = "";
            this.gia = 2;
           

        }

        public ThuocDTO(int _id, string _tenThuoc, decimal _gia)
        {
            this.id = _id;
            this.tenThuoc = _tenThuoc;
            this.gia = _gia;

        }
    }
}
