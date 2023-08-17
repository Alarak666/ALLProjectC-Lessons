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
            string a = "00103", b = "08567";
            Console.WriteLine(sumStrings(a, b));
            Console.ReadLine();
        }
        static string sumStrings(string a, string b)
        {
            a = a.TrimStart('0');
            b = b.TrimStart('0');
            string c = "";
            if(a.Length < b.Length)
            {
                c = a;
                a = b;
                b = c;
                c = "";
            }
            int diff = a.Length - b.Length;
            for (int i = 0; i < diff; i++)
            {
                b = "0" + b;
            }
            int add = 0;
            for (int i = a.Length-1; i >= 0; i--)
            {
                int cc = ((int)a[i] - 48 + (int)b[i] - 48) + add ;
                add = Convert.ToInt32(cc > 9);
                c += (cc % 10).ToString();
            }
            if (add > 0)
            {
                c += add.ToString();
            }
            var ret = c.ToCharArray().Reverse();
            string bb = new string(ret.ToArray());
            Console.WriteLine(a);
            Console.WriteLine(b);
            return bb;
        }
    }
}
