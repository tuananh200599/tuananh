using System;
using System.Collections.Generic;
using System.Text;
namespace KtraAnimal
{
    public class Cage
    {
        public int CageNumber { get; set; }
        public List<Animal> AnimalList { get; set; }

        public void Input()
        {
            Console.WriteLine("Nhap ma chuong");
            CageNumber = int.Parse(Console.ReadLine());
        }
        public Cage()
        {
            AnimalList = new List<Animal>();
        }

        public void AddAnimal(Animal a)
        {
            AnimalList.Add(a);
        }
        public void RemoveAnimal(String Name)
        {
            for (int i = 0; i < AnimalList.Count; i++)
            {
                if (AnimalList[i].Name.Equals(Name))
                {
                    AnimalList.RemoveAt(i);
                }
            }
        }
    }
}