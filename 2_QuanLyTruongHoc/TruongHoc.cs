using System;
using System.Collections.Generic;

namespace HocOPP
{
    public class TruongHoc
    {
        private string tentruong;
        public string TenTruong
        {
            get { return this.tentruong; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.tentruong = "Loi Ten Truong";
                }
                else
                {
                    this.tentruong = value;
                }

            }

        }
        private List<LopHoc> dslh;
        private List<GiangVien> dsgv;
        private List<NhanVien> dsnv;
        public TruongHoc(string a)
        {
            TenTruong = a;
            dslh = new List<LopHoc>();
            dsgv = new List<GiangVien>();
            dsnv = new List<NhanVien>();
        }
        public void ThemLopHoc(LopHoc lop)
        {
            if (lop == null)
            {
                Console.WriteLine("Error");
            }
            else if (dslh.Contains(lop))
            {
                Console.WriteLine("Khong duoc trung");
            }
            else
                dslh.Add(lop);
        }
        public void ThemGiangVien(GiangVien gv)
        {
            if (gv == null)
            {
                Console.WriteLine("Error");
            }
            else if (dsgv.Contains(gv))
            {
                Console.WriteLine("Khong duoc trung");
            }
            else
                dsgv.Add(gv);
        }
        public void ThemNhanVien(NhanVien nv)
        {
            if (nv == null)
            {
                Console.WriteLine("Error");
            }
            else if (dsnv.Contains(nv))
            {
                Console.WriteLine("Khong duoc trung");
            }
            else
                dsnv.Add(nv);
        }
        public void ThongKe()
        {
            Console.WriteLine("====Thong Ke====");
            Console.WriteLine("So Lop Hoc: " + dslh.Count);
            Console.WriteLine("So Giang Vien: " + dsgv.Count);
            Console.WriteLine("So Nhan Vien: " + dsnv.Count);
        }
        public GiangVien TimGiangVien(string ten)
        {
            if (ten != null)
            {
                foreach (GiangVien v in dsgv)
                {
                    if (v.HoTen.Contains(ten))
                    {
                        return v;
                    }
                }
            }
            return null;
        }
        public NhanVien TimNhanVien(string ten)
        {
            if (ten != null)
            {
                foreach (NhanVien v in dsnv)
                {
                    if (v.HoTen.Contains(ten))
                    {
                        return v;
                    }
                }
            }
            return null;
        }
        public void InThongTin()
        {
            Console.WriteLine($"===== Thong tin truong {tentruong} ======");
            foreach (LopHoc l in dslh)
            {
                Console.WriteLine("Lop: " + l.TenLop);
                Console.WriteLine("GVCN: " + l.GVCN.HoTen);
                Console.WriteLine("Sinh Vien: ");
                l.InDanhSachSV();
                Console.WriteLine("---------------------");
            }
        }
    }

}
