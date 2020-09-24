using System;
using System.Collections.Generic;

namespace KtraPractic
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();            
            int choice = 0;
             
            do
            {
                Console.WriteLine("1.Insert student");
                Console.WriteLine("2.View all student ");
                Console.WriteLine("3.Search Student ");
                Console.WriteLine("4.Exit ");                
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);
                
               
                switch (choice)
                {
                    case 1:
                        pro.InsertStudent();
                        break;
                    case 2:
                        pro.ViewAllStudent();
                        break;
                    case 3:
                        pro.SearchStudent();
                        break;                                       
                    case 4:
                        return;
                        
                }
            } while (choice != 4);
        }
        int count = 0;
        Dictionary<int, object> ListStudent = new Dictionary<int, object>();
        public void InsertStudent()
        {
            Student student = new Student();
            student.ID = count;
            Console.WriteLine("Nhap Fullname : ");
            student.Fullname = Console.ReadLine();
            Console.WriteLine("Nhap Date of Birth :");
            student.DateofBirth = DateTime.Parse(Console.ReadLine());  ;
            Console.WriteLine("Nhap Native :");
            student.Native = Console.ReadLine();
            Console.WriteLine("Nhap Class : ");
            student.Class = Console.ReadLine();
            Console.WriteLine("Nhap PhoneNo : ");
            student.PhoneNo = Console.ReadLine();
            Console.WriteLine("Nhap Mobile : ");
            student.Mobile = int.Parse(Console.ReadLine());
            ListStudent.Add(count, student);
            count++;
        }
        public void ViewAllStudent()
        {
            foreach (Student item in ListStudent.Values)
            {
                item.Display();
            }
        }
        public void SearchStudent()
        {
            Console.WriteLine("Nhap ten hoc sinh : ");
            string name = Console.ReadLine();
            foreach (Student item in ListStudent.Values){
                if (item.Fullname.Equals(name))
                    item.Display();
                else{ name = "K co ten trong danh sach";
                
                }
            }
                Console.WriteLine(name);    
        }
    }

}
