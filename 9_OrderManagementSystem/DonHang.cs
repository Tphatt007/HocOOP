using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    
    internal class DonHang
    {
        private string madh;
        public string MaDH
        {
            get { return madh; }
            set { if(!string.IsNullOrEmpty(value)) madh = value; }
        }

        private List<SanPham> list;

        public bool ThemSanPham(SanPham sp, int soluong)
        {
            if (sp == null|| soluong <=0) return false;
            else
            {
                for (int i = 0; i < soluong; i++)
                { list.Add(sp); }
                return true;
            }

        }
        public DonHang(string ma)
        {
            list = new List<SanPham>();
            MaDH = ma;
        }
        
        public decimal ThanhTien()
        {
            decimal tong = 0;
            foreach (var item in list)
            {
                tong += item.GiaBan;
            }
            return tong;
        }
    }
}
