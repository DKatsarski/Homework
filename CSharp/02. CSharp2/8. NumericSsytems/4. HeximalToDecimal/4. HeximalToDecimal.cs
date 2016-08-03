using System;
using System.Numerics;

namespace _4.HeximalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            n = n.ToUpper();
            BigInteger currentNumber = 0;
            BigInteger result = 0;
            

            for (int i = 0; i < n.Length; i++)
            {
                char helper = n[n.Length - i - 1];

                if (helper == 'A' || helper == 'B' || helper == 'C' || helper == 'D' || helper == 'E' || helper == 'F')
                {
                    currentNumber = n[n.Length - i - 1] - 55; 
                }
                else
                {

                    currentNumber = n[n.Length - i - 1] - '0';
                }


                currentNumber = currentNumber * BigInteger.Pow(15, i);
                result += currentNumber;


            }

            Console.WriteLine(result);

        }
    }
}
