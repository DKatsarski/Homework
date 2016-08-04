using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigmatation
{
    class Enigmatation
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            double a = (1 + 9) % 6 - (7 % 2) * 8;
            Console.WriteLine("{0:F3}", a);
        }
    }
}
