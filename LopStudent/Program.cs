using System;

namespace LopStudent
{
    class Program
    {
        static void Main(string[] args)
        {
           Student student1 = new Student(1, "Tuan Anh", "Quang Binh", 30);

     Student student2 = new Student();
     student2.SetId(2);
     student2.SetName("Van Trung");
     student2.SetAddress("Hue");
     student2.SetAge(25);

     Console.WriteLine(student1.ToString());
     Console.WriteLine(student2.ToString());
     Console.Read();
        }
    }
}
