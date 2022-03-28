using System;
using System.Collections.Generic;
using System.Text;

namespace ClassShape.Models
{
    public class CreationOfClassCircle:CreationOfClassShape
    {
        public int Radius { get; set; }
        public CreationOfClassCircle(string name, string color, int[] position, int radius) : base(name, color, position)
        {
            Radius = radius;
        }
        public override void GetArea()
        {
            Console.WriteLine($"The area of the circle with radius {Radius} is: {Math.Round((Radius * Radius * Math.PI),2)}.");
        }
        public override void GetPerimeter()
        {
            Console.WriteLine($"The perimeter of the circle with radius {Radius} is: {Math.Round((2 * Radius * Math.PI),2)}.");
        }
    }
}
