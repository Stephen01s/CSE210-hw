public class Receptions : Event
{
    private string _RSVP;
    public override string EventDetails()
    {
        return _RSVP + " to save your place at the Reception";
    }
    public override string EventName()
    {
        return "Reception";
    }
    public Receptions(string title, string desc, string date, string time, Address address, string RSVP) : base(title, desc, date, time, address)
    {
        _RSVP = RSVP;
    }
}