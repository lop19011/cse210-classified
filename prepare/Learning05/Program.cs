using System;
using Learnning05;

namespace Learning05
{   
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square("Red", 5);
            Console.WriteLine($"Square color: {square.GetColor()}");
            Console.WriteLine($"Square area: {square.GetArea()}");
            Console.WriteLine();


            Rectangle rectangle = new Rectangle("Purple", 4, 10);
            Console.WriteLine($"Rectangle color: {rectangle.GetColor()}");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
            Console.WriteLine();


            Circle circle = new Circle("Blue", 7);
            Console.WriteLine($"Circle color: {circle.GetColor()}");
            Console.WriteLine($"Circle area: {circle.GetArea()}");
            Console.WriteLine();


            List<Shape> shapes = new List<Shape>();
            
            Square square1 = new Square("Red", 5);
            shapes.Add(square1);
            
            Rectangle rectangle1 = new Rectangle("Purple", 4, 10);
            shapes.Add(rectangle1);
            
            Circle circle1 = new Circle("Blue", 7);
            shapes.Add(circle1);

            foreach (Shape shape in shapes)
            {
                string color = shape.GetColor();
                double area = shape.GetArea();
                Console.WriteLine($"The {color} shape has an area of {area}");
              
            }
        }
    }

}