

namespace Buoi4_OOP
{
    internal partial class Program
    {
        class Student
        {
            public string Id { get; }
            public string Name { get; }
            public string Email { get; }
            public Student() : this("No id", "No name", "No email")
            {

            }
            
            public Student(string id, string name, string email)
            {
                Id = id;
                Name = name;
                Email = email;
            }

            public override bool Equals(object? obj)
            {
                if (obj == null) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj is Student other) return this.Id == other.Id;
                return false;
            }
            public override int GetHashCode()
            {
                return Id.GetHashCode();
            }
            public override string ToString()
            {
                return $"ID: {Id}, Name: {Name}, Email: {Email}";
            }
        }
    }

    
}
