using System;

namespace phuong_thuc_chisoBMI
{
    class Program
    {
        static void Main(string[] args)
        {
      
                Console.WriteLine("Nhap chieu cao (m):");
                double chieucao = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nhap can nang (kg):");
                double cannang = Convert.ToDouble(Console.ReadLine());
                TinhBMI(chieucao, cannang);
            Console.ReadLine();
            }
            static double TinhBMI(Double chieucao, double cannang)
            {
                double bmi = cannang / (chieucao * chieucao);
                if (bmi < 18.5)
                {
                    Console.WriteLine("BMI = {0} Ban la nguoi gay !", bmi);
                }
                else if ((18.5 <= bmi) && (bmi < 25))
                {
                    Console.WriteLine("BMI = {0} Ban la nguoi binh thuong !", bmi);
                }
                else if ((25 <= bmi) && (bmi < 30))
                {
                    Console.WriteLine("BMI = {0} Ban la nguoi thua can !", bmi);
                }
                else
                {
                    Console.WriteLine("BMI = {0} Ban la nguoi beo phi !", bmi);
                }
                return 0;
            }
        }
    } 