using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FindOccurances
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var list = new List<int>()
            {3, 4, 4, 2, 3, 3, 4, 3, 2};

            //while (true)
            //{
            //    input = Console.ReadLine();
            //    if (string.IsNullOrEmpty(input))
            //    {
            //        break;
            //    }

            //    list.Add(int.Parse(input));
            //}

            var resultList = new List<int>();

            foreach (var item in list)
            {
                resultList.Add(item);
            }

            var timesNumberAppeared = 1;
            var restartCounter = 1;
            var revisitedNumbers = new List<int>();

            for (int startIndex = 0; startIndex < list.Count; startIndex++)
            {
                for (int searchIndex = startIndex + 1; searchIndex < list.Count; searchIndex++)
                {
                    if (list[startIndex] == list[searchIndex] && !revisitedNumbers.Contains(list[startIndex]))
                    {
                        timesNumberAppeared++;
                    }
                }

                int checkIfThisNumExists = list[startIndex];

                if (!revisitedNumbers.Contains(checkIfThisNumExists))
                {
                    var currentNumber = list[startIndex];
                    Console.WriteLine("{0} -> {1} times", currentNumber, timesNumberAppeared);

                    //resultList.RemoveAll(x => x == numberToRemove);
                }

                if (!revisitedNumbers.Contains(list[startIndex]))
                {
                    revisitedNumbers.Add(list[startIndex]);
                }

                timesNumberAppeared = restartCounter;
            }
        }
    }
}
