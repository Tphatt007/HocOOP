using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    internal class SanPham
    {
        private string masp;
        public string MaSP
        {
            get { return masp; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    masp = value;
            }
        }


        private string tensp;
        public string TenSP
        {
            get { return tensp; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tensp = value;
            }
        }

        private decimal giaban;
        public decimal GiaBan
        {
            get { return giaban; }
            set
            {
                if(value >= 0)
                giaban = value;
            }
        }

        public SanPham(string masp, string tensp, decimal giaban)
        {
            MaSP = masp;
            TenSP = tensp;
            GiaBan = giaban;
        }
    }
}
