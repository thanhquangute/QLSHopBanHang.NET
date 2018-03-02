using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop
{
    public class SanPham
    {
        //Khoa chinh
        public string MaSanPham { get; set; }
        //Thong tin
        public string TenSanPham { get; set; }
        //Khoa ngoai
        public string MaLoaiSanPham { get; set; }
        //Plural
        public List<ChiTietHopDongCungCap> ChiTietHopDongCungCaps { get; set; }
        public List<ChiTietPhieuMuaHang> ChiTietPhieuMuaHangs { get; set; }
        //Singular
        public LoaiSanPham LoaiSanPham { get; set; }
    }
}
