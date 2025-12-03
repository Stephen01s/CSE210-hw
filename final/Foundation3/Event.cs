public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    public void StandardDetails()
    {
        Console.WriteLine("Event:" + _title);
        Console.WriteLine(_description);
        Console.Write("Date and time: " + _date + " at ");
        Console.WriteLine(_time);
        Console.WriteLine("Located at: " + _address.DisplayAddress());
        
    }
    public void FullDisplay()
    {
        StandardDetails();
        Console.WriteLine(EventDetails());

    }
    public void ShortDisplay()
    {
        Console.Write(EventName() + ": ");
        Console.WriteLine(_title);
        Console.WriteLine("Date: " + _date);

    }
    public abstract string EventDetails();
    public abstract string EventName();
    public Event(string title, string desc, string date, string time, Address address)
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
        _address = address;
    }
}