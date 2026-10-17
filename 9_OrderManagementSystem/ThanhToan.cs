using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    internal class ThanhToan
    {
        public void ThanhToanTien(DonHang dh,IKhuyenMai km,IPhuongThucTT pt)
        {
            decimal tientra = dh.ThanhTien() - (dh.ThanhTien() * km.GiamGia());
            Console.WriteLine("Tong tien: "+ dh.ThanhTien());
            Console.WriteLine("Tien duoc giam: "+ dh.ThanhTien() * km.GiamGia());
            Console.WriteLine("Tien phai tra: "+tientra);
            pt.ThanhToan();
        }
    }
}
