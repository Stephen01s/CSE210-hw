
public class Prompt
{

    /*
    extra wrote prompt as a class
    */
    public string _prompt;
    public string RandomPromptDisplay()
    {
        Random randomGenerator = new Random();

        int promptInd = randomGenerator.Next(1, _promptList.Count);
        Console.WriteLine(_promptList[promptInd]);
        return _promptList[promptInd];
        
    }
    public List<String> _promptList = new List<String>();

}