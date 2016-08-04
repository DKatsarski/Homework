using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StrangeLand_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder message = new StringBuilder();
            BigInteger decimalNumber = 0;
            BigInteger digit = 0;


            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 1; j <= input.Length - i; j++)
                {
                    switch (input.Substring(i, j))
                     {

                        case "f":   message.Append("0"); break;
                        case "bIN": message.Append("1"); break;
                        case "oBJEC": message.Append("2"); break;
                        case "mNTRAVL": message.Append("3"); break;
                        case "lPVKNQ": message.Append("4"); break;
                        case "pNWE": message.Append("5"); break;
                        case "hT": message.Append("6"); break;
                        default:
                            break;
                    }

                }
               
            }





            for (int i = 0; i < message.Length; i++)
            {
                decimalNumber += (message[i] - '0') * BigInteger.Pow(7, message.Length - i - 1);
            }

            Console.WriteLine(decimalNumber);





        }
    }
}
