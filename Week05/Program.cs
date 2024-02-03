using System;
using System.IO;
using System.Xml.Serialization;

public class Student
{
    // Assuming Student class has these properties
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        var student = new Student { Name = "John Doe", Age = 20 };

        XmlSerializer serializer = new XmlSerializer(typeof(Student));
        using (TextWriter writer = new StreamWriter("Student.xml"))
        {
            serializer.Serialize(writer, student);
        }
    }
}
