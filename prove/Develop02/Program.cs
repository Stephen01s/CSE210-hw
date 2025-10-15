using System;
class Program
{
    static void Main(string[] args)
    {
        string selection = "0";
        Journal myJournal = new Journal();
        
        // _entry.
        Prompt prompt1 = new Prompt();
        prompt1._promptList.Add("what was the strongest emotion you felt today?");
        prompt1._promptList.Add("Did you talk with someone new today?");
        prompt1._promptList.Add("What was the weather like?");
        prompt1._promptList.Add("Any teaching in class that stuck out to you?");
        prompt1._promptList.Add("In what ways did you see Gods hand in your life today?");

        do
        {
            Console.WriteLine("1 Write entry");
            Console.WriteLine("2 save file");
            Console.WriteLine("3 load file");
            Console.WriteLine("4 Display Journal");
            Console.WriteLine("5 quit");
            selection = Console.ReadLine();

            if (selection == "1")
            {
                Entry fullEntry = new Entry();
                string prompt = prompt1.RandomPromptDisplay();
                string entryText = Console.ReadLine();
                string time = fullEntry.CurrentTime();
                fullEntry._time = time;
                fullEntry._prompt = prompt;
                fullEntry._entry = entryText;
                myJournal._journal.Add(fullEntry);
            }
            else if (selection == "2")
            {
                myJournal.SaveFile();
            }
            else if (selection == "3")
            {
                myJournal = myJournal.LoadFile();
            }
            else if (selection == "4")
            {
                myJournal.DisplayJournal();
            }
            else if (selection == "5")
            {
                Console.WriteLine("program end");
            }
            // else if (selection = "6")
            // {
            //     Console.WriteLine("What is the prompt you want to add?");
            //     string _newprompt = Console.ReadLine();
            //     prompt1.Add(_newprompt)
            // }
            else
            {
                Console.WriteLine("type number correlating to desired action ex: 1 to write an entry");
            }
        } while (selection != "5");
    }
}