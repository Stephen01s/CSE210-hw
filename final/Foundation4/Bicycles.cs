public class Bicicles : Activity
{
    private double _speed;
    public override double Distance()
    {
        return _speed * _length / 60;
    }
    public override double Speed()
    {
        return _speed;
    }
    public override double Pace()
    {
        return 60 / _speed;
    }
    public override string Type()
    {
        return "Cycling";
    }
    public Bicicles(int length, double speed) : base(length)
    {
        _speed = speed;
    }
}