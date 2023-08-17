using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp4
{
    class Program
    {
        public class Element
        {
          
            public string Name;
            public int CountInput;
            public int CountOutput;

            public Element(string Name, int CountInput, int CountOutput)
            {
                this.Name = Name;
                this.CountInput = CountInput;
                this.CountOutput = CountOutput;
            }
            public void AddName(string Name)
            {
                Console.WriteLine($"old {this.Name}, new {Name}");
                this.Name = Name;
                
            }
            ~Element()
            {
                Console.WriteLine("Disposed");
            }
        }


        static async Task Main(string[] args)
        {

        }
    }
}
