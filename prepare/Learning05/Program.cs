using System;

class Program
{
    static void Main(string[] args)
    {
       List<Shape> shapes = new List<Shape>();

       Square sq1 = new Square("blue", 4); 
       shapes.Add(sq1);

       Rectangle rt1 = new Rectangle("green", 5, 2);
       shapes.Add(rt1);

       Circle cr1 = new Circle("pink", 3);
       shapes.Add(cr1);

       foreach (Shape shape in shapes)
       {
        string color = shape.GetColor();

        double  area  = shape.GetArea();
        
        Console.WriteLine($"The {color} shape has an area of {area}.");
       }
    }
}