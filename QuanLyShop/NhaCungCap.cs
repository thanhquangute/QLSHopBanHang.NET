using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop
{
    public class NhaCungCap
    {
        //Khoa chinh
        public string MaNhaCungCap { get; set; }
        //Thong tin
        public string TenNhaCungCap { get; set;  }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        //plural
        public List<HopDongCungCap> HopDongCungCaps { get; set; }
    }
}
