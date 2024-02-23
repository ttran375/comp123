using System;

class Hero
{
    private int health;                  // Not set in constructor, will have default value
    private string name;

    public Hero(string name) { this.name = name; }

    public override string ToString()
    {
        return $"{name} has {health} units of health";
    }
}

class Fraction
{
    private int top;
    private int bottom;
    public Fraction(int top, int bottom = 1)
    {
        this.top = top;
        this.bottom = bottom;
    }

    public override string ToString()
    {
        return $"[{top}, {bottom}]";
    }
}

class Panda
{
    private Panda mate;
    private string name;
    public Panda(string name)
    {
        this.name = name;
    }

    public void Marry(Panda mate)
    {
        this.mate = mate;
        mate.mate = this;
    }
    public override string ToString()
    {
        return $"{name} mate: {(mate != null ? mate.name : "Not Married")}";
    }
}

class Minion
{
    const int MAX = 10;                               // Maximum allowable minions
    static int count = 0;                             // How many minions created so far
    private int mischievousLevel;                     // A value indicating how mischievous this minion is
    private string name;

    private Minion(string name, int level)            // Not accessible externally
    {
        this.name = name;
        mischievousLevel = level;
        count++;                                        // An object was created so update the count
    }

    public static Minion CreateMinion(string name, int mischievousLevel)
    {
        if (count < MAX)                                // Check for room
            return new Minion(name, mischievousLevel);
        return null;                                   // No room so return nothing
    }

    public override string ToString()
    {
        return $"{name} {mischievousLevel} ";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hero robin = new Hero("Robin");
        Console.WriteLine(robin);            // Output: Robin has 0 units of health

        Fraction f1 = new Fraction(5);       // Using the default value for the second argument
        Fraction f2 = new Fraction(3, 10);
        Fraction f3 = new Fraction(bottom: 7, top: 2);
        Console.WriteLine(f1);            // Output: [5, 1]
        Console.WriteLine(f2);            // Output: [3, 10]
        Console.WriteLine(f3);            // Output: [2, 7]

        Panda p1 = new Panda("Tai Shan");
        Panda p2 = new Panda("Hua Mei");
        Console.WriteLine(p1);            // Output: Tai Shan mate: Not Married
        p1.Marry(p2);
        Console.WriteLine(p1);            // Output: Tai Shan mate: Hua Mei
        Console.WriteLine(p2);            // Output: Hua Mei mate: Tai Shan
    }
}
