using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            string intro;
            string end = "the duration you have spent on this activity in seconds is:";
            Console.WriteLine("welcome to the mindfulness program type letter to enter activity");
            Console.WriteLine("1) Breathing activity");
            Console.WriteLine("2) Reflection activity");
            Console.WriteLine("3) Listening activity");
            Console.WriteLine("4) quit");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("How many sessions do you want to do of this activity?");
                string sTime = Console.ReadLine();
                int time = int.Parse(sTime);
                time = time * 21;
                end = end + " " + time;
                intro = "welcome to the breathing activity! This activity helps you breathe in a controled manner. press enter to start";
                Breathing breath = new Breathing(intro, end, time);
                breath.PrintIntro();
                Console.ReadLine();
                breath.BreathTimer();
                breath.PrintEnd();

            }
            else if (choice == "2")
            {
                Console.WriteLine("How many sessions do you want to do of this activity?");
                string sTime = Console.ReadLine();
                int time = int.Parse(sTime);
                time = time * 10;
                end = end + " " + time;
                intro = "welcome to the reflection activity! this activity helps you reflect and recognize times when you showed strength or resiliance.";
                

                List<string> promptL = new List<string>();
                promptL.Add("Think of a time when you stood up for someone else.");
                promptL.Add("Think of a time when you did something really difficult.");
                promptL.Add("Think of a time when you helped someone in need.");
                promptL.Add("Think of a time when you did something truly selfless.)");
                List<string> reflectQ = new List<string>();
                reflectQ.Add("Why was this experience meaningful to you?");
                reflectQ.Add("Have you ever done anything like this before?");
                reflectQ.Add("How did you get started?");
                reflectQ.Add("How did you feel when it was complete?");
                reflectQ.Add("What made this time different than other times when you were not as successful?");
                reflectQ.Add("What is your favorite thing about this experience?");
                reflectQ.Add("What could you learn from this experience that applies to other situations?");
                reflectQ.Add("What did you learn about yourself through this experience?");
                reflectQ.Add("How can you keep this experience in mind in the future?");
                Reflection reflect = new Reflection(promptL, reflectQ, intro, end, time);
                reflect.PrintIntro();
                Console.WriteLine(reflect.RandomPrompt());
                Console.WriteLine("press enter to start");
                Console.ReadLine();
                reflect.ReflectionTimer();
                reflect.PrintEnd();

            }
            else if (choice == "3")
            {
                Console.WriteLine("How long do you want to do this activity in seconds?");
                string sTime = Console.ReadLine();
                int time = int.Parse(sTime);
                end = end + " " + time;
                intro = "Welcome to the Listening activity! this activity helps you think of positive aspects of your life.";
                List<string> promptL = new List<string>();
                promptL.Add("Who are people that you appreciate?");
                promptL.Add("What are personal strengths of yours?");
                promptL.Add("Who are people that you have helped this week?");
                promptL.Add("When have you felt the Holy Ghost this month?");
                promptL.Add("Who are some of your personal heroes?");

                Listening listen = new Listening(promptL, intro, end, time);
                listen.PrintIntro();
                listen.RandomPrompt();
                Console.WriteLine("press enter to begin");
                Console.ReadLine();
                listen.Checktime();

            }
            else if (choice == "4")
            {
                
            }
            else
            {
                Console.WriteLine("that wasn't an option. ex type 3 to enter listening activity");
            }
        }
    }
}