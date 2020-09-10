using System;

namespace phuong_thuc_songaytrongthang
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Nhap thang : ");
            string Sthang = Console.ReadLine();
            Console.Write("Nhap nam : ");
            string Snam = Console.ReadLine();

            tinhNgayThang(Sthang,Snam);

            Console.ReadLine();
        }
        static void tinhNgayThang(string a , string b)
        {
            int th = int.Parse(a);
            int nm = int.Parse(b);
            int songay = 0;

            if (th >= 1 && th <= 12)
            {
                switch (th)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: songay = 31; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: songay = 30; break;

                    case 2:
                        if (nm % 400 == 0 || (nm % 4 == 0 && nm % 100 != 0))    // nam nhuan
                            songay = 29;
                        else
                            songay = 28;
                        break;
                }

                Console.Write(" Thang " + th + "/" + nm + " co " + songay + " ngay\n");
            }
            else
                Console.Write(" Thang khong hop le!\n");
        }
    }
}