using System;
using System.Text;

namespace _5.Parse_tags
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder transformerToUpper = new StringBuilder();
            string input = Console.ReadLine();
            string lenght = "<upcase>";
            int startPoint = input.IndexOf("<upcase>");
            int endPoint = input.IndexOf("</upcase>");
            int transferer = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i == startPoint)
                {
                    startPoint = input.IndexOf(lenght, startPoint + 1);
                    for (int j = i + lenght.Length; j < endPoint; j++)
                    {
                        transformerToUpper.Append(char.ToUpper(input[j]));
                        transferer = j;
                    }
                    endPoint = input.IndexOf("</upcase>", endPoint + 1);
                    i = transferer + lenght.Length + 1 + 1;
                }
                if (i == input.Length)
                {
                    break;
                }
                else
                {
                    transformerToUpper.Append(input[i]);
                }
                
            }

            Console.Write(transformerToUpper);
            Console.ReadLine();
        }
    }
}
