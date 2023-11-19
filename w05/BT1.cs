using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace w05
{
    internal class BT1
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int x;
            Console.Write("Nhap x la phan tu can xoa: ");
            x = int.Parse(Console.ReadLine());

            int index_del = Array.IndexOf(array, x);

            if (index_del != -1)
            {
                for (int i = index_del; i < array.Length - 1; i++)
                {
                    
                    array[i] = array[i + 1];
                }
                Array.Resize(ref array, array.Length - 1);
                Console.WriteLine("Mang sau khi xoa phan tu {0}:", x);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("phan tu {0} khong xuat hien trong mang", x);
            }




            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            int X;
            Console.Write("\nNhap x la phan tu can xoa: ");
            X = int.Parse(Console.ReadLine());

            int index_del2 = list.IndexOf(X);

            if (index_del2 != -1)
            {
                
                list.RemoveAt(index_del2);
                Console.WriteLine("Danh sach sau khi xoa phan tu {0}:", X);
                /*foreach (int item in list)
                {
                    Console.Write(item + " ");
                }*/

                Console.WriteLine(String.Join(" ", list));  
            }
            else
            {
                Console.WriteLine("Phan tu {0} khong xuat hien trong danh sach", X);
            }
        }

        
    }
}
