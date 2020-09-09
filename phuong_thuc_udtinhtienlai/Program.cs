using System;

namespace phuong_thuc_udtinhtienlai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UNG DUNG TINH TIEN LAI ");
            Console.WriteLine("----------------------------------------- ");

            double money = 1.0;
            int month = 1;
            double intersetRate = 1.0;

            Console.WriteLine("Nhap so tien gui : ");
            money = Double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so thang gui : ");
            month = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nhap % lai suat: ");
            intersetRate = Double.Parse(Console.ReadLine());

            TinhTienLai(money,month,intersetRate);
            
        }
        static void TinhTienLai(double money, int month, double intersetRate)
        {

            double totalInterset = 0;
            for (int i = 0; i < month; i++)
            {
                totalInterset = money * (intersetRate / 100) / 12 * 3;
            }

            Console.WriteLine("Lai suat cua ban trong {0} thang la : {1}", month, totalInterset);
            Console.ReadKey();
        }
    }
}
