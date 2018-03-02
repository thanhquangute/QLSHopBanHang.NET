using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop
{
    public class HopDongCungCap
    {
        //Khoa chinh
        public string MaHopDong { get; set; }
        //Info
        public DateTime NgayLapHopDong { get; set; }
       // Khoa ngoai
        public string MaNhaCungCap { get; set; }
        //plural
        public List<PhieuChiTien> PhieuChiTiens { get; set; }
        public List<ChiTietHopDongCungCap> ChiTietHDCCs { get; set; }
        //singular
        public NhaCungCap NhaCungCap { get; set; }
    }
}
