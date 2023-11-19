using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static w06.HinhHoc;

namespace w06
{
    internal class HinhHoc
    {
        public class SHAPE
        {
            private string color;
            private bool filled;

            public SHAPE(string color = "green", bool filled = true)
            {
                this.Color = color;
                this.Filled = filled;
            }

            public string Color { get => color; set => color = value; }
            public bool Filled { get => filled; set => filled = value; }

            public String GetColor()

            {

                return color;

            }

            public bool IsFilled()

            {

                return filled;

            }

            public override string ToString()
            {
                return "A shape with color of " + GetColor() + " and " + (IsFilled() ? "filled" : "not filled");
            }
        }

        public class CIRCLE : SHAPE
        {
            private double radius;

            public double Radius { get => radius; set => radius = value; }

            public CIRCLE(double radius = 1.0, string color = "green", bool filled = true) : base(color, filled)
            {
                this.Radius = radius;
            }

            public double GetRadius()

            {

                return Radius;

            }

            public double GetArea()

            {

                return Radius * Radius * Math.PI;

            }

            public double GetPerimeter()

            {

                return 2 * Radius * Math.PI;

            }

            public override String ToString()

            {
                return "A circle with radius = " + GetRadius()+  ",which is a subclass of " + base.ToString();

            }
        }

        public class RECTANGLE : SHAPE 
        {
            private double width;
            private double lenght;

            public RECTANGLE(double width = 1.0, double lenght = 1.0, string color = "green", bool filled = true) : base(color, filled)
            {
                this.Width = width;
                this.Lenght = lenght;
            }

            public  double Width { get => width; set => width = value; }
            public  double Lenght { get => lenght; set => lenght = value; }

            public double GetArea()

            {

                return width * this.lenght;

            }

            public double GetPerimeter()

            {

                return 2 * (width + this.lenght);

            }

            public double GetWidth()
            {
                return width;
            }

            public double GetLenght()
            {
                return lenght;
            }
            public override String ToString()
            {
                return "A Rectangle with width = " + GetWidth() + " and length = " + GetLenght() + ", which is a subclass of " + base.ToString();
            }
        }

        public class SQUARE : RECTANGLE
        {
            public SQUARE(double side) : base(side, side) { }
            public SQUARE(double side, string color = "green", bool filled = true) : base(side, side, color, filled) { }

            public double GetSide()

            {
                return GetWidth();
            }
            
            
            

            

        }




        static void Main()
        {
            SHAPE shape = new SHAPE();
            Console.WriteLine(shape);
            shape = new SHAPE("red", false);
            Console.WriteLine(shape);
            Console.WriteLine();

            CIRCLE circle = new CIRCLE();
            Console.WriteLine(circle);
            circle = new CIRCLE(3.5);
            Console.WriteLine(circle);
            circle = new CIRCLE(3.5, "indigo", false);
            Console.WriteLine(circle);
            Console.WriteLine();


            RECTANGLE rectangle = new RECTANGLE();
            Console.WriteLine(rectangle);
            rectangle = new RECTANGLE(2.3, 5.8);
            Console.WriteLine(rectangle);
            rectangle = new RECTANGLE(2.5, 3.8, "orange", true);
            Console.WriteLine(rectangle);
            Console.WriteLine();



            Console.ReadKey();
        }


    }
}
