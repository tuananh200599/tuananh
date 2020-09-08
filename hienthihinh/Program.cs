using System;

namespace hienthihinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle (The corner is square at 4 different angles: top-left, top-right, botton-left, botton-right");

            Console.WriteLine("3. Print isosceles triangle");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());
            switch (choice)
     {
      case 1:
           Console.WriteLine("Print the rectangle");
           Console.WriteLine("******");
           Console.WriteLine("******");
           Console.WriteLine("******");
           
           break;
      case 2:
           Console.WriteLine("Print the square triangle (The corner is square at 4 different angles: top-left, top-right, botton-left, botton-right");
           
           Console.WriteLine("* ");
           Console.WriteLine("* * ");
           Console.WriteLine("* * * ");
           Console.WriteLine("* * * *");
           Console.WriteLine("* * * * *");
           break;
           for(int i=1; i<=5; i++)
        for(int j=1; j<i; j++);
      case 3:
           Console.WriteLine("Print isosceles triangle");
           Console.WriteLine("* * * * *");
           Console.WriteLine("* * * *");
           Console.WriteLine("* * * ");
           Console.WriteLine("* *");
           Console.WriteLine("* ");
           break;
           for(int i=7;i>=1;i--)
        for(int j=1;j<=i;j++);
      case 4:
           Environment.Exit(4);
           break;
     default:
           Console.WriteLine("No choice!");
           break;
 }
            while(choice!= 0) {
      
} 
        

    }
}}
