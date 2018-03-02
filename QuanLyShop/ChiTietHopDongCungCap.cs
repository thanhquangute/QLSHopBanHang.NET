using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop
{
    public class ChiTietHopDongCungCap
    {
        //Infomation
        public int SoLuongHang { get; set; }
        public double GiaNhapHang { get; set; }
        public double TongTienThanhToan { get; set; }
        //singular
        public SanPham SanPham { get; set; }
        public HopDongCungCap HopDongCungCap { get; set; }
        // Khoa ngoai
        public string MaHDCC { get; set; }
        public string MaSP { get; set; }
   }
}
