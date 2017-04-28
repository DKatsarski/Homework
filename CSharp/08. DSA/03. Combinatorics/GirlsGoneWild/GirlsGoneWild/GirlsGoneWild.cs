using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirlsGoneWild
{
    public class GirlsGoneWild
    {
        private static SortedSet<string> finalResult = new SortedSet<string>();

        private static int totalPeople;

        private static List<List<int>> combOfNumbers = new List<List<int>>();
        private static List<List<char>> combOfLetters = new List<List<char>>();

        public static void Main()
        {
            var numbers = new int[int.Parse(Console.ReadLine())];
            var letters = Console.ReadLine().ToCharArray().OrderBy(c => c).ToArray());
            totalPeople = int.Parse(Console.ReadLine());

            Comb(numbers, 0, 0, comb =>
            {
                combOfNumbers.Add(new List<int>(comb));
            });
            numbers = new int[letters.Length];
            Comb(numbers, 0, 0, comb =>
            {
                var currentLetterComb = new List<char>();

                for (int i = 0; i < totalPeople; i++)
                {
                    currentLetterComb.Add(letters[comb[i]]);
                }

                combOfLetters.Add(currentLetterComb);
            });
        }

        public static void Comb(int[] arr, int index, int start, Action<int[]> action)
        {
            if (index >= totalPeople)
            {
                action(arr);
            }
            else
            {
                for (int i = start; i < arr.Length; i++)
                {
                    arr[index] = i;
                    Comb(arr, index + 1, i + 1, action);
                }
            }
        }
    }
}
