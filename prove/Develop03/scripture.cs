using System.Diagnostics;

public class Scripture
{
    Random random = new Random();
    private List<Word> _scripWords = new List<Word>();
    private List<Word> _editedVerse = new List<Word>();
    private List<Word> _wordstoReplace = new List<Word>();
    private List<Word> _unchangedWords = new List<Word>();
    private Reference _fullreference;
    // private List<int> _intlist = new List<int>();
    private int _tries;
    public string GetEditedVerse()
    {
        string stringEdited = "";
        foreach (Word l in _editedVerse)
        {
            stringEdited += l.GetWord() + " ";
        }
        return stringEdited;
    }
    public void WordPicker(int k)
    {
        /* multiple ways to do this 1)keep replacing until all are blank and have a tester to see if all are blank can't specify how many times and may have a nonchanging iteration
        2) make a list and use replace many variables keep changing
        3) 
        */
        int num1 = _unchangedWords.Count() / _tries;
        int remainder = _unchangedWords.Count() - (num1 * _tries);
        List<int> intlist = new List<int>();
        for (int d = 0; d < _unchangedWords.Count(); d++)
        {
            if (_wordstoReplace.Contains(_unchangedWords[d]))
            {
            }
            else
            {
                intlist.Add(d);
            }
        }
        // if (remainder > 0)
        // {

        // }
        for (int i = 0; i < num1; i++)
        {
            //since words is actually one instance if I change one list that contains certain words I change another that contains the same components
            if (_wordstoReplace.Count() != _unchangedWords.Count())
            {
                int index = random.Next(0, intlist.Count());
                _wordstoReplace.Add(_unchangedWords[intlist[index]]);
                intlist.Remove(intlist[index]);
            }
        }
        if (k - remainder != 0 && _wordstoReplace.Count() != _unchangedWords.Count())
        {
            int index = random.Next(0, intlist.Count());
            _wordstoReplace.Add(_unchangedWords[intlist[index]]);
            intlist.Remove(intlist[index]);
        }
        

    }
    public bool IsntBlank()
    {
        if (_wordstoReplace.Count() == _unchangedWords.Count())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Replacer()
    {
        foreach (Word i in _wordstoReplace)
        {
            i.WordReplacer();
        }
        
        
    }
    public void DisplayScrip()
    {
        Console.Clear();
        string fullreference = _fullreference.GetReference();
        Console.Write(fullreference + " ");
        string stringVerse = GetEditedVerse();
        Console.WriteLine(stringVerse);
        // displaying unspaced scripture
    }
    public Scripture(Reference fullreference, List<Word> scripWords, int takes)
    {
        _fullreference = fullreference;
        _scripWords = scripWords;
        _editedVerse = scripWords;
        _unchangedWords = scripWords;
        _tries = takes;
    }
}