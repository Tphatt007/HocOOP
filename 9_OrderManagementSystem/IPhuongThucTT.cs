using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public interface IPhuongThucTT
    {
        void ThanhToan();
    }
    public class TTTienMat : IPhuongThucTT
    {
        public void ThanhToan()
        {
            Console.WriteLine("Thanh toan bang tien mat!");
        }
    }
    public class TTTheNganHang : IPhuongThucTT
    {
        public void ThanhToan()
        {
            Console.WriteLine("Thanh toan bang the ngan hang!");
        }
    }
    public class TTViDienTu : IPhuongThucTT
    {
        public void ThanhToan()
        {
            Console.WriteLine("Thanh toan bang vi dien tu!");
        }
    }
}
