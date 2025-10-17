using System;
public class Fraction
{
    private int _top;
    private int _bottom;
    public void GetTop()
    {
        Console.WriteLine(_top);
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public void GetBottom()
    {
        Console.WriteLine(_bottom);
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetfractionString()
    {
        string fraction = _top + "/" + _bottom;
        return fraction;
    }
    public double GetDecimalValue()
    {
        double _topn = _top;
        double _bottomn = _bottom;

        double decimalnumber = _topn /  _bottomn;
        return decimalnumber;
    }

    public void Fractions()
    {
        _top = 1;
        _bottom = 1;
    }
    public void Fractions(int top)
    {
        _top = top;
    }
    public void Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

}