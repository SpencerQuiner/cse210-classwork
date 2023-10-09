public class Circle : Shape
{
    private double _radius;
    private double _pi = 3.1415926535;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public override double GetArea()
    {
        double area = _pi * Math.Pow(_radius, 2);
        return area;
    }
}