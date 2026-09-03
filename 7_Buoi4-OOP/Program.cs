

namespace Buoi4_OOP
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            Student s1 = new Student("1001", "Than Thi Det", "det@gmail.com");
            Student s2 = new Student("1002", "Nguyen Van Coi", "coi@hotmail.com");
            Student s3 = new Student("1003", "Tran Van Tun", "tun@outlook.com");

            Clazz cls = new Clazz();

            cls.AddStu(s1);
            cls.AddStu(s2);
            cls.AddStu(s3);
            

            Console.WriteLine("Danh sach sinh vien");
            cls.PrintStu();
        }
    }

    
}
