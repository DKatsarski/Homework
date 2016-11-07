using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySampleDataImporter.Importer
{
    public class Startup
    {
        static void Main()
        {
            var date = RandomGenerator.GetRandomDate();

            SampleDataImporter.Create(Console.Out).Import();
        }
    }
}
