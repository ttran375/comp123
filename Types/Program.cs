using System;

class Rectangle
{
    public int length;
    public int width;
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle bigRect;              //declare the variable
        bigRect = new Rectangle
        {
            length = 8,             //sets the length to 8
            width = 5              //sets the width to 5
        };      //allocate storage

        //declaration and allocation one step 
        Rectangle smallRect = new Rectangle
        {
            length = 3,           //sets the length to 3
            width = 2            //sets the width to 2
        };

        DescribeRectangle(bigRect);
        DescribeRectangle(smallRect);

        CalculateAndDisplayAreaOfRectangle(bigRect);
        CalculateAndDisplayAreaOfRectangle(smallRect);

        Rectangle newRect = CreateRectangle(4, 6);
        DescribeRectangle(newRect);
        CalculateAndDisplayAreaOfRectangle(newRect);
    }

    public static void DescribeRectangle(Rectangle rect)
    {
        Console.WriteLine($"Width: {rect.width}, Length: {rect.length}");
    }

    public static void CalculateAndDisplayAreaOfRectangle(Rectangle rect)
    {
        int area = rect.width * rect.length;
        Console.WriteLine($"Area: {area}");
    }

    public static Rectangle CreateRectangle(int width, int length)
    {
        Rectangle result = new Rectangle
        {
            width = width,
            length = length
        };
        return result;
    }
}
