﻿using System.Text.Json;
using System.Xml.Serialization;

public class Item
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
}

public class Address
{
    public string Street { get; set; }
    public string PostalCode { get; set; }
}

public class Person
{
    public string Name { get; set; }
    public Address WorkAddress { get; set; }
    public Address HomeAddress { get; set; }
    public List<string> Children { get; set; }
}

public class Student
{
    public string Name { get; set; }
    public Address WorkAddress { get; set; }
    public Address HomeAddress { get; set; }
}

class Program
{
    static void Main()
    {
        // Example using XmlSerializer
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
        TextWriter xmlWriter = new StreamWriter("student.xml");
        Student student = new Student(); // Initialize with actual student data
        xmlSerializer.Serialize(xmlWriter, student);
        xmlWriter.Close();

        TextReader xmlReader = new StreamReader("student.xml");
        Student deserializedStudent = (Student)xmlSerializer.Deserialize(xmlReader);
        Console.WriteLine(deserializedStudent);
        xmlReader.Close();

        // Example using JsonSerializer for Item
        Item item = new Item { Name = "Bananas", Quantity = 2, Price = 0.49 };
        File.WriteAllText("item.json", JsonSerializer.Serialize(item));

        // Example using JsonSerializer for Person
        Person person = new Person
        {
            Name = "Narendra",
            Children = new List<string>("Larry Curly Moe".Split()),
            HomeAddress = new Address { Street = "20 Sheppard Avenue", PostalCode = "M1B6E8" },
            WorkAddress = new Address { Street = "941 Progress Avenue", PostalCode = "M1K5E9" }
        };
        File.WriteAllText("person.json", JsonSerializer.Serialize(person));

        // Example using JsonSerializer to deserialize Item
        string itemJson = File.ReadAllText("item.json");
        Item deserializedItem = JsonSerializer.Deserialize<Item>(itemJson);
        Console.WriteLine(deserializedItem);

        // Example using JsonSerializer to deserialize Person
        string personJson = File.ReadAllText("person.json");
        Person deserializedPerson = JsonSerializer.Deserialize<Person>(personJson);
        Console.WriteLine(deserializedPerson);
    }
}
