using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your Grade percentage? ");
        string GradeR = Console.ReadLine();
        int Grade = int.Parse(GradeR);
        string letter;
        if (Grade >= 90)
        {
            letter = "A";
        }
        else if (Grade >= 80)
        {
            letter = "B";
        }
        else if (Grade >= 70)
        {
            letter = "C";
        }
        else if (Grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is an {letter}");
        
        if (Grade >= 70)
        {
            Console.WriteLine("You are currently passing, Congrats!");
        }
        else
        {
            Console.WriteLine("You Dummy, Do better.");
        }
    }
}