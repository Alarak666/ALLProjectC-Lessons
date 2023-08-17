using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_6_1
{
    class Program
    {
        public static int i = 0;
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            string text = Console.ReadLine();
            string words = "";
            int CountOtherWord = 0, CountWords = 0;
            int j = 0;
            string[] word = new string[0];
            string[] DeleteWords = new string[1];
            text = text.Trim(new char[] { ';', ','});
            Console.WriteLine("Шаманим \n 1) Кількість різних слів в рядку, що входять до заданого тексту\n2)Кількість використаних слів\n3)Видялить подвоєні слова\n\n");
            for (int i = 0; i < text.Length; i++)
            {
                words += text[i];
                if (text[i] == ' ' || text.Length - 1 == i)
                {
                    if (words == " ")
                        continue;
                    CountOtherWord += WordEqually(word, words);
                    CountWords++;
                    Array.Resize(ref word, word.Length + 1);
                    word[j] = words;
                    j++;
                    if (!DeleteWord(words))
                    {
                        Array.Resize(ref DeleteWords, Program.i);
                        DeleteWords[Program.i - 1] = words;
                    }
                    words = "";
                }
            }
            Console.WriteLine("1) Кількість різних слів в рядку, що входять до заданого тексту - {0};\n2) Кількість використаних слів - {1};\n3)Видялить подвоєні слова; ", CountOtherWord, CountWords);
            foreach (var i in DeleteWords)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
        static bool DeleteWord(string words)
        {
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == words[i + 1])
                {
                    Program.i++;
                    return false;
                }

            }
            return true;
        }
        static int WordEqually(string[] word, string words)
        {
            foreach (var strLine in word)
            {
                if (strLine.Contains(words)) 
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
