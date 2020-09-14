using System;

namespace animal
{
    class Program
    {
        static void Main(string[] args)
        {
           var animal = new Animal();
           
            animal.SetName("Cat");
            animal.Age = 30;
            System.Console.WriteLine(Animal.GetIdOfAnimals());
            
            System.Console.WriteLine(animal.Age);
            System.Console.WriteLine(animal.GetInfo());

            var cat = new Cat("Tieu Ho", "Hoho", "Hong");
            System.Console.WriteLine(cat.GetInfo());

            System.Console.WriteLine(Cat.GetIdOfAnimals());
        }
    }

   
    public class Animal
    {
        protected string name;
        private string sound;
        public int Age { get; set; }

        public static int idOfAnimals = 0;

        public static  int GetIdOfAnimals()
        {
            return idOfAnimals;
        }

        public Animal(string _name = "", string _sound = "")
        {
            name = _name;
            sound = _sound;
            idOfAnimals++;
        }

        public string GetInfo()
        {
            return name + " says " + sound;
        }

        public void SetName(string newName)
        {
            if (newName == "Cat")
            {
                name = "Khong duoc set no la meo";
            }
            else
            {
                name = newName;
            }

        }

        public string GetName()
        {
            return name;
        }
    }

    public class Cat : Animal
    {
        private string color;

        public Cat(string _name, string _sound, string _color) : base(_name, _sound)
        {
            color = _color;
        }
        public void SetColor(string newColor)
        {
            if (newColor == "trang")
            {
                System.Console.WriteLine("Ko duoc de mau trang");
                color = "Unknow";
            }
            else
            {
                color = newColor;

            }
        }

        public string GetColor()
        {
            return color;
        }
    }
}

