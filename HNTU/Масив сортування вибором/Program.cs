using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Масив_сортування_вибором
{
    class Program
    {
        public static Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Час бульбашки - {0}, Час вставки{1}", SortBubble(M).Elapsed.TotalMilliseconds, SortInput(M).Elapsed.TotalMilliseconds);
            Console.ReadKey();
        }
        static Stopwatch SortInput(int n)
        {
            int max, temp;
            int[] array = new int[n];
            Console.WriteLine("Початковый масив - Сортування вставкой");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.Write(array[i] + " ");
            }
            myStopwatch.Start();
            for (int i = 0; i < array.Length - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[max])
                        max = j;
                }
                temp = array[i];
                array[i] = array[max];  //swap 
                array[max] = temp;
            }
            myStopwatch.Stop();
            Console.WriteLine();
            Console.WriteLine("Финальный масив");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            return myStopwatch;
        }
        static Stopwatch SortBubble(int n)
        {
            int temp;
            int[] array = new int[n];
            Console.WriteLine("Початковый масив - Сортування Бульбашкой");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.Write(array[i] + " ");
            }
            myStopwatch.Start();
            for (int i = 0; i < array.Length ; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];  
                        array[j] = temp;
                    }
                }
                
            }
            myStopwatch.Stop();
            Console.WriteLine();
            Console.WriteLine("Финальный масив");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            return myStopwatch;
        }
    }
}
