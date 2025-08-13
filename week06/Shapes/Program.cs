using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Shapes project");
        Console.WriteLine("This is the Shapes project");

        Square square = new Square("Red", 5);
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Circle circle = new Circle("Green", 3);

        Console.WriteLine($"{square.GetColor()} Square Area: {square.GetArea()}");
        Console.WriteLine($"{rectangle.GetColor()} Rectangle Area: {rectangle.GetArea()}");
        Console.WriteLine($"{circle.GetColor()} Circle Area: {circle.GetArea()}");

        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        Console.WriteLine("\nIterating through shape list:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
