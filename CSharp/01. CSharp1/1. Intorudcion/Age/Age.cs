using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {
            
            int age = int.Parse(Console.ReadLine());
            Console.Write("Write your birthdate in MM.DD.YYYY:{0} ", age);
            Console.Write("Your age will be {0}", age + 10);
        }
    }
}
