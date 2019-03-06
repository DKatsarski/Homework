using PracticeCSharp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public class Dog : IDog
    {
        private int age;
        private string breed;

        public Dog()
        {
            this.age = Age;
            this.breed = Breed;
        }
        public int Age { get; set; }
        public string Breed { get; set; }
    }
}
