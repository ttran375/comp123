﻿class Program
{
    static void Main(string[] args)
    {
        List<Hero> h = Hero.GetHeros();

        //declare and initialise a dictionary
        Dictionary<string, Hero> heros = new Dictionary<string, Hero>();
        foreach (Hero item in h)
        {
            heros.Add(item.Name, item);
        }
        string name = "Iron Man";
        Console.WriteLine($"{name} -> {heros[name]}\n");

        int age = 25;
        var r1 =
            from pairs in heros
            where pairs.Value.Age < age
            select $"{pairs.Value.Name} {pairs.Value.Age}";
        Console.WriteLine($"Younger than {age}: \n {(string.Join("\n ", r1))}");
    }
}
