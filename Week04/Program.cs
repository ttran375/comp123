namespace Week04;

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string filename = "people.csv"; // Update with your CSV file path

        // Declare and initialize a text reader
        TextReader reader = new StreamReader(filename);

        // List to store the objects
        List<Person> persons = new List<Person>();

        // Read the first line
        string line = reader.ReadLine();

        // Read the file line by line
        while (line != null)
        {
            // Split the line by comma (',') for CSV
            string[] values = line.Split(',');

            // Check if the array has enough elements
            if (values.Length >= 4)
            {
                // Extract values and create a new Person object
                string name = values[0];
                double weight = Convert.ToDouble(values[1]);
                int age = Convert.ToInt32(values[2]);
                bool isMarried = Convert.ToBoolean(values[3]);

                // Add the object to the list
                persons.Add(new Person(name, age, weight, isMarried));
            }
            else
            {
                // Handle the case where the array doesn't have enough elements
                Console.WriteLine("Invalid data format in line: " + line);
            }

            // Read the next line
            line = reader.ReadLine();
        }

        // Close the stream object
        reader.Close();

        // Now, the 'persons' list contains the data as Person objects
        // You can use this list as needed in your application

        // print the list
        foreach (Person person in persons)
        {
            Console.WriteLine(person);
        }
    }
}
