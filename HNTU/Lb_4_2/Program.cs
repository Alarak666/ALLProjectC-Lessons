using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int M = 999, N = 999;
            int m = 0, n = 0, a = 0, b = 10;
            int[] arraymax = new int[0];
            Random random = new Random();
            do
            {
                n = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());
                if (n < N && m < M)
                    break;
            } while (true);
            int[,] array = new int[n, m];
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
            Console.Write("\n\nЗнаходимо рядки без нулiв, та максимальне число в рядку");
            int max = 0;
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                max = array[i, 0];
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] == 0)
                        break;
                    if (max < array[i, j])
                        max = array[i, j];
                    if (j == m - 1)
                    {
                        Array.Resize(ref arraymax, arraymax.Length + 1);
                        arraymax[k] = max;
                        k++;
                    }
                }
            }
            Console.Write($"\nМасив максимальних елементiв\n");
            for (int i = 0; i < arraymax.Length; i++)
            {
                Console.Write(arraymax[i] + " ");
            }
            Console.Write($"\nБез нулiв -" + k);
            Console.ReadLine();
        }
    }
}
