using System;

namespace HocOPP
{
    public class NhanVien : Nguoi
    {
        private string phongban;
        public string PhongBan
        {
            get { return this.phongban; }
            set
            {
                if (string.IsNullOrEmpty(value)) phongban = "Error";
                else phongban = value;
            }
        }
        public override void GioiThieu()
        {
            Console.WriteLine($"{HoTen} la Nhan Vien");
        }
        public NhanVien(string a, int b, string c) : base(a, b)
        {
            PhongBan = c;
        }
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Phong Ban: {PhongBan}");
        }
    }

}
