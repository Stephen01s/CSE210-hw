using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac = new Fraction();
        frac.SetTop(1);
        frac.SetBottom(1);
        string fracString = frac.GetfractionString();
        Console.WriteLine(fracString);
        double decimalValue = frac.GetDecimalValue();
        Console.WriteLine(decimalValue);

        frac.Fractions(5);

        fracString = frac.GetfractionString();
        Console.WriteLine(fracString);
        decimalValue = frac.GetDecimalValue();
        Console.WriteLine(decimalValue);

        frac.Fractions(2, 3);
        fracString = frac.GetfractionString();
        Console.WriteLine(fracString);
        decimalValue = frac.GetDecimalValue();
        Console.WriteLine(decimalValue);
    }
}