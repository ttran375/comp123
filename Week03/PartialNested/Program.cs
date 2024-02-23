using System;

// Define Foo in partial class files
// in foo_b.cs 
public partial class Foo
{
    public Foo()
    {
    }
    public void Bar()
    {
    }
}

// in foo_a.cs
public partial class Foo
{
    public void Baz()
    {
    }
    public override string ToString()
    {
        return "Custom ToString() method";
    }
}

// Define Container class
public class Container
{
    public int Foo;
    public void Bar()
    {
    }
    public class Nested
    {
        public void Baz()
        {
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Anonymous type usage
        var a = new { Name = "Trudeau", Age = 25 };
        Console.WriteLine(a); // Output: { Name = Trudeau, Age = 25 }

        // Instantiate Foo and use its methods
        Foo foo = new Foo();
        foo.Bar();
        foo.Baz();
        Console.WriteLine(foo.ToString()); // Output: Custom ToString() method

        // Instantiate Container and use its members
        Container container = new Container();
        container.Foo = 10;
        container.Bar();

        // Instantiate Nested class and use its methods
        Container.Nested nested = new Container.Nested();
        nested.Baz();
    }
}
