using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w06
{
    internal class CircleAndCylinder
    {
        public class Circle
        {
            private double radius;
            private string color;

            public Circle(double radius = 1, string color = "green")
            {
                this.radius = radius;
                this.color = color;
            }

            public double Radius { get => radius; set => radius = value; }
            public string Color { get => color; set => color = value; }

            public override string ToString()
            {
                return string.Format("radius = {0}, color = {1}", Radius, color);
            }

        }

        public class Cylinder : Circle
        {
            private double height;

            public Cylinder(double radius = 1, string color = "green", double height = 2) : base (radius, color)
            {
                this.height = height;
            }  

            public double Height { get => height; set => height = value; }

            public double TheTich()
            {
                return height * (Math.PI * Radius * Radius);
            }

            public override string ToString()
            {
                return string.Format("radius = {0}, color = {1}, height = {2}", Radius, Color, height);
            }
        }

        static void Main()
        {
            Circle circle = new Circle(5, "Red");
            Console.WriteLine(circle);
            Cylinder cylinder = new Cylinder(6, "Yellow", 3);
            Console.WriteLine(cylinder);
            Console.Write("The tich la: {0}", cylinder.TheTich());

            Console.ReadKey();  
        }
    }
}
