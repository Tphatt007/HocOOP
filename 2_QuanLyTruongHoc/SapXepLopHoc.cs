using System.Collections.Generic;

namespace HocOPP
{
    internal partial class Program
    {
        public class SapXepLopHoc 
        {
            
            public void SapXep(List<SinhVien> dssv, ISoSanhSinhVien ss)
            {
                for (int i = 0; i < dssv.Count - 1; i++)
                {
                    for (int j = i + 1; j < dssv.Count; j++)
                    {
                        
                        if(ss.LonHon(dssv[j],dssv[i]))
                        {
                            SinhVien temp = dssv[i];
                            dssv[i] = dssv[j];
                            dssv[j] = temp;
                        }
                    }
                }
            }
            

        }
        public class SoSanhTheoDiemTB : ISoSanhSinhVien
        {
            public bool LonHon(SinhVien a, SinhVien b)
            {
                return a.DiemTB>b.DiemTB;
            }
            
        }
        public class SoSanhTheoTen : ISoSanhSinhVien
        {
            public bool LonHon(SinhVien a, SinhVien b)
            {
                return a.HoTen.CompareTo(b.HoTen) > 0;
            }
        }

        public class SoSanhTheoTuoi : ISoSanhSinhVien
        {
            public bool LonHon(SinhVien a, SinhVien b)
            {
                return a.NamSinh < b.NamSinh;
            }
        }
        public interface ISoSanhSinhVien
        {
            bool LonHon(SinhVien a, SinhVien b);

        }
    }

}
