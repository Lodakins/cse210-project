using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");


        Shape shape = new Square("Red",5);
        Console.WriteLine($"Shape: Square, Color: {shape.GetColor()} ,  Area: {shape.GetArea()}");

        Shape rect = new Rectangle("Green",5,6);
        Console.WriteLine($"Shape: Rectangle, Color: {rect.GetColor()} ,  Area: {rect.GetArea()}");

        Shape circle = new Circle("Yelow",5);
        Console.WriteLine($"Shape: Circle, Color: {circle.GetColor()} ,  Area: {circle.GetArea()}");
    }
}