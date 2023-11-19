using System;

interface IColorable
{
    void HowToColor();
}

// Bước 2: Xây dựng interface IColorable với phương thức HowToColor()
// (Không cần thêm mã kiểm thử cho interface)

// Bước 3: Viết mã kiểm thử cho lớp Square
class Square : IColorable
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double CalculateArea()
    {
        return side * side;
    }

    // Bước 4: Xây dựng lớp Square triển khai interface IColorable
    public void HowToColor()
    {
        Console.WriteLine("Color all four sides.");
    }
}
