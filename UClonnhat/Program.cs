using System;

namespace UClonnhat
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            do
            {
                Console.WriteLine("Nhap gia tri so a: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap gia tri so b: ");
                b = int.Parse(Console.ReadLine());
            } while (a == 0 || b == 0);
            Math.Abs(a);
            Math.Abs(b);
            while (a != b)
            {
                if (a > b) 
                    a = a - b;
                else b = b - a;
            }
            Console.WriteLine("Uoc so chung lon nhat la: {0}", a);
            Console.ReadLine();
        }

    }
}

