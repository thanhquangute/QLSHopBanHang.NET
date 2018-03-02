using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop
{
    public class PhieuMuaHang
    {
        //Khoa Chinh
        public string MaPhieuMuaHang { get; set; }
        //Info
        public DateTime NgayMua { get; set; }
        // Khoa ngoai
        public string MaKhachHang { get; set; }
        // plural
        public List<ChiTietPhieuMuaHang> ChiTietPhieuMuaHangs { get; set; }
        public List<PhieuThu> PhieuThus { get; set; }
        //singular
        public KhachHang KhachHang { get; set; }
    }
}
