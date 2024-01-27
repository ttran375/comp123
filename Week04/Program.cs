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


TextReader reader = new StreamReader(filename); //Initialise the reader object

string line = reader.ReadLine();                //Do some reading
Console.WriteLine(line);                        //Display what was read

line = reader.ReadLine();                       //Do some reading

while (line != null)                             //Stop if you didn’t read anything
{
    Console.WriteLine(line);                      //Display what was read
    line = reader.ReadLine();                     //Do more reading
}

reader.Close();                                 //Now close the stream object

File.ReadAllText(filename);
