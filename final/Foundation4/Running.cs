public class Running : Activity
{
    private double _distance;
    public override double Distance()
    {
        return _distance;
    }
    public override double Speed()
    {
        return _distance / _length * 60;
    }
    // public override double Pace()
    // {
    //     return _length / _distance;
    // }
    public override string Type()
    {
        return "Running";
    }
    public Running(int length, double distance) : base(length)
    {
        _distance = distance;
    }

    }