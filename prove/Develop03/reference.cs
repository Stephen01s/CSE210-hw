public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _reference;
    private string _endVerse;
    private List<String> _references = new List<String>();
    public string GetReference()
    {
        return _reference;
    }

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _reference = book + " " + chapter + ":" + verse;
    }
    public Reference(string book, string chapter, string startVerse,string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
        _reference = book + " " + chapter + ":" + startVerse + "-" + endVerse;
    }
}