namespace Week06
{
    #region Bird
    interface ISingable
    {
        void Sings();
    }
    interface ILikeable
    {
        bool Like(string disk);
    }
    internal class Bird : ISingable, ILikeable
    {
        public bool Like(string dish)
            => dish == "worm" || dish == "seed";

        public void Sings()
            => Console.WriteLine("tweet-tweet");
    }
    #endregion

    #region Drawing object
    class DrawingObject
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am a generic object");
        }
    }
    class Line : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I am a line");
        }
    }
    class Square : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I am a square");
        }
    }
    #endregion

    public class Address
    {
        public required string Number { get; set; }
        public required string Street { get; set; }
        public override string ToString()
            => $"{Number} {Street}";
    }
    public class Person
    {
        public Address Address { get; set; }

        public string LName { get; init; }  //auto-implemented property
        public string MName { get; private set; }  //auto-implemented property
        public string FName { get; }       //auto-implemented property
        double rate;                        //private field
        public double Rate                  //normal property (uses backing field
        {
            get { return rate; }
            set { rate = value; }
        }
        public double Salary                //computed property (does calculation)
        {
            get { return rate * 40; }
        }
        // abstract public int Age { get; set; } //abstract property
        public Person(string first, string middle, string last, Address address, double rate)
            => (FName, MName, LName, Address, Rate) = (first, middle, last, address, rate);
        public override string ToString()
            => $"{FName} {MName} {LName} {Address} {Rate:C} {Salary:C}";
    }
    class PersonTester
    {
        public static void Run()
        {
            Person p1 = new("shannon", "leigh", "mcgee", new Address { Number = "941", Street = "Progress Avenue" }, 15);
            p1.Address.Street = "Markham Road";
            Console.WriteLine(p1);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            TestBird();
            TestDrawing();
            PersonTester.Run();
        }
        static void TestBird()
        {
            Bird bird = new();
            bird.Sings();
            string dish = "pizza";
            Console.WriteLine($"I {(bird.Like(dish) ? "" : "do not ")}like {dish}");
            dish = "worm";
            Console.WriteLine($"I {(bird.Like(dish) ? "" : "do not ")}like {dish}");
        }
        static void TestDrawing()
        {
            List<DrawingObject> objs = new()
            {
                new DrawingObject(),
                new Square(),
                new Line(),
                new Square(),
                new DrawingObject()
            };
            //demonstrating polymorphism (calling the same on different objects will give different result)
            foreach (var item in objs)
            {
                item.Draw();
            }
        }
    }
}
