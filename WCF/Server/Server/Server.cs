using System;
using System.ServiceModel;
namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://localhost:3001/Server/IService");
            BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
            Type type = typeof(IService);
            ServiceHost host = new ServiceHost(typeof(Service));
            host.AddServiceEndpoint(type, basicHttpBinding, uri);
            host.Open();
            Console.WriteLine("Принимаем значения");
            Console.ReadKey();
        }
    }
}
