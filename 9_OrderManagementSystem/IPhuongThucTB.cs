using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public interface IPhuongThucTB
    {
        void ThongBao();
    }
    public class TBSMS : IPhuongThucTB
    {
        public void ThongBao()
        {
            Console.WriteLine("SMS");
        }
    }
    public class TBEmail : IPhuongThucTB
    {
        public void ThongBao()
        {
            Console.WriteLine("Email");
        }
    }
}
