using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.IO; //STEP I - include the necessary namespace


namespace Week03

{

/**

* This implementation will not match the lab specs

*/

class Date

{

public int Year { get; private set; }

public int Month { get; private set; }

public int Day { get; private set; }

public Date(int year, int month, int day)

=> (Year, Month, Day) = (year , month, day);

public override string ToString()

=> $"{Year}-{Month:D2}-{Day:D2}";

public void Add(int days)

{

Day += days;

Normalize();

}

public void Add(int months, int days)

{

Day += days;

Month += months;

Normalize();

}

public void Add(Date date)

{

Day += date.Day;

Month += date.Month;

Year += date.Year;

Normalize();

}

private void Normalize()

{

//I am going to assume that all months have 30 days

while (Day > 30)

{

Day -= 30;

Month++;

}

while (Month > 12)

{

Month -= 12;

Year++;

}

}

}


enum Gender

{

Male, Female, Neutral

}

class Astronaut

{

//static memeber are shared by the entire class

static int COUNT = 0 , MAX = 6;

public string Name { get; }

public string Nationality { get; }

public Gender Gender { get; }


//private constructor prevents instantiation outside of the class

private Astronaut(string name, string nationality, Gender gender = Gender.Female)

{

(Name, Nationality, Gender) = (name, nationality, gender);

COUNT++;

}


public override string ToString()

=> $"{Nationality}\t{Name}\t{Gender}";

public static Astronaut CreateAstronaut(string name, string nationality, Gender gender = Gender.Female)

{

//check if there is room for another astronaut before instantiation

if (COUNT < MAX)

return new Astronaut(name, nationality, gender);

else

return null; //null is a stand in for any type

}

public static List<Astronaut> CreateAstronautList()

{

return new List<Astronaut>()

{

Astronaut.CreateAstronaut("Sushmita Armstrong", "US", Gender.Male),

Astronaut.CreateAstronaut("Sarah Hadfield", "Canada", Gender.Male),

Astronaut.CreateAstronaut("Shannon Magee", "US", Gender.Male),

Astronaut.CreateAstronaut("Gurleen Buttar", "Canada"),

Astronaut.CreateAstronaut("Haseeb Siddiqi", "US"),

Astronaut.CreateAstronaut("Ayushika Mahajan", "Canada", Gender.Female),

};

}

}

internal class Program

{

static void Main(string[] args)

{

//TestDate();

//TestAstronaut();

DemoFileIO();

}

static void TestDate()

{

//testing the constructor

Date d1 = new Date(2022, 1, 28);

Console.WriteLine(d1);


//testing the Add(int) method

int days = 22;

Console.WriteLine($"Adding {days} days");

d1.Add(days);

Console.WriteLine(d1);


//testing the Add(int, int) method

int months = 11;

days = 23;

Console.WriteLine($"Adding {months} months {days} days");

d1.Add(months, days);

Console.WriteLine(d1);


//testing the Add(Date) method

Date d2 = new Date(2, 6, 11);

Console.WriteLine($"Adding {d2} ");

d1.Add(d2);

Console.WriteLine(d1);

}


static void TestAstronaut()

{

Astronaut a1 = Astronaut.CreateAstronaut("Sushmita Armstrong", "US", Gender.Male);

//Console.WriteLine(a1);

Astronaut a2 = Astronaut.CreateAstronaut("Sarah Hadfield", "Canada", Gender.Male);

//Console.WriteLine(a2);

Astronaut a3 = Astronaut.CreateAstronaut("Shannon Magee", "US", Gender.Male);

//Console.WriteLine(a3);

Astronaut a4 = Astronaut.CreateAstronaut("Gurleen Buttar", "Canada");

//Console.WriteLine(a4);

Astronaut a5 = Astronaut.CreateAstronaut("Haseeb Siddiqi", "US");

//Console.WriteLine(a5);

Astronaut a6 = Astronaut.CreateAstronaut("Ayushika Mahajan", "Canada", Gender.Female);

//Console.WriteLine(a6);


List<Astronaut> astronauts = new List<Astronaut>()

{

a1, a2, a3, a4, a5

};

//using the Add() method to add the last one

astronauts.Add(a6);

foreach (Astronaut astronaut in astronauts)

{

Console.WriteLine(astronaut);

}

string country = "Canada";

Console.WriteLine($"\nDisplaying only astronaut from {country}");

foreach (Astronaut astronaut in astronauts)

{

if(astronaut.Nationality == country)

Console.WriteLine(astronaut);

}


string letter = "S";

Console.WriteLine($"\nDisplaying only astronaut with name starting with {letter}");

foreach (Astronaut astronaut in astronauts)

{

if (astronaut.Name.StartsWith(letter))

Console.WriteLine(astronaut);

}

}


static void DemoFileIO()

{

List<Astronaut> astronauts = Astronaut.CreateAstronautList();


////writing to a file

////STEP II - Create a StreamWriter object

//TextWriter writer = new StreamWriter("astronaut.txt");

////STEP III - Write to the file

//foreach (var item in astronauts)

//{

// writer.WriteLine(item);

//}

////STEP IV - Close the StreamWrite object

//writer.Close();



//reading a file

//STEP II - Create a StreamReader object

TextReader reader = new StreamReader("astronaut.txt");

//STEP III - Write to the file

string line = reader.ReadLine();

while (line != null)

{

string[] parts = line.Split('\t');

Console.WriteLine($"{Convert.ToInt32(parts[2]) + 100}");

line = reader.ReadLine();

}

//STEP IV - Close the StreamReader object

reader.Close();

}

}

}


