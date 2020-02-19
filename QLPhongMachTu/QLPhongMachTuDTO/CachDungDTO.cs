using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongMachTuDTO
{
    public class CachDungDTO
    {
        public int id { get; set; }
        public string ten { get; set; }
        public string moTa { get; set; }

        public CachDungDTO()
        {
            this.id = -1;
            this.ten = "";
            this.moTa = "";
        }

        public CachDungDTO(int _id, string _ten, string _moTa)
        {
            this.id = _id;
            this.ten = _ten;
            this.moTa = _moTa;
        }
    }
}
