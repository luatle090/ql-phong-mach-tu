using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongMachTuDTO
{
    public class LoaiBenhDTO
    {
        public int id { get; set; }
        public string ten { get; set; }

        public LoaiBenhDTO()
        {
            this.id = -1;
            this.ten = "";
        }

        public LoaiBenhDTO(int _id, string _tenLoaiBenh)
        {
            this.id = _id;
            this.ten = _tenLoaiBenh;
        }
    }
}
