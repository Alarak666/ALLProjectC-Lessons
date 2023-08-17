using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ExtensionMethod
{
    public delegate int Calculators(int a, int b);

    class Program
    {
        class Calculator
        {
            public int Sum(int a, int b)
            {
                return a + b;
            }
            public int devide(int a, int b)
            {
                return a + b;
            }
        }
        delegate string Operation(int a, int b, char c);
        public delegate void OidMessage();
        class Gopnik
        {
            public int oil = 100;
            public event OidMessage Oildend;
            public void message()
            {
                Console.WriteLine("NETY SEMOC");
            }
            public void Work()
            {
                for (int i = oil; i >= 0; i--)
                {
                    Thread.Sleep(1);
                    Console.WriteLine(i);
                    if (oil == 0)
                    {
                        Oildend();
                    }
                    oil--;
                }
            }
        }
        class ALKASH
        {
            public int oil = 100;
            public event OidMessage Oildend;
            public void message()
            {
                Console.WriteLine("NETY Buhla");
            }
            public void Work()
            {
                for (int i = oil; i >= 0; i--)
                {
                    Thread.Sleep(1);
                    Console.WriteLine(i);
                    if (oil == 0)
                    {
                        Oildend();
                    }
                    oil--;
                }
            }
        }


        class A
        {
            public virtual void F() { Console.WriteLine("A.F"); }
            public void G() { Console.WriteLine("A.G"); }
        }
        class B : A
        {
            public override void F() { Console.WriteLine("B.F"); }
            public new void G() { Console.WriteLine("B.G"); }
        }
        static void Main(string[] args)
        {
            B b = new B();
            A a = b;

            a.F();
            b.F();

            a.G();
            b.G();
            Console.ReadLine();
        }
        //Gopnik gopnik = new Gopnik();
        //    ALKASH aLKASH = new ALKASH();
        //    OidMessage message = new OidMessage(gopnik.message);
        //    gopnik.Oildend += Gopnik_Oildend; ;
        //    aLKASH.Oildend += message;
        //    gopnik.Work();
        //    aLKASH.Work();
        //Operation operation = (int a, int b, char c) => c == '*' ? $"{a * b}" : c == '+' ? $"{a + b}" : c == '-' ? $"{a - b}" : b == 0 ? "попитка деления на 0": $"{a / b}" ;

        //Console.WriteLine(operation(4,0,'/'));


        //Calculator calculator = new Calculator();
        //int a = 3; int b = 3;
        //Calculators calculators = calculator.Sum;
        //calculators += calculator.devide;
        //Console.WriteLine($"{calculators.Method.GetParameters().ToString()}");
        ////int i = 1;
        ////Console.WriteLine(i.Method());

        ////byte[] array = { 0x64, 0x6f, 0x74, 0x63, 0x65, 0x74 };

        ////string hexValue = Convert.ToBase64String(array);
        ////Console.WriteLine(hexValue);





        private static string Gopnik_Oildend()
        {
            return "CUCU";
        }
    }
    public static class INTEGER
    {
        public static string Message()
        {
            return "sum";
        }
        public static int Method(this int i)
        {
            return i + 1;
        }

    }
}