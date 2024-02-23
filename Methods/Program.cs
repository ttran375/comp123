using System;

class Rectangle
{
    private int length;
    private int width;

    public Rectangle(int len, int wid)
    {
        length = len;
        width = wid;
    }

    public override string ToString()
    {
        return $"Length: {length}, width: {width}";
    }

    public static string GetDescription()
    {
        return "A planar figure with two pairs of parallel sides and all angles 90 degrees";
    }

    public int GetArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiating the class
        Rectangle r1 = new Rectangle(8, 5);

        // Printing the resulting object
        Console.WriteLine(r1); // Output: Length: 8, width: 5

        // Invoking an instance method
        Console.WriteLine(r1.GetArea()); // Output: 40

        // Invoking the static method
        Console.WriteLine(Rectangle.GetDescription()); // Output: A planar figure with two pairs of parallel sides and all angles 90 degrees
    }
}
