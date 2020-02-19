using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongMachTuDTO
{
    public class DonViTinhDTO
    {
        public int id { get; set; }
        public string ten { get; set; }

        public DonViTinhDTO()
        {
            this.id = -1;
            this.ten = "";
        }

        public DonViTinhDTO(int _id, string _tenDVT)
        {
            this.id = _id;
            this.ten = _tenDVT;
        }
    }
}
