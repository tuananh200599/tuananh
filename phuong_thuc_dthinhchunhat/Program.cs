using System;

namespace phuong_thuc_dthinhchunhat
{
    class Program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("Area is: " + area);

            //float area = width * height;
            dientich(width, height);
            Console.ReadKey();
        }

        static float dientich(float a,float b)
        {
            float c = a*b;
            Console.WriteLine("Area is: " + c);
            return c;
        }
    }
}