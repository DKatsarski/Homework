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
        static void Main(string[] args)
        {
            var teachers = new ListOfTeachers();

            teachers.SayAngryWords("Ne goworete poweche!!");

            var director = new Director();

            director.SayAngryWords("sprete!");

            var doorman = new Doorman("Marko");

            var messageFromTheDoorsman = doorman.SpeakStuff();

            Console.WriteLine(messageFromTheDoorsman);
        }
    }
}