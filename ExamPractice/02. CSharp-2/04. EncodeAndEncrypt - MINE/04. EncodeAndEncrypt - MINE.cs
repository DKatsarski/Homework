using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EncodeAndEncrypt___MINE
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string cypher = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            result = Encode(message, cypher);
            result.Append(cypher);
            Console.WriteLine(EncodeAndEncrypt(result).Append( cypher.Length)); 





        }

        private static StringBuilder EncodeAndEncrypt(StringBuilder result)
        {
            StringBuilder finalResult = new StringBuilder();
            int index = 0;
            
            while (index < result.Length)
            {
                char current = result[index];
                int counter = 0;
                int walkThrough = index;
               
                while (walkThrough < result.Length)
                {
                    char next = result[walkThrough];
                    if (next != current)
                    {
                        break;
                    }
                    counter++;
                    walkThrough++;


                }
                index = walkThrough;
                if (counter <= 2)
                {
                    finalResult.Append(current, counter);
                }
                else
                {
                    finalResult.Append(counter);
                    finalResult.Append(current);
                }

            }
            return finalResult;
        }

        private static StringBuilder Encode(string message, string cypher)
        {
            int maxLenght = Math.Max(message.Length, cypher.Length);
            StringBuilder sb = new StringBuilder(message);
       

            for (int i = 0; i < maxLenght; i++)
            {
                int letterMessage = sb[i % sb.Length] - 'A';
                int  letterCypher = cypher[i % cypher.Length] - 'A';

                int result = (letterMessage ^ letterCypher) + 'A';
                sb[i % sb.Length] = (char)result;

            }
            return sb;





        }
    }
}
