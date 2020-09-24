using System;
namespace KtraPractic5_2
{
    interface IBook
    {
        int ID { set; get; }
        string Name { set; get; } 
        DateTime PublishDate { set; get; } 
        string Author { set; get; } 
        string Language { set; get; } 
        float AveragePrice { set; get; }

        void Display();
    }
}