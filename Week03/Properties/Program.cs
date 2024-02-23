using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Thermometer
        Thermometer thermometer = new Thermometer();
        thermometer.Celsius = 25.5;
        Console.WriteLine($"Temperature in Celsius: {thermometer.Celsius}");

        // Creating an instance of Distance
        Distance distance = new Distance();
        distance.Km = 100;
        Console.WriteLine($"Distance in Kilometers: {distance.Km}");
        Console.WriteLine($"Distance in Miles: {distance.Mile}");

        // Testing the Month property
        MonthTester monthTester = new MonthTester();
        monthTester.Month = 5; // Valid month
        Console.WriteLine($"Month: {monthTester.Month}");
        monthTester.Month = 15; // Invalid month, should be defaulted to 0
        Console.WriteLine($"Month: {monthTester.Month}");

        // Testing the Name property
        NameTester nameTester = new NameTester();
        nameTester.Name = "John";
        Console.WriteLine($"Name: {nameTester.Name}");
        nameTester.Name = ""; // Empty name, should be "NA"
        Console.WriteLine($"Name: {nameTester.Name}");

        // Testing the Balance property
        BalanceTester balanceTester = new BalanceTester();
        Console.WriteLine($"Balance: {balanceTester.Balance}");

        // Testing the Information property
        InformationTester informationTester = new InformationTester();
        informationTester.Information = "This is a secret.";
        Console.WriteLine($"Information: {informationTester.Information}");

        Console.ReadLine();
    }
}

class Thermometer
{
    private double _Celsius;   // A backing field
    public double Celsius      // A property using the field _Celsius
    {
        get
        {
            return _Celsius;
        }
        set
        {
            _Celsius = value;     // This is an implicit parameter supplied by the runtime
        }
    }
}

class Distance
{
    const double KM_TO_MILES = 0.621371;       // Conversion factor
    private double _km;                        // In kilometers

    public double Km
    {
        get { return _km; }
        set { _km = value; }
    }

    public double Mile
    {
        get { return _km * KM_TO_MILES; }       // Get the correct mile value
        set { _km = value / KM_TO_MILES; }       // Set the correct kilometer value
    }
}

class MonthTester
{
    private double month;

    public double Month
    {
        get { return month; }

        // A month value has to be between 0 and 11
        set
        {
            if (value < 0 || value > 11) value = 0;
            month = value;
        }
    }
}

class NameTester
{
    private string name;

    public string Name
    {
        get { return (name == "") ? "NA" : name; }

        // Sets the name field
        set
        {
            name = value;
        }
    }
}

class BalanceTester
{
    private int balance;
    private int numberOfTimeAccessed = 0;

    public int Balance
    {
        get
        {
            numberOfTimeAccessed++;     // You can also log to file
            return balance;
        }
    }
}

class InformationTester
{
    private string secret_information;
    private string userId = "user123"; // Assuming userId is available

    public string Information
    {
        get
        {
            Console.WriteLine($"Accessed by {userId} on {DateTime.Now}"); // Logs id and time
            return secret_information;
        }

        set
        {
            Console.WriteLine($"Written by {userId} on {DateTime.Now}"); // Logs id and time
            secret_information = value;
        }
    }
}
