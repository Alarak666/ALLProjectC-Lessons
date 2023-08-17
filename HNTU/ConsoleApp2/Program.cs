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
            int a, b, c;
            a = b = 2;
            // (a + b)^2
            Console.WriteLine($"{a*a + 2*a*b + b*b}");
            Console.WriteLine($"{Math.Pow((a + b),2)}");
            Console.ReadLine();
        }
    }
}
