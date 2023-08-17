using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int arg = 0;
            char a = 'a'; char b = 's';
        }
        public static int SameCase(char a, char b)
        {
            Console.WriteLine("{0}, {1}", a, b);
            return (char.IsDigit(a) && char.IsLetter(b)) ? 0 : (a.Equals(b))? 1:-1;
        }
    }
}
