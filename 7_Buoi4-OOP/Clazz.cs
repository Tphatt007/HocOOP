

namespace Buoi4_OOP
{
    internal partial class Program
    {
        class Clazz 
        {
            private List<Student> students;
            public void AddStu(Student student)
            {
                if (student == null || students.Contains(student))
                {

                }
                else
                    students.Add(student);
            }
            public Clazz()
            {
                 students = new List<Student>();
            }
            public void PrintStu()
            {
                foreach (Student student in students)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            public int CountStu()
            {
                return students.Count;
            }

            public Student? GetStudentById(string id)
            {
                if (string.IsNullOrEmpty(id)) return null;
                Student st = new Student(id,"","");
                int index = students.IndexOf(st);
                if (index == -1) return null;
                return students[index];
            }
            public bool UpdateStudent(string id, Student newstu)
            {
                Student? st = GetStudentById(id);
                if (st == null) return false;
                int index = students.IndexOf(st);
                if ( newstu.Id == students[index].Id)
                {
                    students[index] = newstu;
                    return true;
                }
                else Console.WriteLine("ID khong trung khop");
                    return false;
            }
            public bool DeleteById(string id)
            {
                Student? stu = GetStudentById(id);
                if (stu == null) return false;
                students.Remove(stu);
                return true;
            }
        }
    }

    
}
