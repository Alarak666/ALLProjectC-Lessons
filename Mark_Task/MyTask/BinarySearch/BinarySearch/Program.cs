using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int[] a = new int[10];
            for (int c = 0; c < 10; c++)
            {
                a[c] = rd.Next(10,23);
                Console.Write(a[c] + " ");
            }
            Console.WriteLine();
            int b;
            int cpunt = 0;
            DateTime start = DateTime.Now;
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = j + 1; i < a.Length; i++)
                {
                    if (a[j] < a[i])
                    {
                        b = a[j];
                        a[j] = a[i];
                        a[i] = b;
                    }
                }
            }
            Console.WriteLine(cpunt+ " Repeat");
            DateTime end = DateTime.Now;
            Console.WriteLine((end-start).TotalMilliseconds);
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
           
            Console.ReadKey();
            for (int i = 0; i < 100; i++)
            {

            }
        }
    }
}
