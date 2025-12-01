public class Receptions : Event
{
    private int _attendees;
    public void RSVP()
    {
        Console.WriteLine("How many of your party are attending?");
        string at = Console.ReadLine();
        _attendees += int.Parse(at);
    }
}