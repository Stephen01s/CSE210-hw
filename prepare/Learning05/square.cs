using System.Security.Cryptography.X509Certificates;

public class Square : Shape
{
    private double _side;

    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
    public Square(double side, string color) : base(color)
    {
        _side = side;
    }
}