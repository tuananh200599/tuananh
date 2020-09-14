using System;

namespace lophcn
{
    class Program
    {
        static void Main(string[] args)
        {
          var Reactangle = new Reactangle();
          Reactangle rect1 = new Reactangle(10,20);
            Reactangle rect2 = new Reactangle(10,20);
            Reactangle rect3 = new Reactangle(10,20);

            var arrayRect = new Reactangle[3] {
                new Reactangle(10,1),
                new Reactangle(15,1),
                new Reactangle(100,1)
            };

            arrayRect[0].height = 30;

            foreach(var item in arrayRect) {
                System.Console.WriteLine(item.GetArea());
            }
        }
    }

    public class Reactangle
    {
        public double width { get; set; }
        public double height { get; set; }
        public Reactangle(double _width = 1, double _height = 1)
        {
            width = _width;
            height = _height;
        }

        public double GetArea()
        {
            return width * height;
        }

        public double GetPremeter()
        {
            return (width + height) * 2;
        }
    }
}
