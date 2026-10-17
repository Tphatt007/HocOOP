namespace OrderManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SanPham banphim = new SanPham("SP0001", "Ban Phim", 500000);
            SanPham chuot = new SanPham("SP0002", "Chuot", 300000);
            DonHang dh1 = new DonHang("DH0001");
            dh1.ThemSanPham(banphim, 2);
            dh1.ThemSanPham(chuot, 1);
            KhuyenMaiKhaiTruong km = new KhuyenMaiKhaiTruong();
            ThanhToan tt = new ThanhToan();
            TTViDienTu ttvdt = new TTViDienTu();
            tt.ThanhToanTien(dh1, km, ttvdt);
            ThongBao tb = new ThongBao();
            TBEmail pttb = new TBEmail();
            tb.TBDH(dh1, pttb);
        }
    }
}
