using System;
using System.Collections.Generic;

namespace sdGeneris
{
    class Program
    {
        static void Main(string[] args)
        {
            Generics gene = new Generics();
            gene.Generic<int>(7,6);
            gene.Generic<string>("Yes","Yes");

        }
    }
}
