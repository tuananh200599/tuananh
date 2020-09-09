using System;

namespace bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            float can_nang;
            float chieu_cao;
            float bmi;
            Console.WriteLine("Hay nhap vao can nang: ");
            can_nang = float.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap vao chieu cao: ");
            chieu_cao = float.Parse(Console.ReadLine());

            bmi = (can_nang / (chieu_cao * chieu_cao));
            Console.WriteLine("Chi so BMI cua ban la : {0}\n", bmi);

            if (bmi >= 18.50 && bmi <= 25.00)
                Console.WriteLine("Ban nguoi la binh thuong\n");
            else
            if (bmi < 18.50)
                Console.WriteLine("Ban la nguoi gay\n");
            else
            if (bmi >= 24.99 && bmi <= 30.00)
                Console.WriteLine("Ban la nguoi beo\n");
            else
            if (bmi > 30.00)
                Console.WriteLine("Ban bi benh beo phi\n");
            else
                Console.WriteLine("Ban nhap sai can nang hoac chieu cao \n");
        }
    }
}