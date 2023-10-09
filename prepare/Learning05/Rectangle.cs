public class Rectangle : Shape
{
    private double _width;
    private double _length;
    public Rectangle(string color, double width, double length) : base(color)
    {
        _width = width;
        _length = length;
    }
    public void SetLength(double length)
    {
        _length = length;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }
    public double GetWidth()
    {
        return _width;
    }
    public double GetLength()
    {
        return _length;
    }
    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }

}