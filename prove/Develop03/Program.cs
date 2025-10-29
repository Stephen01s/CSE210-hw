using System;

class Program
{
    static void Main(string[] args)
    {
        string scriptureString = "Proverbs 3:5-6 5 Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths.";
        string[] scripturelist = scriptureString.Split(" ");

        
        string book = scripturelist[0];
        string[] chapVerse = scripturelist[1].Split(":");
        string chapter = chapVerse[0];
        bool contain = chapVerse[1].Contains('-');
        Reference ref1;
        if (contain)
        {
            string[] verse = chapVerse[1].Split("-");
            string startVerse = verse[0];
            string endVerse = verse[1];
            ref1 = new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            string startVerse = chapVerse[1];
            ref1 = new Reference(book, chapter, startVerse);
        }
        scripturelist = scripturelist[2..];

        List<Word> scripWords = new List<Word>();
        foreach (string i in scripturelist)
        {
            Word word = new Word(i);
            scripWords.Add(word);
        }
        int takes = 3;
        //choice to change take
        Scripture fullscripture = new Scripture(ref1, scripWords, takes);
        List<Word> replacelist = new List<Word>();
        List<Word> editedScripture = new List<Word>();
        string choice = "";
        int k=1;
        while (choice != "quit")
        {
            fullscripture.DisplayScrip();
            if (fullscripture.IsntBlank())
            {
                break;
            }
            fullscripture.WordPicker(k);
            k++;
            fullscripture.Replacer();
            Console.WriteLine("press enter to blank out words or type 'quit' to exit");
            choice = Console.ReadLine();
        } 
    }
}