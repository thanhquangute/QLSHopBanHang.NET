using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop
{
    public class ChiTietPhieuMuaHang
    {
        //singular
        public SanPham SP { get; set; }
        public PhieuMuaHang PMH { get; set; }
        //Info
        public int SoLuongMua { get; set; }
        public double DonGiaHang { get; set; }
        public double TongTien { get; set; }
        //khoa ngoai
        public string MaPMH { get; set; }
        public string MaSP { get; set; }

    }
}
