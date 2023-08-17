using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сортування_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int three = 0, third = 0;
            bool flag = true;
            Random random = new Random();
            int[] array = new int[three];
            int[] tempArray = new int[third];
            do
            {
                three = int.Parse(Console.ReadLine());
                Array.Resize(ref array, three);
                if (three % 3 == 0)
                {
                    for (int i = 0; i < three; i++)
                    {
                        array[i] =  random.Next(0, 12);
                    }
                    third = three / 3;
                    Array.Resize(ref tempArray, third);
                    flag = false; 
                }
            } while (flag);
            for (int i = 0; i < three; i +=third)
            {
                if(third > i) 
                {
                    tempArray = SortInput(third, ref array);
                    for (int j = 0; j < third; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(tempArray[j] +" ");
                    }
                }
                else if (third + third > i ) 
                {
                    int max = SearchMax(third, array);
                    for (int j = third; j < third * 2; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        if(max == array[j])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(max + " ");
                            continue;
                        }
                        Console.Write(array[j] + " ");
                    }
                }
                else {
                    tempArray = SortBubble(third * 2, ref array);
                    for (int j = third * 2; j < three; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(tempArray[j] + " ");
                    }
                }
            }
            
            Console.ReadLine();
        }
        static int SearchMax(int start, int [] array)
        {
            int max = 0;
            int finish = start * 2;
            for (int i = start; i < finish; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }
        static int[] SortInput(int n, ref int [] array )
        {
            int max, temp;
            
            for (int i = 0; i < n-1; i++)
            {
                max = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[max])
                        max = j;
                }
                temp = array[i];
                array[i] = array[max];  //swap 
                array[max] = temp;
            }
            return array;
        }
        static int[] SortBubble(int n, ref int [] array)
        {
            int temp;
            for (int i = n; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

            }
            return array;
        }
    }
}
