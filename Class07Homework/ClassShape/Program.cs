using System;
using ClassShape.Models;

namespace ClassShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** SHAPE *****");
            CreationOfClassShape anyShape = new CreationOfClassShape("someShape", "red", new int[] { 1, 3 });
            Console.WriteLine($"The name of my shape is {anyShape.Name}.");
            Console.WriteLine($"My shape has {anyShape.Color} color.");
            Console.WriteLine($"My shape has the following coordinates: {anyShape.Position[0]} for x and {anyShape.Position[1]} for y.");
            anyShape.GetArea();
            anyShape.GetPerimeter();
            CreationOfClassShape.Move(anyShape);
            Console.WriteLine($"My shape has new coordinates: {anyShape.Position[0]} for x and {anyShape.Position[1]} for y.");

            Console.WriteLine("***** RECTANLGE *****");
            CreationOfClassRectangle anyRectangle = new CreationOfClassRectangle("someRectangle", "white", new int[] { 5, 9 }, 4, 5);
            Console.WriteLine($"The name of my rectangle is {anyRectangle.Name}.");
            Console.WriteLine($"My rectangle has {anyRectangle.Color} color.");
            Console.WriteLine($"My rectangle has the following coordinates: {anyRectangle.Position[0]} for x and {anyRectangle.Position[1]} for y.");
            anyRectangle.GetArea();
            anyRectangle.GetPerimeter();
            CreationOfClassShape.Move(anyRectangle);
            Console.WriteLine($"My rectangle has new coordinates: {anyRectangle.Position[0]} for x and {anyRectangle.Position[1]} for y.");

            Console.WriteLine("***** CIRCLE *****");
            CreationOfClassCircle anyCircle = new CreationOfClassCircle("someCircle", "pink", new int[] { 4, 7 }, 5);
            Console.WriteLine($"The name of my circle is {anyCircle.Name}.");
            Console.WriteLine($"My circle has {anyCircle.Color} color.");
            Console.WriteLine($"My circle has the following coordinates: {anyCircle.Position[0]} for x and {anyCircle.Position[1]} for y.");
            anyCircle.GetArea();
            anyCircle.GetPerimeter();
            CreationOfClassShape.Move(anyCircle);
            Console.WriteLine($"My circle has new coordinates: {anyCircle.Position[0]} for x and {anyCircle.Position[1]} for y.");
        }
        
    }
}

