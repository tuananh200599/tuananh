using System;

namespace ktranamnhuan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n");
            Console.Write("Kiem tra nam nhuan:\n");
            Console.Write("\n\n");

            int n;

            Console.Write("Hay nhap mot so nam bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());

            if ((n % 4 == 0 && n % 100 != 0) || (n % 400 == 0))
                Console.WriteLine("Nam " + n + " la nam nhuan \n");
            else Console.WriteLine("Nam " + n + " khong phai la nam nhuan");
        }
    }
}