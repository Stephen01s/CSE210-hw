public class Reflection : Activities
{
    Random random = new Random();
    private List<string> _prompt = new List<string>();
    private List<string> _reflectionQ = new List<string>();
    private int _time;
    public void ReflectionTimer()
    {
        int time = _time / 10;
        for (int i = 0; i < time; i++)
        {
            RandomQuestion();
            Animator(10);
        }
    }
    public string RandomPrompt()
    {
        int index = random.Next(0, _prompt.Count());
        string prompt = _prompt[index];
        return prompt;
    }
    private void RandomQuestion()
    {
        int index = random.Next(0, _reflectionQ.Count());
        string Question = _reflectionQ[index];
        Console.WriteLine(Question);
    }
    public Reflection(List<string> prompt, List<string> reflect, string intro, string end, int time) : base(intro, end, time)
    {
        _prompt = prompt;
        _reflectionQ = reflect;
        _time = time;
    }
}