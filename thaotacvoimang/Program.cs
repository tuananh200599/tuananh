using System;

namespace thaotacvoimang
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] numbers = new int[5];
            

            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;
            

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            

            Console.WriteLine("Tong cua mang la : {0}",tongmang(numbers));
        }

        static int tongmang(int []a)
        {
            
            int total = 0;
            for (int i = 0; i < a.Length; i++)
            {
                total = total + a[i];
            }
            return total;
        }
    }
}