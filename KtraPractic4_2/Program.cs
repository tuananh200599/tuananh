using System;
using System.Collections.Generic;

namespace KtraPractic4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();
            int choice = 0;

            do
            {
                Console.WriteLine("1.Insert new student");
                Console.WriteLine("2.View list of students ");
                Console.WriteLine("3.Average mark ");
                Console.WriteLine("4.Exit ");
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        pro.InsertStudent();
                        break;

                    case 2:
                        pro.ViewListStudent();
                        break;
                    case 3:
                        pro.AverageMark();
                        break;
                    case 4:
                        return;
                        
                }

            } while (choice != 5);
        }
        int count = 0;
        Dictionary<int, object> ListStudent = new Dictionary<int, object>();
        public void InsertStudent() {           
            StudentMark studentMark = new StudentMark();
            studentMark.ID = count;
            Console.WriteLine("Full name :");
            studentMark.FullName = Console.ReadLine();
            Console.WriteLine("Class :");
            studentMark.Class = Console.ReadLine();
            Console.WriteLine("Semeter :");
            studentMark.Semeter = int.Parse(Console.ReadLine());
            for (int i = 0;i<5;i++)
            {
                Console.WriteLine("Marks of subject "+(i+1)+":");
                studentMark[i] = int.Parse(Console.ReadLine());
                
            }
            
            ListStudent.Add(count, studentMark);
            count++;
        }
        public void ViewListStudent()
        {
            foreach (StudentMark item in ListStudent.Values)
            {
                item.Display();
            }
        }
        public void AverageMark()
        {
            foreach (StudentMark item in ListStudent.Values)
            {
                item.Display();
                item.AveCal();                
            }
        }
         
    }
}
