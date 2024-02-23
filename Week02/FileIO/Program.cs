using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filename = "example.txt";

        // Writing to a file
        using (TextWriter writer = new StreamWriter(filename))
        {
            writer.Write("Mulroney");
            writer.WriteLine("Harper");

            writer.Write("Narendra");
            writer.WriteLine("Pershad");
            writer.WriteLine("================");

            for (int i = 1; i <= 12; i++)
            {
                writer.WriteLine($"{i,2} x 15 = {i * 15}");
            }
        }

        // Reading from a file
        using (TextReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        // Creating objects from file data
        List<Person> persons = new List<Person>();
        using (TextReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] values = line.Split('\t');
                string name = values[0];
                double weight = Convert.ToDouble(values[1]);
                int age = Convert.ToInt32(values[2]);
                bool isMarried = Convert.ToBoolean(values[3]);
                persons.Add(new Person(name, age, weight, isMarried));
            }
        }

        // Alternative object creation from file data
        using (TextReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string name = line;
                double weight = Convert.ToDouble(reader.ReadLine());
                int age = Convert.ToInt32(reader.ReadLine());
                bool isMarried = Convert.ToBoolean(reader.ReadLine());
                Person person = new Person(name, age, weight, isMarried);
            }
        }
    }
}

class Person
{
    public string Name { get; }
    public int Age { get; }
    public double Weight { get; }
    public bool IsMarried { get; }

    public Person(string name, int age, double weight,
        bool isMarried = true)
    {
        Name = name; Age = age; Weight = weight;
        IsMarried = isMarried;
    }
}
