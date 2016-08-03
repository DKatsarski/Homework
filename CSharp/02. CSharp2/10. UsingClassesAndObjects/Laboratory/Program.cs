using System;
using System.Timers;

namespace Laboratory
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
    
    public class PasswordsGenerator
    {

        private readonly string alphabetLower = "abcdefghijklmnopqrstuvwxyz";
        private readonly string alphabetUpper;
        private readonly string digits = "0123456789";
        private readonly string specialCharacters = "!@#$%^&*()";



        public PasswordsGenerator()
        {
            alphabetLower.ToUpper();

        }

        public string Generate(int length = 10)
        {

        }

    }




}
