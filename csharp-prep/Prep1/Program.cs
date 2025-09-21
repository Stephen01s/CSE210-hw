using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string FirstN = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string LastN = Console.ReadLine();
        Console.WriteLine($"Your name is {LastN}, {FirstN} {LastN}.");
    }
}