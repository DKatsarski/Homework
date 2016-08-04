using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Variable_Length_Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            //input 
            string[] input = Console.ReadLine()
                                    .Trim(' ')
                                    .Split(' ')
                                    .ToArray();
            int numberToInput = int.Parse(Console.ReadLine());
            string[] letterOfSignificance = new string[numberToInput];

            for (int i = 0; i < letterOfSignificance.Length; i++)
            {
                letterOfSignificance[i] = Console.ReadLine();
            }

            // have to convert to binary
            StringBuilder numberInBinary = new StringBuilder();

            numberInBinary = ConvertToBinary(input);

            // ottuk zapochwa interesnoto
            int counter = 0;



            StringBuilder result = new StringBuilder();
            int verifier = 0;
            int jCounter = 0;
            for (int i = 0; ; i++)
            {

                for (int j = jCounter; j < numberInBinary.Length; j++)
                {

                    //extracting the numbers from binary
                    if (numberInBinary[jCounter] == '1')
                    {
                        jCounter++;
                        counter++;
                    }
                    else
                    {
                        jCounter++;
                        break;
                    }
                }

                int index = 0;
                while (true)
                {
                    if (index >= letterOfSignificance.Length)
                    {
                        break;
                    }
                    verifier = int.Parse(letterOfSignificance[index].Remove(0, 1));
                    if (verifier == counter)
                    {
                        result.Append(letterOfSignificance[index].Remove(1, letterOfSignificance[index].Length - 1));
                        break;
                    }
                    index++;
                }
                if (index >= letterOfSignificance.Length)
                {
                    break;
                }

                counter = 0;
            }
            Console.WriteLine(result);

        }




        private static int ExtractingNumbersFromBinary(StringBuilder numberInBinary, int counter)
        {
            for (int i = 0; i < numberInBinary.Length; i++)
            {
                //extracting the numbers from binary
                if (numberInBinary[i] == '1')
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }





        private static StringBuilder ConvertToBinary(string[] input)
        {
            StringBuilder returnBinary = new StringBuilder();
            int converter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                converter = int.Parse(input[i]);
                returnBinary.Append(Convert.ToString(converter, 2).PadLeft(8, '0'));
            }

            return returnBinary;
        }
    }
}
