using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bubka e mnogo hubawa";

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
            }
        }
    }
}