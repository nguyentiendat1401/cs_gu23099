using System;

// Interface Resizeable
public interface Resizeable
{
    void Resize(double percent);
}

// Lớp Circle
public class Circle : Resizeable
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void Resize(double percent)
    {
        Radius *= percent / 100;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Lớp Rectangle
public class Rectangle : Resizeable
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public void Resize(double percent)
    {
        Width *= percent / 100;
        Height *= percent / 100;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

// Lớp Square
public class Square : Resizeable
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    public void Resize(double percent)
    {
        Side *= percent / 100;
    }

    public double CalculateArea()
    {
        return Side * Side;
    }
}