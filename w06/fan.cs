using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static w06.fan;

namespace w06
{
    internal class fan
    {
        public class FAN
        {
            private const int SLOW = 1;
            private const int MEDIUM = 2;
            private const int FAST = 3;

            private int speed;
            private bool on;
            private double radius;
            private string color;

            public FAN(int speed = SLOW, bool on = false, double radius = 5, string color = "blue")
            {
                this.Speed = speed;
                this.On = on;
                this.Radius = radius;
                this.Color = color;
            }

            public int Speed { get => speed; set => speed = value; }
            public bool On { get => on; set => on = value; }
            public double Radius { get => radius; set => radius = value; }
            public string Color { get => color; set => color = value; }

            public override string ToString()
            {
                if (on)
                {
                    return $"Speed: {speed}, Color: {color}, Radius: {radius} -> FAN is on";
                }
                else
                {
                    return $"Color: {color}, Radius: {radius} -> FAN is off";
                }
            }

            public int fast()
            {
                return FAST;
            }

            public int medium()
            {
                return MEDIUM;
            }
        }

        public static void Main()
        {
            FAN FAN1 = new FAN();
            FAN1.Speed = FAN1.fast();
            FAN1.Radius = 10;
            FAN1.Color = "yellow";
            FAN1.On = true;

            Console.WriteLine("FAN 1:\n " + FAN1.ToString());

            FAN FAN2 = new FAN();
            FAN2.Speed = FAN2.medium();
            FAN2.Radius = 5;
            FAN2.Color = "blue";
            FAN2.On = false;

            Console.WriteLine("FAN 2:\n " + FAN2.ToString());

            Console.ReadKey();
        }
    }
}
