using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public interface IKhuyenMai
    {
        decimal GiamGia();
    }
    public class KhuyenMaiKhaiTruong: IKhuyenMai
    {
        public decimal GiamGia()
        {
            //10%
            return (decimal)0.1;
        }
    }
}
