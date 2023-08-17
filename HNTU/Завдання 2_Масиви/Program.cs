using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_2_Масиви
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int a, b, n, sum, zero;
                int* yx;
                zero = -1;
                a = b = n = sum = 0;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                if (a > b)
                    n = a;
                else
                    n = b;
                int[] array = new int[n];
                Random random = new Random();
                int* PArray = stackalloc int[n];
                yx = PArray;
                for (int i = 0; i < n; i++, yx++)
                {
                    *yx = random.Next(0, 10);
                    if (i % 2 == 0)
                    {
                        sum += *yx;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    yx--;
                }
                Console.WriteLine("Сумма парних елементiв - {0}", sum);
                for (int i = 0; i < n; i++)
                {
                    Console.Write(PArray[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 20));
                if (a > b)
                    n = b;
                else
                    n = a;
                sum = 0;
                for (int i = 0; i < n; i++, yx++)
                {
                    *yx = random.Next(0, 11);
                    if (*yx == 0)
                    {
                        zero = i;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    yx--;
                }
                if (zero != -1)
                {
                    for (int i = 0; i < zero; i++, yx++)
                    {
                        sum += *yx;
                    }
                }
                Console.WriteLine((sum != 0) ? $"Сумма елементiв мiж першим та останiм нульовим - {sum}" : "Вiдсутнi нулi!!!");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(PArray[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 20));
                Console.ReadLine();
            }
        }

    }
}
