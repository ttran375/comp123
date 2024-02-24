using System;
using System.IO;

class Foo
{
    private int a;                     // a private instance variable
    private double b;                  // a variable of type double
    public bool c;                     // public variable
    private static string d = "Hello"; // a class variable
    private Foo e;                     // e is an object reference
    private DateTime f;                // f is of type DateTime
    private StreamReader reader;       // reader is of type StreamReader

    // Constructor
    public Foo()
    {
        a = 0;             // Example initialization for demonstration
        b = 0.0;           // Example initialization for demonstration
        c = false;         // Example initialization for demonstration
        d = "World";       // Example initialization for demonstration
        e = null;          // Example initialization for demonstration
        f = DateTime.Now;  // Example initialization for demonstration
        reader = null;     // Example initialization for demonstration
    }
}

class Person
{
    public int age;             // Each object has its own copy of this non-static field
    public static int program;  // All instances share this static field
}

class Program
{
    static void Main(string[] args)
    {
        Foo f1 = new Foo();  // Instantiate class to get objects
        Foo f2 = new Foo();
        Foo f3 = f1;

        Person p1 = new Person();
        p1.age = 19;

        Person p2 = new Person();
        p2.age = 21;

        // Output age for p1 and p2
        Console.WriteLine("Age for p1: " + p1.age); // Different for each instance
        Console.WriteLine("Age for p2: " + p2.age); // Different for each instance

        // Output the value of the static field program
        Console.WriteLine("Value of program: " + Person.program); // Same for all instances
    }
}
