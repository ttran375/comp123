using System;

public enum Days { Sun = 1, Mon = 2, Tue = 3, Wed = 4, Thu = 5, Fri = 6 }

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a day of the week: ");
        Days day = (Days)Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case Days.Mon:
            case Days.Wed:
                Console.WriteLine($"{day} is a Home day");
                break;
            default:
                Console.WriteLine($"{day} is a Work day");
                break;
        }

        // Consider the following enum definition         
        // Note the underlying type is declared byte to save
        // on storage

        Console.WriteLine("\nEnum values and members for Volume:");

        // get a list of member names from Volume
        // enum, figure out the numeric value, and
        // display 

        foreach (var v in Enum.GetNames(typeof(Volume)))
        {
            Console.WriteLine($"Member: {v}\n Value: {(byte)Enum.Parse(typeof(Volume), v)}");
        }

        // get all values (numeric values) from the
        // Volume enum type, figure out member name,
        // and display

        foreach (var v in Enum.GetValues(typeof(Volume)))
        {
            Console.WriteLine($"Value: {v}\n Member: {Enum.GetName(typeof(Volume), v)}");
        }
    }
}

// Define additional enums mentioned in the instructions

public enum Volume : byte
{
    Low = 1,
    Medium,
    High
}

[Flags]
public enum CarOptions
{
    None = 0x00,
    SunRoof = 0x01,
    Spoiler = 0x02,
    FogLights = 0x04,
    TintedWindows = 0x08,
    Hydraulics = 0x16
}

[Flags]
public enum MovieGenre
{
    None,
    Action,
    Romance,
    Documentary,
    Adult,
    Sci_Fi,
    Religious
}

public enum Day
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public enum MaritalStatus
{
    Single = 6,
    Married = 2,
    Separated,
    Divorced,
    Widowed
}

public enum OrderStatus
{
    None,
    Confirmed,
    Paid,
    Shipped
}

public enum Color
{
    None,
    Red,
    Green,
    Blue
}

public enum CoffeeSize
{
    Small,
    Medium,
    Large,
    Extra_Large
}

public enum Direction
{
    East,
    West,
    North,
    South
}
