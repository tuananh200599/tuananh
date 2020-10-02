using System;
using System.Collections.Generic;

namespace KtraCau2
{
    class Post : IPost
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Content { set; get; }
        public string Author { set; get; }

        public float AverageRate { set; get; }

        public int[] Rates = new int[3];

        public void Display()
        {
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Content :" + Content);
            Console.WriteLine("Author :" + Author);
            Console.WriteLine("AverageRate :" + AverageRate);
        }

        public void CaculatorRate()
        {
            foreach (int item in Rates)
            {
                AverageRate += item;
            }
            AverageRate /= 3;
        }
    }
}