using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KtraPractic3_2
{
    public class New : INew
    {
        public New()
        {
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get ; set; }
        public string Author { get; set ; }
        public string Content { get ; set ; }
        
        public float AverageRate {get;set;}
        

        public void Display()
        {
            Console.WriteLine("Title : " +Title);
            Console.WriteLine("Publish Date : " +PublishDate);
            Console.WriteLine("Author : "+Author);
            Console.WriteLine("Content : " +Content);
            Console.WriteLine("AverateRate : " +AverageRate);
        }
        int[] RateList = new int[3];
        public int this [int index]{
            get {
                return RateList[index];
            }
            set {
                RateList[index] = value;
            }
        }
        public void Caculate()
        {
            AverageRate = (float)(RateList[0]+RateList[1]+RateList[2])/3;
        }
    }
}