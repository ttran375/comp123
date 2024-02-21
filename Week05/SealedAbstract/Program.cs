class X
{
    protected virtual void A() { /* implementation for A in X */ }
    protected virtual void B() { /* implementation for B in X */ }
}

class Y : X
{
    sealed protected override void A() { /* implementation for A in Y */ }
    protected override void B() { /* implementation for B in Y */ }
}

class Z : Y
{
    // Unable to override A in Y because it is sealed in Y
    // Can override B in Y
    protected override void B() { /* implementation for B in Z */ }
}

abstract class AnotherParent
{
    public abstract void E(); // Abstract method to be overridden
}

abstract class Parent : AnotherParent
{
    public int A = 0; // Initialize the field

    public string B { get; } = string.Empty; // Assign a default value or use nullable reference types

    public virtual string C { get; } = string.Empty; // Assign a default value or use nullable reference types

    public virtual void D() { /* implementation for D in Parent */ }

    public override void E() { /* overrides E in parent class */ }

    public abstract void F(); // MUST be overridden
}

class Child : Parent
{
    // Compiler error: Cannot override B because it is not declared as virtual in Parent
    // public override string B { get; }

    public override string C => "Narendra"; // Child replaces implementation in Parent class

    public override void D() { /* implementation for D in Child */ }

    public override void F() { /* implementation for F in Child */ }
}

class Program
{
    static void Main()
    {
        // Create an instance of Child
        Child child = new Child();

        // Call overridden methods and properties
        Console.WriteLine(child.C); // Output: Narendra
        child.D();
        child.E();
        child.F();
    }
}
