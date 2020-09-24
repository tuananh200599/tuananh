using System;
using System.Collections.Generic;
namespace KtraPractic5_2
{
    class Book : IBook
    {
        public int ID { set; get; } 
        public string Name { set; get; } 
        public DateTime PublishDate { set; get; } 
        public string Author { set; get; } 
        public string Language { set; get; } 
        public float AveragePrice { set; get; } 

        public void Display()
        {            
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Publish Date :" + PublishDate);
            Console.WriteLine("Author :" + Author);
            Console.WriteLine("Lenguage :" + Language);
            Console.WriteLine("Average Price :"+ AveragePrice); 
        }
        int[] PriceList = new int[5];
        public int this[int index]
        {
            get
            {
                return PriceList[index];
            }
            set
            {
                PriceList[index] = value;
            }
        }
        public void Calculate()
        {
            AveragePrice = (float)(PriceList[0] + PriceList[1] + PriceList[2] + PriceList[3] + PriceList[4]) / 5;
            Console.WriteLine("Average Price = " + AveragePrice);
        }
    }
}