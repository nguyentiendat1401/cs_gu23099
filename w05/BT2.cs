using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w05
{
    internal class BT2
    {
        static void Main()
        {
            string str = "Hello";

            Console.Write("Nhap ki tu can dem: ");
            string kytu = Console.ReadLine(); 
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == kytu[0])
                {
                    count++;
                }
            }

            Console.WriteLine("so lan xuat hien ky tu '{0}' trong chuoi la: {1}", kytu, count);
        }
    }
}
