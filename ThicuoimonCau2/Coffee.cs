using System;
using System.Collections.Generic;

namespace ThicuoimonCau2
{
    public class Coffee
    {
        Dictionary<int, Table> Tables = new Dictionary<int, Table>();
        int count = 0;
        public void NewOrder()
        {
            Table table = new Table();


            Console.WriteLine("Nhap TableId : ");
            table.TableId = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap StarTime : ");
            table.StartTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap EndTime : ");
            table.EndTime = DateTime.Parse(Console.ReadLine());

            Tables.Add(count, table);
            count++;

        }
        public void UpdateOrder()
        {
            bool search = false;
            Console.Write("Nhap TableId cua Table ma ban muon update : : ");
            int TableId = int.Parse(Console.ReadLine());
            foreach (Table item in Tables.Values)
            {
                if (TableId.Equals(item.TableId))
                {
                    search = true;
                    Table table = new Table();
                    OrderDetail order = new OrderDetail();

                    Console.WriteLine("Nhap TableId : ");
                    table.TableId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap Name : ");
                    order.Name = Console.ReadLine();
                    Console.WriteLine("Nhap Price : ");
                    order.Price = long.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap Count: ");
                    order.Count = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap Total: ");
                    order.Total = long.Parse(Console.ReadLine());
                    Tables.Remove(TableId);
                    Tables.Add(TableId, table);
                    break;
                }
            }
        }
        public void CancelOrder()
        {
            bool search = false;
            Console.Write("Nhap TableId cua Table ma ban muon Remove : ");
            int TableId = int.Parse(Console.ReadLine());
            foreach (Table item in Tables.Values)
            {
                if (TableId.Equals(item.TableId))
                {
                    search = true;
                    Tables.Remove(TableId);
                    break;
                }
            }
            if (search == true)
                Console.WriteLine("Remove thanh cong");
            else
                Console.WriteLine("K remove duoc!");
        }
        public void Search()
        {
            Console.WriteLine("Nhap TableID : ");
            int TableId = int.Parse(Console.ReadLine());
            foreach (Table item in Tables.Values)
                if (item.TableId.Equals(TableId))
                    item.ShowInfo();
                else Console.WriteLine("Khong tim thay ten");
        }
        public void Pay()
        {
            foreach (Table item in Tables.Values)
            {
                item.Pay();
            }
        }
        public void Show()
        {
            foreach (Table item in Tables.Values)
            {
                item.ShowInfo();

            }
        }

    }
}
