using System;
using System.IO;
using System.Xml.Serialization;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Student));
        using (TextReader reader = new StreamReader("Student.xml"))
        {
            Student student = (Student)serializer.Deserialize(reader);
            Console.WriteLine(student);
        }
    }
}
