using System;

namespace HocOPP
{
    public abstract class Nguoi
    {
        private string hoten;
        private int namsinh;
        public Nguoi(string hoten, int namsinh)
        {
            this.HoTen = hoten;
            this.NamSinh = namsinh;
        }
        public string HoTen
        {
            get { return this.hoten; }
            set
            {
                if (string.IsNullOrEmpty(value)) this.hoten = "lỗi tên";
                else this.hoten = value;
            }
        }
        public int NamSinh
        {
            get { return this.namsinh; }
            set
            {
                if (value <= DateTime.Now.Year) this.namsinh = value;
            }
        }
        public abstract void GioiThieu();
        public virtual void InThongTin()
        {
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Nam Sinh: {NamSinh}");
        }

    }

}
