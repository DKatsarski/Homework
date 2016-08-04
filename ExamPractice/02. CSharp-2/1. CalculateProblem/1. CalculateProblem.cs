using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CalculateProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Trim(' ')
                .Split(' ')
                .ToArray();

            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int a = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    a = arr[i][j] - 'a' + 1;
                    list.Add(a);
                }




            }


       


        }

  




    }
}
