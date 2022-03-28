using System;
using System.Collections.Generic;
using System.Text;

namespace ClassShape.Models
{
    public class CreationOfClassRectangle : CreationOfClassShape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public CreationOfClassRectangle(string name, string color, int[] position, int sideA, int sideB) : base(name, color, position)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public override void GetArea()
        {
            Console.WriteLine($"The area of the rectangle is: {SideA}*{SideB} = {SideA * SideB}.");
        }
    public override void GetPerimeter()
        {
            
            Console.WriteLine($"The perimeter of the rectangle is: 2*{SideA}+2*{SideB}={2*SideA + 2*SideB}.");
        }
    }
}
