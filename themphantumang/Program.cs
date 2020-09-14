using System;

namespace themphantumang
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = { 2, 4, 6, 8, 10 , 12 };
            int x, k;
            Console.WriteLine("Nhap x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vi tri can chen :");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mang truoc khi chen : ");
            HienThi(arr, arr.Length - 1);
            Chen(arr, x, k);
            Console.WriteLine("Mang sau khi chen : ");
            HienThi(arr, arr.Length);
        }

        private static void Chen(int[] arr, int x, int k)
        {
            for (int i = arr.Length - 1; i > k; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[k] = x;
        }

        static void HienThi(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        
    }
}
