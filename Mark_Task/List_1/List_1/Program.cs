using System;
using System.Collections.Generic;
namespace List_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4] {1, 1, 4, 5};
            int[] b = new int[4] {3, 4, 3, 2 };
            int[] list = new int[4];
            do
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (a[i] != a[j])
                        {
                            for (int c = 0; c < list.Length; c++)
                            {
                                if (list[c] != a[i])
                                {
                                    list[i] = a[i];
                                    break;
                                }
                            }
                        }
                    }
                }
                foreach (var item in list)
                {
                    Console.WriteLine(item + " ");
                }
                Console.ReadLine();
            } while (list.Length != b.Length);
        }
    }
}
