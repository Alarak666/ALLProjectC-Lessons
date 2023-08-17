using System;

namespace Splitting_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Я занимаюсь програмированием";
            string[] arrStr = new string[] { };
            string[] mymethod = new string[5];
            arrStr = str.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in arrStr)
            {
                Console.WriteLine($"{item} ");
            }
            int j = 0;
            string method = "";
            for (int i = 0; i <= str.Length-1; i++)
            {
                method += Convert.ToString(str[i]);
                if (str[i] == ' ' || str.Length-1 == i)
                {
                    mymethod[j] = method;
                    j++;
                    method = "";
                }
                
            }
            foreach (var item in mymethod)
            {
                Console.WriteLine($"{item } ");
            }
        }
    }
}
