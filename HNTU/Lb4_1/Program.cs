using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int M = 10, N = 10;
            int m = 0, n = 0, a = 10, b = 99;
            int[] arrayrandom = new int[0];
            Random random = new Random();
            do
            {
                n = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());
                if (n < N && m < M)
                    break;
            } while (true);
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
                    Console.Write(array[i,j] + " ");
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
