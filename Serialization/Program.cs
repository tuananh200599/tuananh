using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Anh",35,1,56.6),
                new Student("Trung",32,2,66.6),
                new Student("Nam",33,3,76.6),
                new Student("Hoang",34,4,46.6),
                new Student("Linh",31,5,66.6)
            };
            string stu = @"D:\C#\tuananh\Serialization\Data\students.xml";
            using (Stream fs = new FileStream(stu, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
                xmlSerializer.Serialize(fs,students);
            }
            List<Student> students1 = null;

            XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(List<Student>));
            
            using (FileStream fs2 = File.OpenRead(stu))
            {
                students1 = (List<Student>)xmlSerializer2.Deserialize(fs2);
            }
            foreach (var item in students1)
            {
                System.Console.WriteLine(item.ToString());
            }

        }
    }
}
