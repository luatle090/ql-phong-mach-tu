using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongMachTuDTO
{
    public class NhanVienDTO
    {
        public int id { get; set; }
        public string ma { get; set; }
        public string hoTen { get; set; }
        public int gioiTinh { get; set; }//1: nam, 0: nu
        public string diaChi { get; set; }
        public int chucVu { get; set; }//1: admin, 2: nhanvien thường, 3: bác sĩ, 4: kế toán, 5: lể tân...
        public string username { get; set; }
        public string pass { get; set; }

        public NhanVienDTO()
        {
            this.id = -1;
            this.ma = "";
            this.hoTen = "";
            this.gioiTinh = 1;
            this.diaChi = "";
            this.chucVu = -1;
            this.username = "";
            this.pass = "";
        }

        public NhanVienDTO(int _id, string _ma, string _hoTen, int _gioiTinh, string _diaChi, int _chucVu, string _username, string _pass)
        {
            this.id = _id;
            this.ma = _ma;
            this.hoTen = _hoTen;
            this.gioiTinh = _gioiTinh;
            this.diaChi = _diaChi;
            this.chucVu = _chucVu;
            this.username = _username;
            this.pass = _pass;
        }
    }
}
