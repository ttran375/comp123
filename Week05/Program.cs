using System;
using System.IO;
using System.Text.Json;

public class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Address { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        var student = new Student { Name = "John Doe", Age = 20, Address = "123 Main St" };

        using (TextWriter writer = new StreamWriter("Student.json"))
        {
            writer.Write(JsonSerializer.Serialize(student));
        }
    }
}
