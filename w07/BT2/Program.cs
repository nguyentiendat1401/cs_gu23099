using System;

class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

class Program
{
    static void Main()
    {
        // Tạo một mảng các đối tượng hình học, trong đó có ít nhất một Square
        object[] shapes = new object[]
        {
            new Square(5.0),
            new Circle(3.0),
            // Các đối tượng hình học khác có thể được thêm vào mảng
        };

        // Hiển thị diện tích và gọi phương thức HowToColor() (nếu có) cho mỗi đối tượng
        foreach (var shape in shapes)
        {
            if (shape is Square)
            {
                Square square = (Square)shape;
                Console.WriteLine($"Square Area: {square.CalculateArea()}");
                if (shape is IColorable)
                {
                    ((IColorable)shape).HowToColor();
                }
            }
            else if (shape is Circle)
            {
                Circle circle = (Circle)shape;
                Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
                // Không gọi HowToColor() vì Circle không triển khai IColorable
            }
        }
    }
}