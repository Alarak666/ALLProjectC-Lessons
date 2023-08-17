using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    class Program
    {
        class Work 
        {
            string word = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            Random random = new Random();
             
            public void Method()
            {
                for (; ; )
                {
                    int rd = random.Next(0, 45);
                  
                    new string(' ', rd);
                    Console.WriteLine(GetWord(word, rd));
                }
                
            }
            public string GetWord(string word, int rd)
            {
                for (; ;)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(word[rd]);
                    return sb.ToString();
                }
            }
            
        }
       public class exe
        {
            public readonly int  zx;
            public IEnumerable GetElement(int[] a)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if(i == a.Length)
                    {
                        yield break;
                    }
                    else if(a[i] % 2 == 0)
                    {
                        yield return a[i];
                    }
                }
            }

           
        }
        static void Main(string[] args)
        {
            try
            {
                int   a = 0;
                int b = 8;
                int c = b / 0;
                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("VSE OK!!!");
            }
            Console.ReadKey();

            //int[] a = new int[] { 1, 2, 3, 4, 1, 3, 4, 5, 6 };
            //exe exe = new exe();
            //exe.GetElement(a);
            //foreach (var item in exe.GetElement(a))
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            //Work work = new Work();

        //    Thread thread = new Thread(new ThreadStart(work.Method));
        //    Thread[] threads = new Thread[4]
        //    {
        //        new Thread(new ThreadStart(work.Method)),
        //        new Thread(new ThreadStart(work.Method)),
        //        new Thread(new ThreadStart(work.Method)),
        //        new Thread(new ThreadStart(work.Method))
        //};
            
            
        //        for (int i = 0; i < 4; i++)
        //        {
        //            threads[i].Start();
        //        }
            
        }
    }
}
