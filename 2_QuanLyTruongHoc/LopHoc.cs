using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HocOPP
{
    public class LopHoc
    {
        public int soluonggg;
        private string malop;
        public string MaLop
        {
            get { return this.malop; }
            set
            {
                if (string.IsNullOrEmpty(value)) { this.malop = "Error"; }
                else this.malop = value;
            }
        }
        private string tenlop;
        public string TenLop
        {
            get { return this.tenlop; }
            set
            {
                if (string.IsNullOrEmpty(value)) { this.tenlop = "Error"; }
                else this.tenlop = value;
            }

        }
        private GiangVien gvcn;
        public GiangVien GVCN
        {
            get { return this.gvcn; }
            set { gvcn = value; }

        }
        private List<SinhVien> dssv;
        public void InDanhSachSV()
        {
            foreach (SinhVien v in dssv)
            {
                Console.WriteLine(v.HoTen);
            }
        }
        public LopHoc(string a, string b, GiangVien c)
        {
            this.MaLop = a;
            this.TenLop = b;
            this.GVCN = c;

            dssv = new List<SinhVien>();
        }
        public void ThemSV(SinhVien sv)
        {
            if (sv != null)
            {
                if (dssv.Count >= 40)
                {
                    Console.WriteLine("Lop da day");
                    return;
                }
                dssv.Add(sv);
            }
        }

        public int DemSV()
        {
            
            return dssv.Count;
        }
        public List<SinhVien> LayDanhSachSV()
        {
            return new List<SinhVien>(dssv);
        }
        public SinhVien TimSVTheoTen(string a)
        {
            foreach (SinhVien v in dssv)
            {
                if (v.HoTen.Contains(a))
                {
                    return v;
                }

            }
            return null;
        }
        public SinhVien TimSVDiemcaonhat()
        {
            if (dssv.Count != 0)
            {
                SinhVien x = dssv[0];
                foreach (SinhVien v in dssv)
                {
                    if (v.DiemTB > x.DiemTB)
                        x = v;
                }
                return x;
            }
            else return null;
        }
        public SinhVien TimSVDiemthapnhat()
        {
            if (dssv.Count != 0)
            {
                SinhVien x = dssv[0];
                foreach (SinhVien v in dssv)
                {
                    if (v.DiemTB < x.DiemTB)
                        x = v;
                }
                return x;
            }
            else return null;
        }
        public double DiemTBlop()
        {
            if (dssv == null || dssv.Count == 0) return 0;
            else
            {
                double x = 0;
                foreach (SinhVien v in dssv)
                {
                    x += v.DiemTB;
                }
                return x / dssv.Count;
            }
        }
        public void XoaSV(string a)
        {
            if (!string.IsNullOrEmpty(a))
            {
                SinhVien sv = TimSVTheoTen(a);
                dssv.Remove(sv);
            }
            else return;
        }
        public void CapNhatDiem(string ten, double diem)
        {
            foreach (SinhVien v in dssv)
            {
                if (v.HoTen.Contains(ten))
                {
                    v.DiemTB = diem;
                }
            }
        }
        public void ThongKeXepLoai()
        {

            int gioi=0, kha=0, tb=0, yeu=0;
            foreach (SinhVien v in dssv)
            {
                string loai = v.XepLoai();
                if (loai == "Gioi") gioi++;
                if (loai == "Kha") kha++;
                if (loai == "Trung Binh") tb++;
                if (loai == "Yeu") yeu++;

            }
            Console.WriteLine( "====Thong Ke Xep Loai====");
            Console.WriteLine($"Gioi: {gioi} \nKha: {kha} \nTrung Binh: {tb} \nYeu: {yeu}");
        }

    }

}
