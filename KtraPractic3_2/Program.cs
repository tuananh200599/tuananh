using System;
using System.Collections.Generic;
namespace KtraPractic3_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Program pro = new Program();            
            int choice = 0;
             
            do
            {
                Console.WriteLine("1.Insert News");
                Console.WriteLine("2.View list News ");
                Console.WriteLine("3.Averate Rate ");
                Console.WriteLine("4.Exit ");                
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);
                
               
                switch (choice)
                {
                    case 1:
                        pro.InsertNew();
                        break;
                    case 2:
                        pro.ViewListNew();
                        break;
                    case 3:
                        pro.AvarageRate();
                        break;                                       
                    case 4:
                        return;
                        
                }
            } while (choice != 4);
        }
        int count = 0;
         Dictionary<int, object> NewList = new Dictionary<int, object>();
         public void InsertNew()
         {
             New n = new New();
             n.ID = ++count;
             Console.WriteLine("Title : ");
             n.Title = Console.ReadLine();
             Console.WriteLine("Publish :");
             n.PublishDate = DateTime.Parse(Console.ReadLine());
             Console.WriteLine("Author :");
             n.Author = Console.ReadLine();
             Console.WriteLine("Content :  ");
             n.Content = Console.ReadLine();
             for (int i = 0 ; i < 3 ; i++ ){
                 Console.WriteLine("Rate "+(i+1)+":");
                 n [i] = int.Parse(Console.ReadLine());}
             NewList.Add(count ,n);
             count++;
               
         }
         public void ViewListNew()
         {
             if ( NewList.Count > 0 ){
             foreach (New item in NewList.Values)
            {
                item.Display();
               
            }
         } 
         else{
             Console.WriteLine("News k hop le ");
         }
         }
         public void AvarageRate() 
         {
             if ( NewList.Count > 0 ){
             foreach (New item in NewList.Values)
            {
                item.Display();
                item.Caculate();
            }
         } 
         else{
             Console.WriteLine("News k hop le ");
         }
         }
    }

}
