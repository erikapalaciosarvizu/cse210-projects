using System.Drawing;

public abstract class Shape // esta clase sirve como clase base para las formas.
{
    private string _color; // para representar el color de la forma.

    //Constructor que acepta el color y lo asigna a _color:
    public Shape(string asignaColor)
    {
        _color = asignaColor;
    }

    //Métodos para obtener y establecer el color.
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string colorSet)
    {
        _color = colorSet;
    }

    //método abstracto GetArea() que debe ser implementado por las clases derivadas.
    public abstract double GetArea();
}