using System;

namespace docsothanhchu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, t, c, d;
            
            {
                Console.WriteLine("Hay nhap so co ba chu so: ");
                n = int.Parse(Console.ReadLine());
                t = n / 100;
                c = (n % 100) / 10;
                d = (n % 100) % 10;
                switch (t)
                {
                    case 1:
                        Console.Write("mot tram");
                        break;
                    case 2:
                        Console.Write("hai tram");
                        break;
                    case 3:
                        Console.Write("ba tram");
                        break;
                    case 4:
                        Console.Write("bon tram");
                        break;
                    case 5:
                        Console.Write("nam tram");
                        break;
                    case 6:
                        Console.Write("sau tram");
                        break;
                    case 7:
                        Console.Write("bay tram");
                        break;
                    case 8:
                        Console.Write("tam tram");
                        break;
                    case 9:
                        Console.Write("chin tram");
                        break;
                }
                switch (c)
                {
                    case 0:
                        if (d == 0) Console.Write("chan");
                        else
                            Console.Write("le");
                        break;
                    case 1:
                        Console.Write("muoi");
                        break;
                    case 2:
                        Console.Write("hai muoi");
                        break;
                    case 3:
                        Console.Write("ba muoi");
                        break;
                    case 4:
                        Console.Write("bon muoi");
                        break;
                    case 5:
                        Console.Write("nam muoi");
                        break;
                    case 6:
                        Console.Write("sau muoi");
                        break;
                    case 7:
                        Console.Write("bay muoi");
                        break;
                    case 8:
                        Console.Write("tam muoi");
                        break;
                    case 9:
                        Console.Write("chin muoi");
                        break;
                }
                switch (d)
                {
                    case 1:
                        Console.Write("mot");
                        break;
                    case 2:
                        Console.Write("hai");
                        break;
                    case 3:
                        Console.Write("ba");
                        break;
                    case 4:
                        Console.Write("bon");
                        break;
                    case 5:
                        Console.Write("nam");
                        break;
                    case 6:
                        Console.Write("sau");
                        break;
                    case 7:
                        Console.Write("bay");
                        break;
                    case 8:
                        Console.Write("tam");
                        break;
                    case 9:
                        Console.Write("chin");
                        break;
                }
            }
         }   
    }
}

