using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSide
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "asdf  sdf ", "sfdasdf sd f", " dd d d   d d" };

            Console.WriteLine(a[1].Replace(" ", ""));
        }
    }
}
