using System;

namespace TheHorror
{
    class TheHorror
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            double digitAmount = 0;

            for (int i = 0; i < input.Length; i += 2)
            {
                if (input[0] == '-')
                {
                    continue;
                }
                if (input[i] >= '0' && input[i] <= '9')
                {
                    sum += input[i] - '0';
                    digitAmount++;
                }
                else
                {
                    continue;
                }
            
            }
            Console.WriteLine("{0} {1}", digitAmount, sum);
        }
    }
}
