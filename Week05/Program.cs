class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123", "Main St", "Anytown", "Anystate", "AnyCountry", "AnyProvince", "12345");
        Console.WriteLine(address.ToString());
    }
}

public class Address
{
    string StreetNumber;
    string StreetName;
    string City;
    string State;
    string Country;
    string StateProvince;
    string StateZipCode;

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
