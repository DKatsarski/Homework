using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            // ideqta - poluchawm pyrwoto chislo 2. prewryshtam go w decimal. 3 polu`awa wtorto chislo 4 prewryshtam go w decimal. 5. izwajdam g ili gi sybiram. poluchawam decimal POSLEDNO - prewryshtam go w 9-chna 
            string twentySixBaseSys = Console.ReadLine();
            char inputOperator = char.Parse(Console.ReadLine());
            string sevenBaseSys = Console.ReadLine();

            BigInteger digit = 0;
            BigInteger decimalNumberFrom26 = 0;
            BigInteger decimalNumberFrom7 = 0;
            BigInteger numberAfterOperation = 0;

            //convert firt to decimal
            for (int i = 0; i < twentySixBaseSys.Length; i++)
            {
                digit = twentySixBaseSys[i] - 'a';
                decimalNumberFrom26 += digit * BigInteger.Pow(26, twentySixBaseSys.Length - i - 1);

                if (i <= sevenBaseSys.Length - 1)
                {
                    digit = sevenBaseSys[i] - '0';
                    decimalNumberFrom7 += digit * BigInteger.Pow(7, sevenBaseSys.Length - i - 1);
                }
            }


            // make operation 

            if (inputOperator == '+')
            {
                numberAfterOperation = decimalNumberFrom26 + decimalNumberFrom7;
            }
            else
            {
                numberAfterOperation = decimalNumberFrom26 - decimalNumberFrom7;
            }


            //convert to ninth. 

            StringBuilder result = new StringBuilder();


result = Encod
            Console.WriteLine(result);

        }

        public static class BaseConverter
        {
            public static string Encode(BigInteger value, int @base = 0)
            {
                if (@base <= 0);
                var sb = new StringBuilder();
                do
                {
                    int m = (int)(value % @base);
                    sb.Insert(0, chars[m]);
                    value = (value - m) / @base;
                } while (value > 0);
                return sb.ToString();
            }
        }
    }
}
