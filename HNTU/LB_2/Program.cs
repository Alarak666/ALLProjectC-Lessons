using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_2
{
    class Program
    {
        public class Bill
        {
            private double Tarif = 24.4;
            private double Discount = 0.5;
            public string Telephone;
            public double TimeCall;
            private int sum;
            public int Sum { get { return sum; }}
            public Bill(string Telephone, double TimeCall)
            {
                this.Telephone = Telephone;
                this.TimeCall = TimeCall;
                sum = SumCall();
            }
            private int SumCall()
            {
                int a;
                Console.WriteLine("Сумма звонка - {0}", a = (int)(Math.Round(Tarif * TimeCall) * Discount));
                return a;
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            Bill[] bills = new Bill[1];
            int i = 1;
            bool flag = true;
            do
            {
                Console.WriteLine("1 - Сделать звонок;\n2 - Просмотреть звонки;\n3 - Полная сума за звонки;\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        Array.Resize(ref bills, i);
                        bills[i-1] = new Bill(Console.ReadLine(), (double)(random.Next(0, 120) / 10));
                        i++;
                        break;
                    case "2":
                        SeeCall(bills);
                        break;
                    case "3":
                        SumCallTotal(bills);
                        break;
                }
                Console.WriteLine("Продолжаем? y/n");
                flag = ("y" == Console.ReadLine().ToLower()) ? true : false;
                Console.WriteLine("Продолжаем");
            } while (flag);
        }
        static void SeeCall(Bill [] bills)
        {
            foreach (var item in bills)
            {
                Console.WriteLine("\nНомер телефона - {0};\n Время звонка - {1};Сумма звонка - {2};\n",item.Telephone, item.TimeCall, item.Sum);
            }
        }
        static void SumCallTotal(Bill[] bills)
        {
            int Sum = 0;
            foreach (var item in bills)
            {
                Sum += item.Sum;
            }
            Console.WriteLine("Сумма всех звонков - {0}", Sum);
        }
    }
}
