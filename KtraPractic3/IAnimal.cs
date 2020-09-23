using System;

namespace KtraPractic3
{
    public interface IAnimal
    {
        int ID { get; set; }
        string Name { get; set; }
        int Age { get; set; }
    }
    public interface ITerrestrialAnimal : IAnimal
    {
        void Move();
    }
    public interface IMarineAnimal : IAnimal
    {
        void Move();
    }
}
