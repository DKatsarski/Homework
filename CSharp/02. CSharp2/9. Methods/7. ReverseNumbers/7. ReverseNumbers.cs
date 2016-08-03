using System;

namespace _7.ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            ReverseIt(n);
            Console.ReadLine();



        }

        static void ReverseIt(string n)
        {
            char[] reverse = new char[n.Length];
            for (int i = 0; i < n.Length; i++)
            {

                reverse[i] = n[n.Length - i - 1];
                 Console.Write(reverse[i]);
            }
            

        }
    }
}
