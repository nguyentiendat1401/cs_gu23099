using System;

public class Shape
{
    public string Color { get; set; }
    public bool Filled { get; set; }

    public Shape()
    {
        Color = "green";
        Filled = true;
    }

    public Shape(string color, bool filled)
    {
        Color = color;
        Filled = filled;
    }

    public override string ToString()
    {
        string filledStatus = Filled ? "filled" : "not filled";
        return $"A Shape with color of {Color} and {filledStatus}.";
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle()
    {
        Radius = 1.0;
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override string ToString()
    {
        return $"A Circle with radius={Radius}, which is a subclass of {base.ToString()}";
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Length { get; set; }

    public Rectangle()
    {
        Width = 1.0;
        Length = 1.0;
    }

    public Rectangle(double width, double length)
    {
        Width = width;
        Length = length;
    }

    public double GetArea()
    {
        return Width * Length;
    }

    public double GetPerimeter()
    {
        return 2 * (Width + Length);
    }

    public override string ToString()
    {
        return $"A Rectangle with width={Width} and length={Length}, which is a subclass of {base.ToString()}";
    }
}

public class Square : Rectangle
{
    public double Side
    {
        get { return Width; }
        set { Width = Length = value; }
    }

    public Square()
    {
        Side = 1.0;
    }

    public override string ToString()
    {
        return $"A Square with side={Side}, which is a subclass of {base.ToString()}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Shape shape = new Shape("red", false);
        Console.WriteLine(shape.ToString());

        Circle circle = new Circle(2.5);
        Console.WriteLine(circle.ToString());
        Console.WriteLine("Area: " + circle.GetArea());
        Console.WriteLine("Perimeter: " + circle.GetPerimeter());

        Rectangle rectangle = new Rectangle(3.0, 4.0);
        Console.WriteLine(rectangle.ToString());
        Console.WriteLine("Area: " + rectangle.GetArea());
        Console.WriteLine("Perimeter: " + rectangle.GetPerimeter());

        Square square = new Square();
        Console.WriteLine(square.ToString());
        Console.WriteLine("Area: " + square.GetArea());
        Console.WriteLine("Perimeter: " + square.GetPerimeter());

        square.Side = 5.0;
        Console.WriteLine(square.ToString());
        Console.WriteLine("Area: " + square.GetArea());
        Console.WriteLine("Perimeter: " + square.GetPerimeter());
    }
}