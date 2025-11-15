using System.Net.NetworkInformation;

public class Circle : Shape
{
    private double _radius;
    public override double GetArea()
    {
        double area = 2 * _radius * 3.14;
        return area;
        
    }

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }
}