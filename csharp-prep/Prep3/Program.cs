using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);
        int guess;
        string guessS;
        do
        {
            Console.WriteLine("What is your Guess?");
            guessS = Console.ReadLine();
            guess = int.Parse(guessS);
            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Correct, that was the magic number!");
            }
        } while (magic != guess);

    }
}