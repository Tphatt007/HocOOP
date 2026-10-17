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
    public class KhuyenMaiVIP : IKhuyenMai
    {
        public decimal GiamGia()
        {
            //20%
            return (decimal)0.2;
        }
    }
}
