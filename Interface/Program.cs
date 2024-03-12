interface ISingable
{
    void Sing();
}

interface ILikeable
{
    bool Like(string dish);
}

interface IMoveable
{
    string Move { get; }
}

class Frog : ISingable
{
    public void Sing()
    {
        Console.WriteLine("ribbit");
    }
}

class Rabbit : IMoveable
{
    public string Move
    {
        get => "hop";
    }
}

class Bird : ISingable, ILikeable
{
    public void Sing()
    {
        Console.WriteLine("tweet tweet");
    }

    public bool Like(string food)
        => food == "worm" || food == "seeds";
}

abstract class Pet : IMoveable, ILikeable
{
    public abstract string Move { get; }
    public abstract bool Like(string dish);
}

class Snake : Pet
{
    public override string Move
    {
        get => "crawl";
    }

    public override bool Like(string dish)
        => dish == "mouse";
}

interface IBar
{
    void Foo();
}

interface IBaz
{
    void Foo();
}

class Qux : IBar, IBaz
{
    void IBar.Foo()
    {
        Console.WriteLine("IBar.Foo");
    }

    void IBaz.Foo()
    {
        Console.WriteLine("IBaz.Foo");
    }
}

interface IDrivable
{
    void ChangeGear(int i);
    void SlowDown(int i);
    void SpeedUp(int i);
}

interface IEmployee
{
    string Name
    {
        get;
        set;
    }

    int Counter
    {
        get;
    }
}

public class Employee(string initialName) : IEmployee
{
    public static int NumberOfEmployees;
    public string Name { get; set; } = initialName ?? throw new ArgumentNullException(nameof(initialName));
    public int Counter { get; } = ++NumberOfEmployees;
}

interface IQux : IBar, IBaz
{
    void Quux();
}


class Program
{
    static void Main()
    {
        Bird b = new();

        if (b is not ISingable c)
        {
            Console.WriteLine("Conversion unsuccessful");
        }
        else
        {
            Console.WriteLine("Conversion successful");
        }
    }
}
