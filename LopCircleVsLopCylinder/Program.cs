using System;

namespace LopCircleVsLopCylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.setColor("White");
            circle.setR(9);
            Console.WriteLine(circle.ToString());
            Cylinder cylinder = new Cylinder();
            cylinder.setColor("Black");
            cylinder.setR(6);
            cylinder.setHeight(8);
            cylinder.getArea();
            Console.WriteLine(cylinder.ToString());
        }
    }
}
