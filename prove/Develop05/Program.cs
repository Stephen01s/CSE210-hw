using System;

class Program
{
    static void Main(string[] args)
    {
        
        string choice = "";
        int totalpoints = 0;
        List<Goal> goals = new List<Goal>();
        Console.WriteLine("welcome to the Goalmaking program type letter to enter activity");
        while (choice != "6")
        {
            Console.WriteLine($"Total Ponts: {totalpoints}");
            Console.WriteLine("1) Create new Goal");
            Console.WriteLine("2) List Goals");
            Console.WriteLine("3) Save Goals");
            Console.WriteLine("4) Load Goals");
            Console.WriteLine("5) Record Event");
            Console.WriteLine("6) quit");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("What type of goal is it?");
                Console.WriteLine("1) Simple goal");
                Console.WriteLine("2) eternal goal");
                Console.WriteLine("3) checklist goal");
                string choice2 = Console.ReadLine();
                if (choice2 == "1")
                {
                    Console.WriteLine("What is the name of the goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a small description of the goal?");
                    string desc = Console.ReadLine();
                    Console.WriteLine("How many points do you want associated with the goal?");
                    string pointS = Console.ReadLine();
                    int point = int.Parse(pointS);
                    Simple simple = new Simple(point, desc, name);
                    goals.Add(simple);
                }
                else if (choice2 == "2")
                {
                    Console.WriteLine("What is the name of the goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a small description of the goal?");
                    string desc = Console.ReadLine();
                    Console.WriteLine("How many points do you want associated with the goal?");
                    string pointS = Console.ReadLine();
                    int point = int.Parse(pointS);
                    Eternal eternal = new Eternal(point, desc, name);
                    goals.Add(eternal);
                }
                else if (choice2 == "3")
                {
                    Console.WriteLine("What is the name of the goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a small description of the goal?");
                    string desc = Console.ReadLine();
                    Console.WriteLine("How many points do you want associated with the goal?");
                    string pointS = Console.ReadLine();
                    int point = int.Parse(pointS);
                    Console.WriteLine("How many times do you want to complete this goal in order to recieve the bonus points?");
                    string bonusCompletions = Console.ReadLine();
                    int bonusTotal = int.Parse(bonusCompletions);
                    Console.WriteLine("How many points do you want the bonus to be?");
                    string bonusS = Console.ReadLine();
                    int bonusPoints = int.Parse(bonusS);
                    Checklist checklist = new Checklist(point, desc, name, bonusTotal, bonusPoints);
                    goals.Add(checklist);
                }
                else
                {
                    Console.WriteLine("That wasn't an option");
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("The Goals are:");
                foreach (Goal g in goals)
                {
                    string dis = g.DisplayGoal();
                    Console.WriteLine(dis);
                }
            }
            else if (choice == "3")
            {
                File file = new File(goals);
                file.Save();
            }
            else if (choice == "4")
            {
                File file = new File(goals);
                (goals, totalpoints) =file.Load();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Which goal did you accomplish? ");
                for(int i = 0; i < goals.Count(); i++)
                {
                    Console.Write($"{i + 1})");
                    Console.WriteLine(goals[i].DisplayGoal());
                }
                string indexS = Console.ReadLine();
                int index = int.Parse(indexS);
                totalpoints += goals[index - 1].RecordEvent();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("that wasn't an option");
            }
            
        }
    }
}