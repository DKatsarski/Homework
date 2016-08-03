using System;

namespace _11.StringsAndTextOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            char holder = ')';
            int counter = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == '(')
                {
                    counter++;
                }
                else if (counter > 0)
                {
                    if (holder == n[i])
                    {
                        counter--;
                    }
                }
                else if (n[i] == holder && counter == 0)
                {
                    counter = 12;
                    break;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Correct");
            }
            else if (counter != 0)
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
