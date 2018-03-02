using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop
{
   public  class PhieuThu
    {
       //Khoa chinh
       public string MaPhieuThu { get; set; }
       //Thong tin
       public DateTime NgayThu { get; set; }
       public double SoTienThu { get; set; }
       public string LyDoThu { get; set; }
       //singular
       public PhieuMuaHang PhieuMuaHang { get; set; }
       //Khoa ngoai
       public string MaPMH { get; set; }
    }
}
