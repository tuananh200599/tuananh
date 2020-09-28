using System;
using System.Collections.Generic;
using System.Linq;
namespace ThaotacList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add(" lion ");
            list.Add(" cat ");
            list.Add(" dog ");
            list.Add(" elephant ");
            Console.WriteLine(" Danh sach animal  : ");
            foreach (var item in list)
            {
                Console.WriteLine(item); 
            }
            Console.WriteLine(" Danh sach animal sau khi xoa  : ");
            list.Remove(" dog ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" Danh sach animal sau khi sap xep : "); 
            var listAnimal = from ani in list
                         orderby ani.Length
                         select ani;
            foreach (var item in listAnimal)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Index cat  : "); 
            Console.WriteLine(list.IndexOf(" cat ")); 
        }
    }
}
