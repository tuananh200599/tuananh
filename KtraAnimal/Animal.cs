namespace KtraAnimal
{
    public class Animal
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public string Description {get; set;}
        
        public Animal(){}
        public Animal(string name){}
        public Animal(string name , int age){}

        public Animal(string name , int age , string description){
            this.Name = name;
            this.Age = age;
            this.Description = description;
        }
       public void ViewInfo(){
          System.Console.WriteLine( "Name : " + Name + " Age : " + Age + " Description : " + Description);
       }
       public void Speak(){

       }
    
        
    }
}