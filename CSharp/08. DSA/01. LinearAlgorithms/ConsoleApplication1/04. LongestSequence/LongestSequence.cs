using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestSequence
{
    public class LongestSequence
    {
        public static List<int> FindLongestSequenceOfEqualNumbers(IList<int> list)
        {
            int currentSequence = 0;
            int longestSequence = 0;
            int restartCurrentSequence = 0;
            List<int> resultList = new List<int>();

            for (int startIndex = 0; startIndex < list.Count; startIndex++)
            {
                for (int searchIndex = startIndex + 1; searchIndex < list.Count; searchIndex++)
                {
                    if (list[startIndex] == list[searchIndex])
                    {
                        currentSequence++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentSequence > longestSequence)
                {
                    resultList.Clear();

                    for (int i = startIndex; i <= startIndex + currentSequence; i++)
                    {
                        resultList.Add(list[i]);
                    }

                    longestSequence = currentSequence;
                    currentSequence = restartCurrentSequence;
                }

                currentSequence = restartCurrentSequence;
            }

            return resultList;
        }

        static void Main()
        {
            var list = new List<int>
            { 2, 1, 3, 3, 3, 8, 7, 7, 8, 8, 8, 8, 8, 8};
            var result = FindLongestSequenceOfEqualNumbers(list);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
