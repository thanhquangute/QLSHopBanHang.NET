using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop
{
    public class LoaiSanPham
    {
        //Khoa Chinh
        public string MaLoaiSanPham { get; set; }
        //Thong tin
        public string DongSanPham { get; set; }
        //plural
        public List<SanPham> SanPhams { get; set; }
    }
}
