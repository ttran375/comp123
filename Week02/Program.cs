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
        => (Year, Month, Day) = (year, month, day);

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
            // I am going to assume that all months have 30 days
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
        // Static memeber are shared by the entire class
        static int COUNT = 0, MAX = 6;
        public string Name { get; }
        public string Nationality { get; }
        public Gender Gender { get; }

        // Private constructor prevents instantiation outside of the class

        private Astronaut(string name, string nationality, Gender gender = Gender.Female)
        {
            (Name, Nationality, Gender) = (name, nationality, gender);
            COUNT++;
        }

        public override string ToString()
        => $"{Nationality}\t{Name}\t{Gender}";

        public static Astronaut CreateAstronaut(string name, string nationality, Gender gender = Gender.Female)
        {
            // Check if there is room for another astronaut before instantiation
            if (COUNT < MAX)
                return new Astronaut(name, nationality, gender);
            else
                return null; //null is a stand in for any type
        }

        public static List<Astronaut> CreateAstronautList()
        {
            return
            new List<Astronaut>()
            {
            CreateAstronaut("Sushmita Armstrong", "US", Gender.Male),
            CreateAstronaut("Sarah Hadfield", "Canada", Gender.Male),
            CreateAstronaut("Shannon Magee", "US", Gender.Male),
            CreateAstronaut("Gurleen Buttar", "Canada"),
            CreateAstronaut("Haseeb Siddiqi", "US"),
            CreateAstronaut("Ayushika Mahajan", "Canada", Gender.Female),
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
