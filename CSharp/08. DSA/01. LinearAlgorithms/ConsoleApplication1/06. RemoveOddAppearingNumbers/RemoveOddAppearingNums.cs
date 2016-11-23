using System;
using System.Collections.Generic;

namespace _06.RemoveOddAppearingNumbers
{
    class RemoveOddAppearingNums
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var list = new List<int>();
                //{4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2};

            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                list.Add(int.Parse(input));
            }

            var resultList = new List<int>();

            foreach (var item in list)
            {
                resultList.Add(item);
            }

            var oddTimesCounter = 0;
            var restartCounter = 0;
            var revisitedNumbers = new List<int>();

            for (int startIndex = 0; startIndex < list.Count; startIndex++)
            {
                for (int searchIndex = startIndex + 1; searchIndex < list.Count; searchIndex++)
                {
                    if (list[startIndex] == list[searchIndex] && !revisitedNumbers.Contains(list[startIndex]))
                    {
                        oddTimesCounter++;
                    }
                }

                int checkIfThisNumExists = list[startIndex];

                if ((oddTimesCounter % 2 == 0 || oddTimesCounter == 0) && !revisitedNumbers.Contains(checkIfThisNumExists))
                {
                    var numberToRemove = list[startIndex];

                    resultList.RemoveAll(x => x == numberToRemove);
                }

                if (!revisitedNumbers.Contains(list[startIndex]))
                {
                    revisitedNumbers.Add(list[startIndex]);
                }
                
                oddTimesCounter = restartCounter;
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
