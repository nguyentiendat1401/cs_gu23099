using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w06
{
    internal class stopwatch
    {
        class Timer
        {
            private DateTime startTime;
            private DateTime endTime;

            public DateTime StartTime
            {
                get { return startTime; }
            }

            public DateTime EndTime
            {
                get { return endTime; }
            }

            public Timer()
            {
                startTime = DateTime.Now;
            }

            public void Start()
            {
                startTime = DateTime.Now;
            }

            public void Stop()
            {
                endTime = DateTime.Now;
            }

            public double GetElapsedTime()
            {
                TimeSpan elapsedTime = endTime - startTime;
                return elapsedTime.TotalMilliseconds;
            }
        }

        static void Main()
        {
            
            int[] numbers = new int[];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1,1000);
            }

            //Timer: do thoi gian thuc thi sap xep
            Timer timer = new Timer();
            SelectionSort(numbers);
            timer.Stop();

            Console.WriteLine("thoi gian thuc thi: " + timer.GetElapsedTime() + " giay");
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
