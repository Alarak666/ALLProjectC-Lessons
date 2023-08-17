using System;
using System.Threading;

namespace Task_gal
{
    class Program
    {
        class Calc
        {
            public int a, b, sum;
            public int Sum (int a, int b)
            {
                sum = a + b;
                return sum;
            }
            public int Invoke(int a, int b)
            {
                sum = Sum(a, b);
                return sum;
            }
            public IAsyncResult asyncResult()
        }

        static void Main(string[] args)
        {
            
        }
    }
}
