using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractice_2
{
    class Laboratory
    {
        static void Main(string[] args)
        {
            string message = "ABC";
            string cypher = "PQRST";
            int maxLenght = Math.Max(message.Length, cypher.Length);
            StringBuilder sb = new StringBuilder(message);


            for (int i = 0; i < maxLenght; i++)
            {
                int letterMessage = sb[i % message.Length] - 'A';
                int letterCypher = cypher[i % cypher.Length] - 'A';

               
                int result = (letterMessage ^ letterCypher) + 'A';
                sb[i % message.Length] = (char)result;

            }
            Console.WriteLine(sb);
        }
    }
}