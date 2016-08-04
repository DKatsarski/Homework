using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoding
{
    class Decoding
    {
        static void Main(string[] args)
        {
            int salt = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            double result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '@')
                {
                    break;
                }
                else if (text[i] >= 'a' && text[i] <= 'z')
                {
                    result = (text[i] * salt) + 1000;
                }
                else if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    result = (text[i] * salt) + 1000;
                }
                else if (text[i] >= '0' && text[i] <= '9')
                {
                    result = text[i] + salt + 500;
                }
                else
                {
                    result = text[i] - salt;
                }

                if (i % 2 == 0)
                {
                    result /= 100;
                    Console.WriteLine("{0:F2}", result);
                }
                else
                {
                    result *= 100;
                    Console.WriteLine(result);
                }


               
                result = 0;
            }




        }
    }
}
