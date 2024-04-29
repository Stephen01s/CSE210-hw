using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade percentage? ");
        string Grade_P = Console.ReadLine();
        int Grade = int.Parse(Grade_P);
        string Letter = "";
        if (Grade >= 90)
        {
            Letter = "A";
        }
        else if (Grade >= 80)
        {
            Letter = "B";
        }
        else if (Grade >= 70)
        {
            Letter = "C";
        }
        else if (Grade >= 60)
        {
            Letter = "D";
        
        }
        else
        {
            Letter = "F";
            
        }

        if (Grade >= 70)
        {
            Console.WriteLine("Congrats you pass! ");
        }
        else 
        {
            Console.WriteLine("You failed");
        }
    }
}