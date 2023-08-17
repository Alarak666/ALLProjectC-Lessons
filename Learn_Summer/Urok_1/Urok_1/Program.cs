using System;
using System.Collections.Generic;
namespace Urok_1
{
    class Program
    {
        private enum MyEnum

        {

            First = 11,

            Second,

            Third = 33

        }


        public static class Kata
            {
                public static IEnumerable<string> FriendOrFoe(string[] names)
                {
                    string[] friends_my = new string[0];


                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i].Length == 4)
                        {
                            Array.Resize(ref friends_my, friends_my.Length + 1);
                            friends_my[i] = names[i];
                        }
                    }
                    return friends_my;
                }
            }
            
            static String str;



            static DateTime time;



            static void Main(string[] args)



            {

            Console.WriteLine((int)MyEnum.Second);
            int a = -5;

            Console.WriteLine(~a);
            Console.ReadKey();



        }
    }
    }

