class Parent(string name)
{
    public string Name { get; protected set; } = name;
    public int Length { get; private set; }
    protected static void Doit() { /* Implementation of Doit method */ }

    public static void OpenUri(string uri) { /* Implementation of OpenUri method */ }
}

class Child : Parent
{
    public Child() : base("Narendra") { /* Additional functionalities specific to Child class, if any */ }
}


class ClassA
{
    public ClassA() { Console.WriteLine("ClassA"); }
}

class ClassB : ClassA
{
    public ClassB() { Console.WriteLine("ClassB"); }
}

class ClassC : ClassB
{
    public ClassC() { Console.WriteLine("ClassC"); }
}

class AParent
{
    public void HiddenMethod() { Console.WriteLine("In Parent"); }
}

class AChild : AParent
{
    new public void HiddenMethod() { Console.WriteLine("In Child"); }
}

class BParent
{
    public virtual void ReplaceableMethod() { Console.WriteLine("In Parent"); }
}

class BChild : BParent
{
    public override void ReplaceableMethod() { Console.WriteLine("In Child"); }
}

class Program
{
    static void Main()
    {
        // Example for AParent and AChild
        new AParent().HiddenMethod();                     // Output: In Parent

        AChild aChild = new();
        aChild.HiddenMethod();                            // Output: In Child
        ((AParent)aChild).HiddenMethod();                // Output: In Parent, child has two implementations of HiddenMethod

        // Example for BParent and BChild
        new BParent().ReplaceableMethod();                // Output: In Parent

        BChild bChild = new();
        bChild.ReplaceableMethod();                       // Output: In Child
        bChild.ReplaceableMethod();           // Output: In Child
    }
}
