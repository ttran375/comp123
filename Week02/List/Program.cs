using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Declaration of uninitialized list
        List<int> evens;

        // Creating an empty list of ints
        List<int> numbers = new List<int>();

        // Creating a list with three doubles
        List<double> radii = new List<double>() { 1.0, 2.1, 3.6 };

        // Creating a list with five strings
        List<string> pms = new List<string>() { "Trudeau", "Harper", "Martin", "Chretien", "Campbell" };

        // Creating a list of rectangle
        List<Rectangle> rectangles = new List<Rectangle>();

        // Adding an item to a list
        // The new item will be appended to the end of the list
        numbers.Add(3);         // numbers will have a single item
        pms.Add("Mulroney");    // pms will now have six items

        // Adding a collection to a list
        pms.AddRange(pms);    // add the pms collection to itself

        // Inserting an item to a list
        // This adds an item at a specified position
        pms.Insert(2, "William Lyon Mackenzie King");

        // Removing an item from a list
        // This method will remove an item from the list if it exists.
        // If it not present, nothing happens.
        pms.Remove("Mulroney");             // pms will now have six items

        // You may also remove an item at a specified location in a list.
        radii.RemoveAt(1);

        // You may also remove multiple items
        // radii.RemoveRange(position, amount);

        // Removing all items from a list
        // This method will remove all of the items from a list.
        numbers.Clear();                   // numbers is now empty

        // The contains method checks for any occurrence of an item to a list:
        string name = "Mulroney";
        if (pms.Contains(name))
        {
            Console.WriteLine($"{name} is present in the list");    // this will be executed
        }
        else
        {
            Console.WriteLine($"{name} is not present in the list"); // this will not be executed
        }

        // Displaying lists
        Console.WriteLine("\nDisplaying numbers:");
        foreach (int x in numbers)
        {
            Console.Write(x + ", ");
        }

        Console.WriteLine("\n\nDisplaying names that are longer than 6 letters:");
        foreach (string pm in pms)
        {
            if (pm.Length > 6)
            {
                Console.Write(pm + ", ");
            }
        }

        Console.WriteLine("\n\nDisplaying names that start with 'C':");
        foreach (string pm in pms)
        {
            if (pm.StartsWith("C"))
            {
                Console.Write(pm + ", ");
            }
        }

        // Printing lists using string.Join()
        Console.WriteLine("\n\nPrinting names using string.Join():");
        string res = string.Join(", ", pms); // each item is separated by a comma and a space
        Console.WriteLine(res);
    }
}

public class Rectangle
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Area()
    {
        return Width * Height;
    }

    public override string ToString()
    {
        return $"Rectangle [Width={Width}, Height={Height}]";
    }
}
