namespace Week04;

class Program
{
    public static void Main(string[] args)
    {
        String filename = "output.txt";
        // TextWriter writer = new StreamWriter(filename);  //Declare and initialise 
        //                                                  //the object to write to

        // writer.Write("Narendra");                      //Do some writing
        // writer.WriteLine("Pershad");
        // writer.WriteLine("================");

        // for (int i = 1; i <= 12; i++)
        // {
        //     writer.WriteLine($"{i,2} x 15 = {i * 15}");     //Do more writing
        // }

        // writer.Close();                                  //Now close the stream object


        // TextReader reader = new StreamReader(filename); //Initialise the reader object

        // string line = reader.ReadLine();                //Do some reading
        // Console.WriteLine(line);                        //Display what was read

        // line = reader.ReadLine();                       //Do some reading

        // while (line != null)                             //Stop if you didn’t read anything
        // {
        //     Console.WriteLine(line);                      //Display what was read
        //     line = reader.ReadLine();                     //Do more reading
        // }

        // reader.Close();                                 //Now close the stream object

        // File.ReadAllText(filename);

        TextReader reader = new StreamReader(filename);  //Declare and initialise a text reader
        List<Person> persons = new List<Person>();      //list to store the objects                                          
        string line = reader.ReadLine();                 //read the first line
        while (line != null)                              //read the first line
        {
            string[] values = line.Split('\t');
            if (values.Length >= 4)
            {
                string name = values[0];
                double weight = Convert.ToDouble(values[1]);
                int age = Convert.ToInt32(values[2]);
                bool isMarried = Convert.ToBoolean(values[3]);
                persons.Add(new Person(name, age, weight, isMarried)); //add object to the list
            }
            else
            {
                Console.WriteLine($"Line '{line}' does not contain the expected number of elements.");
            }
            string name = values[0];
            double weight = Convert.ToDouble(values[1]);
            int age = Convert.ToInt32(values[2]);
            bool isMarried = Convert.ToBoolean(values[3]);
            persons.Add(new Person(name, age, weight, isMarried)); //add object to the list
            line = reader.ReadLine();                      //read the next line
        }

        reader.Close();                                  //Now close the stream object

    }
}
