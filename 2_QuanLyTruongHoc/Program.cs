using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HocOPP
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            GiangVien gvIT1 = new GiangVien("Phan Tan Phat", 1990, "Thac Si");
            LopHoc IT = new LopHoc("IT0001", "Cong Nghe Thong Tin", gvIT1);
            SinhVien sv1 = new SinhVien("Nguyen Van An", 2005, "CNTT01");
            SinhVien sv2 = new SinhVien("Tran Thi Binh", 2004, "CNTT01");
            SinhVien sv3 = new SinhVien("Le Minh Cuong", 2005, "CNTT01");
            sv1.DiemTB = 9;
            sv2.DiemTB = 6;
            sv3.DiemTB = 7;
            
            IT.ThemSV(sv1);
            IT.ThemSV(sv2);
            IT.ThemSV(sv3);
            ISoSanhSinhVien sosanh = new SoSanhTheoDiemTB();

            List<SinhVien> ds = IT.LayDanhSachSV();

            SapXepLopHoc sx = new SapXepLopHoc();
            sx.SapXep(ds, sosanh);
            foreach (SinhVien s in ds)
            {
                Console.WriteLine( s.DiemTB);
            }
            Console.WriteLine("========================================");
            //IT.InDanhSachSV();

            //NhanVien nv1 = new NhanVien("Le Vy", 2000, "Phong Nhan Su");
            //List<Nguoi> ds = new List<Nguoi>();
            //ds.Add(sv1);
            //ds.Add(sv2);
            //ds.Add(gvIT1);
            //ds.Add(nv1);
            //Console.WriteLine( "======thong ke=======");
            //int sv = 0, gv = 0, nv = 0;
            //foreach (Nguoi i in ds)
            //{
            //    if(i is SinhVien)
            //    {
            //        sv++;
            //    }
            //    if(i is GiangVien)
            //    {
            //        gv++;
            //    }
            //    if(i is NhanVien)
            //    {
            //        nv++;
            //    }
            //}
            //Console.WriteLine($"Sinh Vien: {sv}");
            //Console.WriteLine($"Giang Vien: {gv}");
            //Console.WriteLine($"Nhan Vien: {nv}");
            //Console.WriteLine("-------------------------------");
            //TimTheoLoai(ds);
            //Console.WriteLine("-------------------------------");
            //InThongTin(ds);
        }
        static void TimTheoLoai(List<Nguoi> ds)
        {
            Console.WriteLine(" 1.Nhan Vien \n 2.Sinh Vien \n 3.Giang Vien");
            Console.Write("Nhap loai can tim (1 or 2 or 3): ");
            int a = int.Parse(Console.ReadLine());
            foreach (Nguoi i in ds)
            {
                if (a == 1 && i is NhanVien)
                {
                    Console.WriteLine(i.HoTen);
                }
                else if (a == 2 && i is SinhVien)
                {
                    Console.WriteLine(i.HoTen);
                }
                else if (a == 3 && i is GiangVien)
                {
                    Console.WriteLine(i.HoTen);
                }
            }

        }
        static void InThongTin(List<Nguoi> ds)
        {
            foreach (Nguoi i in ds)
            {
                i.InThongTin();
            }
        }
    }

}
