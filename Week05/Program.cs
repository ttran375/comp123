

using System;
class Program
{
    static void Main(string[] args)
    {
        X x = new X();
        x.A();
        x.B();

        Y y = new Y();
        y.A();
        y.B();

        Z z = new Z();
        // Can't call A() on Z because it's sealed in Y
        z.B();
    }
}

class X
{
    protected virtual void A()
    {
        Console.WriteLine("Executing A in class X");
    }

    protected virtual void B()
    {
        Console.WriteLine("Executing B in class X");
    }
}

class Y : X
{
    sealed protected override void A()
    {
        Console.WriteLine("Executing A in class Y");
    }

    protected override void B()
    {
        Console.WriteLine("Executing B in class Y");
    }
}

class Z : Y
{
    // Can't override A() because it's sealed in Y

    protected override void B()
    {
        Console.WriteLine("Executing B in class Z");
    }
}
