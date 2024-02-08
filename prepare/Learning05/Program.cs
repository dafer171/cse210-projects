using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("red", 10);
        //s1.getArea();
        shapes.Add(s1);


        Rectangle s2 = new Rectangle("gren", 5, 5);
        //s2.getArea();
        shapes.Add(s2);

        Circle s3 = new Circle("black", 5);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.getColor();
            double area = s.getArea();
            Console.WriteLine($"The {color} shape has an area of:{area}");
        }

    }


}