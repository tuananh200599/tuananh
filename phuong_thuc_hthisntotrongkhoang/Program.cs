using System;

namespace phuong_thuc_hthisntotrongkhoang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            
            Console.WriteLine("Nhap n :");
            
            hienthi();
        }
        static void hienthi()
        {
            int n = int.Parse(Console.ReadLine());
            int dem = 0;
            Console.Write($"Cac so nguyen to nam trong khoang {n} la:");
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        dem++;
                    }
                }

                if (dem == 2)
                {
                    Console.Write($"{i},");
                }
                dem = 0;
            }
        }
    }
}

