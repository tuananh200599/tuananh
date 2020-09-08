using System;

namespace SoNgt
{
    class Program
    {static void Main(string[] args)
        {
            Console.Write("\n");
            Console.Write("Kiem tra n co phai la so nguyen to:\n");
            Console.Write("\n\n\n\n");

            int s=0;
            int n,i;
            

            Console.Write("Hay nhap mot so n bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++) 
                if (n % i == 0)
                    s++;

            if (s == 2)
                Console.WriteLine("La so ngto");
            else
                Console.WriteLine("Khong phai la so ngto");

            Console.ReadKey();
        }
    }
}
