using System;

namespace cdtiente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ti gia tien:");
            int tigia = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap USD :");
            int usd = int.Parse(Console.ReadLine());
            int vnd = tigia * usd;
            Console.WriteLine("VND chuyen doi la : {0} VND", vnd);
        }
    }
}
