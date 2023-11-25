using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapesList = new List<Shape>(); //se crea una lista llamada shapesList que contiene objetos de la clase Shape.
                                                    // Crear instancias de las clases Square, Rectangle y Circle, y se agregan a la lista shapesList.
        Square Shape1 = new Square("Purple", 4);
        shapesList.Add(Shape1);

        Rectangle Shape2 = new Rectangle("Yellow", 5, 4);
        shapesList.Add(Shape2);

        Circle Shape3 = new Circle("Red", 6);
        shapesList.Add(Shape3);

        //call the GetColor() and GetArea() methods and make sure they return the values you expect.
        foreach (Shape s in shapesList)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}