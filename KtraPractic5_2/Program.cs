using System;
using System.Collections.Generic;

namespace KtraPractic5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();
            int choice = 0;

            do
            {
                Console.WriteLine("1.Insert new book");
                Console.WriteLine("2.View list of books ");
                Console.WriteLine("3.Average Price ");
                Console.WriteLine("4.Exit ");
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        pro.InsertBooks();
                        break;

                    case 2:
                        pro.ViewListBooks();
                        break;
                    case 3:
                        pro.AveragePrice();
                        break;
                    case 4:
                        return;
                        
                }

            } while (choice != 5);
        }
        int count = 0;
        Dictionary<int, object> ListBook = new Dictionary<int, object>();
        public void InsertBooks()
        {
            Book book = new Book();
            book.ID = count;
            Console.WriteLine("Name : ");
            book.Name = Console.ReadLine();
            Console.WriteLine("Publish Date :");
            book.PublishDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Author :");
            book.Author = Console.ReadLine();
            Console.WriteLine("Language :");
            book.Language = Console.ReadLine();            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Average Price " + (i + 1) + ":");
                book[i] = int.Parse(Console.ReadLine());

            }
            ListBook.Add(count, book);
            count++;

        }
        public void ViewListBooks()
        {
            foreach (Book item in ListBook.Values)
            {
                item.Display();
            }
        }
        public void AveragePrice()
        {
            foreach (Book item in ListBook.Values)
            {
                item.Display();
                item.Calculate();
            }
        }
    }
}