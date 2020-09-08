using System;

namespace dtichhcn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n");
            Console.Write("Tinh dien tich HCN:\n");
            Console.Write("\n\n");

            float cd;
            float cr;

            Console.Write("Nhap vao chieu dai HCN:\n ");
            cd = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao chieu rong HCN:\n ");
            cr = float.Parse(Console.ReadLine());

            float dientich = cd * cr;
            Console.WriteLine("Dien tich HCN la: " + dientich);

        }
    }
}
