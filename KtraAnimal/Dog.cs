using System;
using System.Collections.Generic;
using System.Text;
namespace KtraAnimal
{
    public class Dog : Animal
    {

        public override void Speak()
        {
            Console.WriteLine("Gau Gau");
        }
        public Dog() : base()
        {

        }
        public override void ViewInfo()
        {
            base.ViewInfo();
        }
        public Dog(string Name, int Age, string Description) : base(Name, Age, Description)
        {
        }
    }
}