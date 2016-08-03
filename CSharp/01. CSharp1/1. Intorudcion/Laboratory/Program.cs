using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intorudcion
{
    class HelloCSharp
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your first name: ");
            string a = Console.ReadLine();
            Console.Write("Please enter your second name: ");
            string b = Console.ReadLine();
            Console.Write("Please, enter your age: ");
            int age = int.Parse(Console.ReadLine());


            //Console.WriteLine("Yes, you are homosexual!");
            Console.WriteLine("Hello, {0} {1}!", a, b);
            Console.WriteLine("Your age is {0}", age);
            Console.WriteLine();
        }
    }
}
