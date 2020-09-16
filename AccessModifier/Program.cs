using System;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.setColor("red");
            circle.setRadius(2.0);
            Console.WriteLine(circle.getColor());
            Console.WriteLine(circle.getRadius());
        }
    }
}