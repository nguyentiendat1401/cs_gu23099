using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace w04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TH4();
        }

        static void TH1()
        {
            int n = 5;
            int[] numbers = new int[5];

            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                numbers[i] = rd.Next(0,11);
            }

            
            Console.WriteLine(String.Join(" ", numbers));

            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            Console.WriteLine("Tong cac so la: " + total.ToString());

            List<int> lst = new List<int>();

            for (int i = 0; i < n; i++)
            {
                lst.Add(rd.Next(1,11));
            }

            Console.WriteLine(string.Join(" ", lst));
            Console.Write("Tong cac so la: "+ lst.Sum());
            

        }

        static void TH2()
        {
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };

            Console.WriteLine("Enter a name’s student:");
            string input_name = Console.ReadLine();

            bool isExist = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(input_name))
                {
                    Console.WriteLine("Position of the students in the list " + input_name + " is: " + (i + 1));
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                Console.WriteLine("Not found" + input_name + " in the list.");
            }
        }

        static void TH3()
        {
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                    Console.WriteLine("Size should not exceed 20");
            } while (size > 20);

            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Enter element" + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }

            Console.WriteLine("Property list: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }

            int max = array[0];
            int index = 1;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    max = array[j];
                    index = j + 1;
                }
            }
            Console.WriteLine("The largest property value in the list is " + max + " ,at position " + index);
        }

        static void BT1()
        {
            
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            
            int X = 10;

            
            int index = 2;

            // Nếu index <= 1 và index >= array.length – 1 thì hiển thị không chèn được phần tử vào mảng.
            if (index <= 1 || index >= array.Length - 1)
            {
                Console.WriteLine("Khong chen duoc phan tu");
            }
            else
            {
                //  chèn phần tử X ở vị trí index vào mảng
                int[] newArray = new int[array.Length + 1];
                for (int i = 0; i < index; i++)
                {
                    newArray[i] = array[i];
                }
                newArray[index] = X;
                for (int i = index + 1; i < newArray.Length; i++)
                {
                    newArray[i] = array[i - 1];
                }
                array = newArray;

                
                Console.WriteLine("In mang:");
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
            }
        }

        static void BT2()
        {
            int n, m;
            Console.WriteLine("Nhap so hang va so cot: ");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            int[,] array = new int[n, m]; 
            Random rd = new Random();
            
            for(int i = 0; i < n; i++)
            {
                for(int j=0; j < m; j++)
                {
                    array[i, j] = rd.Next(1,9);
                }
            }

            int max = -1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i,j]+" ");
                    if (array[i,j] > max) max = array[i,j];
                }
                Console.WriteLine("");
            }
            
            Console.WriteLine("Phan tu lon nhat la: {0}",max);
        }

        static void BT3()
        {
            int n, m;
            Console.WriteLine("Nhap so hang va so cot: ");
            n = int.Parse(Console.ReadLine()); 
            m = int.Parse(Console.ReadLine());

            int[, ] arr = new int[n, m];
            Random rd = new Random();

            for (int i = 0;i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    arr[i, j] = rd.Next(1, 9);
                }
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i,j]+ " ");
                    if (i == j) sum += arr[i, i];
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Tong duong cheo chinh la: " + sum);
        }

        static void TH4()
        {
            string[,] map = {
            {"*", ".", ".", "."},
            {".", ".", ".", "."},
            {".", "*", ".", "."},
            {".", ".", ".", "."}
        };
            int MAP_HEIGHT = map.GetLength(0);
            int MAP_WIDTH = map.GetLength(1);

            string[,] mapReport = new string[MAP_HEIGHT, MAP_WIDTH];
            for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
            {
                for (int xOrdinate = 0; xOrdinate < map.GetLength(0); xOrdinate++)
                {
                    string curentCell = map[yOrdinate, xOrdinate];
                    if (curentCell.Equals("*"))
                    {
                        mapReport[yOrdinate, xOrdinate] = "*";
                    }
                    else
                    {
                        int[,] NEIGHBOURS_ORDINATE = {
                        {yOrdinate - 1, xOrdinate - 1}, {yOrdinate - 1, xOrdinate}, {yOrdinate - 1, xOrdinate + 1},
                        {yOrdinate, xOrdinate - 1}, {yOrdinate, xOrdinate + 1},
                        {yOrdinate + 1, xOrdinate - 1}, {yOrdinate + 1, xOrdinate}, {yOrdinate + 1, xOrdinate + 1},};

                        int minesAround = 0;
                        int length = NEIGHBOURS_ORDINATE.GetLength(0);
                        for (int i = 0; i < length; i++)
                        {
                            int xOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 1];
                            int yOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 0];

                            bool isOutOfMapNeighbour = xOrdinateOfNeighbour < 0
                                    || xOrdinateOfNeighbour == MAP_WIDTH
                                    || yOrdinateOfNeighbour < 0
                                    || yOrdinateOfNeighbour == MAP_HEIGHT;
                            if (isOutOfMapNeighbour)
                            {
                                continue;
                            }

                            bool isMineOwnerNeighbour = map[yOrdinateOfNeighbour, xOrdinateOfNeighbour].Equals("*");
                            if (isMineOwnerNeighbour)
                            {
                                minesAround++;
                            }
                        }

                        mapReport[yOrdinate, xOrdinate] = minesAround.ToString();
                    }
                }
            }

            for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
            {
                Console.WriteLine("\n");
                for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
                {
                    String currentCellReport = mapReport[yOrdinate, xOrdinate];
                    Console.Write(currentCellReport);
                }
            }
            Console.ReadLine();
        }
    }
}
