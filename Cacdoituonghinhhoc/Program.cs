using System;

namespace Cacdoituonghinhhoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shape");
            Console.WriteLine("Nhap Color :");
            string color = Console.ReadLine();
            Console.WriteLine("Nhap filled (true / false):");
            string tam = Console.ReadLine();
            bool filled = true;
            if (tam == "true")
            {
                filled = true;
            }else if(tam == "false")
            {
                filled = false;
            }         
            Shape shape = new Shape(color, filled);
            Console.WriteLine(shape.ToString());

            Console.WriteLine("Circle");
            Console.WriteLine("Nhap ban kinh r :");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            Console.WriteLine($"Chu vi hinh tron la {circle.getPerimeter()}");
            Console.WriteLine($"Dien tich hinh tron la {circle.getArea()}");
            Console.WriteLine(circle.ToString());

            Console.WriteLine("Rectangle");
            Console.WriteLine("Nhap width :");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap length :");
            double length = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width,length);
            Console.WriteLine($"Chu vi hinh tron la {rectangle.getPerimeter()}");
            Console.WriteLine($"Dien tich hinh tron la {rectangle.getArea()}");
            Console.WriteLine(rectangle.ToString());
            Console.ReadKey();
        }
    }
}
