using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop
{
    class Test
    {
        public static List<NhaCungCap> dsNhaCungCap = 
                new List<NhaCungCap>();
        public static List<HopDongCungCap> dsHopDongCungCap = 
            new List<HopDongCungCap>();
        public static List<LoaiKhachHang> dsLoaiKhachHang = 
            new List<LoaiKhachHang>();
        public static List<KhachHang> dsKhachHang = 
            new List<KhachHang>();
        public static List<PhieuChiTien> dsPhieuChiTien = 
            new List<PhieuChiTien>();
        public static List<SanPham> dsSanPham = 
            new List<SanPham>();
        public static List<LoaiSanPham> dsLoaiSanPham = 
            new List<LoaiSanPham>();
        public static List<PhieuMuaHang> dsPhieuMuaHang = 
            new List<PhieuMuaHang>();
        public static List<PhieuThu> dsPhieuThu = 
            new List<PhieuThu>();
        //Relationship Relations
        public static List<ChiTietHopDongCungCap> dsChiTietHopDongCungCap = 
            new List<ChiTietHopDongCungCap>();
        public static List<ChiTietPhieuMuaHang> dsChiTietPhieuMuaHang = 
            new List<ChiTietPhieuMuaHang>();
        //Create Data
        public static void TaoDSNhaCungCap()
        {
            dsNhaCungCap.Add(new NhaCungCap()
            {
                MaNhaCungCap = "NCC001",
                TenNhaCungCap = "CTCP Trung Hieu",
                SoDienThoai = "(04)36501661",
                DiaChi = "131B/66 Ngoc Lam, Q.Long Bien, Ha Noi"
            });
            dsNhaCungCap.Add(new NhaCungCap()
            {
                MaNhaCungCap = "NCC002",
                TenNhaCungCap = "CTTNHH Que Lam",
                SoDienThoai = "(08)39716999",
                DiaChi = "106/8-10 Bau Cat, Q.Tan Binh, HCMC"
            });
            dsNhaCungCap.Add(new NhaCungCap()
            {
                MaNhaCungCap = "NCC003",
                TenNhaCungCap = "CTTNHH Thoi Trang Thanh",
                SoDienThoai = "(08)22112862",
                DiaChi = "38 Cao Thang, Q3, HCMC"
            });
            dsNhaCungCap.Add(new NhaCungCap()
            {
                MaNhaCungCap = "NCC004",
                TenNhaCungCap = "CTTNHH Linh San",
                SoDienThoai = "(08)38593998",
                DiaChi = "553-553A Nguyen Trai, Q5, HCMC"
            });
            dsNhaCungCap.Add(new NhaCungCap()
            {
                MaNhaCungCap = "NCC005",
                TenNhaCungCap = "CTTNHH Tuong Duy",
                SoDienThoai = "(08)38124743",
                DiaChi = "662/4 Su Van Hanh(noi dai), Q.10, HCMC"
            });
        }
        public static void TaoDSHopDongCungCap()
        {
            dsHopDongCungCap.Add(new HopDongCungCap(){
                MaHopDong = "HDCC001",
                NgayLapHopDong = new DateTime(2015,5,30),   
                MaNhaCungCap = "NCC001",
                NhaCungCap = dsNhaCungCap.Single(ncc => ncc.MaNhaCungCap == "NCC001")
            });
            dsHopDongCungCap.Add(new HopDongCungCap()
            {
                MaHopDong = "HDCC002",
                NgayLapHopDong = new DateTime (2015,5,17),
                MaNhaCungCap = "NCC002",
                NhaCungCap = (from ncc in dsNhaCungCap
                              where ncc.MaNhaCungCap == "NCC002"
                              select ncc).Single()
            });
            dsHopDongCungCap.Add(new HopDongCungCap()
            {
                MaHopDong = "HDCC003",
                NgayLapHopDong = new DateTime(2015, 5, 15),
                MaNhaCungCap = "NCC003",
                NhaCungCap = (from ncc in dsNhaCungCap
                              where ncc.MaNhaCungCap == "NCC003"
                              select ncc).Single()
            });
            dsHopDongCungCap.Add(new HopDongCungCap()
            {
                MaHopDong = "HDCC004",
                NgayLapHopDong = new DateTime(2015, 6, 2),
                MaNhaCungCap = "NCC004",
                NhaCungCap = (from ncc in dsNhaCungCap
                              where ncc.MaNhaCungCap == "NCC004"
                              select ncc).Single()
            });
            dsHopDongCungCap.Add(new HopDongCungCap()
            {
                MaHopDong = "HDCC005",
                NgayLapHopDong = new DateTime(2015,8,7),
                MaNhaCungCap = "NCC005",
                NhaCungCap = (from ncc in dsNhaCungCap
                              where ncc.MaNhaCungCap == "NCC005"
                              select ncc).Single()
            });
            dsHopDongCungCap.Add(new HopDongCungCap()
            {
                MaHopDong = "HDCC006",
                NgayLapHopDong = new DateTime(2015, 12, 28),
                MaNhaCungCap = "NCC001",
                NhaCungCap = dsNhaCungCap.Single(ncc => ncc.MaNhaCungCap == "NCC001")
            });
            dsHopDongCungCap.Add(new HopDongCungCap()
            {
                MaHopDong = "HDCC007",
                NgayLapHopDong = new DateTime(2015, 10, 25),
                MaNhaCungCap = "NCC003",
                NhaCungCap = dsNhaCungCap.Single(ncc => ncc.MaNhaCungCap == "NCC003")
            });
            dsHopDongCungCap.Add(new HopDongCungCap()
            {
                MaHopDong = "HDCC008",
                NgayLapHopDong = new DateTime(2015, 12, 30),
                MaNhaCungCap = "NCC005",
                NhaCungCap = dsNhaCungCap.Single(ncc => ncc.MaNhaCungCap == "NCC005")
            });
            dsHopDongCungCap.Add(new HopDongCungCap()
            {
                MaHopDong = "HDCC009",
                NgayLapHopDong = new DateTime(2015, 9, 11),
                MaNhaCungCap = "NCC004",
                NhaCungCap = dsNhaCungCap.Single(ncc => ncc.MaNhaCungCap == "NCC004")
            });
        }
        public static void TaoDSPhieuChiTien()
        {
            dsPhieuChiTien.Add(new PhieuChiTien(){
                MaPhieuChi = "PC001",
                NgayChi = new DateTime(2015, 05, 30),
                TenNguoiChi = "Nguyen Minh Hieu Hao",
                SoTienChi = 1000000,
                LyDoChi = "Chi tien mat",
                MaHopDong = "HDCC001",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC001")
            });
            dsPhieuChiTien.Add(new PhieuChiTien()
            {
                MaPhieuChi = "PC002",
                NgayChi = new DateTime(2015, 05, 17),
                TenNguoiChi = "Tong Huu Phuc Ha",
                SoTienChi = 1500000,
                LyDoChi = "Chi tien mat",
                MaHopDong = "HDCC002",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC002")
            });
            dsPhieuChiTien.Add(new PhieuChiTien()
            {
                MaPhieuChi = "PC003",
                NgayChi = new DateTime(2015, 05, 15),
                TenNguoiChi = "Pham Nguyen Truong Giang",
                SoTienChi = 750000,
                LyDoChi = "Chi tien mat",
                MaHopDong = "HDCC003",
                HopDongCungCap = (from hdcc in dsHopDongCungCap
                                  where hdcc.MaHopDong == "HDCC003"
                                  select hdcc).Single() 
            });
            dsPhieuChiTien.Add(new PhieuChiTien()
            {
                MaPhieuChi = "PC004",
                NgayChi = new DateTime(2015, 06, 02),
                TenNguoiChi = "Ho Hao Khang",
                SoTienChi = 1250000,
                LyDoChi = "Chi tien mat",
                MaHopDong = "HDCC004",
                HopDongCungCap = (from hdcc in dsHopDongCungCap
                                  where hdcc.MaHopDong == "HDCC004"
                                  select hdcc).Single()
            });
            dsPhieuChiTien.Add(new PhieuChiTien()
            {
                MaPhieuChi = "PC005",
                NgayChi = new DateTime(2015, 08, 07),
                TenNguoiChi = "Tran Thien Du",
                SoTienChi = 1750000,
                LyDoChi = "Chi tien mat",
                MaHopDong = "HDCC005",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC005")
            });
             dsPhieuChiTien.Add(new PhieuChiTien()
            {
                MaPhieuChi = "PC006",
                NgayChi = new DateTime(2015, 12, 28),
                TenNguoiChi = "Tong Huu Phuc Ha",
                SoTienChi = 2000000,
                LyDoChi = "Chi tien mat",
                MaHopDong = "HDCC006",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC006")
            });
             dsPhieuChiTien.Add(new PhieuChiTien()
            {
                MaPhieuChi = "PC007",
                NgayChi = new DateTime(2015, 10, 25),
                TenNguoiChi = "Nguyen Minh Chau",
                SoTienChi = 1550000,
                LyDoChi = "Chi tien mat",
                MaHopDong = "HDCC007",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC007")
            });
             dsPhieuChiTien.Add(new PhieuChiTien()
            {
                MaPhieuChi = "PC008",
                NgayChi = new DateTime(2015, 12, 30),
                TenNguoiChi = "Nguyen Minh Hieu Hao",
                SoTienChi = 5200000,
                LyDoChi = "Chi tien mat",
                MaHopDong = "HDCC008",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC008")
            });
             dsPhieuChiTien.Add(new PhieuChiTien()
            {
                MaPhieuChi = "PC009",
                NgayChi = new DateTime(2015, 09, 11),
                TenNguoiChi = "Bui Hoang Hao",
                SoTienChi = 1500000,
                LyDoChi = "Chi tien mat",
                MaHopDong = "HDCC009",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC009")
            });
        }
        public static void TaoDSLoaiSanPham()
        {
            dsLoaiSanPham.Add(new LoaiSanPham() { 
                MaLoaiSanPham = "MLSP001",
                DongSanPham = "Dat tien",
            });
            dsLoaiSanPham.Add(new LoaiSanPham()
            {
                MaLoaiSanPham = "MLSP002",
                DongSanPham = "Trung luu",
            });
            dsLoaiSanPham.Add(new LoaiSanPham()
            {
                MaLoaiSanPham = "MLSP003",
                DongSanPham = "Pho thong",
            });
            dsLoaiSanPham.Add(new LoaiSanPham()
            {
                MaLoaiSanPham = "MLSP004",
                DongSanPham = "Sale off",
            });
        }
        public static void TaoDSSanPham()
        {
            dsSanPham.Add(new SanPham() { 
                MaSanPham = "SP001",
                TenSanPham = "Nike Flyknit Lunar 3 Nam",
                MaLoaiSanPham = "MLSP004",
                LoaiSanPham = dsLoaiSanPham.Single(lsp => lsp.MaLoaiSanPham == "MLSP004")
            });
            dsSanPham.Add(new SanPham() { 
                MaSanPham = "SP002",
                TenSanPham = "Nike Air Relentless 5",
                MaLoaiSanPham = "MLSP004",
                LoaiSanPham = dsLoaiSanPham.Single(lsp => lsp.MaLoaiSanPham == "MLSP004")
            });
            dsSanPham.Add(new SanPham()
            {
                MaSanPham = "SP003",
                TenSanPham = "Adidas Xlite Sneaker",
                MaLoaiSanPham = "MLSP001",
                LoaiSanPham = dsLoaiSanPham.Single(lsp => lsp.MaLoaiSanPham == "MLSP001")
            });
            dsSanPham.Add(new SanPham()
            {
                MaSanPham = "SP004",
                TenSanPham = "Nike Flex Experence RN4",
                MaLoaiSanPham = "MLSP002",
                LoaiSanPham = dsLoaiSanPham.Single(lsp => lsp.MaLoaiSanPham == "MLSP002")
            });
            dsSanPham.Add(new SanPham()
            {
                MaSanPham = "SP005",
                TenSanPham = "Nike Air Max",
                MaLoaiSanPham = "MLSP003",
                LoaiSanPham = dsLoaiSanPham.Single(lsp => lsp.MaLoaiSanPham == "MLSP003")
            });
            dsSanPham.Add(new SanPham()
            {
                MaSanPham = "SP006",
                TenSanPham = "New Balance K1300GGY",
                MaLoaiSanPham = "MLSP003",
                LoaiSanPham = dsLoaiSanPham.Single(lsp => lsp.MaLoaiSanPham == "MLSP003")
            });
            dsSanPham.Add(new SanPham()
            {
                MaSanPham = "SP007",
                TenSanPham = "New Balance Fresh Foam",
                MaLoaiSanPham = "MLSP002",
                LoaiSanPham = dsLoaiSanPham.Single(lsp => lsp.MaLoaiSanPham == "MLSP002")
            });
            dsSanPham.Add(new SanPham()
            {
                MaSanPham = "SP008",
                TenSanPham = "Nike Air Max Premiere Run",
                MaLoaiSanPham = "MLSP001",
                LoaiSanPham = dsLoaiSanPham.Single(lsp => lsp.MaLoaiSanPham == "MLSP001")
            });
            //dsSanPham.Add(new SanPham()
            //{
            //    MaSanPham = "SP009",
            //    TenSanPham = "Supra Vaider",
            //    MaLoaiSanPham = "MLSP001",
            //    LoaiSanPham = dsLoaiSanPham.Single(lsp => lsp.MaLoaiSanPham == "MLSP001")
            //});
            //dsSanPham.Add(new SanPham()
            //{
            //    MaSanPham = "SP0010",
            //    TenSanPham = "Running Adidas Galaxy 2",
            //    MaLoaiSanPham = "MLSP002",
            //    LoaiSanPham = dsLoaiSanPham.Single(lsp => lsp.MaLoaiSanPham == "MLSP002")
            //});
        }
        public static void TaoDSChiTietHopDongCungCap()
        {
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap() { 
                SoLuongHang = 100,
                GiaNhapHang = 1000000,
                TongTienThanhToan = 1750000,
                MaHDCC = "HDCC001",
                MaSP = "SP002",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC001"),
                SanPham = dsSanPham.Single(sp => sp.MaSanPham == "SP002")
            });
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap()
            {
                SoLuongHang = 110,
                GiaNhapHang = 1520000,
                TongTienThanhToan = 1950000,
                MaHDCC = "HDCC002",
                MaSP = "SP008",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC002"),
                SanPham = dsSanPham.Single(sp => sp.MaSanPham == "SP008")
            });
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap()
            {
                SoLuongHang = 120,
                GiaNhapHang = 1660000,
                TongTienThanhToan = 2000000,
                MaHDCC = "HDCC003",
                MaSP = "SP001",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC003"),
                SanPham = dsSanPham.Single(sp => sp.MaSanPham == "SP001")
            });
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap()
            {
                SoLuongHang = 110,
                GiaNhapHang = 1500000,
                TongTienThanhToan = 1900000,
                MaHDCC = "HDCC004",
                MaSP = "SP003",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC004"),
                SanPham = dsSanPham.Single(sp => sp.MaSanPham == "SP003")
            });
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap()
            {
                SoLuongHang = 90,
                GiaNhapHang = 1300000,
                TongTienThanhToan = 1530000,
                MaHDCC = "HDCC005",
                MaSP = "SP004",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC005"),
                SanPham = dsSanPham.Single(sp => sp.MaSanPham == "SP004")
            });
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap()
            {
                SoLuongHang = 50,
                GiaNhapHang = 950000,
                TongTienThanhToan = 1200000,
                MaHDCC = "HDCC006",
                MaSP = "SP005",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC006"),
                SanPham = dsSanPham.Single(sp => sp.MaSanPham == "SP005")
            });
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap()
            {
                SoLuongHang = 50,
                GiaNhapHang = 1200000,
                TongTienThanhToan = 1950000,
                MaHDCC = "HDCC007",
                MaSP = "SP006",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC007"),
                SanPham = dsSanPham.Single(sp => sp.MaSanPham == "SP006")
            });
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap()
            {
                SoLuongHang = 100,
                GiaNhapHang = 1520000,
                TongTienThanhToan = 2000000,
                MaHDCC = "HDCC008",
                MaSP = "SP007",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC008"),
                SanPham = dsSanPham.Single(sp => sp.MaSanPham == "SP007")
            });
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap()
            {
                SoLuongHang = 120,
                GiaNhapHang = 1750000,
                TongTienThanhToan = 2550000,
                MaHDCC = "HDCC001",
                MaSP = "SP005",
                HopDongCungCap = dsHopDongCungCap.Single(hdcc => hdcc.MaHopDong == "HDCC002"),
                SanPham = dsSanPham.Single(sp => sp.MaSanPham == "SP008")
            });
        }
        public static void TaoDSLoaiKhachHang()
        {
            dsLoaiKhachHang.Add(new LoaiKhachHang() { 
                MaLoaiKhachHang = "MLKH001",
                loaiKH = "VIP",
                KhachHangs = (from kh in dsKhachHang
                              where kh.MaLoaiKH == "MLKH001"
                              select kh).ToList()
            });
            dsLoaiKhachHang.Add(new LoaiKhachHang(){
                MaLoaiKhachHang = "MLKH002",
                loaiKH = "Than thiet",
                KhachHangs = (from kh in dsKhachHang
                              where kh.MaLoaiKH == "MLKH002"
                              select kh).ToList()
            });
            dsLoaiKhachHang.Add(new LoaiKhachHang()
            {
                MaLoaiKhachHang = "MLKH003",
                loaiKH = "Thuong",
                KhachHangs = (from kh in dsKhachHang
                              where kh.MaLoaiKH == "MLKH003"
                              select kh).ToList()
            });
        }
        public static void TaoDSKhachHang()
        {
            dsKhachHang.Add(new KhachHang()
            {
                MaKhachHang = "KH001",
                TenKhachHang = "Luu Nac Nhat",
                SoDienThoai = "0916265433",
                GioiTinh = "Nam",
                DiaChi = "123 Kha Van Can",
                MaLoaiKH = "MLKH001",
                LoaiKhachHang = dsLoaiKhachHang.Single(lkh => lkh.MaLoaiKhachHang == "MLKH001"),
                PhieuMuaHangs = (from i in dsPhieuMuaHang
                                 where i.MaKhachHang == "KH001"
                                 select i).ToList()
            });
            dsKhachHang.Add(new KhachHang()
            {
                MaKhachHang = "KH003",
                TenKhachHang = "Liang Jing Ru",
                SoDienThoai = "01223336565",
                GioiTinh = "Nu",
                DiaChi = "15 Le Thanh Ton, Q1",
                MaLoaiKH = "MLKH002",
                LoaiKhachHang = dsLoaiKhachHang.Single(lkh => lkh.MaLoaiKhachHang == "MLKH002"),
                PhieuMuaHangs = (from i in dsPhieuMuaHang
                                 where i.MaKhachHang == "KH003"
                                 select i).ToList()
            });
            dsKhachHang.Add(new KhachHang()
            {
                MaKhachHang = "KH002",
                TenKhachHang = "Nguyen Luong An",
                SoDienThoai = "004956235689144",
                GioiTinh = "Nam",
                DiaChi = "Elsenstraße 3 12435 Berlin-Treptow ",
                MaLoaiKH = "MLKH003",
                LoaiKhachHang = dsLoaiKhachHang.Single(lkh => lkh.MaLoaiKhachHang == "MLKH003"),
                PhieuMuaHangs = (from i in dsPhieuMuaHang
                                 where i.MaKhachHang == "KH002"
                                 select i).ToList()
            });
            dsKhachHang.Add(new KhachHang()
            {
                MaKhachHang = "KH004",
                TenKhachHang = "Kim Tae Hee",
                SoDienThoai = "0903852693",
                GioiTinh = "Nu",
                DiaChi = "24 Su Van Hanh, Q10",
                MaLoaiKH = "MLKH002",
                LoaiKhachHang = dsLoaiKhachHang.Single(lkh => lkh.MaLoaiKhachHang == "MLKH002"),
                PhieuMuaHangs = (from i in dsPhieuMuaHang
                                 where i.MaKhachHang == "KH004"
                                 select i).ToList()
            });
            dsKhachHang.Add(new KhachHang()
            {
                MaKhachHang = "KH005",
                TenKhachHang = "Lam Tam Nhu",
                SoDienThoai = "0903999999",
                GioiTinh = "Nu",
                DiaChi = "123/123 Huynh Tan Phat, Q7",
                MaLoaiKH = "MLKH001",
                LoaiKhachHang = dsLoaiKhachHang.Single(lkh => lkh.MaLoaiKhachHang == "MLKH001"),
                PhieuMuaHangs = (from i in dsPhieuMuaHang
                                 where i.MaKhachHang == "KH005"
                                 select i).ToList()
            });
            dsKhachHang.Add(new KhachHang()
            {
                MaKhachHang = "KH006",
                TenKhachHang = "Ho Hao Khang",
                SoDienThoai = "0122333999",
                GioiTinh = "Nam",
                DiaChi = "69 Vo Van Ngan, Q. Thu Duc",
                MaLoaiKH = "MLKH002",
                LoaiKhachHang = dsLoaiKhachHang.Single(lkh => lkh.MaLoaiKhachHang == "MLKH002"),
                PhieuMuaHangs = (from i in dsPhieuMuaHang
                                 where i.MaKhachHang == "KH006"
                                 select i).ToList()
            });
            dsKhachHang.Add(new KhachHang()
            {
                MaKhachHang = "KH007",
                TenKhachHang = "Ha Thien",
                SoDienThoai = "0903222666",
                GioiTinh = "Nu",
                DiaChi = "96/69 Nguyen Thi Minh Khai",
                MaLoaiKH = "MLKH002",
                LoaiKhachHang = dsLoaiKhachHang.Single(lkh => lkh.MaLoaiKhachHang == "MLKH002"),
                PhieuMuaHangs = (from i in dsPhieuMuaHang
                                 where i.MaKhachHang == "KH007"
                                 select i).ToList()
            });
            dsKhachHang.Add(new KhachHang()
            {
                MaKhachHang = "KH008",
                TenKhachHang = "Luu Diep",
                SoDienThoai = "0903685269",
                GioiTinh = "Nam",
                DiaChi = "147/8 Nguyen Trai, Q5",
                MaLoaiKH = "MLKH001",
                LoaiKhachHang = dsLoaiKhachHang.Single(lkh => lkh.MaLoaiKhachHang == "MLKH001"),
                PhieuMuaHangs = (from i in dsPhieuMuaHang
                                 where i.MaKhachHang == "KH008"
                                 select i).ToList()
            });
            dsKhachHang.Add(new KhachHang()
            {
                MaKhachHang = "KH009",
                TenKhachHang = "Sandara Park",
                SoDienThoai = "0964087184",
                GioiTinh = "Nu",
                DiaChi = "233 Hoang Dieu 2",
                MaLoaiKH = "MLKH003",
                LoaiKhachHang = dsLoaiKhachHang.Single(lkh => lkh.MaLoaiKhachHang == "MLKH003"),
                PhieuMuaHangs = (from i in dsPhieuMuaHang
                                 where i.MaKhachHang == "KH009"
                                 select i).ToList()
            });
        }
        public static void TaoDSPhieuMuaHang()
        {
            dsPhieuMuaHang.Add(new PhieuMuaHang() { 
                MaPhieuMuaHang = "PMH001",
                NgayMua = new DateTime(2016, 1, 16),
                MaKhachHang = "KH001",
                KhachHang = dsKhachHang.Single(kh => kh.MaKhachHang == "KH001")
            });
            dsPhieuMuaHang.Add(new PhieuMuaHang()
            {
                MaPhieuMuaHang = "PMH0010",
                NgayMua = new DateTime(2016, 7, 17),
                MaKhachHang = "KH001",
                KhachHang = (from kh in dsKhachHang
                             where kh.MaKhachHang == "KH001"
                             select kh).Single()
            });
            dsPhieuMuaHang.Add(new PhieuMuaHang()
            {
                MaPhieuMuaHang = "PMH0011",
                NgayMua = new DateTime(2016, 8, 18),
                MaKhachHang = "KH001",
                KhachHang = dsKhachHang.Single(kh => kh.MaKhachHang == "KH001")
            });
            dsPhieuMuaHang.Add(new PhieuMuaHang()
            {
                MaPhieuMuaHang = "PMH002",
                NgayMua = new DateTime(2016, 1, 16),
                MaKhachHang = "KH002",
                KhachHang = dsKhachHang.Single(kh => kh.MaKhachHang == "KH002")
            });
            dsPhieuMuaHang.Add(new PhieuMuaHang()
            {
                MaPhieuMuaHang = "PMH003",
                NgayMua = new DateTime(2016, 2,18),
                MaKhachHang = "KH003",
                KhachHang = dsKhachHang.Single(kh => kh.MaKhachHang == "KH003")
            });
            dsPhieuMuaHang.Add(new PhieuMuaHang()
            {
                MaPhieuMuaHang = "PMH0012",
                NgayMua = new DateTime(2016, 9, 16),
                MaKhachHang = "KH003",
                KhachHang = dsKhachHang.Single(kh => kh.MaKhachHang == "KH003")
            });
            dsPhieuMuaHang.Add(new PhieuMuaHang()
            {
                MaPhieuMuaHang = "PMH004",
                NgayMua = new DateTime(2016, 2, 18),
                MaKhachHang = "KH004",
                KhachHang = (from kh in dsKhachHang
                             where kh.MaKhachHang == "KH004"
                             select kh).Single()
            });
            dsPhieuMuaHang.Add(new PhieuMuaHang()
            {
                MaPhieuMuaHang = "PMH005",
                NgayMua = new DateTime(2016, 5, 20),
                MaKhachHang = "KH005",
                KhachHang = (from kh in dsKhachHang
                             where kh.MaKhachHang == "KH005"
                             select kh).Single()
            });
            dsPhieuMuaHang.Add(new PhieuMuaHang()
            {
                MaPhieuMuaHang = "PMH006",
                NgayMua = new DateTime(2016, 6, 27),
                MaKhachHang = "KH006",
                KhachHang = (from kh in dsKhachHang
                             where kh.MaKhachHang == "KH006"
                             select kh).Single()
            });
            dsPhieuMuaHang.Add(new PhieuMuaHang()
            {
                MaPhieuMuaHang = "PMH007",
                NgayMua = new DateTime(2016, 7, 16),
                MaKhachHang = "KH007",
                KhachHang = (from kh in dsKhachHang
                             where kh.MaKhachHang == "KH007"
                             select kh).Single()
            });
            dsPhieuMuaHang.Add(new PhieuMuaHang()
            {
                MaPhieuMuaHang = "PMH008",
                NgayMua = new DateTime(2016, 7, 16),
                MaKhachHang = "KH008",
                KhachHang = (from kh in dsKhachHang
                             where kh.MaKhachHang == "KH008"
                             select kh).Single()
            });
            dsPhieuMuaHang.Add(new PhieuMuaHang()
            {
                MaPhieuMuaHang = "PMH009",
                NgayMua = new DateTime(2016, 7, 17),
                MaKhachHang = "KH009",
                KhachHang = (from kh in dsKhachHang
                             where kh.MaKhachHang == "KH009"
                             select kh).Single()
            });
        }
        public static void TaoDSChiTietPhieuMuaHang()
        {
            dsChiTietPhieuMuaHang.Add(new ChiTietPhieuMuaHang()
            {
                SoLuongMua = 3,
                DonGiaHang = 950000,
                TongTien = 2850000,
                MaPMH = "PMH001",
                MaSP = "SP002",
                SP =  (from sp in dsSanPham
                       where sp.MaSanPham == "SP002"
                       select sp).Single(),
                PMH = (from pmh in dsPhieuMuaHang
                       where pmh.MaPhieuMuaHang == "PMH001"
                       select pmh).Single()
            });
            dsChiTietPhieuMuaHang.Add(new ChiTietPhieuMuaHang()
            {
                SoLuongMua = 2,
                DonGiaHang = 900000,
                TongTien = 1800000,
                MaPMH = "PMH002",
                MaSP = "SP002",
                SP = (from sp in dsSanPham
                      where sp.MaSanPham == "SP002"
                      select sp).Single(),
                PMH = (from pmh in dsPhieuMuaHang
                       where pmh.MaPhieuMuaHang == "PMH002"
                       select pmh).Single()
            });
            dsChiTietPhieuMuaHang.Add(new ChiTietPhieuMuaHang()
            {
                SoLuongMua = 3,
                DonGiaHang = 950000,
                TongTien = 2850000,
                MaPMH = "PMH003",
                MaSP = "SP003",
                SP = (from sp in dsSanPham
                      where sp.MaSanPham == "SP003"
                      select sp).Single(),
                PMH = (from pmh in dsPhieuMuaHang
                       where pmh.MaPhieuMuaHang == "PMH003"
                       select pmh).Single()
            });
            dsChiTietPhieuMuaHang.Add(new ChiTietPhieuMuaHang()
            {
                SoLuongMua = 1,
                DonGiaHang = 950000,
                TongTien = 950000,
                MaPMH = "PMH004",
                MaSP = "SP004",
                SP = (from sp in dsSanPham
                      where sp.MaSanPham == "SP004"
                      select sp).Single(),
                PMH = (from pmh in dsPhieuMuaHang
                       where pmh.MaPhieuMuaHang == "PMH004"
                       select pmh).Single()
            });
            dsChiTietPhieuMuaHang.Add(new ChiTietPhieuMuaHang()
            {
                SoLuongMua = 5,
                DonGiaHang = 950000,
                TongTien = 4750000,
                MaPMH = "PMH005",
                MaSP = "SP005",
                SP = (from sp in dsSanPham
                      where sp.MaSanPham == "SP005"
                      select sp).Single(),
                PMH = (from pmh in dsPhieuMuaHang
                       where pmh.MaPhieuMuaHang == "PMH005"
                       select pmh).Single()
            });
            dsChiTietPhieuMuaHang.Add(new ChiTietPhieuMuaHang()
            {
                SoLuongMua = 1,
                DonGiaHang = 950000,
                TongTien = 950000,
                MaPMH = "PMH006",
                MaSP = "SP006",
                SP = (from sp in dsSanPham
                      where sp.MaSanPham == "SP006"
                      select sp).Single(),
                PMH = (from pmh in dsPhieuMuaHang
                       where pmh.MaPhieuMuaHang == "PMH006"
                       select pmh).Single()
            });
            dsChiTietPhieuMuaHang.Add(new ChiTietPhieuMuaHang()
            {
                SoLuongMua = 5,
                DonGiaHang = 950000,
                TongTien = 4750000,
                MaPMH = "PMH007",
                MaSP = "SP003",
                SP = (from sp in dsSanPham
                      where sp.MaSanPham == "SP003"
                      select sp).Single(),
                PMH = (from pmh in dsPhieuMuaHang
                       where pmh.MaPhieuMuaHang == "PMH007"
                       select pmh).Single()
            });
            dsChiTietPhieuMuaHang.Add(new ChiTietPhieuMuaHang()
            {
                SoLuongMua = 2,
                DonGiaHang = 900000,
                TongTien = 1800000,
                MaPMH = "PMH008",
                MaSP = "SP001",
                SP = (from sp in dsSanPham
                      where sp.MaSanPham == "SP001"
                      select sp).Single(),
                PMH = (from pmh in dsPhieuMuaHang
                       where pmh.MaPhieuMuaHang == "PMH008"
                       select pmh).Single()
            });
            dsChiTietPhieuMuaHang.Add(new ChiTietPhieuMuaHang()
            {
                SoLuongMua = 4,
                DonGiaHang = 950000,
                TongTien = 3800000,
                MaPMH = "PMH009",
                MaSP = "SP003",
                SP = (from sp in dsSanPham
                      where sp.MaSanPham == "SP003"
                      select sp).Single(),
                PMH = (from pmh in dsPhieuMuaHang
                       where pmh.MaPhieuMuaHang == "PMH009"
                       select pmh).Single()
            });
            dsChiTietPhieuMuaHang.Add(new ChiTietPhieuMuaHang()
            {
                SoLuongMua = 4,
                DonGiaHang = 950000,
                TongTien = 3800000,
                MaPMH = "PMH0010",
                MaSP = "SP002",
                SP = (from sp in dsSanPham
                      where sp.MaSanPham == "SP002"
                      select sp).Single(),
                PMH = (from pmh in dsPhieuMuaHang
                       where pmh.MaPhieuMuaHang == "PMH0010"
                       select pmh).Single()
            });
            dsChiTietPhieuMuaHang.Add(new ChiTietPhieuMuaHang()
            {
                SoLuongMua = 4,
                DonGiaHang = 950000,
                TongTien = 3800000,
                MaPMH = "PMH0011",
                MaSP = "SP008",
                SP = (from sp in dsSanPham
                      where sp.MaSanPham == "SP008"
                      select sp).Single(),
                PMH = (from pmh in dsPhieuMuaHang
                       where pmh.MaPhieuMuaHang == "PMH0011"
                       select pmh).Single()
            });
            dsChiTietPhieuMuaHang.Add(new ChiTietPhieuMuaHang()
            {
                SoLuongMua = 1,
                DonGiaHang = 950000,
                TongTien = 950000,
                MaPMH = "PMH0012",
                MaSP = "SP001",
                SP = (from sp in dsSanPham
                      where sp.MaSanPham == "SP001"
                      select sp).Single(),
                PMH = (from pmh in dsPhieuMuaHang
                       where pmh.MaPhieuMuaHang == "PMH0012"
                       select pmh).Single()
            });
            dsChiTietPhieuMuaHang.Add(new ChiTietPhieuMuaHang()
            {
                SoLuongMua = 3,
                DonGiaHang = 950000,
                TongTien = 2850000,
                MaPMH = "PMH0010",
                MaSP = "SP004",
                SP = (from sp in dsSanPham
                      where sp.MaSanPham == "SP004"
                      select sp).Single(),
                PMH = (from pmh in dsPhieuMuaHang
                       where pmh.MaPhieuMuaHang == "PMH0010"
                       select pmh).Single()
            });
            dsChiTietPhieuMuaHang.Add(new ChiTietPhieuMuaHang()
            {
                SoLuongMua = 3,
                DonGiaHang = 950000,
                TongTien = 2850000,
                MaPMH = "PMH0010",
                MaSP = "SP003",
                SP = (from sp in dsSanPham
                      where sp.MaSanPham == "SP003"
                      select sp).Single(),
                PMH = (from pmh in dsPhieuMuaHang
                       where pmh.MaPhieuMuaHang == "PMH0010"
                       select pmh).Single()
            });
        }
        public static void TaoDSPhieuThu()
        {
            dsPhieuThu.Add(new PhieuThu() { 
                MaPhieuThu = "PT001",
                NgayThu = new DateTime (2016,1,16),
                SoTienThu = 950000,
                LyDoThu = "Sold",
                MaPMH = "PMH001",
                PhieuMuaHang = dsPhieuMuaHang.Single(pmh => pmh.MaPhieuMuaHang == "PMH001")
            });
            dsPhieuThu.Add(new PhieuThu()
            {
                MaPhieuThu = "PT002",
                NgayThu = new DateTime(2016, 7, 17),
                SoTienThu = 850000,
                LyDoThu = "Sold",
                MaPMH = "PMH0010",
                PhieuMuaHang = dsPhieuMuaHang.Single(pmh => pmh.MaPhieuMuaHang == "PMH0010")
            });
            dsPhieuThu.Add(new PhieuThu()
            {
                MaPhieuThu = "PT003",
                NgayThu = new DateTime(2016, 8, 18),
                SoTienThu = 900000,
                LyDoThu = "Sold",
                MaPMH = "PMH0011",
                PhieuMuaHang = dsPhieuMuaHang.Single(pmh => pmh.MaPhieuMuaHang == "PMH0011")
            });
            dsPhieuThu.Add(new PhieuThu()
            {
                MaPhieuThu = "PT004",
                NgayThu = new DateTime(2016, 1, 16),
                SoTienThu = 950000,
                LyDoThu = "Sold",
                MaPMH = "PMH002",
                PhieuMuaHang = dsPhieuMuaHang.Single(pmh => pmh.MaPhieuMuaHang == "PMH002")
            });
            dsPhieuThu.Add(new PhieuThu()
            {
                MaPhieuThu = "PT005",
                NgayThu = new DateTime(2016, 2, 18),
                SoTienThu = 850000,
                LyDoThu = "Sold",
                MaPMH = "PMH003",
                PhieuMuaHang = dsPhieuMuaHang.Single(pmh => pmh.MaPhieuMuaHang == "PMH003")
            });
            dsPhieuThu.Add(new PhieuThu()
            {
                MaPhieuThu = "PT006",
                NgayThu = new DateTime(2016, 2, 18),
                SoTienThu = 750000,
                LyDoThu = "Sold",
                MaPMH = "PMH004",
                PhieuMuaHang = dsPhieuMuaHang.Single(pmh => pmh.MaPhieuMuaHang == "PMH004")
            });
            dsPhieuThu.Add(new PhieuThu()
            {
                MaPhieuThu = "PT007",
                NgayThu = new DateTime(2016, 5, 20),
                SoTienThu = 970000,
                LyDoThu = "Sold",
                MaPMH = "PMH005",
                PhieuMuaHang = dsPhieuMuaHang.Single(pmh => pmh.MaPhieuMuaHang == "PMH005")
            });
            dsPhieuThu.Add(new PhieuThu()
            {
                MaPhieuThu = "PT008",
                NgayThu = new DateTime(2016, 6, 27),
                SoTienThu = 955000,
                LyDoThu = "Sold",
                MaPMH = "PMH006",
                PhieuMuaHang = dsPhieuMuaHang.Single(pmh => pmh.MaPhieuMuaHang == "PMH006")
            });
            dsPhieuThu.Add(new PhieuThu()
            {
                MaPhieuThu = "PT009",
                NgayThu = new DateTime(2016, 7, 16),
                SoTienThu = 950000,
                LyDoThu = "Sold",
                MaPMH = "PMH007",
                PhieuMuaHang = dsPhieuMuaHang.Single(pmh => pmh.MaPhieuMuaHang == "PMH007")
            });
            dsPhieuThu.Add(new PhieuThu()
            {
                MaPhieuThu = "PT0010",
                NgayThu = new DateTime(2016, 7, 16),
                SoTienThu = 970000,
                LyDoThu = "Sold",
                MaPMH = "PMH008",
                PhieuMuaHang = dsPhieuMuaHang.Single(pmh => pmh.MaPhieuMuaHang == "PMH008")
            });
            dsPhieuThu.Add(new PhieuThu()
            {
                MaPhieuThu = "PT0011",
                NgayThu = new DateTime(2016, 7, 17),
                SoTienThu = 1050000,
                LyDoThu = "Sold",
                MaPMH = "PMH009",
                PhieuMuaHang = dsPhieuMuaHang.Single(pmh => pmh.MaPhieuMuaHang == "PMH009")
            });
            dsPhieuThu.Add(new PhieuThu()
            {
                MaPhieuThu = "PT0012",
                NgayThu = new DateTime(2016, 9, 16),
                SoTienThu = 950000,
                LyDoThu = "Sold",
                MaPMH = "PMH0012",
                PhieuMuaHang = dsPhieuMuaHang.Single(pmh => pmh.MaPhieuMuaHang == "PMH0012")
            });
        }

        /*--------------------------------------------------------------------*/
        public static void DanhSachKhachHang()
        {
            var kh = from n in dsKhachHang
                     select n;
            Console.WriteLine("Danh sach khach hang: ");
            foreach (var n in kh)
            {
                Console.Write("Ma khach hang: ");
                Console.WriteLine(n.MaKhachHang);
                Console.Write("Ten khach: ");
                Console.WriteLine(n.TenKhachHang);
                Console.Write("Gioi tinh: ");
                Console.WriteLine(n.GioiTinh);
                Console.Write("So dien thoai: ");
                Console.WriteLine(n.SoDienThoai);
                Console.Write("Dia chi: ");
                Console.WriteLine(n.DiaChi);
                Console.WriteLine("--------------------------------------");
                Console.Write("\n");
            }
        }
        public static void DanhSachKhachHangLaNu()
        { 
            var khn  =  (from nu in dsKhachHang
                        where  nu.GioiTinh == "Nu"
                        select nu);
            Console.WriteLine("Danh sach khach hang la nu: ");
            Console.WriteLine("\n");
            foreach (var khnn in khn)
            {
                Console.Write("Ten khach hang: ");
                Console.WriteLine(khnn.TenKhachHang);
                Console.Write("Ma khach hang: ");
                Console.WriteLine(khnn.MaKhachHang);
                Console.Write("So dien thoai: ");
                Console.WriteLine(khnn.SoDienThoai);
                Console.Write("Dia Chi: ");
                Console.WriteLine(khnn.DiaChi);
                Console.Write("---------------------------------------\n");
            }
        }
        public static void DanhSachKhachHangLaNam()
        {
            var khn = (from nam in dsKhachHang
                       where nam.GioiTinh == "Nam"
                       select nam);
            Console.WriteLine("Danh sach khach hang la nam: ");
            Console.WriteLine("\n");
            foreach (var khng in khn)
            {
                Console.Write("Ten khach hang: ");
                Console.WriteLine(khng.TenKhachHang);
                Console.Write("Ma khach hang: ");
                Console.WriteLine(khng.MaKhachHang);
                Console.Write("So dien thoai: ");
                Console.WriteLine(khng.SoDienThoai);
                Console.Write("Dia Chi: ");
                Console.WriteLine(khng.DiaChi);
                Console.Write("---------------------------------------\n");
            }
        }
        public static void TimRaPhieuMuaHangCuaCungMotKhach()
        {
            var pmh = (from n in dsPhieuMuaHang
                       group n.MaPhieuMuaHang by n.MaKhachHang into g
                       select new { MaKhach = g.Key, MaPhieu = g });
            var kh = from p in pmh
                     join k in dsKhachHang on p.MaKhach equals k.MaKhachHang
                     select new
                     {
                         tenkhach = k.TenKhachHang,
                         makhach = k.MaKhachHang,
                         maphieumuahang = p.MaPhieu
                     };
            foreach (var n in kh)
            {
                Console.WriteLine("Phieu mua hang co cung ma khach hang \"{0}\":", n.makhach);
                Console.Write("Ten khach hang: ");
                Console.WriteLine(n.tenkhach);
                foreach (var mp in n.maphieumuahang)
                {
                    Console.WriteLine(mp);
                }
            }
        }
        public static void SoLuongKhachHangTheoLoai()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("So Luong Khach Hang Thuoc Tung Loai Khach Hang:");
            dsKhachHang[0].LoaiKhachHang.loaiKH = "VIP";
            dsLoaiKhachHang[0].KhachHangs = (from kh in dsKhachHang
                                             where kh.MaLoaiKH == "MLKH001"
                                             select kh).ToList();
            dsKhachHang[1].LoaiKhachHang.loaiKH ="Than thiet";
            dsLoaiKhachHang[1].KhachHangs = (from kh in dsKhachHang
                                             where kh.MaLoaiKH == "MLKH002"
                                             select kh).ToList();
            dsKhachHang[2].LoaiKhachHang.loaiKH = "Thuong   ";
            dsLoaiKhachHang[2].KhachHangs = (from kh in dsKhachHang
                                             where kh.MaLoaiKH == "MLKH003"
                                             select kh).ToList();
            int stt = 1;
            foreach (var lkh in dsLoaiKhachHang)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\n{0}. Loai khach hang: {1}\n",stt,lkh.loaiKH);
                stt++;
                foreach (var kh in lkh.KhachHangs)
                {
                    Console.Write("Ma khach hang: ");
                    Console.WriteLine(kh.MaKhachHang);
                    Console.Write("Ten khach hang: ");
                    Console.WriteLine(kh.TenKhachHang);
                    Console.Write("So dien thoai: ");
                    Console.WriteLine(kh.SoDienThoai);
                    Console.Write("Gioi tinh: ");
                    Console.WriteLine(kh.GioiTinh);
                    Console.Write("Dia chi: ");
                    Console.WriteLine(kh.DiaChi);
                    Console.WriteLine("------------------------------------------------");
                }
                Console.WriteLine("=> Tong so khach:{0}", lkh.KhachHangs.Count());
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************");
            Console.WriteLine(); Console.WriteLine();
        }
        public static void NhungPhieuThuCoNgayTrungNhau()
        {
            var days = (from d in dsPhieuThu
                        group d by d.NgayThu into g
                        select new { NgayThu = g.Key, MaPhieuThu = g});
            foreach (var n in days)
            {
                Console.WriteLine("Nhung phieu thu co cung ngay thu\"{0:MM/dd/yyyy}\": ",n.NgayThu);
                foreach(var w in n.MaPhieuThu)
                {
                    Console.WriteLine(w.MaPhieuThu);
                }
            }
        }
        public static void SapXepThuTuTheoChuCaiDauTrongHo()
        {
            var character = (from chr in dsKhachHang
                             group chr by chr.TenKhachHang[0] into g
                             select new {FirstLetter = g.Key, TenKhachHang = g});
            var sapxep = from sx in character
                         orderby sx.FirstLetter
                         select sx;
            foreach(var kh in sapxep)
            {
                Console.WriteLine("Tu dau tien trong Ho cua khach la \"{0}\": ",kh.FirstLetter);
                foreach (var ho in kh.TenKhachHang)
                {
                    Console.WriteLine(ho.TenKhachHang);
                }
            }
        }
        public static void SanPhamDuocCungCapNhieuNhat()
        {
            Console.WriteLine("San pham duoc cung cap voi so luong nhieu nhat: ");
            var spccnn = from cc in dsChiTietHopDongCungCap
                        from sp in dsSanPham
                        where (cc.MaSP == sp.MaSanPham && cc.SoLuongHang ==   dsChiTietHopDongCungCap.Max(k => k.SoLuongHang))
                        select new
                        {
                            cc.MaSP,
                            cc.TongTienThanhToan,
                            sp.TenSanPham,
                            soluongmax = dsChiTietHopDongCungCap.Max(k => k.SoLuongHang)
                        };
            foreach (var i in spccnn)
            {
                Console.Write("Ten san pham: ");
                Console.WriteLine(i.TenSanPham);
                Console.Write("Ma san pham: ");
                Console.WriteLine(i.MaSP);
                Console.Write("So luong: ");
                Console.WriteLine(i.soluongmax);
                Console.Write("Tong gia: ");
                Console.WriteLine(i.TongTienThanhToan);
                Console.WriteLine("---------------------------------------------------");
            }
        }
        public static void ChiTietPhieuMuaHangCuaTungKhach()
        {
            var khach = from p in dsPhieuMuaHang
                      join kh in dsKhachHang on p.MaKhachHang equals kh.MaKhachHang
                      select new
                      {
                          makhachhang = kh.MaKhachHang,
                          tenkhachhang = kh.TenKhachHang,
                          ngaymuahang = p.NgayMua,
                          maphieumuahang = p.MaPhieuMuaHang
                      };
            var ctpmh = from i in khach
                        join k in dsChiTietPhieuMuaHang on i.maphieumuahang equals k.MaPMH
                        select new {i,
                                    k};
            var nhomKhachHang = from kh in ctpmh
                                group kh by kh.i.makhachhang into g
                                select new { MaKhachHang = g.Key, Khach = g };
            foreach (var v in nhomKhachHang){
                Console.Write("Ma khach hang: ");
                Console.WriteLine(v.MaKhachHang);
                Console.WriteLine("Chi tiet phieu mua hang: ");
                foreach(var t in v.Khach)
                {
                    Console.Write("Ma phieu mua hang: ");
                    Console.WriteLine(t.i.maphieumuahang);
                    Console.Write("Ten nguoi mua: ");
                    Console.WriteLine(t.i.tenkhachhang);
                    Console.Write("Ngay mua hang: ");
                    Console.WriteLine(t.i.ngaymuahang);
                    Console.Write("San pham: ");
                    Console.WriteLine(t.k.SP.TenSanPham);
                    Console.Write("So luong mua: ");
                    Console.WriteLine(t.k.SoLuongMua);
                    Console.Write("Tong gia tien: ");
                    Console.WriteLine(t.k.TongTien);
                    Console.Write("\n");
                }
                Console.WriteLine("----------------------------------------");
            }
        }
        public static void SoTienTrungBinhThuDuocTheoNgay()
        {
            var t = from n in dsPhieuThu
                    group n by n.NgayThu into g
                    select new
                    {
                        Ngaythu = g.Key,
                        SoTienTrungBinh = g.Average(m => m.SoTienThu)
                    };
            int stt = 1;
            Console.WriteLine("So tien thu trung binh theo ngay: ");
            foreach (var n in t)
            {
                Console.WriteLine("{0}.So tien thu duoc vao ngay {1:MM/dd/yyyy} la {2}", stt, n.Ngaythu, n.SoTienTrungBinh);
                stt++;
            }
            Console.Write("\n");
        }
        public static void TongSoTienThuDuocTheoNgay()
        {
            var m = from t in dsPhieuThu
                    group t by t.NgayThu into g
                    select new { Ngaythu = g.Key, Tien = g.Sum(t => t.SoTienThu)};
            Console.WriteLine("Tong so tien thu duoc theo ngay: ");
            foreach (var i in m )
            {
                Console.WriteLine("So tien thu duoc trong ngay {0:MM/dd/yyyy} la: {1}", i.Ngaythu,i.Tien);
                Console.Write("\n");
            }
        }
        public static void NhungPhieuMuaHangCoTienMuaHangNhieuHon950k()
        {
            var tien = from m in dsPhieuMuaHang
                       join n in dsPhieuThu on m.MaPhieuMuaHang equals n.MaPMH
                       join k in dsKhachHang on m.MaKhachHang equals k.MaKhachHang
                       where (n.SoTienThu > 950000)
                       select new
                       {
                           tenKhach = k.TenKhachHang,
                           maKhach = k.MaKhachHang,
                           soTien = n.SoTienThu,
                           maPhieu = m.MaPhieuMuaHang,
                           ngaymua = n.NgayThu
                       };
            Console.WriteLine("Danh sach Phieu mua hang co so tien mua lon hon 950000: ");
            foreach (var i in tien)
            {
                Console.WriteLine("Ma phieu mua hang:{0}",i.maPhieu);
                Console.WriteLine("-----------------------");
                Console.WriteLine("Ten khach hang: {0}", i.tenKhach);
                Console.WriteLine("Ma khach hang: {0}", i.maKhach);
                Console.WriteLine("So tien mua hang: {0}", i.soTien);
                Console.WriteLine("Ngay mua: {0:MM/dd/yyyy}", i.ngaymua);
                Console.WriteLine("\n");
            }
        }
        public static void NhungKhachHangCoNhieuHon1PhieuMuaHang()
        {
            dsKhachHang[0].PhieuMuaHangs = (from pmh in dsPhieuMuaHang
                                            where pmh.MaKhachHang == "KH001"
                                            select pmh).ToList();
            dsKhachHang[1].PhieuMuaHangs = (from pmh in dsPhieuMuaHang
                                            where pmh.MaKhachHang == "KH003"
                                            select pmh).ToList();
            dsKhachHang[2].PhieuMuaHangs = (from pmh in dsPhieuMuaHang
                                            where pmh.MaKhachHang == "KH002"
                                            select pmh).ToList();
            dsKhachHang[3].PhieuMuaHangs = (from pmh in dsPhieuMuaHang
                                            where pmh.MaKhachHang == "KH004"
                                            select pmh).ToList();
            dsKhachHang[4].PhieuMuaHangs = (from pmh in dsPhieuMuaHang
                                            where pmh.MaKhachHang == "KH005"
                                            select pmh).ToList();
            dsKhachHang[5].PhieuMuaHangs = (from pmh in dsPhieuMuaHang
                                            where pmh.MaKhachHang == "KH006"
                                            select pmh).ToList();
            dsKhachHang[6].PhieuMuaHangs = (from pmh in dsPhieuMuaHang
                                            where pmh.MaKhachHang == "KH007"
                                            select pmh).ToList();
            dsKhachHang[7].PhieuMuaHangs = (from pmh in dsPhieuMuaHang
                                            where pmh.MaKhachHang == "KH008"
                                            select pmh).ToList();
            dsKhachHang[8].PhieuMuaHangs = (from pmh in dsPhieuMuaHang
                                            where pmh.MaKhachHang == "KH009"
                                            select pmh).ToList();

            var p = from i in dsKhachHang
                     where (i.PhieuMuaHangs != null && i.PhieuMuaHangs.Count() > 1)
                     select i;
            Console.WriteLine("Nhung khach hang co nhieu hon 1 phieu mua hang: ");
            Console.WriteLine("------------------------------------------------------");

            foreach (var i in p)
            {
                Console.Write("Ten khach hang: ");
                Console.WriteLine(i.TenKhachHang);
                Console.Write("Ma khach hang: ");
                Console.WriteLine(i.MaKhachHang);
                Console.Write("So phieu mua hang: ");
                Console.WriteLine(i.PhieuMuaHangs.Count());
                Console.WriteLine("------------------------------------");
            }
        }
        public static void SoTienMuaSanPhamChoMoiNamVaMoiThang()
        {
            var i = from k in dsPhieuChiTien
                    group k by k.NgayChi.Year into g
                    select new
                    {
                        Nam = g.Key,
                        TongSoTienMuaSanPham = g.Sum(k => k.SoTienChi),
                        MonthGroup = from t in g
                                     group t by t.NgayChi.Month into y
                                     select new { mg = y.Key, tongtienthang = y.Sum(t => t.SoTienChi)}
                    };
            foreach (var h in i)
            {
                Console.WriteLine("So tien mua san pham theo nam {0} la {1}: ",h.Nam, h.TongSoTienMuaSanPham);
                foreach (var g in h.MonthGroup)
                {
                    Console.WriteLine("So tien mua hang thang {0} trong nam {1} la: {2}", g.mg, h.Nam, g.tongtienthang);
                    Console.WriteLine("----------------------------------------------");
                }
                
            }
        }

        /*--------------------------------------------------------------------*/
       static void Main(string[] args)
        {
           TaoDSLoaiKhachHang();
           TaoDSNhaCungCap();
           TaoDSLoaiSanPham();
           TaoDSKhachHang();
           TaoDSHopDongCungCap();
           TaoDSPhieuMuaHang();
           TaoDSPhieuChiTien();
           TaoDSPhieuThu();
           TaoDSSanPham();
           TaoDSChiTietHopDongCungCap();
           TaoDSChiTietPhieuMuaHang();


           //TimRaPhieuMuaHangCuaCungMotKhach();
           //NhungPhieuThuCoNgayTrungNhau();
           //DanhSachKhachHang();
           //DanhSachKhachHangLaNu();
           //DanhSachKhachHangLaNam();
           //SoLuongKhachHangTheoLoai();
           //SapXepThuTuTheoChuCaiDauTrongHo();
           //SanPhamDuocCungCapNhieuNhat();
           //ChiTietPhieuMuaHangCuaTungKhach();
           //SoTienTrungBinhThuDuocTheoNgay();
           //TongSoTienThuDuocTheoNgay();
           //NhungPhieuMuaHangCoTienMuaHangNhieuHon950k();
           //NhungKhachHangCoNhieuHon1PhieuMuaHang();
           SoTienMuaSanPhamChoMoiNamVaMoiThang();
           Console.ReadKey();
        }
    }
}
