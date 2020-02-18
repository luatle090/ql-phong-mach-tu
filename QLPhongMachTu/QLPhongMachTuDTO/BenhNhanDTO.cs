using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongMachTuDTO
{
    public class BenhNhanDTO
    {
        public int id { get; set; }
        public string ma { get; set; }
        public string hoTen { get; set; }
        public int gioiTinh { get; set; }//1: nam, 0: nu
        public string diaChi { get; set; }
        public DateTime ngaySinh { get; set; }

        public BenhNhanDTO()
        {
            this.id = -1;
            this.ma = "";
            this.hoTen = "";
            this.gioiTinh = 1;
            this.diaChi = "";
            //this.namSinh = 2000;
           
        }

        public BenhNhanDTO(int _id, string _ma, string _hoTen, int _gioiTinh, string _diaChi, DateTime _namSinh)
        {
            this.id = _id;
            this.ma = _ma;
            this.hoTen = _hoTen;
            this.gioiTinh = _gioiTinh;
            this.diaChi = _diaChi;
            this.ngaySinh = _namSinh;
            
        }
    }
}
