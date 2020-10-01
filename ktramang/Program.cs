using System;
using System.Collections.Generic;
using System.Text;

namespace ktramang
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();
            int choice = 0;

            do
            {
                Console.WriteLine("1.Tao Mang");
                Console.WriteLine("2.Kiem tra mang doi xung ");
                Console.WriteLine("3.Sap xep mang ");
                Console.WriteLine("4.Tim kiem mang ");
                Console.WriteLine("5.Thoat ");
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        pro.CreateArray();
                        break;

                    case 2:
                        pro.IsSymmetryArray();
                        break;
                    case 3:
                        pro.BubbleSort();
                        break;
                    case 4:
                        pro.Find();
                        break;
                    case 5:
                        return;

                }

            } while (choice != 5);
        }

        Dictionary<int, object> ListArray = new Dictionary<int, object>();


        public void arIn(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[" + i + "]=");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public void arOut(int[] arr, int n)
        {
            Console.WriteLine("Mang : ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }

        public void CreateArray()
        {
            Console.WriteLine("Nhap so phan tu cua mang : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arIn(arr, n);
            arOut(arr, n);

            Console.ReadKey();





        }
        public void IsSymmetryArray()
        {

        }
        public void BubbleSort()
        {

            int n, temp;
            int[] a;
            Console.WriteLine("Nhap so phan tu mang :");
            n = int.Parse(Console.ReadLine());

            a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}]:", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }

            Console.WriteLine("Mang sau khi sap xep:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ,", a[i]);
            }
        }
        public void Find()
        {

        }
    }
}
