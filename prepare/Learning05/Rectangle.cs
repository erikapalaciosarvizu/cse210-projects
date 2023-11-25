public class Rectangle : Shape // hereda de la clase base Shape.
{
    //variables privadas _length y _width para representar la longitud y el ancho del rectángulo.
    private double _length;
    private double _width;

    //constructor que acepta el color, la longitud y el ancho, y llama al constructor base con el color.
    public Rectangle(string color, double sideLength, double sideWidth) : base(color)
    {
        _length = sideLength;
        _width = sideWidth;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}