using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_4_4
{
    class Person : IDisposable
    {
        public string name;
        public byte[] memory = new byte[] { };
        public Person(string name, byte[] memory)
        {
            this.name = name;
            this.memory = memory;
        }
        public void AddMemory(int add)
        {
            Array.Resize(ref memory, add);
        }
        public void Add(string a)
        {
            memory = Encoding.UTF8.GetBytes(a);
        }
        public void SizeMemory()
        {
            Console.WriteLine($"{this.name}, має пам'ятi - {this.memory.Length}");
        }
        public void Dispose()
        {
            byte[] resultBytes = memory.Select(value => Convert.ToByte(value)).ToArray();
            string result = Encoding.UTF8.GetString(resultBytes);
            
            Console.WriteLine("В пам'яти - {0}\nРесурси выгрузив!", result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int personpick = -1;
            int answer;
            Person[] person = new Person[]
            {
              new Person("Alice", new byte[4500]),
              new Person("Bob", new byte[128]),
              new Person("Carl", new byte[64000])
            };
            do
            {
                for (int i = 1; i <= person.Length; i++)
                {
                    Console.WriteLine("{0} - "+ person[i-1].name.ToString() + " "+  person[i-1].memory.Length, i);
                }
                Console.WriteLine("Обери користувача вiд 1 - {0}", person.Length);
                answer = int.Parse(Console.ReadLine());
                for (int i = 0; i < person.Length; i++)
                {
                    if(answer-1 == i)
                    {
                        personpick = i;
                    }
                }
                do
                {
                    Console.WriteLine("Обери операцiю\n 1 - Перевiрити память;\n 2 - додати пам\'ятi, параметр ввести;\n 3 - додати данi;\n 4 - Прочитати та вигрузити з пам\'ятi;");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            person[personpick].SizeMemory();
                            break;
                        case "2":
                            person[personpick].AddMemory(int.Parse(Console.ReadLine()));
                            break;
                        case "3":
                            person[personpick].Add(Console.ReadLine());
                            break;
                        case "4":
                            person[personpick].Dispose();
                            flag = false;
                            break;
                        default :
                            Console.WriteLine("Мимо");
                            break; 
                    }
                    
                } while (flag);
                Console.WriteLine("Змінити людину? y/n");
                flag = (Console.ReadLine().ToLower() == "y") ? true : false;
            } while (flag);
        }
    }
}