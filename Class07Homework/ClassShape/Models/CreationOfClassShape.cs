using System;
namespace ClassShape.Models
{
    public class CreationOfClassShape
    {
        public string Name { get; set; }
        public string get()
        {
            return Name;
        }
        public void set(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new Exception("Name must not be empty");
            }
            else { Name = value; }
        }
    
    public string Color { get; set; }   
    public int[] Position { get; set; }

    public CreationOfClassShape(string name, string color, int[] position)
        {
            if (String.IsNullOrEmpty(name))
            {
            throw new Exception("Name must not be empty!");
            }
            if (String.IsNullOrEmpty(color))
            {
                throw new Exception("Color must not be empty!");
            }
            Name = name;
            Color = color;
            Position = position;
        }
        public virtual void GetArea()
        {
            Console.WriteLine("There is no special implementation for area.");
        }
        public virtual void GetPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter.");
        }
        public static CreationOfClassShape Move(CreationOfClassShape shape)
        {
            shape.Position = new int[2] { shape.Position[0] + 5, shape.Position[1] + 5 };

            return shape;
        }
        
    }
}
