using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w06
{
    internal class HCN
    {
        public class Rectangle
        {
            private double height;
            private double width;

            public double Width { get => width; set => width = value; }
            public double Height { get => height; set => height = value; }

            public Rectangle(double width=1, double height=1)
            {
                this.Width = width;
                this.Height = height;
            }

            /*public Rectangle()
            {
            }

            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }*/

            public double GetArea()
            {
                return this.Width * this.Height;
            }

            public double GetPerimeter()
            {
                return (this.Width + this.Height) * 2;
            }

            public string Display()
            {
                return "Rectangle{" + "width=" + Width + ", height=" + Height + "}";
            }

        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the width:");
            double width = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            double height = Double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width, height);

            Console.WriteLine("Your Rectangle \n" + rectangle.Display());
            Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
            Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());
        }
    }


}

