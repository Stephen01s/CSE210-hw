public class Activities
{
    private string _introMessage;
    private string _endMessage;
    private int _time;
    public void PrintIntro()
    {
        Console.WriteLine(_introMessage);
        Thread.Sleep(1000);
    }
    public void PrintEnd()
    {
        Console.WriteLine(_endMessage);
        Thread.Sleep(1000);
    }
    public void BreathTimer()
    {
        int time = _time / 21;
        for (int i = 0; i < time; i++)
        {
            Console.Clear();
            Console.WriteLine("Breathe in");
            Countdown(7);
            Console.Clear();
            Console.WriteLine("Hold breathe");
            Countdown(7);
            Console.Clear();
            Console.WriteLine("breathe out");
            Countdown(7);
        }
    }
    public void Checktime()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        DateTime currentTime = startTime;
        int k = 0;
        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.ReadLine();
            k += 1; 
        }
        Console.WriteLine($"you thought of {k} answers");
    }
    public void Countdown(int subtime)
    {
        //works for times less than 10 seconds
        for (int i = 0; i < subtime; i++)
        {

            Console.Write(subtime - i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
    public void Animator(int subtime)
    {
        for (int i = 0; i < subtime; i++)
        {
            //Animator takes 1 seconds
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
    public Activities(string intro, string end, int time)
    {
        _introMessage = intro;
        _endMessage = end;
        _time = time;
    }
}