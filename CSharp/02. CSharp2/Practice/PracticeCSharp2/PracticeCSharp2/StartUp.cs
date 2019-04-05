using Bazik;
using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public class PracticeCSharp2
    {
        static void Main()
        {
            int n = 6;// Convert.ToInt32(Console.ReadLine());
            

            staircase(n);
        }

        static void staircase(int n)
        {
            int star = 1;

            for (int i = n; i > 0; i--)
            {
                Console.Write(new string(' ', i - 1));
                Console.Write(new string('#', star));
                Console.WriteLine();
                star++;

            }

        }

    }
}
