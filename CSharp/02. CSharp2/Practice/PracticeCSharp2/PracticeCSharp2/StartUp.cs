using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public class StartUp
    {
        static void Main()
        {
            int[] numbers = new int[4];

            numbers[1] = 3;

            string a = string.Join(", ", numbers);

            Console.WriteLine(a);
        }
    }
}
