class AParent
{
    public void HiddenMethod()
    {
        Console.WriteLine("In Parent");
    }
}

class AChild : AParent
{
    new public void HiddenMethod()
    {
        Console.WriteLine("In Child");
    }
}

class Program
{
    static void Main()
    {
        AParent parent = new AChild();
        parent.HiddenMethod(); // Output: In Parent
    }
}
