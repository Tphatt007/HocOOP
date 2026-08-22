using System;

namespace HocOPP
{
    public class SinhVien : Nguoi
    {
        private string lop;
        private double diemtb;
        public double DiemTB
        {
            get { return this.diemtb; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    diemtb = value;
                }
                
            }
        }


        public string Lop
        {
            get { return this.lop; }
            set
            {
                if (string.IsNullOrEmpty(value)) this.lop = "Error";
                else this.lop = value;
            }
        }
        public SinhVien(string a, int b, string c) : base(a, b)
        {
            Lop = c;
        }
        public override void GioiThieu()
        {
            Console.WriteLine($"{HoTen} la Sinh Vien");
        }
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Lop: {Lop}");
            Console.WriteLine($"Diem TB: {diemtb}");
            Console.WriteLine("Xep Loai: " + XepLoai());
        }
        public string XepLoai()
        {
            if (diemtb >= 0 && diemtb< 5) return "Yeu";

            else if (diemtb >=5 && diemtb <6.5) return "Trung Binh";
         
            else if(diemtb >=6.5 && diemtb < 8) return "Kha";

            else return "Gioi";
        }
    }

}
