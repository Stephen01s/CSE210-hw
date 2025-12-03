public class Swim : Activity
{
    private double _laps;
    public override double Distance()
    {
        return _laps * 50 / 1000; 
    }
    public override double Speed()
    {
        return _laps * 50 / _length / 1000 * 60;
    }
    // public override double Pace()
    // {
    //     return _length / Distance();
        
    // }
    public override string Type()
    {
        return "Swimming";
    }
    public Swim(int length, int laps) : base(length)
    {
        _laps = laps;
    }
}