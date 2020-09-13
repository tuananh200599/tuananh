using System;

namespace demsoluongsv
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 30)
                    Console.WriteLine("Size should not exceed 30");

            } while (size > 30);
           
            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                do {
                    Console.WriteLine("Enter a mark for student " + (i + 1) + ": ");
                    array[i] = Int32.Parse(Console.ReadLine());
                } while (array[i] > 10);  

            int count = 0;
            Console.WriteLine("List of mark: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
                if (array[j] >= 5 && array[j] <= 10) 
                    count++;
            }
            Console.WriteLine("\n The number of students passing the exam is " + count);
        }
    }
    }
}