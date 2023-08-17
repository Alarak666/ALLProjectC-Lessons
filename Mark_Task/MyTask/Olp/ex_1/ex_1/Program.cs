using System;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            sbyte a = sbyte.Parse(Console.ReadLine());
            sbyte b = sbyte.Parse(Console.ReadLine());
            DateTime time = DateTime.Now;
            Console.WriteLine("a + b = {0}", b += a);
            DateTime end = DateTime.Now;
            Console.WriteLine((end - time).TotalSeconds);
        }
    }
}
