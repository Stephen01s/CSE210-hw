public class Word
{
    private string _word;
    // private string _punctuation;
    public string GetWord()
    {
        return _word;
    }
    public void WordReplacer()
    {
        int letters;
        letters = _word.Count();
        _word = "";
        for (int i = 0; i < letters; i++)
        {
            _word += "_";
        }
        // _word += _punctuation;


    }
    public Word(string word, char punctuation)
    {
        _word = word;
    }
    public Word(string word)
    {
        _word = word;
    }
}