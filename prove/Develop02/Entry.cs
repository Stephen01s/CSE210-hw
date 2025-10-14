using System;
public class Entry
{
    public string _entry;
    public string GetTIme();
    {
        DateTime theCurrentTime = DateTime.Now;
        return string dateText = theCurrentTime.ToShortDateString();
    }
}