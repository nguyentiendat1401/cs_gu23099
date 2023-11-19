using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        Resizeable[] shapes = new Resizeable[3];
        shapes[0] = new Circle(5);
        shapes[1] = new Rectangle(3, 4);
        shapes[2] = new Square(2);

        foreach (Resizeable shape in shapes)
        {
            double originalArea = CalculateArea(shape);
            double resizePercent = random.Next(1, 101);
            shape.Resize(resizePercent);
            double newArea = CalculateArea(shape);

            Console.WriteLine("Original area: " + originalArea);
            Console.WriteLine("Resized area: " + newArea);
            Console.WriteLine();
        }

        Console.ReadLine();
    }

    static double CalculateArea(Resizeable shape)
    {
        if (shape is Circle)
        {
            Circle circle = (Circle)shape;
            return circle.CalculateArea();
        }
        else if (shape is Rectangle)
        {
            Rectangle rectangle = (Rectangle)shape;
            return rectangle.CalculateArea();
        }
        else if (shape is Square)
        {
            Square square = (Square)shape;
            return square.CalculateArea();
        }
        else
        {
            throw new ArgumentException("Invalid shape type");
        }
    }
}