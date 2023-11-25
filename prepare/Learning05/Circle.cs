public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double shapeRadius) : base(color)
    {
        _radius = shapeRadius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}