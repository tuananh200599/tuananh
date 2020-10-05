using System;

namespace ThicuoimonCau2
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            Table table = new Table();

            int choice = 0;

            do
            {
                Console.WriteLine("1.NewOrder ");
                Console.WriteLine("2.UpdateOrder ");
                Console.WriteLine("3.CancelOrder ");
                Console.WriteLine("4.Search ");
                Console.WriteLine("5.Pay ");
                Console.WriteLine("6.Exit ");
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        coffee.NewOrder();
                        table.ShowInfo();
                        break;

                    case 2:
                        coffee.UpdateOrder();
                        break;
                    case 3:
                        coffee.CancelOrder();
                        break;
                    case 4:
                        coffee.Search();
                        break;
                    case 5:
                        coffee.Pay();
                        break;
                    case 6:
                        return;

                }

            } while (choice != 7);
        }


    }
}

