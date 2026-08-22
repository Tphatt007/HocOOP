using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArenaOfMonster
{
    public abstract class Monster
    {
        private int hp;

        private int damage;

        public string name;
        public int HP
        {
            get { return hp; }
            set
            {
                hp = value < 0 ? 0 : value;
            }
        }

        public int Damage
        {
            get { return damage; }
            set
            {
                if (value >= 0)
                {
                    damage = value;
                }
            }
        }
        //==============Method==============
        public abstract void TanCong(Monster m);
        public void NhanSatThuong(int dame)
        {
            HP -= dame; // Tận dụng setter của HP để tự đưa về 0 nếu âm

            if (hp == 0)
            {
                DaChet();
            }
            else
            {
                Console.WriteLine($"{name} nhan sat thuong: -{dame}, HP con lai: {HP}");
            }
        }
        public void DaChet()
        {
            Console.WriteLine("Quai da chet");
        }
        public abstract Monster TaoBanSao();
    }
    public class Zombie : Monster
    {
       
        public Zombie()
        {
            name = "Zombie";
            HP = 100;
            Damage = 20;
        }
        public override void TanCong(Monster m)
        {
            Console.WriteLine("Zombie danh manh");
            m.NhanSatThuong(this.Damage);

        }
        public override Monster TaoBanSao()
        {
            return new Zombie();
        }

    }
    public class Skeleton : Monster
    {
        

        public override Monster TaoBanSao()
        {
            return new Skeleton();
        }
        public Skeleton()
        {
            name = "Skeleton";
            HP = 70;
            Damage = 30;
        }
        public override void TanCong(Monster m)
        {
            Console.WriteLine("Skeleton ban manh");
            m.NhanSatThuong(this.Damage);
        }
    }
    public class Goblin : Monster
    {
        

        public override Monster TaoBanSao()
        {
            return new Goblin();
        }
        public Goblin()
        {
            name = "Goblin";
            HP = 100;
            Damage = 25;
        }
        public override void TanCong(Monster m)
        {
            Console.WriteLine("Golbin danh nhanh");
            m.NhanSatThuong(this.Damage);
        }

    }
    public class DoiQuan
    {
        private List<Monster> dq;
        public List<Monster> DQ
        {
            get { return dq; }

        }
        //=========method===========
        public DoiQuan(int sla, int slb, int slc)
        {
            dq = new List<Monster>();


            for (int i = 0; i < sla; i++)
            {

                dq.Add(new Zombie());
            }
            for (int i = 0; i < slb; i++)
            {
                dq.Add(new Skeleton());
            }
            for (int i = 0; i < slc; i++)
            {
                dq.Add(new Goblin());
            }

        }
        public void Them(Monster m, int slm)
        {
            for (int i = 0; i < slm; i++)
                dq.Add(m.TaoBanSao());
        }

        public void Xoa(Monster m, int slm)
        {
            int z = 0, k = 0, g = 0;
            foreach (Monster i in dq)
            {
                if (i is Zombie) z++;
                if (i is Skeleton) k++;
                if (i is Goblin) g++;
            }
            int sl = 0;
            if (m is Zombie) sl = z;
            else if (m is Goblin) sl = g;
            else if (m is Skeleton) sl = k;
            //==============================
            //==============================
            int daxoa = 0;
            if (slm > sl) Console.WriteLine("So luong vuot qua. SL hien tai: " + sl);
            else
            {
                for (int u = dq.Count - 1; u >= 0; u--)
                {
                    if (dq[u].GetType() == m.GetType())
                    {
                        dq.Remove(dq[u]);
                        daxoa++;
                        if (daxoa == slm) break;
                    }
                }
                Console.WriteLine($"Da xoa, so luong con lai: {sl} - {slm}");
            }

        }
        public Dictionary<string, int> ConSong()
        {
            Dictionary<string, int> cs = new Dictionary<string, int>();
            foreach (Monster m in dq)
            {
                if (!cs.ContainsKey(m.name)) cs[m.name] = 0;
                cs[m.name]++;
            }
            
            return cs;
        }
        public void TongMau()
        {
            int tong = 0;
            foreach (Monster i in dq)
            {
                tong += i.HP;
            }
            Console.WriteLine("Tong mau: " + tong);
        }
    }
    public class TranDau
    {
        public void BatDau(DoiQuan a, DoiQuan b)
        {
            int luot = 1;
            Console.WriteLine("==========BAT DAU========");
            while (a.DQ.Count >0 && b.DQ.Count >0)
            {
                Console.WriteLine($"Luot {luot}");
                Monster quaiA = a.DQ[0];
                Monster quaiB = b.DQ[0];
                Console.WriteLine($"Quai {quaiA.name} doi A tan cong {quaiB.name} doi B");
                quaiA.TanCong(quaiB);
                if (quaiB.HP == 0)
                {
                    Console.WriteLine($"-> {quaiB.name} doi B chet, bi xoa khoi doi quan");
                    b.DQ.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine($"Quai {quaiB.name} doi B tan cong {quaiA.name} doi A");
                    quaiB.TanCong(quaiA);
                    if (quaiA.HP == 0)
                    {
                        Console.WriteLine($"-> {quaiA.name} doi A chet, bi xoa khoi doi quan");
                        a.DQ.RemoveAt(0);
                    }
                }
                luot++;
            }
            Console.WriteLine("======Tran dau ket thuc======");
            if (a.DQ.Count > 0) Console.WriteLine("Doi A thang");
            else if (b.DQ.Count > 0) Console.WriteLine("Doi B thang");
            else Console.WriteLine("2 doi hoa!");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo Đội A: 2 Zombie, 1 Skeleton, 1 Goblin
            DoiQuan doiA = new DoiQuan(2, 1, 1);

            // Tạo Đội B: 1 Zombie, 2 Skeleton, 1 Goblin
            DoiQuan doiB = new DoiQuan(1, 2, 1);

            TranDau arena = new TranDau();
            SLConSong(doiA);

            Console.ReadLine();
        }
        static void SLConSong(DoiQuan a)
        {
            Dictionary<string, int> cs = a.ConSong();
            foreach (var i in cs)
            {
                Console.WriteLine($"{i.Key} : {i.Value}");
            }
        }
    }
}
