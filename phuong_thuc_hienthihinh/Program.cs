using System;

namespace phuong_thuc_hienthihinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 5;
            int choice1 = 0;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. Print the square triangle (The corner is square at 4 different angles: top-left, top-right, botton-left, botton-right)");
                Console.WriteLine("3. Print isosceles triangle");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        rectangle();
                        break;
                    case 2:
                        {
                            Console.WriteLine("Chon goc: ");
                            Console.WriteLine("1. top-left");
                            Console.WriteLine("2. top-right");
                            Console.WriteLine("3. botton-left");
                            Console.WriteLine("4. botton-right");
                            choice1 = Int32.Parse(Console.ReadLine());
                            while (choice1 != 0)
                            {
                                if (choice1 == 1)
                                {
                                    topleft();
                                    break;
                                }
                                else if (choice1 == 2)
                                {
                                    topright();
                                    break;



                                }
                                else if (choice1 == 3)
                                {
                                    bottonleft();
                                    break;
                                }
                                else if (choice1 == 4)
                                {
                                    bottonright();
                                    break;
                                }
                            }
                        }
                        break;
                    case 3:
                        isosceles_triangle();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        static void rectangle()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
        static void topleft()
        {
            for (int a = 5; a >= 1; a--)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void topright()
        {
            for (int a = 1; a <= 5; a++)
            {
                for (int b = 1; b <= 5; b++)
                {
                    if (b < a)
                    {
                        Console.Write(" ");
                    }
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void bottonleft()
        {
            for (int a = 1; a <= 5; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void bottonright()
        {
            for (int a = 1; a <= 5; a++)
            {
                for (int b = 5; b >= 1; b--)
                {
                    if (b > a)
                    {
                        Console.Write(" ");
                    }
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void isosceles_triangle()
        {
            for (int i = 1; i < 10; i += 2)
            {
                for (int k = 0; k < (4 - i / 2); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}