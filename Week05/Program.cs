using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

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

public class Program
{
    public static void Main(string[] args)
    {
        // Serialize Item
        Item item = new Item { Name = "Bananas", Quantity = 2, Price = 0.49 };
        File.WriteAllText("item.json", JsonSerializer.Serialize(item));

        // Deserialize Item
        using (TextReader reader = new StreamReader("item.json"))
        {
            Item deserializedItem = JsonSerializer.Deserialize<Item>(reader.ReadToEnd());
            Console.WriteLine($"Item: {deserializedItem.Name}, Quantity: {deserializedItem.Quantity}, Price: {deserializedItem.Price}");
        }

        // Serialize Person
        Person p = new Person
        {
            Name = "Narendra",
            Children = "Larry Curly Moe".Split().ToList(),
            HomeAddress = new Address { Street = "20 Sheppard Avenue", PostalCode = "M1B6E8" },
            WorkAddress = new Address { Street = "941 Progress Avenue", PostalCode = "M1K5E9" }
        };
        File.WriteAllText("person.json", JsonSerializer.Serialize(p));

        // Deserialize Person
        using (TextReader reader = new StreamReader("person.json"))
        {
            Person deserializedPerson = JsonSerializer.Deserialize<Person>(reader.ReadToEnd());
            Console.WriteLine($"Person: {deserializedPerson.Name}, Children: {string.Join(", ", deserializedPerson.Children)}");
        }
    }
}
