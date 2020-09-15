using System;

namespace StaticProperty
{
    class Program
    {
        static void Main(string[] args)
        {
             Car car1 = new Car("Mazda 3", "Skyactiv 3");
          Console.WriteLine(Car.numberOfCars);
          Car car2 = new Car("Mazda 6", "Skyactiv 6");
          
          Console.WriteLine(car1.ToString());
          Console.WriteLine(Car.numberOfCars);
          Console.WriteLine(car2.ToString());
          Console.ReadLine();
    }
}
}
