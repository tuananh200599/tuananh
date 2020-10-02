using System;
using System.Collections.Generic;
using System.Collections;
namespace KtraCau2
{
    class Forum
    {
        static void Main(string[] args)
        {

            Forum pro = new Forum();
            int choice = 0;

            do
            {
                Console.WriteLine("1.Create Post");
                Console.WriteLine("2.Update Post ");
                Console.WriteLine("3.Remove Post ");
                Console.WriteLine("4.Show Post ");
                Console.WriteLine("5.Exit ");
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        pro.CreatePost();
                        break;

                    case 2:
                        pro.UpdatePost();
                        break;
                    case 3:
                        pro.RemovePost();
                        break;
                    case 4:
                        pro.ShowPost();
                        break;
                    case 5:
                        return;

                }

            } while (choice != 6);
        }
        int count = 0;
        SortedList SL = new SortedList();
        public void CreatePost()
        {
            Post po = new Post();
            po.Id = count;
            Console.WriteLine("Nhap title :");
            po.Title = Console.ReadLine();
            Console.WriteLine("Nhap content :");
            po.Content = Console.ReadLine();
            Console.WriteLine("Nhap author :");
            po.Author = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Nhap rate :");
                po.Rates[i] = int.Parse(Console.ReadLine());
            }
            po.CaculatorRate();
            SL.Add(count, po);
            count++;

        }
        public void UpdatePost()
        {
            bool search = false;
            Console.Write("Nhap id cua Post ma ban muon update : : ");
            int id = int.Parse(Console.ReadLine());
            foreach (Post item in SL.Values)
            {
                if (id.Equals(item.Id))
                {
                    search = true;
                    Post po = new Post();
                    po.Id = id;
                    Console.WriteLine("Nhap title :");
                    po.Title = Console.ReadLine();
                    Console.WriteLine("Nhap content :");
                    po.Content = Console.ReadLine();
                    Console.WriteLine("Nhap author :");
                    po.Author = Console.ReadLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Nhap rate :");
                        po.Rates[i] = int.Parse(Console.ReadLine());
                    }
                    po.CaculatorRate();
                    SL.Remove(id);
                    SL.Add(id, po);
                    break;
                }
            }
        }
        public void RemovePost()
        {
            bool search = false;
            Console.Write("Nhap id cua Post ma ban muon Remove : ");
            int id = int.Parse(Console.ReadLine());
            foreach (Post item in SL.Values)
            {
                if (id.Equals(item.Id))
                {
                    search = true;
                    SL.Remove(id);
                    break;
                }
            }
            if (search == true)
                Console.WriteLine("Remove thanh cong");
            else
                Console.WriteLine("K remove duoc!");
        }
        public void ShowPost()
        {
            foreach (Post item in SL.Values)
            {
                item.Display();
            }
        }

    }
}
        
       


    


