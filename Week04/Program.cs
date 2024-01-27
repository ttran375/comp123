namespace Week04;

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // string filename = "people.txt"; // Update with your CSV file path

        // TextReader reader = new StreamReader(filename);  //Declare and initialise a text reader
        // List<Person> persons = new List<Person>();      //list to store the objects                                          
        // string line = reader.ReadLine();                 //read the first line
        // while (line != null)                              //read the first line
        // {
        //     string[] values = line.Split('\t');
        //     string name = values[0];
        //     double weight = Convert.ToDouble(values[1]);
        //     int age = Convert.ToInt32(values[2]);
        //     bool isMarried = Convert.ToBoolean(values[3]);
        //     persons.Add(new Person(name, age, weight, isMarried)); //add object to the list
        //     line = reader.ReadLine();                      //read the next line
        // }

        // reader.Close();                                  //Now close the stream object


        // Now, the 'persons' list contains the data as Person objects
        // You can use this list as needed in your application

        // print the list
        // foreach (Person person in persons)
        // {
        //     Console.WriteLine(person);
        // }

        // using (StreamReader sr = new StreamReader("people.csv"))
        // {
        //     string line;
        //     while ((line = sr.ReadLine()) != null)
        //     {
        //         string[] values = line.Split(',');
        //         string name = values[0];
        //         Console.WriteLine(name);
        //     }
        // }

        using (StreamReader sr = new StreamReader("people.csv"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
