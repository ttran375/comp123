# This test will be the same format as the first test, however for convenience you are given a single document.

The supporting class hero is given and will be used for all the
questions.

There are embedding code that will figure out if there are
irregularities with your apps. If a problem is detected in one question,
then the entire test is forfeited. Please control your code.

The sample executables and supporting class file is given.

Each question will be done in separate projects. (The name of the
projects will be «firstname»\_ques1) so for me the folders will be
called **narendra_ques1**, **narendra_ques2** and **narendra_ques3**.

You will submit a zip file of your entire project folder (You need to
submit 3 zip files)

## Question 1

Examine the output of the **Question1.exe** to determine the linq
queries to write.

```
Only villians:
 Green Goblin Bad 25 Elemental_Control, Teleporter
 Spiderman Bad 21 Strength
 Night Crawler Bad 22 Armour, Teleporter
 Penguin Bad 22 Armour
 Riddler Bad 23 Speed
 Thanos Bad 24 Elemental_Control, Strength, Speed
 Loki Bad 25 Strength, Speed
 Vulture Bad 21 Speed
 Lizard Bad 26 Strength
 Hydro Man Bad 27 Elemental_Control
 Vector Bad 28 Strength
Press enter to see the next query ...
```

## Question 2

Examine the output of the **Question2.exe**.

1.  In this question, you will use the static **GetHeros()** of the Hero
    class to create a dictionary with the name of the hero as the key
    and the hero obj as the value.

2.  Print out the value of the key **"Iron Man"** to determine the linq
    queries to write.

3.  Use a linq query to print all the heros from the dictionary who are
    under 25

```
Iron Man -> Iron Man Good 26 Armour

Younger than 25:
 Batman 24
 Spiderman 21
 Night Crawler 22
 Penguin 22
 Riddler 23
 Thanos 24
 Vulture 21
 Atom Man 23
Press enter to end program ...
```

## Question 3

Create a Windows Forms that behaves exactly like **Question3.exe**.

## Hero.cs

``` cs
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

```
