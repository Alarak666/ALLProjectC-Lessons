using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, SumPob;
            m = n = SumPob = 0;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            int[,] array = new int[m, n];
            Random rnd = new Random();
            int sum = 0;
            ConsoleColor color = Console.ForegroundColor;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 10);
                    if (j > array.GetLength(0) - i - 1)
                    {
                        sum += array[i, j];
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(array[i, j] + " ");
                        Console.ForegroundColor = color;
                        continue;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"sum {sum}");
            Console.ReadKey();
        }
    }
}
