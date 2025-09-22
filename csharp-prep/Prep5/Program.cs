using System;
using System.Security.Cryptography;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Wlecome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your Name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        string favNumS = Console.ReadLine();
        int favNum = int.Parse(favNumS);
        return favNum;
    }
    static int PromptBirthday()
    {
        Console.WriteLine("What year is your birthday? ");
        string birthYearS = Console.ReadLine();
        int birthYear = int.Parse(birthYearS);
        return birthYear;
    }
    static int SquareNumber(int favNum)
    {
        int squared = favNum * favNum;
        return squared;
    }
    static void DisplayResults(string name, int birthYear, int squared)
    {
        int age = 2025 - birthYear;
        Console.WriteLine($"{name}, you will turn {age} this year");
        Console.WriteLine($"{name}, your favorite number squared is {squared}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int birthYear = PromptBirthday();
        int squared = SquareNumber(favNum);
        DisplayResults(name, birthYear, squared);
    }
}