using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    class Program
    {
        static void Change(int a)
        {
            a = 10;
        }

        static void Main(string[] args)
        {
            int b = 2;
            Change(b);
            Console.WriteLine(b);
        }
    }
}
