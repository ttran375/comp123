using System;
using System.IO;
using System.Text.Json;

public class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Address { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Address: {Address}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        using (TextReader reader = new StreamReader("Student.json"))
        {
            Student? student = JsonSerializer.Deserialize<Student>(reader.ReadToEnd());
            Console.WriteLine(student);
        }
    }
}
