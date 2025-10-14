
public class Prompt
{

    /*prompt list
    Did you talk with someone new today?
    What was the weather like?
    Any teaching in class that stuck out to you?
    In what ways did you see Gods hand in your life today?
    */
    public void RandomPromptDisplay(_prompt)
    {
        Random randomGenerator = new Random();

        int promptInd = randomGenerator.Next(1, _prompt.Count + 1);
        Console.WriteLine(_prompt[promptInd]);
        
    }
    public List<CreatePrompt> _prompt = new List<CreatePrompt>();

}