using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<int> result = Enumerable.Range(1, 10).Where(x => x % 2 ==0);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

        }
    }
}