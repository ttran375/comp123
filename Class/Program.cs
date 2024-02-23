using System;

class Program
{
    static void Main(string[] args)
    {
        // Constant values
        const double PI = 3.14159;
        const double DIAMETER = PI * 2;

        // Creating an object of class Foo
        Foo f = new Foo();

        // Accessing members of class Foo
        Console.WriteLine(Foo.A); // Accessing static property
        Foo.Baz(); // Accessing static method
        f.Bar(); // Accessing instance method
    }
}

public class Foo
{
    // Static property
    public static string A { get; set; }

    // Static constructor
    static Foo()
    {
        Console.WriteLine("Static constructor");
    }

    // Instance method
    public void Bar()
    {
        Console.WriteLine("Instance method");
    }

    // Static method
    public static void Baz()
    {
        Console.WriteLine("Static method");
    }

    // Instance constructor
    public Foo()
    {
        Console.WriteLine("Instance constructor");
    }

    // Finalizer
    ~Foo()
    {
        Console.WriteLine("In the finalizer");
    }
}
