using System.Drawing;

public class Shape
{
    public string _color;
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        double area = 1;
        return area;
        
    }
    public Shape(string color)
    {
        _color = color;
    }
}