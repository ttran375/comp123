using System;

class Account
{
    private double _balance;
    private static double INTEREST_RATE = 0.02;

    public static void SetInterestRate(double rate)
    {
        INTEREST_RATE = rate;
    }

    public Account(double balance)
    {
        _balance = balance;
    }

    public double Balance
    {
        get { return _balance * INTEREST_RATE; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account a1 = new Account(100);
        Account a2 = new Account(200);

        Console.WriteLine($"{a1.Balance:C}");     //$2.00
        Console.WriteLine($"{a2.Balance:C}");     //$4.00

        Account.SetInterestRate(0.025);		   //class member accessed via type
        Console.WriteLine($"{a1.Balance:C}");     //$2.50
        Console.WriteLine($"{a2.Balance:C}");     //$5.00
    }
}
