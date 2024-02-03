using System;
using System.IO;
using System.Xml.Serialization;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public Student() { }

    public Student(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new()
        {
            Name = "John Doe",
            Age = 20,
            Address = "123 Main St"
        };

        XmlSerializer serializer = new(typeof(Student));
        using TextWriter writer = new StreamWriter("Student.xml");
        serializer.Serialize(writer, student);
    }
}
