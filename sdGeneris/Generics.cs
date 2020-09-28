using System;
namespace sdGeneris
{
    public class Generics
    {
        
        public void Generic<Y>(Y a,Y b)
        {
            if (a.Equals(b))
            {
                
                Console.WriteLine(a +" bang "+b);
            }
            else
            {
                
                Console.WriteLine(a +" k bang "+b);
            }
        }
    }
}