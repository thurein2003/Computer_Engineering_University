using System;

class ATM
{
    public static void Main(string[] args)
    {
        Console.Write("Enter withdraw amount: ");
        int amount = int.Parse(Console.ReadLine());

        Console.WriteLine("You need " + amount + " baht");

        int fiftyNotes = amount / 50;
        amount %= 50;

        int twentyNotes = amount / 20;
        amount %= 20;

        int tenCoins = amount / 10;

        Console.WriteLine("You get " + fiftyNotes + " fifty notes");
        Console.WriteLine("You get " + twentyNotes + " twenty notes");
        Console.WriteLine("You get " + tenCoins + " ten coins");
    }
}
