using System;

class Program
{
    static void Main(string[] args)
    {
        // Example of using auto-implemented properties
        Person person = new Person(25, "John");
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        // Example of using a class with auto-implemented property
        Account account = new Account();
        account.Deposit(100);
        Console.WriteLine($"Account Balance: {account.Balance}");

        // Example of using read-only auto-implemented property
        // This will result in a compilation error because Age is read-only
        // person.Age = 30; // Uncommenting this line will result in a compilation error
    }
}

class Account
{
    public int Balance { get; private set; }

    public void Deposit(int amount)
    {
        Balance += amount;
    }
}

class Person
{
    public int Age { get; }
    public string Name { get; }

    public Person(int age, string name)
    {
        Age = age;
        Name = name;
    }
}
