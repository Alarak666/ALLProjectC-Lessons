using System;

namespace propg
{
    class Program
    {
        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        class Person
        {
            public void V()
            {
            }
            static void Main()
            {
                Int32 x1 = 15;
                Int64 x2 = 155;
                x2 += x1;
                x1 += (int)x2;
                x2 = x1;
                int x = 23;
                float y = 12.9f;
                Console.WriteLine(x += (int)y);
                Console.WriteLine(Factorial(5));
                y += x;
            }
        }
    }
}