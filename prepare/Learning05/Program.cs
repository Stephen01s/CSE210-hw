using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(3, "red");
        Console.WriteLine(square.GetArea());
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        Circle circle = new Circle(4, "blue");
        Rectangle rectangle = new Rectangle(4, 3, "green");
        shapes.Add(circle);
        shapes.Add(rectangle);
        foreach (Shape i in shapes)
        {
            Console.WriteLine(i.GetArea());
            Console.WriteLine(i.GetColor());
        }
    }
}