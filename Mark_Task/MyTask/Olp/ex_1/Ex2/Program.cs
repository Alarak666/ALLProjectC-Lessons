using System;
namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            char[ , ] array = new char[weight, height];
            for (int i = 0; i < weight; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    array[j, i] = '.';
                    Console.Write(array[j, i]) ;
                }
                Console.WriteLine();
            }
            int X, Y, K, S;
            char D, U, R, L;
            D = 'D'; U = 'U'; R = 'R'; L = 'L';
            char  move = '0';
            X = 0; Y = 0; K = 3;
            Console.WriteLine("Путь");
            Console.WriteLine("Количесвто шагом");
            do
            {
                move =Convert.ToChar(Console.ReadLine());
                S = int.Parse(Console.ReadLine());
                if (move == D)
                {
                    for (int i = 0; i < S; i++)
                    {
                        array[X, i] = '*';
                        Console.WriteLine(array[X, i]);
                    }
                   X += S;
                }
                if (move == U)
                {
                    for (int i = Y; i + Y == S; i--)
                    {
                        array[X, i] = '*';
                        Console.WriteLine(array[X, i]);
                    }
                    X -= S;
                }
                if (move == R)
                {
                    for (int i = 0; i < S; i++)
                    {
                        array[i, Y] = '*';
                        Console.Write(array[i, Y]);
                    }
                    Y += S;
                }
                if (move == L)
                {
                    for (int i = Y; i + Y == S; i--)
                    {
                        array[i, Y] = '*';
                        Console.Write(array[i, Y]);
                    }
                    Y -= S;
                }
                
            } while (K != 0);
            for (int i = 0; i < weight; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(array[j, i]);
                }
                Console.WriteLine();
            }
        }
    }
}
