using System;
using System.Collections.Generic;
using System.Text;

namespace KtraAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            int choice = 0;
            do
            {
                Console.WriteLine("1.Add Cage");
                Console.WriteLine("2.Remove Cage");
                Console.WriteLine("3.Add Animal");
                Console.WriteLine("4.Remove Animal");
                Console.WriteLine("5.Iterate Animal");
                Console.WriteLine("6.Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Nhap chuong :");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Cage cage = new Cage();
                            cage.Input();
                            zoo.AddCage(cage);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Nhap ma chuong can xoa");
                        int maChuong = int.Parse(Console.ReadLine());
                        zoo.RemoveCage(maChuong);
                        break;
                    case 3:
                        for (int i = 0; i < zoo.CageList.Count; i++)
                        {
                            Console.WriteLine("Nhap so luong con vat cho chuong co ma {0}", zoo.CageList[i].CageNumber);
                            int soVat = int.Parse(Console.ReadLine());
                            for (int j = 0; j < soVat; j++)
                            {
                                Console.WriteLine("Nhap loai thu \n1. Tiger\n2. Dog \n3. Cat");
                                int animalType = int.Parse(Console.ReadLine());
                                Animal newAnimal;
                                Console.WriteLine("Nhap ten con vat");
                                string ten = Console.ReadLine();
                                Console.WriteLine("Nhap tuoi con vat");
                                int tuoi = int.Parse(Console.ReadLine());
                                Console.WriteLine("Nhap mo ta");
                                string moTa = Console.ReadLine();
                                switch (animalType)
                                {
                                    case 1:
                                        newAnimal = new Tiger(ten, tuoi, moTa);
                                        break;
                                    case 2:
                                        newAnimal = new Dog(ten, tuoi, moTa);
                                        break;
                                    case 3:
                                        newAnimal = new Cat(ten, tuoi, moTa);
                                        break;
                                    default:
                                        newAnimal = new Tiger(ten, tuoi, moTa);
                                        break;
                                }
                                zoo.CageList[i].AddAnimal(newAnimal);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Nhap ma chuong muon xoa con vat");
                        int MaChuong = int.Parse(Console.ReadLine());
                        foreach (Cage c in zoo.CageList)
                        {
                            if (c.CageNumber == MaChuong)
                            {
                                Console.WriteLine("Nhap ten con vat");
                                string tenVat = Console.ReadLine();
                                c.RemoveAnimal(tenVat);
                                break;
                            }
                        }
                        break;
                    case 5:
                        foreach (Cage c in zoo.CageList)
                        {
                            Console.WriteLine("Danh sach con vat o chuong co ma chuong {0}", c.CageNumber);
                            foreach (Animal anm in c.AnimalList)
                            {
                                anm.Speak();
                                anm.ViewInfo();
                            }
                        }
                        break;
                    case 6:
                        return;
                }
            } while (choice != 7);
        }        
    }
}
