using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int m, n; m = n = 0;
            int a, b; a = 10; b = 99;
            string nm = "";
            int[] arrayrandom = new int[0];
            Random random = new Random();
                n = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            Array.Resize(ref arrayrandom, n * m);
            Console.WriteLine("\nОдномiрний масив");
            for (int i = 0; i < arrayrandom.Length; i++)
            {
                Console.Write((arrayrandom[i] = random.Next(a, b)) + " ");
            }
            Console.Write($"\n\nМатриця {n} x {m}");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(a, b);
                    Console.Write(array[i, j] + " ");
                }
            }
            Console.Write("\n\nЗмiнюємо елементи матрицi, на елементи iз одномiрного масиву");
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++, k++)
                {
                    array[i, j] = arrayrandom[k];
                    Console.Write(array[i, j] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
