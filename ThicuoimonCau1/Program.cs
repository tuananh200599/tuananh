using System;
using System.Text;
namespace ThicuoimonCau1
{
    class Program
    {
        static void Main(string[] args)
        {

            Program pro = new Program();
            int choice = 0;

            do

            {
                Console.WriteLine("1. CreateArray");
                Console.WriteLine("2. IsSymmetryArray");
                Console.WriteLine("3. SelectionSort");
                Console.WriteLine("4. Find");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Select item : ");
                choice = int.Parse(Console.ReadLine());
                int[] arr = CreateArray();
                switch (choice)
                {
                    case 1:
                        CreateArray(); break;
                    case 2:
                        bool dx = IsSymmetryArray(arr);
                        if (dx)
                        {
                            Console.WriteLine("Mang doi xung!!  ");
                        }
                        else Console.WriteLine("Mang k đoi xung!!! ");
                        break;
                    case 3:
                        SelectionSort(arr); break;
                    case 4:
                        Find(arr); break;
                    case 5:
                        return;
                }
            } while (choice != 5);
        }
        static int[] CreateArray()
        {

            int n = 0;

            while (n <= 0)
            {
                Console.WriteLine("Nhap so ptu mang : ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Phan tu thu {i}: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            return a;
        }
        static bool IsSymmetryArray(int[] arr)
        {
            int n = arr.Length / 2;
            for (int i = 0; i <= n; i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void SelectionSort(int[] array)
        {
            Array.Sort(array);
        }
        static void Find(int[] array)
        {

            Console.WriteLine("Nhap ptu can tim : ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                if (array[i] == n)
                {
                    Console.WriteLine($"Ptu [{i}] nam o vi tri {n}");
                }
                else Console.WriteLine("Khong tim thay ptu nay ");
            }
        }

    }
}