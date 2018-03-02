using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop
{
    public class PhieuChiTien
    {
        //Khoa chinh
        public string MaPhieuChi { get; set; }
        //Thong tin
        public DateTime NgayChi { get; set; }
        public string TenNguoiChi { get; set; }
        public double SoTienChi { get; set; }
        public string LyDoChi { get; set; }
        //Khoa ngoai
        public string MaHopDong { get; set; }
        // singular
        public HopDongCungCap HopDongCungCap { get; set; }
    }
}
