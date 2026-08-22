using System;

namespace HocOPP
{
    public class GiangVien : Nguoi
    {
        private string hocvi;
        public string HocVi
        {
            get { return hocvi; }
            set
            {
                if (string.IsNullOrEmpty(value)) hocvi = "hoc vi khong hop le";
                else hocvi = value;
            }
        }
        public GiangVien(string a, int b, string c) : base(a, b)
        {
            HocVi = c;
        }
        public override void GioiThieu()
        {
            Console.WriteLine($"{HoTen} la Giang Vien");
        }
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"HocVi: {HocVi}");
        }
    }

}
