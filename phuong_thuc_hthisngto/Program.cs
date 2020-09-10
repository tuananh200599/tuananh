using System;

namespace phuong_thuc_hthisngto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            
            Console.WriteLine("Nhap n :");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"{n} so nguyen to dau tien la :");
            daySNT(n);
        }
        static void daySNT(int n)
        {
            int index = 0;
            for (int i = 2; i < 200; i++)
            {
                bool check = true;
                for (int count = 2; count <= Math.Sqrt(i); count++)
                {
                    if (i % count == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    index = index + 1;
                    if (index <= n)
                    {
                        Console.Write($"{i} ,");
                    }
                }
            }
        }
    }
}