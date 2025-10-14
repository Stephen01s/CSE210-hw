using System.IO;
public class File
{
    public void SaveFile()
    {
        string filename = "myJournal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_journal);
        }
    }
    public List<> LoadFile()
    {
        string entries = System.IO.File.ReadAllLines("myJournal.txt");
        return entries;
    }
    // public List<> LoadPrompts()
    // {
    //     string prompts = System.IO.File.ReadAllLines("myPrompts.txt");
    //     return prompts;
    // }
    // Also add a loop in order to change prompts so they return individually instead of one block

}
