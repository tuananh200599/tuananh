using System;

namespace KtraPractic
{
    public class Student : IStudent
    {
        public Student()
        {
        }

        public string Fullname { get; set ; }
        public int ID { get; set; }
        public DateTime DateofBirth { get ; set ; }
        public string Native { get; set; }
        public string Class { get ; set; }
        public string PhoneNo { get ; set ; }
        public int Mobile { get; set; }

        public void Display()
        {
            Console.WriteLine("Fullname : " + Fullname);
            Console.WriteLine("Id : " + ID );
            Console.WriteLine("DateofBirth : " + DateofBirth);
            Console.WriteLine("Class : "+ Class);
            Console.WriteLine("Native : " + Native);
            Console.WriteLine("PhoneNo: "+ PhoneNo);
            Console.WriteLine("Mobile : " +Mobile);
            Console.ReadLine();
    
            
        }
    }
}