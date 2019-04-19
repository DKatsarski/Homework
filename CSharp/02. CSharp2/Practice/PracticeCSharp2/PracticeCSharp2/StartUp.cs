using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public class StartUp
    {
        static void Main()
        {
            Console.WriteLine(7 / -3);
            Console.WriteLine(Divide(10, 3));
            Console.WriteLine(Divide(7, -3));
            Console.WriteLine(2147483648 / 1);
            Console.WriteLine(Divide(-2147483648, -1));

        }

        public static int Divide(int dividend, int divisor)
        {
            int result = 0;

            if (dividend < 0 && divisor < 0)
            {
                string dividenedString = dividend.ToString();
                string divisorString = divisor.ToString();
                divisorString.TrimStart('-');

                divisor = int.Parse(divisorString);
                dividend = int.Parse(dividenedString);


                for (int i = divisor; i >= dividend; i += divisor)
                {
                    result++;
                }


                return result;
            }
            else if (dividend < 0 || divisor < 0)
            {
                if (dividend < 0)
                {
                    string myString = dividend.ToString();
                    string newString = string.Empty;
                    for (int i = 1; i < myString.Length; i++)
                    {
                        newString += myString[i];
                    }

                    dividend = int.Parse(newString);

                }
                else if (divisor < 0)
                {
                    string myString = divisor.ToString();
                    string newString = string.Empty;
                    for (int i = 1; i < myString.Length; i++)
                    {
                        newString += myString[i];
                    }

                    divisor = int.Parse(newString);
                }

                for (int i = divisor; i <= dividend; i += divisor)
                {
                    result++;
                }

                string minus = "-" + result.ToString();

                return int.Parse(minus);
            }
            else
            {
                for (int i = divisor; i <= dividend; i += divisor)
                {
                    result++;
                }

                return result;
            }



        }








    }
}