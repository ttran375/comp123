using System;

class Room
{
    // Room implementation goes here
}

class House
{
    private readonly Room _room; // a room only exists in a house

    public House()
    {
        _room = new Room();
    }
}

class Address
{
    // Address implementation goes here
}

class Person
{
    private readonly Address _address;

    public Person(Address address)
    {
        _address = address;
    }
}

class Program
{
    static void Main()
    {
        House house = new House();
        Address address = new Address();
        Person person = new Person(address);

        Console.WriteLine("Objects created successfully.");
    }
}
