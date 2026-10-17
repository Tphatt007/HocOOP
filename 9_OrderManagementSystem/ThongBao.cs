using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    internal class ThongBao
    {
        public void TBDH(DonHang dh, IPhuongThucTB pt)
        {
            Console.Write($"Ma don hang {dh.MaDH} cua quy khach da duoc gui ve ");
            pt.ThongBao();
        }
    }
}
