using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2_w02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int usd;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập số tiền USD: ");
            usd = int.Parse(Console.ReadLine());
            Console.WriteLine("Số tiền VND là: " + usd * 23000);
        }
    }
}
