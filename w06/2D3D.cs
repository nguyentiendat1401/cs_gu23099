using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static w06._2D3D;

namespace w06
{
    internal class _2D3D
    {

        public class Point2D
        {

            private double x, y;

            public Point2D(double x = 0, double y = 0)
            {
                this.x = x;
                this.y = y;
            }

            public void SetXY(double x = 0, double y = 0)
            {
                this.x = x;
                this.y = y;
            }

            public List<double> GetXY()
            {
                List<double> result = new List<double>();
                result.Add(this.x);
                result.Add(this.y);

                return result;

            }

            public override string ToString()
            {
                return string.Format("{0}, {1}", x, y);
            }

            public double X { get => x; set => x = value; }
            public double Y { get => y; set => y = value; }
        }

        public class Point3D : Point2D
        {
            private double z;

            public Point3D(double x = 0, double y = 0, double z = 0) : base(x,y)
            {
                this.Z = z;
            }

            public double Z { get => z; set => z = value; }

            public void SetXYZ(double x = 0, double y = 0, double z = 0)
            {
                base.SetXY();
                this.Z = z;
            }

            public List<double> GetXYZ()
            {
                List<double> result = new List<double>();
                result = base.GetXY();
                result.Add(this.Z);

                return result;
            }

            public override string ToString()
            {
                return string.Format("{0}, {1}, {2}",X,Y,z);
            }
        }

        static void Main()
        {
            Point2D point2d = new Point2D(1, 5);
            Console.WriteLine(point2d.ToString());

            Point3D point3d = new Point3D(3, 7, 9);
            Console.WriteLine(point3d.ToString());

            
            Console.WriteLine(string.Join(" ",Point3D.GetXYZ()));

            Console.ReadKey();

        }

    }
}
