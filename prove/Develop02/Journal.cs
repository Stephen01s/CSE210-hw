
public class Journal
{
    public void DisplayJournal()
    {
        foreach (Entry _entry in _journal)
        {
            Console.WriteLine(_entry);
        }
    }
    public List<Journal> _journal = new List<Journal>();
}
