using System;

namespace Server
{
    class Service : IService
    {
        public void Say(string a)
        {
            Console.Write("CONECT", a);
        }
    }
}
