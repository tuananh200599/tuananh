using System;
using System.Collections.Generic;

namespace Practical8
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();
            int choice = 0;

            do
            {
                Console.WriteLine("1.Add a student");
                Console.WriteLine("2.List students ");
                Console.WriteLine("3.Classify students ");
                Console.WriteLine("4.Exit ");
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        pro.AddStudent();
                        break;

                    case 2:
                        pro.ListStudents();
                        break;
                    case 3:
                        pro.ClassifyStudent();
                        break;
                    case 4:
                        return;

                }

            } while (choice != 5);
        }
        int count = 0;
        Dictionary<int, object> ListStudent = new Dictionary<int, object>();
        public void AddStudent()
        {
            Student student = new Student();
            student.Id = count;
            Console.WriteLine("Name :");
            student.Name = Console.ReadLine();
            Console.WriteLine("Class :");
            student.Classs = Console.ReadLine();
            Console.WriteLine("Math mark : ");
            student.Math = float.Parse(Console.ReadLine());
            Console.WriteLine("Physic mark : ");
            student.Physic = float.Parse(Console.ReadLine());
            Console.WriteLine("Chemistry mark : ");
            student.Chemistry = float.Parse(Console.ReadLine());



            ListStudent.Add(count, student);
            count++;
        }
        public void ListStudents()
        {
            foreach (Student item in ListStudent.Values)
            {
                item.Display();
            }
        }
        public void ClassifyStudent()
        {
            foreach (Student item in ListStudent.Values)
            {
                item.Average();
                item.Display();
            }


        }
    }
}

