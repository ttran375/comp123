using System;

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

class Program
{
    static void Main(string[] args)
    {
        ClassC obj = new ClassC();
    }
}
