using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = new int[] { };
            int a = 10;
            Random random = new Random();
            for (int i = 0; i < a; i++)
            {
                Array.Resize(ref b, a);
                b[i] = random.Next(1, 10);
            }
            for (int i = 0; i < a; i++)
            {
                if (i == a-1)
                {
                    Console.Write("{0};", b[i]);
                }
                else
                {
                    Console.Write("{0}, ", b[i]);
                }
            }
            Console.WriteLine();
            b = SquareOrSquareRoot(b);
            for (int i = 0; i < a; i++)
            {
                if (i == a - 1)
                {
                    Console.Write("{0};", b[i]);
                }
                else
                {
                    Console.Write("{0}, ", b[i]);
                }

            }

            Console.ReadKey();  
        }
        public static int[] SquareOrSquareRoot(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Sqrt(array[i]) % 1 == 0)
                {
                    array[i] = (int)Math.Sqrt(array[i]);
                }
                else
                {
                    array[i] = (int)Math.Pow(array[i],2);
                }
            }
            return array;
        }
    }
}
