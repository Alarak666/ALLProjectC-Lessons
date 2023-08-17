using System;

namespace Task_3
{
    class Program
    {
        //         посчитать сколько значений в массиве делятся на 8 без остатка.
        //  вывести на экран только первые 4 значения, которые делятся на 7.
        // вывести на экран только последние 3 значения, которые делятся на 4.
        // каждое значение которое делиться на 4 или 7 умножить на 9 и вывести на
        // экран.
        // вывести минимальное значение среди нечетных значений и в четных строках.
        static void Main(string[] args)
        {
            
            Random rd = new Random();
            int[][] jaggArr = new int[3][]; // Объявление трехстрочного зубчатого массива.
            jaggArr[0] = new int[2]; // Первая строка на 2 ячейки.
            jaggArr[1] = new int[5]; // Вторая строка на 5 ячеек.
            jaggArr[2] = new int[3]; // Третья строка на 3 ячейки.
            int count = 0;
            for (int i = 0; i < jaggArr.Length; i++)
            {
                int len = jaggArr[i].Length;
                for (int j = 0; j < len; j++)
                {
                    jaggArr[i][j] = rd.Next(1, 100);
                    if (jaggArr[i][j] % 8 == 0 && count < 5)
                    {
                        Console.Write($"{jaggArr[i][j]} ");
                        count++;
                    }
                    Console.WriteLine();
                    if (jaggArr[i][j] % 8 == 0 && count < 5)
                    {
                        Console.Write($"{jaggArr[i][j]} ");
                        count++;
                    }
                }
                Console.WriteLine();
            }
            int t13 = jaggArr[1][3]; // 6
        }
    }
}