using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w06
{
    internal class Animal
    {
        public abstract class AniMal
        {
            protected string Weight { get; set; }
            protected string Height { get; set; }

            public AniMal(string weight, string height)
            {
                this.Weight = weight;
                this.Height = height;
            }
            public abstract void PrintInfo();
        }

        class Cat : AniMal
        {
            public string Name { get; set; }
            public Cat(string weight, string height, string name)
            : base(weight, height)
            {
                this.Name = name;
            }

            public override void PrintInfo()
            {
                Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.Weight, this.Height, this.Name);
            }
        }

        static void Main(string[] args)
        {
            Cat cat = new Cat("20kg", "1.5", "kitty");
            cat.PrintInfo();

            Console.ReadKey();
        }

    }
}
