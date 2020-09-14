using System;

namespace lopquadraticequation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ CT ] Giai PT bac 2 (ax^2 + bx + x = 0)");
            Console.WriteLine("Nhap a :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b :");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c :");
            double c = double.Parse(Console.ReadLine());
            QuadraticEquation quadraticequation = new QuadraticEquation(a,b,c);

            if (quadraticequation.GetDiscriminant() > 0)
            {
                Console.WriteLine("PT co 2 nghiem !");
                Console.WriteLine("X1 = " + quadraticequation.GetRoot2x1());
                Console.WriteLine("X2 = " + quadraticequation.GetRoot2x2());
            }
            else if (quadraticequation.GetDiscriminant() == 0)
            {
                Console.WriteLine("PT co 1 nghiem duy nhat x = " + quadraticequation.GetRoot1());
            }
            else
                Console.WriteLine("PT vo nghiem !");
        }
    }

    internal class QuadraticEquation
    {
        private double a { set; get; }
        private double b { set; get; }
        private double c { set; get; }
        
        public QuadraticEquation()
        {

        }
        public QuadraticEquation(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetDiscriminant()
        {
            double delta;
            return delta = b * b - (4 * a * c);
        }
        public double GetRoot1()
        {
            return -b / (2.0 * a);
        }
        public double GetRoot2x1()
        {
            return (-b + Math.Sqrt(GetDiscriminant())) / (2 * a);
        }

        public double GetRoot2x2()
        {
            return (-b - Math.Sqrt(GetDiscriminant())) / (2 * a);
        }
    }
}
