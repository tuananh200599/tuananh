using System;

namespace phuong_thuc_cdtiente
{
    class Program
    {             
        static void Main(string[] args)
        {
            int usd, tigia = 23000000;
            Console.WriteLine("Nhap USD :");
            usd = int.Parse(Console.ReadLine());
            vnd(usd, tigia);
            Console.ReadKey();
        }
        static int vnd (int a,int b)
        {
            int c = a * b;
            Console.WriteLine("VNĐ là : {0} Vnđ", +c);
            return c;
        }

    }
}
