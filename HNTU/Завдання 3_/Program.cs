using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Login = new string[] {"Alice", "Bob", "Carl" };
            string[] Password = new string[] {"Cooper", "Dylan", "Perkins" };
            string answerLogin = "";
            string answerPassword = "";
            bool flag;
            int permissions = -1;
            string[] Access = new string[] { "x", "wx", "r" };
            do
            {
                flag = false;
                do
                {
                    Console.WriteLine("Введите Логин и пароль");
                    Console.Write("Логин - ");
                    answerLogin = Console.ReadLine();
                    Console.Write("Пароль - ");
                    answerPassword = Console.ReadLine();
                    for (int i = 0; i < Login.Length; i++)
                    {
                        for (int j = 0; j < Password.Length; j++)
                        {
                            if(Login[i] == answerLogin && Password[j] == answerPassword)
                            {
                                permissions = i;
                                flag = false;
                                break;
                            }
                        }
                    }
                } while (flag);
                Console.Write($"Користувач - {answerLogin}, має такi права:\n");
                foreach(char n in Access[permissions])
                {
                    Console.Write( ((n == 'r') ? "Read" : (n == 'w') ? "Write" : "Execute File") + "\n");
                }
                Console.WriteLine("Продолжить? y/n");
                flag = "y" == Console.ReadLine() ? true : false;
            } while (flag);
        }
    }
}
