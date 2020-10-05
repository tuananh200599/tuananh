using System;
using System.Collections.Generic;
namespace ThicuoimonCau2
{
    class Table : ITable
    {
        public int TableId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public long SumTotal { get; set; }

        List<OrderDetail> list = new List<OrderDetail>();

        public void Pay()
        {
            foreach (OrderDetail item in list)
            {
                SumTotal += item.Total;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("TableId : ", TableId);
            Console.WriteLine("StartTime : ", StartTime);
            Console.WriteLine("EndTime : ", EndTime);
            Console.WriteLine("SumTotal : ", SumTotal);
        }
    }
}