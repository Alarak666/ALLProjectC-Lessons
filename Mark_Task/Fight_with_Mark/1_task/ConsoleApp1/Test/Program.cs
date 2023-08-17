using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "ne-NP", "es-BO", "ig-NG" };
            foreach (var cultureName in cultureNames)
            {
                RegionInfo region = new RegionInfo(cultureName);
                Console.WriteLine("{0} {1} the metric system.", region.EnglishName,
                                  region.IsMetric ? "uses" : "does not use");
            }
            Console.ReadKey();
        }
     
    }
}
