using System;
using System.Runtime.Serialization;


namespace Serialization

{
    [Serializable()]
    public class Student : ISerializable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public double Weight { get; set; }
        public Student()
        {

        }
        public Student(string name, int age, int id, double weight)
        {
            Name = name;
            Age = age;
            Id = id;
            Weight = weight;
        }
        public Student(SerializationInfo info, StreamingContext context)
        {
            Id = (int)info.GetValue("Id", typeof(int));
            Name = (string)info.GetValue("Name", typeof(string));
            Weight = (double)info.GetValue("Weight", typeof(double));
            Age = (int)info.GetValue("Age", typeof(int));
            
        }
        public override string ToString()
        {
            return string.Format("Sing vien {0} có Id {1} nam nay {2} tuoi", Name, Id, Age);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id ", Id);
            info.AddValue("Name ", Name);
            info.AddValue("Age ", Age);
            info.AddValue("Weight ", Weight);
        }
    }
}