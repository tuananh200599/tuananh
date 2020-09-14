using System;

namespace xoaphantumang
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = { 2, 4 , 6 , 8 , 10  };
            int k;
            Console.Write("Mang ");
            HienMang(array, array.Length);
            Console.WriteLine("Nhap phan tu can xoa");
            k = Convert.ToInt32(Console.ReadLine());
            Xoa(array, k);
            Console.WriteLine("Mang sau khi xoa : ");
            HienMang(array, array.Length - 1);
        }

        static bool Xoa(int[] a, int k)
        {
            bool found = false;
            for (int i = 0; i < a.Length; ++i)
            {
                if (found)
                {
                    a[i - 1] = a[i];
                }
                else if (a[i] == k)
                {
                    int x = i;
                    Console.WriteLine($"Vi tri cua phan tu {k} : {x} ");
                    found = true;
                }
            }
            return found;
        }

        static void HienMang(int[] a, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
