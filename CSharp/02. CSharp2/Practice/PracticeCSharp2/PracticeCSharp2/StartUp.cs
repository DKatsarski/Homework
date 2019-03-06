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

            var dog = new Dog();
            dog.Age = 5;
            dog.Breed = "Border Collie";

            Console.WriteLine(dog.Age);
            Console.WriteLine(dog.Breed);
        }
    }
}
