using System;

namespace phuong_thuc_hienthiloichao
{
    class Program
    {
        static void chao()
        {
            String a;
            Console.Write("Enter your name: ");
            a = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hello:" + a);

        }
        static void Main(string[] args)
        {
            chao();
            Console.ReadKey();
        }
        } }
