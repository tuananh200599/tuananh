using System;

namespace KtraAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Meo", 3,"Haha");
            animal.ViewInfo();
            Tiger tiger = new Tiger();
            Dog dog = new Dog();
            Cat cat = new Cat();
            
        }
    }
}
