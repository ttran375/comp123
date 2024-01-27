namespace Week04;

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
