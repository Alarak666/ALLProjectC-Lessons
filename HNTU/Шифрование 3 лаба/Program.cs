using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double increment, b, c, a, encryption;
            increment = b = c = a = encryption = 0;
            double[] list_encryption = new double[10] { 6, 7, 8, 9, 0, 5, 4, 2, 3, 1 };
            double[] list_Dencryption = new double[10];
            b = 10;
            c = 10;
            // a = int.Parse(Console.ReadLine());
            for (int k = 0; k < b; k++)
            {
                Console.WriteLine();
                for (int q = 0; q < c; q++)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        encryption += (k * i + 2 * Math.Pow((q - i), i));
                    }
                    list_Dencryption[q] = encryption % 10;
                    foreach (var item in list_Dencryption)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
        //encryption
        static double fact(double i)
        {
            int sum = 1;
            if (i == 0)
                return sum;
            for (int j = 1; j <= i; j++)
            {
                sum = sum * j;
            }
            return sum;
        }
    }
}

