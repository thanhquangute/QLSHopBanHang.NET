using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop
{
    public class LoaiKhachHang
    {
        //Khoa chinh
        public string MaLoaiKhachHang { get; set; }
        //Info
        public string loaiKH {get; set; }
        //plural
        public List<KhachHang> KhachHangs { get; set; }
    }
}
