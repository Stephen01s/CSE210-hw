using System.IO;
public class Journal
{
    public List<Entry> _journal = new List<Entry>();
    public void DisplayJournal()
    {
        foreach (Entry nonstriEntry in _journal)
        {
            Console.WriteLine(nonstriEntry._time);
            Console.WriteLine(nonstriEntry._prompt);
            Console.WriteLine(nonstriEntry._entry);
        }
    }
    public void SaveFile()
    {
        string filename = "myJournal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _journal)
            {
                outputFile.Write(entry._time + "~");
                outputFile.Write(entry._prompt + "~");
                outputFile.WriteLine(entry._entry);
            }
        }
        Console.WriteLine("Save complete");
    }
    public Journal LoadFile()
    {
        string filename = "myJournal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        Journal journalTest = new Journal();
        foreach (string line in lines)
        {
            Entry fullEntry = new Entry();
            string[] parts = line.Split("~");
            string time = parts[0];
            string prompt = parts[1];
            string entry = parts[2];
            fullEntry._time = time;
            fullEntry._prompt = prompt;
            fullEntry._entry = entry;
            journalTest._journal.Add(fullEntry);
        }
        Console.WriteLine("load complete");
        return journalTest;
        
    }
}
