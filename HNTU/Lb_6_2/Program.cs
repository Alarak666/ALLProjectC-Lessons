using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Default;
            Console.OutputEncoding = Encoding.Default;
            string text = Console.ReadLine();
            char[] TextOfChar = text.ToCharArray();
            text = text.ToLower();
            char[] Letters = new char[] { 'а', 'о', 'е', 'и', 'у', 'і' };
            char[] LettersChange = new char[] {'і', 'е' };
            char[] Ignor = new char[] { ';', ',', ' ', '.', '!', '\'' };
            int coints = 0;
            int CountVowels = 0, CountConsonants = 0;
            int _i = 5, e = 7; 
            for (int i = 0; i < text.Length; i++)
            {
                if (!Ignor.Contains(text[i]))
                {
                    if (Letters.Contains(text[i]))
                        CountVowels++;
                    else
                        CountConsonants++;
                    if (CountVowels == _i)
                    {
                        TextOfChar[i] = LettersChange[0];
                        CountVowels = 0;
                        coints += 10;
                    }
                    if (CountConsonants == e)
                    {
                        TextOfChar[i] = LettersChange[1];
                        CountConsonants = 0;
                        coints++;
                    }
                }
                
            }
            
            Console.WriteLine(text = new string(TextOfChar) +" Для \"Бендери\" -"+coints);
            Console.ReadLine();
        }
    }
}
