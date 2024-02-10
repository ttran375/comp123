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

    public string getStreetNumber()
    {
        return this.StreetNumber;
    }

    public void setStreetNumber(string StreetNumber)
    {
        this.StreetNumber = StreetNumber;
    }

    public string getStreetName()
    {
        return this.StreetName;
    }

    public void setStreetName(string StreetName)
    {
        this.StreetName = StreetName;
    }

    public string getCity()
    {
        return this.City;
    }

    public void setCity(string City)
    {
        this.City = City;
    }

    public string getState()
    {
        return this.State;
    }

    public void setState(string State)
    {
        this.State = State;
    }

    public string getCountry()
    {
        return this.Country;
    }

    public void setCountry(string Country)
    {
        this.Country = Country;
    }

    public string getStateProvince()
    {
        return this.StateProvince;
    }

    public void setStateProvince(string StateProvince)
    {
        this.StateProvince = StateProvince;
    }

    public string getStateZipCode()
    {
        return this.StateZipCode;
    }

    public void setStateZipCode(string StateZipCode)
    {
        this.StateZipCode = StateZipCode;
    }


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
