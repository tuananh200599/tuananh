using System;
using System.Collections;
using System.Linq;

namespace Linq_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Staff(1, "Nam", 24));
            arrayList.Add(new Staff(2, "Kien", 21));
            arrayList.Add(new Staff(3, "Viet", 21));
            arrayList.Add(new Staff(4, "Hang", 23));
            arrayList.Add(new Staff(5, "Tien", 24));
            var arrList = arrayList.OfType<Staff>();
            var arList = from aList in arrList
                         where (aList.Age < 24)
                         select aList;
            foreach (var item in arList)
            {
                Console.WriteLine("ID :" + item.ID + " Name : " + item.Name + " Age : " + item.Age);
            }
        }
    }
}
