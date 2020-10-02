using System;

namespace KtraCau1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] Arr= new int[10,50];
            int n, m;
            do
            {
                Console.WriteLine("Nhap so dong :");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("K hop le , nhap lai");
                }
            } while (n <= 0);
            do
            {
                Console.WriteLine("Nhap so cot :");
                m = int.Parse(Console.ReadLine());
                if (m <= 0)
                {
                    Console.WriteLine(" K hop le, nhap lai");
                }
            } while (m <= 0);
             CreateMatrix(ref Arr, ref n, ref m);
           
            int Max = max(Arr, n, m);
            Console.WriteLine("Phan tu lon nhat = {0} ", Max);
            Console.ReadLine();
        }
        static void CreateMatrix(ref int[,] Arr, ref int n, ref int m)
        {

            for (int i = 0; i < n * m; i++)
            {
                Console.Write("Nhap tu dong den cot [{0}][{1}] :", i / m, i % m);
                Arr[i / m, i % m] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n * m; i++)
            {
                Console.Write("{0}    ", Arr[i / m, i % m]);
                if ((i + 1) % m == 0)
                {
                    Console.Write("\n");
                }
            }
        }
       

        static int max(int[,] Arr, int d, int c)
        {
            int max = Arr[0, 0];
            for (int i = 0; i < d * c; i++)
            {
                if (max < Arr[i / c, i % c])
                {
                    max = Arr[i / c, i % c];
                }
            }
            return max;
        }
    }
}

