public class Lectures : Event
{
    private string _speaker;
    private int _capacity;
    public Lectures(string title, string desc, string date, string time, Address address, string speaker, int capacity) : base( title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string EventDetails()
    {
        return "Lecture by " + _speaker + " capacity of: " + _capacity;
    }
    public override string EventName()
    {
        return "Lecture";
    }
}