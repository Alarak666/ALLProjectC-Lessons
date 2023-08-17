using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace рандом_1
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int n, m, k = 0, numb = 0;
                n = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());
                k = int.Parse(Console.ReadLine());
                string line = "";
                Random random = new Random();
                Console.WriteLine("Випадковi числа з промiжку [-200; 100] :");
                for (int i = 0; i < m; i++)
                {
                    line += random.Next(-200, 100);
                    if (line.Length > k)
                    {
                        Console.WriteLine($"{line.Remove(k)} ");
                        line = line.Remove(0, k);
                    }
                }
                Console.WriteLine(line);
                line = "";
                Console.WriteLine("Випадковi дiйснi числа з промiжку [0; 10] з точнiстю до тисячних");
                for (int i = 0; i < m; i++)
                {
                    line += Math.Round((double)random.Next(0, 10) / random.Next(0, 10), 2);
                    if (line.Length > k)
                    {
                        Console.WriteLine($"{line.Remove(k)} ");
                        line = line.Remove(0, k);
                    }
                }
                Console.Write(line);
                Console.ReadKey();
            }
        }
    }
}
