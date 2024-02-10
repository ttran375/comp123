class Program
{
    static void Main(string[] args)
    {
        // Create a new Person object with a name and a new Address
        Person person = new Person("John Doe", new Address("123", "Main St", "Anytown", "Anystate", "AnyCountry", "AnyProvince", "12345"));

        // Add some phone numbers to the person
        person.AddPhoneNumber(new PhoneNumber("123-456-7890", "Home"));
        person.AddPhoneNumber(new PhoneNumber("098-765-4321", "Mobile"));

        // Print out the person's name, address, and phone numbers
        Console.WriteLine($"Name: {person.Name}");
        Console.WriteLine($"Address: {person.Address}");
        foreach (PhoneNumber phoneNumber in person.PhoneNumbers)
        {
            Console.WriteLine(phoneNumber);
        }
    }
}

public class Address
{
    public string StreetNumber { get; set; }
    public string StreetName { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string StateProvince { get; set; }
    public string StateZipCode { get; set; }

    public Address(string streetNumber, string streetName, string city, string state, string country, string stateProvince, string stateZipCode)
    {
        StreetNumber = streetNumber;
        StreetName = streetName;
        City = city;
        State = state;
        Country = country;
        StateProvince = stateProvince;
        StateZipCode = stateZipCode;
    }

    public override string ToString()
    {
        return $"{StreetNumber} {StreetName}, {City}, {State}, {Country}, {StateProvince}, {StateZipCode}";
    }
}

public class PhoneNumber
{
    public string Number { get; set; }
    public string Type { get; set; } // e.g., Mobile, Home, Work

    public PhoneNumber(string number, string type)
    {
        Number = number;
        Type = type;
    }

    public override string ToString()
    {
        return $"{Type}: {Number}";
    }
}

class Person
{
    public string Name { get; set; }
    public Address Address { get; private set; }
    public List<PhoneNumber> PhoneNumbers { get; set; }

    public Person(string name, Address address)
    {
        Name = name;
        Address = address;
        PhoneNumbers = new List<PhoneNumber>();
    }

    public void AddPhoneNumber(PhoneNumber phoneNumber)
    {
        PhoneNumbers.Add(phoneNumber);
    }
}
