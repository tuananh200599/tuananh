using System;


namespace Practical8
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Classs { get; set; }
        public float Math { get; set; }
        public float Physic { get; set; }
        public float Chemistry { get; set; }

        public Student() { }
        public Student(int id, string name, string classs, float math, float physic, float chemistry)
        {
            Id = id;
            Name = name;
            Classs = classs;
            this.Math = math;
            this.Physic = physic;
            this.Chemistry = chemistry;

        }
        public void Display()
        {
            float Rs = (Math + Physic + Chemistry) / 3;
            Console.WriteLine("Student  Name : {0} Class : {1} Average : {2} ", Name, Classs, Rs);
        }
        public void Average()
        {
            float Rs = (Math + Physic + Chemistry) / 3;
            if(Rs >= 8.5){
                Console.WriteLine("Gud Student : ");
            }else if (Rs >= 7){
                Console.WriteLine("Fairs Student : ");
            }else if (Rs >= 5){
                Console.WriteLine("Normal Student : ");
            }else  
                Console.WriteLine("Bad Student : ");
            
            
        }
    }
}
