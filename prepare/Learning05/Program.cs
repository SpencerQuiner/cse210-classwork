using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>() { new Square("blue", 3), new Rectangle("maroon", 5, 6), new Circle("green", 4.5) };

        foreach (Shape shape in _shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Color: {color} area: {area}");

        }
    }
}