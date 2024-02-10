using System;

abstract class AnotherParent
{
    public virtual void E() { Console.WriteLine("Executing E in AnotherParent"); }
}

abstract class Parent : AnotherParent
{
    public int A = 0; // Assign a default value
    public string B { get; } = ""; // Assign a default value
    public virtual string C { get; } = ""; // Assign a default value
    public virtual void D() { Console.WriteLine("Executing D in Parent"); }
    public override void E() { Console.WriteLine("Executing E in Parent"); }
    public abstract void F();
}

class Child : Parent
{
    public override string C
    {
        get { return "Narendra"; }
    }

    public override void D() { Console.WriteLine("Executing D in Child"); }
    public override void F() { Console.WriteLine("Executing F in Child"); }
}

class Program
{
    static void Main(string[] args)
    {
        Child child = new Child();
        child.D();
        child.F();
    }
}
