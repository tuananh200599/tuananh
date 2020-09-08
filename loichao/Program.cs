using System;

namespace loichao
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            Console.Write("Enter your name: ");
            a = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hello:"+a);
            Console.ReadKey();
        }

    }
}