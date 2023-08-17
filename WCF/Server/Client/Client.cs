using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Windows;

namespace Client
{
    class People {

    public string name;
    }
    class ALcal : People {
        public int bib;
    };
    class Prem : People { };
    class Client
    {
        
        static void Main(string[] args)
        {
            //try
            //{
            //    ALcal aLcal = new ALcal();
            //    Console.WriteLine(aLcal.GetHashCode().ToString());
            //    People people = new ALcal();
            //    ALcal aLcal1 = (ALcal)people;
            //    Console.WriteLine(people.GetHashCode().ToString());
            //    Console.ReadKey();
            //}
            //catch (Exception e) {
            //    MessageBox.Show(e.ToString());
            //}

            Type type = typeof(People);
            Type type1 = typeof(ALcal);
            Console.WriteLine(type1);
            Console.WriteLine(type);
            Uri uri = new Uri("http://localhost:3001/Server/IService");
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress(uri);
            ChannelFactory<IService> factory = new ChannelFactory<IService>(binding, endpoint);
            IService service = factory.CreateChannel(endpoint, uri);
            Console.WriteLine("Введите свое сообщение на сервер");
            service.Say("asda");
            Console.WriteLine("asda");
            Console.ReadKey();
        }
    }
}
