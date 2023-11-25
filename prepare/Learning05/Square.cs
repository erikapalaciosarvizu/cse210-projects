public class Square : Shape //this class inherits from the base class.
{
    private double _side; //Create the _side attribute as a private member variable. --- Se declara una variable privada _side para representar el lado del cuadrado.


    //Create a constructor that accepts the color and the side, and then call the base constructor with the color.
    public Square(string color, double sideFigure) : base(color)
    {
        _side = sideFigure;
    }

    //Override the GetArea() method from the base class and fill in the body of this function to return the area.
    //Se utiliza la palabra clave override para anular el método GetArea() de la clase base y se implementa para calcular el área del cuadrado.
    public override double GetArea()
    {
        return _side * _side;
    }
}