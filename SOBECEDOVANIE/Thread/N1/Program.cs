using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N1.N2;
using System.Xml.XPath;
namespace n3
{
    class gay
    {

    }
}

namespace N1
{
    namespace N2
    {
        
        using R = n3;
        class Person
        {
            R.gay gay = new R.gay();
            
            public int a;
            public void Method()
            {
                for (int i = 0; i < 10; i++)
                { 
                    Console.WriteLine(gay.Equals(i));

                }
                
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            //person.Method();
            //for (int i = 0; i < 10; i++)
            //{

            //}
            ////Console.ReadKey();
            //dynamic x = 3;
            //int a = 2;
            //int c ;
            //Console.WriteLine(c = a + x);
            //x = new Person();

            //Console.WriteLine(x.GetType());
            //Console.ReadKey();

            GC
            Stream stream ;
            XPathDocument xPath = new XPathDocument(@"C:\Users\popel\source\repos\SOBECEDOVANIE\Thread\N1\", System.Xml.XmlSpace.Default);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(xPath.CreateNavigator());
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
