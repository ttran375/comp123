using System;

public class Time
{
    private int ticks;

    public int Seconds { get => ticks % 60; }
    public int Minutes { get => ticks / 60 % 60; }
    public int Hours { get => ticks / 3600; }

    public Time(int hours, int minutes, int seconds)
    {
        this.ticks = hours * 3600 + minutes * 60 + seconds;
    }

    public Time(int ticks) => this.ticks = ticks;

    public static Time operator +(Time lhs, Time rhs)
        => new Time(lhs.ticks + rhs.ticks);

    public static Time operator +(Time lhs, int rhs)
        => new Time(lhs.ticks + rhs);

    public static bool operator ==(Time lhs, Time rhs)
        => lhs.ticks == rhs.ticks;

    public static bool operator !=(Time lhs, Time rhs)
        => !(lhs == rhs);

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Time other = (Time)obj;
        return this.ticks == other.ticks;
    }

    public override int GetHashCode()
    {
        return ticks.GetHashCode();
    }

    public override string ToString()
        => $"{Hours:d2}:{Minutes:d2}:{Seconds:d2}";
}

class Program
{
    static void Main(string[] args)
    {
        Time t1 = new Time(2, 15, 45);
        Time t2 = new Time(2, 35, 20);

        Time t3 = t1 + t2;
        Console.WriteLine($"t1 + t2 = {t3}");

        if (t1 == t2)
            Console.WriteLine("t1 is equal to t2");
        else
            Console.WriteLine("t1 is not equal to t2");

        Time t4 = t1 + 20;
        Console.WriteLine($"t1 + 20 seconds = {t4}");
    }
}
