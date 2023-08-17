using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пошук_найбильшого_слова_по_байтам
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "man i need a taxi up to ubud";
            Console.WriteLine(High(s));
            Console.ReadKey();
        }
        public static string High(string s)
        {
            string word = "";
            string[] words = new string[1];
            int valueOld = 0;
            int valueNew = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                    word += s[i];
                if (s[i] == ' ' || s.Length == i + 1)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        valueNew += (int)word[j] - 96;
                    }
                    if (words[0] == null)
                    {
                        valueOld = valueNew;
                        words[0] = word;
                    }
                    else
                    {
                        if (valueNew > valueOld)
                        {
                            valueOld = valueNew;
                            words[0] = word;
                        }
                    }
                    valueNew = 0;
                    word = "";
                    continue;
                }
            }
            return words[0];
        }
    }
}
