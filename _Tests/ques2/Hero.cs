[Flags]
enum PowerEnum
{
    None = 0,
    Armour = 1,
    Elemental_Control = 0b10,
    Teleporter = 0b100,
    Healing = 0b1_000,
    Marksman = 0b10_000,
    Size_Changer = 0b100_000,
    Strength = 0b1_000_000,
    Speed = 0b10_000_000
}
class Hero
{
    public string Name { get; }
    public int Age { get; private set; }
    public bool IsGood { get; private set; }
    public PowerEnum Power { get; private set; }
    public Hero(string name, int age, bool isGood, PowerEnum power)
    {
        Name = name; Age = age;
        IsGood = isGood;
        Power = power;
    }
    public static List<Hero> GetHeros()
        => new List<Hero> {
            new Hero( "Superman",32, true, PowerEnum.Strength | PowerEnum.Speed),
            new Hero( "Batman",24, true, PowerEnum.Armour ),
            new Hero( "Green Goblin",25, false, PowerEnum.Teleporter | PowerEnum.Elemental_Control),
            new Hero( "Mystique",27, true, PowerEnum.Elemental_Control ),
            new Hero( "Flash", 29, true, PowerEnum.Marksman | PowerEnum.Speed ),
            new Hero( "Spiderman", 21, false, PowerEnum.Strength ),
            new Hero( "Wonder Woman", 32, true, PowerEnum.Strength | PowerEnum.Speed ),
            new Hero( "Iron Man",26, true, PowerEnum.Armour ),
            new Hero( "Iceman",31, true, PowerEnum.Elemental_Control ),
            new Hero( "Night Crawler",22, false, PowerEnum.Teleporter | PowerEnum.Armour ),
            new Hero( "Elixer",33, true, PowerEnum.Healing ),
            new Hero( "Green Arrow",30, true, PowerEnum.Marksman ),
            new Hero( "Penguin",22, false, PowerEnum.Armour ),
            new Hero( "Riddler",23, false, PowerEnum.Speed),
            new Hero( "Thanos",24, false, PowerEnum.Strength | PowerEnum.Speed | PowerEnum.Elemental_Control),
            new Hero( "Loki",25, false,PowerEnum.Speed | PowerEnum.Strength ),
            new Hero( "Vulture",21, false, PowerEnum.Speed ),
            new Hero( "Lizard",26, false, PowerEnum.Strength ),
            new Hero( "Hydro Man",27, false, PowerEnum.Elemental_Control),
            new Hero( "Vector",28, false, PowerEnum.Strength ),
            new Hero( "Atom Man",23, true, PowerEnum.Size_Changer | PowerEnum.Teleporter)
        };

    public override string ToString()
        => $"{Name} {(IsGood ? "Good" : "Bad")} {Age} {Power}";
}
