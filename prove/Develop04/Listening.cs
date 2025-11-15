public class Listening : Activities
{
    private List<string> _inputs = new List<string>();
    private List<string> _prompts = new List<string>();
    public void RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count());
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
    }
    public void Display()
    { }
    public Listening(List<string> prompt, string intro, string end, int time) : base(intro, end, time)
    {
        _prompts = prompt;
    }

}