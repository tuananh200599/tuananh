using System;

namespace GTNNtrongmang
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Nhap kich thuoc cho mang (Toi da 20):");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                    Console.WriteLine("Vuot qua kich thuoc!");
            } while (size > 20);

            
            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Nhap phan tu " + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            
            Console.WriteLine("Property list: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }
            int min =  MinValue(array);
            Console.WriteLine("Phan tu nho nhat trong mang  :{0}",min);

        }
        static int MinValue(int[] array)
        {

            int min = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return min;
        }
    }
}