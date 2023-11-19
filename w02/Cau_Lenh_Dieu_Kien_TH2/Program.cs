using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_Lenh_Dieu_Kien_TH2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height;
            double weight;

            Console.Write("nhap chieu cao: ");
            height = double.Parse(Console.ReadLine());

            Console.Write("nhap can nang: ");
            weight = double.Parse(Console.ReadLine());

            double BMI = weight / height;
            
            if (BMI < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if(BMI < 25.0)
            {
                Console.WriteLine("Normal");
            }   
            else if(BMI < 30.0)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }

        }
    }
}
