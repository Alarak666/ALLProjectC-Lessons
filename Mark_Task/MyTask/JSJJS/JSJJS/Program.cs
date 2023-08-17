using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace JSJJS
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int ya, gm, ur, ma;
            ya = gm = ur = ma = 0;
            
            using (StreamReader reader = new StreamReader(@"C:\Users\popel\OneDrive\Робочий стіл\ds.txt", true)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Regex.IsMatch(line, @"\w+\@yandex\.ru", RegexOptions.Compiled))
                        ya++;// yandex.ru
                    else if (Regex.IsMatch(line, @"\w+\@mail\.ru", RegexOptions.Compiled))
                        ma++;// mail.ru
                    else if (Regex.IsMatch(line, @"\w+\@gmail\.com", RegexOptions.Compiled))
                        gm++;// gmail.com
                    else if (Regex.IsMatch(line, @"\w+\@ukr\.net", RegexOptions.Compiled))
                        ur++;// ukr.net
                }
            };
            Console.WriteLine($"yandex - {ya};\ngmail - {gm};\nukr - {ur};\nmail - {ma}");
            Console.ReadKey();
        }
    }
}
