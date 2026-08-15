using System.Collections.Generic;
using System.Security.Cryptography;

namespace HocOPP
{
    public class ThongKeLopHoc
    {
        public double TinhDiemTrungBinh(IEnumerable<SinhVien> dssv)
        {
            double tong = 0;
            int dem = 0;
            foreach (var i in dssv)
            {
                tong += i.DiemTB;
                dem++;
            }
            return tong / dem;
        }
        public List<SinhVien> LayDanhSach(IEnumerable<SinhVien> dssv)
        {
            List<SinhVien> ds = new List<SinhVien>();
            foreach (SinhVien i in dssv)
            {
                ds.Add(i);
            }
            return ds;
        }
    }

}
