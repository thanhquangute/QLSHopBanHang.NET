using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop
{
    public class KhachHang
    {
        //Khoa chinh
        public string MaKhachHang { get; set; }
        //Info
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        //Khoa ngoai
        public string MaLoaiKH { get; set; }
        // singular
        public LoaiKhachHang LoaiKhachHang { get; set; }
        //plural
        public List<PhieuMuaHang> PhieuMuaHangs { get; set; }
    }
}
