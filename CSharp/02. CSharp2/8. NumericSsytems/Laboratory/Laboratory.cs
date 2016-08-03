using System;
using System.Numerics;

namespace _7.OneSystemToAnyOther
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstNumSys = Console.ReadLine();

            BigInteger result = BaseToDecimal(firstNumSys, 2);
            string realResult = DecmimalToBase(result, 16);
            Console.WriteLine(realResult);
        }

        static string DecmimalToBase(BigInteger decimalNumber, BigInteger numeralSystem)
        {

            string result = "";

            while (decimalNumber > 0)
            {
                BigInteger digit = decimalNumber % numeralSystem;
                if (digit >= 0 && digit <= 9)
                {
                    result = (char)(digit + '0') + result;
                }
                else
                {
                    result = (char)(digit - 10 + 'A') + result;
                }

                decimalNumber /= numeralSystem;
            }
            return result;
        }


        static BigInteger BaseToDecimal(string number, BigInteger numeralSystem)
        {
            BigInteger decinamlNumber = 0;

            for (int i = 0; i < number.Length; i++)
            {
                BigInteger digit = 0;
                if (number[i] >= '0' && number[i] <= '9')
                {
                    digit = number[i] - '0';
                }
                else
                {
                    digit = number[i] - 'A' + 10;
                }

                decinamlNumber += digit * BigInteger.Pow(numeralSystem, number.Length - i - 1);


            }

            return decinamlNumber;

        }

    }
}
