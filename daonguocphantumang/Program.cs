using System;


namespace daonguocphantumang
{
    class Program
    {
        private static int size;

        static void Main(string[] args)
        {
           
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                {
                    Console.WriteLine("Size does not exceed 20");
                }
            } while (size > 20);
            
            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Enter element " + (i + 1) + ": ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            

            Console.WriteLine("Elements in array: ", "");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }
            
            DaoNguoc(array);
            
            

            Console.WriteLine("Reverse array: ", "");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }
        }
        
                
        
        static void DaoNguoc(int []array){
            for (int j = 0; j < array.Length / 2; j++)
            {
                int temp = array[j];
                array[j] = array[size - 1 - j];
                array[size - 1 - j] = temp;
            }
        }
    }
}