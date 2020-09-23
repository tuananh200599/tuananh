using System;
namespace KtraPractic3
{
    
    class Cat : ITerrestrialAnimal
    {
       
           
        
        public int ID{get;set;}
        public string Name{set;get;}
        public int Age {get;set;}
        public void  Move() 
        {
            System.Console.WriteLine("run");
            
        }
        public override string ToString()
        {
           return "ID :" + ID + " Name : " + Name + " Age : " + Age;

        }
    }
}