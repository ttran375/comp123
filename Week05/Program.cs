class Program
{
    static void Main()
    {
        // Creating an instance of the Child class will invoke the Parent and Child constructors
        Child childObject = new Child();

        // Rest of the program logic, if any
    }
}

class Parent
{
    public Parent(string name)
    {
        // Constructor logic here
        Console.WriteLine($"Parent constructor called with name: {name}");
    }
}

class Child : Parent
{
    public Child() : base("Narendra")
    {
        // Child-specific constructor logic here
        Console.WriteLine("Child constructor called");
    }
}
