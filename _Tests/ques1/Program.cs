class Program
{
    static void Main(string[] args)
    {
        //get the heros collection
        List<Hero> heroes = Hero.GetHeros();
        /*
        //query 1
        var r1 =
            from h in heroes
            where h.IsGood == false
            select h;
        Console.WriteLine($"Only villians: \n {(string.Join("\n ", r1))}");

        //query 2
        PowerEnum power = PowerEnum.Armour;
        var r2 =
            from h in heroes
            where h.Power.HasFlag(power)
            select h;
        Console.WriteLine($"Heros with {power}: \n {(string.Join("\n ", r2))}");

        //query 3
        var r3 =
            from h in heroes
            orderby h.Age descending
            select h;
        Console.WriteLine($"Ordered by age: \n {(string.Join("\n ", r3))}");

        //query 4
        var r4 =
            from h in heroes
            orderby h.Age
            select $"{h.Name} {h.Age} - {h.Power}";
        Console.WriteLine($"Name, age and power in age order: \n {(string.Join("\n ", r4))}");

        //query 5
        var r5 =
            from h in heroes
            select new {h.Name, h.Age };
        Console.WriteLine($"Name and age in no order: \n {(string.Join("\n ", r5))}");
        */
        //query 6
        var r6 =
            from h in heroes
            group h by h.Age % 2 into age_group
            select age_group;
        Console.WriteLine($"Age grouped into odd and even years: \n ");
        foreach (var group in r6)
        {
            Console.WriteLine($"{group.Count()} hero(s) with {(group.Key == 0 ? "even" : "odd")} age");
            Console.WriteLine($" {(string.Join("\n ", group))}");
        }
    }
}
