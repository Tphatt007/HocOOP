using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {
        private string name;
        private double score;
        private static int totalStudents = 0;

        public Student(string name, double score)
        {
            this.name = name;
            this.score = score;
            totalStudents++;
        }
        public string GetName()
        {
            return name;
        }
        public double GetScore()
        {
            return score;
        }
        public bool IsPassed()
        {
            return score >= 5;
        }
        public string GetClassification()
        {
            if (score >= 8) return "Excellent";
            else if (score >= 6.5 && score < 8) return "Good";
            else if (score >= 5 && score < 6.5) return "Avergage";
            else return "Weak";
        }
        public static int GetTotalStudents()
        {
            return totalStudents;
        }
        public static Student FindTopStudent(Student[] dss)
        {
            Student sd =
            sd= dss[0];
            foreach (Student s in dss)
            {
                if (sd.score < s.score) sd = s;
            }
            return sd;
        }
        public static double CalculateAverageScore(Student[] st)
        {
            double tong = 0;
            foreach (Student s in st)
            {
                tong += s.score;
            }
            return tong / st.Length;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] dshs =
            {
                new Student("Pham Hung", 9.5),
                new Student("Le The Vinh", 4),
                new Student("Nguyen Duc Thinh", 6.0),
                new Student("Phan Tan Phat", 10),
                new Student("Nguyen Quoc Phong", 7.8)

            };
            Console.WriteLine("So luong: "+Student.GetTotalStudents());
            Console.WriteLine("========Danh sach========");
            foreach (Student a in dshs)
            {
                Console.WriteLine(
                 "Name: " + a.GetName() +
                 ", Score: " + a.GetScore() +
                 ", Classification: " + a.GetClassification() +
                 ", Status: " + (a.IsPassed() ? "Passed" : "Failed"));
            }
            Console.WriteLine("Diem cao nhat: "+Student.FindTopStudent(dshs).GetScore());
            Console.WriteLine("Diem trung binh: "+Student.CalculateAverageScore(dshs));

        }
    }

}
