using System;

namespace phuong_thuc_ktrasngto
{
    class ktSNT
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot so bat ky n =");
            bool kiemtra = uint.TryParse(Console.ReadLine(), out uint n);
            while (kiemtra == false)
            {
                Console.Write("Du lieu khong hop le, moi nhap lai n =");
                kiemtra = uint.TryParse(Console.ReadLine(), out n);
            }
            kiemtraSNT(n);
            
        }
        static void kiemtraSNT(uint n)
        {
            if (n == 0)
            {
                Console.WriteLine("0 khong phai la so nguyen to");
            }
            for (uint i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    Console.WriteLine("{0} la so nguyen to", n);
                    break;
                }
                else if (n % i == 0 && i != 1)
                {
                    Console.WriteLine("{0} khong phai la so nguyen to", n);
                    break;
                }
            }
        }
    }
}