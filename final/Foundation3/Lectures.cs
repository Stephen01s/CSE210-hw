public class Lectures : Event
{
    private string _speaker;
    private int _capacity;
    public Lectures(string speaker, int capacity)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
}