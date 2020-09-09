using System;

namespace phuong_thuc_ptrinh_bac_nhat{
class Program
    {

        static void Giaiphuongtrinh()
        {
            double a;
            double b;
            Console.WriteLine("a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b: ");
            b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                double solution = -b / a;
                Console.Write("The solution is: {0}!", solution);
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("The solution is all x!");
                }
                else
                {
                    Console.Write("Nod solution!");
                }
            }
        }
        static void Main(string[] args)
        {
            Giaiphuongtrinh();
            Console.ReadKey();
        }
    }
}
