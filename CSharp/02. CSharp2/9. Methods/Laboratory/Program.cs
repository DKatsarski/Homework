using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    class Program
    {
   

        static void Main(string[] args)
        {
           
            string n = Console.ReadLine();
            for (int i = 0; i < n.Length; i++)
            {
                char[] reverse = new char[n.Length];
                reverse[i] = n[n.Length - i - 1];

                Console.Write(reverse[i]);
            }


          
        }
    }
}
