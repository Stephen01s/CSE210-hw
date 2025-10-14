using System;
class Program
{
    static void Main(string[] args)
    {
        string selection = "0";
        Journal _journal = new Journal();
        File _file = new File();
        Entry _entry = new Entry();
        Prompt _prompts = new Prompt();
        _prompts.Add("Did you talk with someone new today?");
        _prompts.Add("What was the weather like?");
        _prompts.Add("Any teaching in class that stuck out to you?");
        _prompts.Add("In what ways did you see Gods hand in your life today?");

        do
        {
            Console.WriteLine("1 Write entry");
            Console.WriteLine("2 save file");
            Console.WriteLine("3 load file");
            Console.WriteLine("4 Display Journal");
            Console.WriteLine("5 quit");
            // Console.WriteLine("6 add entry prompt");
            selection = Console.ReadLine();

            if (selection = "1")
            {
                Prompt.RandomPromptDisplay(_prompts);
                _entry = Console.ReadLine();
                string time = Entry.GetTime();
                _journal.Add(time);
                _journal.Add(_entry);
            }
            else if (selection = "2")
            {
                _file.SaveFile();
            }
            else if (selection = "3")
            {
                _entry = _file.LoadFile();
                _prompts = _file.Loadprompts();
            }
            else if (selection = "4")
            {
                _journal.DisplayJournal();
            }
            else if (selection = "5")
            {
                Console.WriteLine("program end");
            }
            // else if (selection = "6")
            // {
            //     Console.WriteLine("What is the prompt you want to add?");
            //     string _newprompt = Console.ReadLine();
            //     _prompts.Add(_newprompt)
            // }
            else
            {
                Console.WriteLine("type number correlating to desired action ex: 1 to write an entry");
            }
        } while (selection != "5");
    }
}

/*questions
underscore is inside of class or references
Add
selection error
what should I deem worthy to put in a class
*/