using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLPhongMachTuDTO
{
    public class ConfigDTO
    {
        public string quyDinh { get; set; }
        public string doiTuong { get; set; }
        public int giaTri { get; set; }

        public ConfigDTO()
        {
            this.quyDinh = "";
            this.doiTuong = "";
            this.giaTri = 0;
        }

        public ConfigDTO(string _quyDinh, string _doiTuong, int _giaTri)
        {
            this.quyDinh = _quyDinh;
            this.doiTuong = _doiTuong;
            this.giaTri = _giaTri;
        }
    }
}
