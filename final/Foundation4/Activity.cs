public abstract class Activity
{
    //questions asks for virtual asks for private
    private string _date;
    protected int _length; //length in minutes

    public void Summary()
    {
        Console.Write(_date + " ");
        Console.Write(Type()+ $" ({_length} mins):");
        Console.Write($"Distance {Distance()} km ");
        Console.Write($"Speed: {Speed()} km/h ");
        Console.WriteLine($"Pace: {Pace()} mins/km");

    }
    public abstract double Distance();
    public abstract double Speed();
    public virtual double Pace()
    {
        return _length / Distance();
    }
    public Activity(int length)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _date = dateText;
        _length = length;
    }
    public abstract string Type();
}