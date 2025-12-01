public class Activity
{
    private string _date;
    private int _length;

    public string Summary()
    {}
    public virtual double Distance()
    {}
    public virtual double Speed()
    {}
    public virtual double Pace()
    {}
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
}