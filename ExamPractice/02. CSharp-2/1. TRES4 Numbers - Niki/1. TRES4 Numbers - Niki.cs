using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TRES4_Numbers___Niki
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            StringBuilder reveresIt = new StringBuilder();
            string result = DecimalToBase(input).ToString();
            reveresIt = ReverseIt(result);

            Console.WriteLine(TranslateToTheAlienLanguate(reveresIt));



        }

        private static StringBuilder ReverseIt(string result)
        {
            StringBuilder reverse = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
            {
                reverse.Append(result[result.Length - i - 1]);
            }
            return reverse;
        }

        private static StringBuilder TranslateToTheAlienLanguate(StringBuilder result)
        {
            StringBuilder finalResult = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
            {
                switch (result[i])
                {
                    case '0': finalResult.Append("LON+"); break;
                    case '1': finalResult.Append("VK-"); break;
                    case '2': finalResult.Append("*ACAD"); break;
                    case '3': finalResult.Append("^MIM"); break;
                    case '4': finalResult.Append("ERIK|"); break;
                    case '5': finalResult.Append("SEY&"); break;
                    case '6': finalResult.Append("EMY>>"); break;
                    case '7': finalResult.Append("/TEL"); break;
                    case '8': finalResult.Append("<<DON"); break;

                    default:
                        break;
                }


            }


            return finalResult;
        }

        private static StringBuilder DecimalToBase(BigInteger input)
        {
            StringBuilder result = new StringBuilder();
            if (input == 0)
            {
                result.Append("0");
            }
            else
            {
                while (input > 0)
                {
                    BigInteger digit = input % 9;
                    result.Append((char)(digit + '0'));

                    input /= 9;

                }
            }
        
          
            return result;
        }
    }
}