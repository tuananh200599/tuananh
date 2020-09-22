using System;

namespace LopMoveblePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Point");
            Point point = new Point(7.8f, 5.8f);


            Console.WriteLine(point);
           

            Console.WriteLine("MovablePoint");
            MovablePoint movablePoint = new MovablePoint(6.4f, 8.2f);
            Console.WriteLine(movablePoint.Move());
            Console.WriteLine(movablePoint.ToString());
        }
    }
}