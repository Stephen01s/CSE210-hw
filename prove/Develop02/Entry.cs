using System;
public class Entry
{
    public string _prompt;
    public string _entry;
    public string _time;
    public string CurrentTime()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
   
}